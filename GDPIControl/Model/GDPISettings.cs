using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace GDPIControl.Model
{
    public class GDPISettings : INotifyPropertyChanged
    {
        public GDPISettings()
        {
            DNS_Port = "53";
            DNS6_Port = "53";
            MP_V = 1200;
        }

        #region P

        public bool P { get; set; }

        #endregion P

        #region R

        public bool R { get; set; }

        #endregion R

        #region S

        public bool S { get; set; }

        #endregion S

        #region M

        public bool M { get; set; }

        #endregion M

        #region F
        private bool F_State;

        public bool F
        {
            get => F_State;
            set
            {
                F_State = value;
                NotifyPropertyChanged();
            }
        }

        public int F_V { get; set; }
        #endregion F

        #region K
        private bool K_State;

        public bool K
        {
            get => K_State;
            set
            {
                K_State = value;
                NotifyPropertyChanged();
            }
        }

        public int K_V { get; set; }
        #endregion K

        #region N

        public bool N { get; set; }

        #endregion N

        #region E
        private bool E_State;

        public bool E
        {
            get => E_State;
            set
            {
                E_State = value;
                NotifyPropertyChanged();
            }
        }

        public int E_V { get; set; }
        #endregion E

        #region A

        public bool A { get; set; }

        #endregion A

        #region W

        public bool W { get; set; }

        #endregion W

        #region DNS
        private bool _DNS_State;

        public string DNS_Addr { get; set; }

        public string DNS_Port { get; set; }

        public bool DNS_State
        {
            get => _DNS_State;
            set
            {
                _DNS_State = value;
                NotifyPropertyChanged();
            }
        }

        #endregion DNS

        #region DNS6
        private bool _DNS6_State;

        public string DNS6_Addr { get; set; }

        public string DNS6_Port { get; set; }

        public bool DNS6_State
        {
            get => _DNS6_State;
            set
            {
                _DNS6_State = value;
                NotifyPropertyChanged();
            }
        }

        #endregion DNS6

        #region AllowNoSNI
        public bool SNI { get; set; }
        #endregion AllowNoSNI

        #region SetTTL
        private bool STTL_State;

        public bool STTL
        {
            get => STTL_State;
            set
            {
                STTL_State = value;
                NotifyPropertyChanged();
            }
        }

        public int STTL_V { get; set; }

        #endregion SetTTL

        #region AutoTTL
        public bool ATTL { get; set; }

        #endregion AutoTTL

        #region MinTTL
        private bool MTTL_State;

        public bool MTTL
        {
            get => MTTL_State;
            set
            {
                MTTL_State = value;
                NotifyPropertyChanged();
            }
        }

        public int MTTL_V { get; set; }

        #endregion MinTTL

        #region WrongCheckSum

        public bool ChkSum { get; set; }
        #endregion WrongCheckSum

        #region WrongSeq
        public bool Seq { get; set; }
        #endregion WrongSeq

        #region NativeFrag
        public bool NFrag { get; set; }
        #endregion NativeFrag

        #region ReverseFrag
        public bool RFrag { get; set; }
        #endregion ReverseFrag

        #region MaxPayload
        private bool MP_State;

        public bool MP
        {
            get => MP_State;
            set
            {
                MP_State = value;
                NotifyPropertyChanged();
            }
        }

        public int MP_V { get; set; }

        #endregion MaxPayload

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

        // --dns-addr    <value>    redirect UDP DNS requests to the supplied IP address (experimental)
        // --dns-port    <value>    redirect UDP DNS requests to the supplied port (53 by default)
        // --dnsv6-addr  <value>    redirect UDPv6 DNS requests to the supplied IPv6 address (experimental)
        // --dnsv6-port  <value>    redirect UDPv6 DNS requests to the supplied port (53 by default)
        // --dns-verb               print verbose DNS redirection messages

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

        #region Static

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
                Modeset.M1 => new GDPISettings { P = true, R = true, S = true, F = true, F_V = 2, K = true, K_V = 2, N = true, E = true, E_V = 2 },
                Modeset.M2 => new GDPISettings { P = true, R = true, S = true, F = true, F_V = 2, K = true, K_V = 2, N = true, E = true, E_V = 40 },
                Modeset.M3 => new GDPISettings { P = true, R = true, S = true, E = true, E_V = 2 },
                Modeset.M4 => new GDPISettings { P = true, R = true, S = true },
                Modeset.M5 => new GDPISettings { F = true, F_V = 2, E = true, E_V = 2, ATTL = true, RFrag = true, MP = true, MP_V = 1200 },
                Modeset.M6 => new GDPISettings { F = true, F_V = 2, E = true, E_V = 2, Seq = true, RFrag = true, MP = true, MP_V = 1200 },
                _ => new GDPISettings(),
            };
        }

        public string ToArguments()
        {
            var SB = new StringBuilder();
            if (P) { SB.Append(" -p"); }
            if (R) { SB.Append(" -r"); }
            if (S) { SB.Append(" -s"); }
            if (M) { SB.Append(" -m"); }
            if (F) { SB.Append($" -f {F_V}"); }
            if (K) { SB.Append($" -k {K_V}"); }
            if (N) { SB.Append(" -n"); }
            if (A) { SB.Append(" -a"); }
            if (W) { SB.Append(" -w"); }

            if (DNS_State) { SB.Append($"--dns-addr {DNS_Addr} --dns-port {DNS_Port}"); }
            if (DNS6_State) { SB.Append($"--dns-addr {DNS6_Addr} --dns-port {DNS6_Port}"); }
            if (SNI) { SB.Append(" --allow-no-sni"); }
            if (STTL) { SB.Append($" --set-ttl {STTL_V}"); }
            if (ATTL) { SB.Append(" --auto-ttl"); }
            if (MTTL) { SB.Append($" --min-ttl {MTTL_V}"); }
            if (ChkSum) { SB.Append(" --wrong-chksum"); }
            if (Seq) { SB.Append(" --wrong-seq"); }
            if (NFrag) { SB.Append(" --native-frag "); }
            if (RFrag) { SB.Append(" --reverse-frag "); }
            if (MP) { SB.Append($" --max-payload {MP_V}"); }
            return SB.ToString().Trim();
        }

        #endregion Static

        #region INotify

        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion INotify
    }
}