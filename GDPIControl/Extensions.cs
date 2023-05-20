using System;
using System.Windows.Forms;

namespace GDPIControl
{
    internal static class Extensions
    {
        public static DialogResult ShowError(this Form form, Exception exception)
        {
            return MessageBox.Show(form, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult ShowError(this Form form, Exception exception, string caption)
        {
            return MessageBox.Show(form, exception.Message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult ShowInfo(this Form form, string text)
        {
            return MessageBox.Show(form, text, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult ShowInfo(this Form form, string text, string caption)
        {
            return MessageBox.Show(form, text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}