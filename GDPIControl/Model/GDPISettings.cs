using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GDPIControl.Model
{
    public class GDPISettings : INotifyPropertyChanged
    {
        /// <summary>
        /// Block passive DPI
        /// </summary>
        public bool P { get; set; }

        /// <summary>
        /// Replace Host with hoSt
        /// </summary>
        public bool R { get; set; }

        /// <summary>
        /// Remove space between host header and its value
        /// </summary>
        public bool S { get; set; }

        /// <summary>
        /// Mix host header case (test.com -> tEsT.cOm)
        /// </summary>
        public bool M { get; set; }

        #region F
        private bool _F_State;

        /// <summary>
        /// Set HTTP fragmentation to value
        /// </summary>
        public bool F_State
        {
            get => _F_State;
            set
            {
                _F_State = value;
                NotifyPropertyChanged();
            }
        }

        public bool F_Value { get; set; }
        #endregion F

        #region TTL
        private bool _TTL_State;

        /// <summary>
        /// Activate Fake Request Mode And send it with supplied TTL value.
		/// DANGEROUS! May break websites In unexpected ways. Use With care.
        /// </summary>
        public bool TTL_State
        {
            get => _TTL_State;
            set
            {
                _TTL_State = value;
            }
        }

        private int _TTL_Value;

        public int TTL_Value
        {
            get => _TTL_Value;
            set
            {
                _TTL_Value = value;
                NotifyPropertyChanged();
            }
        }

        #endregion TTL

        #region K
        private bool _K_State;

        /// <summary>
        /// Enable HTTP persistent (keep-alive) fragmentation and set it to value
        /// </summary>
        public bool K_State
        {
            get => _K_State;
            set
            {
                _K_State = value;
                NotifyPropertyChanged();
            }
        }

        public bool K_Value { get; set; }
        #endregion K

        private bool _ChkSum;

        private bool _E_State;

        private bool _DNS_State;

        private bool _DNS6_State;

        // -p          block passive DPI
        // -r          replace Host with hoSt
        // -s          remove space between host header and its value
        // -m          mix Host header case (test.com -> tEsT.cOm)
        // -f <value>  set HTTP fragmentation to value
        // -k <value>  enable HTTP persistent (keep-alive) fragmentation and set it to value
        // -n          do not wait for first segment ACK when -k is enabled
        // -e <value>  set HTTPS fragmentation to value
        // -a          additional space between Method and Request-URI (enables -s, may break sites)
        // -w          try to find and parse HTTP traffic on all processed ports (not only on port 80)
        // --port        <value>    additional TCP port to perform fragmentation on (and HTTP tricks with -w)
        // --ip-id       <value>    handle additional IP ID (decimal, drop redirects and TCP RSTs with this ID).
        //                          This option can be supplied multiple times.
        // --dns-addr    <value>    redirect UDP DNS requests to the supplied IP address (experimental)
        // --dns-port    <value>    redirect UDP DNS requests to the supplied port (53 by default)
        // --dnsv6-addr  <value>    redirect UDPv6 DNS requests to the supplied IPv6 address (experimental)
        // --dnsv6-port  <value>    redirect UDPv6 DNS requests to the supplied port (53 by default)
        // --dns-verb               print verbose DNS redirection messages
        // --blacklist   <txtfile>  perform circumvention tricks only to host names and subdomains from
        //                          supplied text file (HTTP Host/TLS SNI).
        //                          This option can be supplied multiple times.
        // --allow-no-sni           perform circumvention if TLS SNI can't be detected with --blacklist enabled.
        // --set-ttl     <value>    activate Fake Request Mode and send it with supplied TTL value.
        //                          DANGEROUS! May break websites in unexpected ways. Use with care.
        // --auto-ttl    [a1-a2-m]  activate Fake Request Mode, automatically detect TTL and decrease
        //                          it based on a distance. If the distance is shorter than a2, TTL is decreased
        //                          by a2. If it's longer, (a1; a2) scale is used with the distance as a weight.
        //                          If the resulting TTL is more than m(ax), set it to m.
        //                          Default (if set): --auto-ttl 1-4-10. Also sets --min-ttl 3.
        // --min-ttl     <value>    minimum TTL distance (128/64 - TTL) for which to send Fake Request
        //                          in --set-ttl and --auto-ttl modes.
        // --wrong-chksum           activate Fake Request Mode and send it with incorrect TCP checksum.
        //                          May not work in a VM or with some routers, but is safer than set-ttl.
        // --wrong-seq              activate Fake Request Mode and send it with TCP SEQ/ACK in the past.
        // --native-frag            fragment (split) the packets by sending them in smaller packets, without
        //                          shrinking the Window Size. Works faster (does not slow down the connection)
        //                          and better.
        // --reverse-frag           fragment (split) the packets just as --native-frag, but send them in the
        //                          reversed order. Works with the websites which could not handle segmented
        //                          HTTPS TLS ClientHello (because they receive the TCP flow "combined").
        // --max-payload [value]    packets with TCP payload data more than [value] won't be processed.
        //                          Use this option to reduce CPU usage by skipping huge amount of data
        //                          (like file transfers) in already established sessions.
        //                          May skip some huge HTTP requests from being processed.

        public string ToArguments()
        {
            var SB = new StringBuilder();
            if (P) { SB.Append(" -p"); }
            if (R) { SB.Append(" -r"); }
            if (S) { SB.Append(" -s"); }
            if (M) { SB.Append(" -m"); }
            if (F_State) { SB.Append($" -f {F_Value}"); }
            if (K_State) { SB.Append($" -k {K_Value}"); }
            return SB.ToString().Trim();
        }

        public static string ModesetArgument(Modeset modeset)
        {
            return modeset switch
            {
                Modeset.M1 => "-1",
                Modeset.M2 => "-2",
                Modeset.M3 => "-3",
                Modeset.M4 => "-4",
                Modeset.M5 => "-5",
                Modeset.M6 => "-6",
                _ => "-5",
            };
        }

        public static GDPISettings ModesetSettings(Modeset modeset)
        {
            return modeset switch
            {
                Modeset.M1 => new GDPISettings(),
                Modeset.M2 => new GDPISettings(),
                Modeset.M3 => new GDPISettings(),
                Modeset.M4 => new GDPISettings(),
                Modeset.M5 => new GDPISettings(),
                Modeset.M6 => new GDPISettings(),
                _ => new GDPISettings(),
            };
        }

        #region INotify

        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion INotify
    }
}