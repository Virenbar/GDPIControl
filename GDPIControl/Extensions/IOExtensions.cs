using System;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace GDPIControl.Extensions
{
    internal static class IOExtensions
    {
        public static Task CopyToAsync(this Stream source, Stream destination, int bufferSize) => CopyToAsync(source, destination, bufferSize, default, default);

        public static Task CopyToAsync(this Stream source, Stream destination, int bufferSize, IProgress<long> progress) => CopyToAsync(source, destination, bufferSize, progress, default);

        /// <summary>
        /// https://stackoverflow.com/a/46497896
        /// </summary>
        public static async Task CopyToAsync(this Stream source, Stream destination, int bufferSize, IProgress<long> progress, CancellationToken cancellationToken)
        {
            if (source is null) { throw new ArgumentNullException(nameof(source)); }
            if (!source.CanRead) { throw new ArgumentException("Has to be readable", nameof(source)); }
            if (destination is null) { throw new ArgumentNullException(nameof(destination)); }
            if (!destination.CanWrite) { throw new ArgumentException("Has to be writable", nameof(destination)); }
            if (bufferSize < 0) { throw new ArgumentOutOfRangeException(nameof(bufferSize)); }

            var buffer = new byte[bufferSize];
            long totalBytesRead = 0;
            int bytesRead;
            while ((bytesRead = await source.ReadAsync(buffer, 0, buffer.Length, cancellationToken).ConfigureAwait(false)) != 0)
            {
                await destination.WriteAsync(buffer, 0, bytesRead, cancellationToken).ConfigureAwait(false);
                totalBytesRead += bytesRead;
                progress?.Report(totalBytesRead);
            }
        }

        /// <summary>
        /// Асинхронно скачать файл
        /// </summary>
        public static Task DownloadAsync(this HttpClient client, string requestUri, Stream destination) => DownloadAsync(client, requestUri, destination, default(CancellationToken));

        /// <summary>
        /// Асинхронно скачать файл
        /// </summary>
        public static async Task DownloadAsync(this HttpClient client, string requestUri, Stream destination, CancellationToken cancellationToken)
        {
            // Считать только заголовок
            using var response = await client.GetAsync(requestUri, HttpCompletionOption.ResponseHeadersRead, cancellationToken);
            response.EnsureSuccessStatusCode();
            // А содержимое записать прямо в файл
            using var download = await response.Content.ReadAsStreamAsync();
            await download.CopyToAsync(destination);
        }

        /// <summary>
        /// Асинхронно скачать файл с отчётом о прогрессе
        /// </summary>
        public static Task DownloadAsync(this HttpClient client, string requestUri, Stream destination, IProgress<float> progress) => DownloadAsync(client, requestUri, destination, progress, default);

        /// <summary>
        /// Асинхронно скачать файл с отчётом о прогрессе
        /// </summary>
        public static async Task DownloadAsync(this HttpClient client, string requestUri, Stream destination, IProgress<float> progress, CancellationToken cancellationToken)
        {
            // Get the http headers first to examine the content length
            using var response = await client.GetAsync(requestUri, HttpCompletionOption.ResponseHeadersRead, cancellationToken);
            response.EnsureSuccessStatusCode();
            var contentLength = response.Content.Headers.ContentLength;
            using var download = await response.Content.ReadAsStreamAsync();
            // Ignore progress reporting when no progress reporter was
            // passed or when the content length is unknown
            if (!contentLength.HasValue)
            {
                await download.CopyToAsync(destination);
                progress.Report(1);
                return;
            }

            // Convert absolute progress (bytes downloaded) into relative progress (0% - 100%)
            var relativeProgress = new Progress<long>(totalBytes => progress.Report((float)totalBytes / contentLength.Value));
            // Use extension method to report progress while downloading
            await download.CopyToAsync(destination, 81920, relativeProgress, cancellationToken);
            progress.Report(1);
        }
    }
}