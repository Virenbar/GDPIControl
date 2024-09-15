using System;
using System.ComponentModel;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;

namespace GDPIControl.Model
{
    public class GDPISettings : INotifyPropertyChanged, ICloneable
    {
        public GDPISettings()
        {
            DNS_Port = "53";
            DNS6_Port = "53";
            FakeResend_V = 1;
            MP_V = 1200;
        }

        #region P
        private bool _P;

        public bool P
        {
            get => _P;
            set
            {
                if (_P == value) { return; }
                _P = value;
                NotifyPropertyChanged();
            }
        }

        #endregion P

        #region Q
        private bool _Q;

        public bool Q
        {
            get => _Q;
            set
            {
                if (_Q == value) { return; }
                _Q = value;
                NotifyPropertyChanged();
            }
        }

        #endregion Q

        #region R
        private bool _R;

        public bool R
        {
            get => _R;
            set
            {
                if (_R == value) { return; }
                _R = value;
                NotifyPropertyChanged();
            }
        }

        #endregion R

        #region S
        private bool _S;

        public bool S
        {
            get => _S;
            set
            {
                if (_S == value) { return; }
                _S = value;
                NotifyPropertyChanged();
            }
        }

        #endregion S

        #region M
        private bool _M;

        public bool M
        {
            get => _M;
            set
            {
                if (_M == value) { return; }
                _M = value;
                NotifyPropertyChanged();
            }
        }

        #endregion M

        #region F
        private bool _F;
        private int _F_V;

        public bool F
        {
            get => _F;
            set
            {
                if (_F == value) { return; }
                _F = value;
                NotifyPropertyChanged();
            }
        }

        public int F_V
        {
            get => _F_V;
            set
            {
                if (_F_V == value) { return; }
                _F_V = value;
                NotifyPropertyChanged();
            }
        }

        #endregion F

        #region K
        private bool _K;
        private int _K_V;

        public bool K
        {
            get => _K;
            set
            {
                if (_K == value) { return; }
                _K = value;
                NotifyPropertyChanged();
            }
        }

        public int K_V
        {
            get => _K_V;
            set
            {
                if (_K_V == value) { return; }
                _K_V = value;
                NotifyPropertyChanged();
            }
        }

        #endregion K

        #region N
        private bool _N;

        public bool N
        {
            get => _N;
            set
            {
                if (_N == value) { return; }
                _N = value;
                NotifyPropertyChanged();
            }
        }

        #endregion N

        #region E
        private bool _E;
        private int _E_V;

        public bool E
        {
            get => _E;
            set
            {
                if (_E == value) { return; }
                _E = value;
                NotifyPropertyChanged();
            }
        }

        public int E_V
        {
            get => _E_V;
            set
            {
                if (_E_V == value) { return; }
                _E_V = value;
                NotifyPropertyChanged();
            }
        }

        #endregion E

        #region A
        private bool _A;

        public bool A
        {
            get => _A;
            set
            {
                if (_A == value) { return; }
                _A = value;
                NotifyPropertyChanged();
            }
        }

        #endregion A

        #region W
        private bool _W;

        public bool W
        {
            get => _W;
            set
            {
                if (_W == value) { return; }
                _W = value;
                NotifyPropertyChanged();
            }
        }

        #endregion W

        #region DNS
        private bool _DNS_State;
        private string _DNS_Addr;
        private string _DNS_Port;

        public bool DNS_State
        {
            get => _DNS_State;
            set
            {
                if (_DNS_State == value) { return; }
                _DNS_State = value;
                NotifyPropertyChanged();
            }
        }

        public string DNS_Addr
        {
            get => _DNS_Addr; set
            {
                if (_DNS_Addr == value) { return; }
                _DNS_Addr = value;
                NotifyPropertyChanged();
            }
        }

        public string DNS_Port
        {
            get => _DNS_Port; set
            {
                if (_DNS_Port == value) { return; }
                _DNS_Port = value;
                NotifyPropertyChanged();
            }
        }

        #endregion DNS

        #region DNS6
        private bool _DNS6_State;
        private string _DNS6_Addr;
        private string _DNS6_Port;

        public bool DNS6_State
        {
            get => _DNS6_State;
            set
            {
                if (_DNS6_State == value) { return; }
                _DNS6_State = value;
                NotifyPropertyChanged();
            }
        }

        public string DNS6_Addr
        {
            get => _DNS6_Addr; set
            {
                if (_DNS6_Addr == value) { return; }
                _DNS6_Addr = value;
                NotifyPropertyChanged();
            }
        }

        public string DNS6_Port
        {
            get => _DNS6_Port; set
            {
                if (_DNS6_Port == value) { return; }
                _DNS6_Port = value;
                NotifyPropertyChanged();
            }
        }

        #endregion DNS6

        #region AllowNoSNI
        private bool _SNI;

        public bool SNI
        {
            get => _SNI;
            set
            {
                if (_SNI == value) { return; }
                _SNI = value;
                NotifyPropertyChanged();
            }
        }

        #endregion AllowNoSNI

        #region SetTTL
        private bool _STTL;
        private int _STTL_V;

        public bool STTL
        {
            get => _STTL;
            set
            {
                if (_STTL == value) { return; }
                _STTL = value;
                NotifyPropertyChanged();
            }
        }

        public int STTL_V
        {
            get => _STTL_V; set
            {
                if (_STTL_V == value) { return; }
                _STTL_V = value;
                NotifyPropertyChanged();
            }
        }

        #endregion SetTTL

        #region AutoTTL
        private bool _ATTL;

        public bool ATTL
        {
            get => _ATTL;
            set
            {
                if (_ATTL == value) { return; }
                _ATTL = value;
                NotifyPropertyChanged();
            }
        }

        #endregion AutoTTL

        #region MinTTL
        private bool _MTTL;
        private int _MTTL_V;

        public bool MTTL
        {
            get => _MTTL;
            set
            {
                if (_MTTL == value) { return; }
                _MTTL = value;
                NotifyPropertyChanged();
            }
        }

        public int MTTL_V
        {
            get => _MTTL_V;
            set
            {
                if (_MTTL_V == value) { return; }
                _MTTL_V = value;
                NotifyPropertyChanged();
            }
        }

        #endregion MinTTL

        #region WrongCheckSum
        private bool _ChkSum;

        public bool ChkSum
        {
            get => _ChkSum;
            set
            {
                if (_ChkSum == value) { return; }
                _ChkSum = value;
                NotifyPropertyChanged();
            }
        }

        #endregion WrongCheckSum

        #region WrongSeq
        private bool _Seq;

        public bool Seq
        {
            get => _Seq;
            set
            {
                if (_Seq == value) { return; }
                _Seq = value;
                NotifyPropertyChanged();
            }
        }

        #endregion WrongSeq

        #region NativeFrag
        private bool _NFrag;

        public bool NFrag
        {
            get => _NFrag;
            set
            {
                if (_NFrag == value) { return; }
                _NFrag = value;
                NotifyPropertyChanged();
            }
        }

        #endregion NativeFrag

        #region ReverseFrag
        private bool _RFrag;

        public bool RFrag
        {
            get => _RFrag;
            set
            {
                if (_RFrag == value) { return; }
                _RFrag = value;
                NotifyPropertyChanged();
            }
        }

        #endregion ReverseFrag

        #region FakeFromHex
        private bool _FFH;
        private string _FFH_V;

        public bool FakeHex
        {
            get => _FFH;
            set
            {
                if (_FFH == value) { return; }
                _FFH = value;
                NotifyPropertyChanged();
            }
        }

        public string FakeHex_V
        {
            get => _FFH_V;
            set
            {
                if (_FFH_V == value) { return; }
                _FFH_V = value;
                NotifyPropertyChanged();
            }
        }

        #endregion FakeFromHex

        #region FakeGen
        private bool _FG;
        private int _FG_V;

        public bool FakeGen
        {
            get => _FG;
            set
            {
                if (_FG == value) { return; }
                _FG = value;
                NotifyPropertyChanged();
            }
        }

        public int FakeGen_V
        {
            get => _FG_V;
            set
            {
                if (_FG_V == value) { return; }
                _FG_V = value;
                NotifyPropertyChanged();
            }
        }

        #endregion FakeGen

        #region FakeResend
        private bool _FR;
        private int _FR_V;

        public bool FakeResend
        {
            get => _FR;
            set
            {
                if (_FR == value) { return; }
                _FR = value;
                NotifyPropertyChanged();
            }
        }

        public int FakeResend_V
        {
            get => _FR_V;
            set
            {
                if (_FR_V == value) { return; }
                _FR_V = value;
                NotifyPropertyChanged();
            }
        }

        #endregion FakeResend

        #region MaxPayload
        private bool _MP;
        private int _MP_V;

        public bool MP
        {
            get => _MP;
            set
            {
                if (_MP == value) { return; }
                _MP = value;
                NotifyPropertyChanged();
            }
        }

        public int MP_V
        {
            get => _MP_V;
            set
            {
                if (_MP_V == value) { return; }
                _MP_V = value;
                NotifyPropertyChanged();
            }
        }

        #endregion MaxPayload

        // -p          block passive DPI
        // -q          block QUIC/HTTP3
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
        // --fake-from-hex <value>   Load fake packets for Fake Request Mode from HEX values(like 1234abcDEF).
        //                          This option can be supplied multiple times, in this case each fake packet
        //                          would be sent on every request in the command line argument order.
        // --fake-gen <value>        Generate random-filled fake packets for Fake Request Mode, value of them
        //                          (up to 30).
        // --fake-resend <value>     Send each fake packet value number of times.
        //                          Default: 1 (send each packet once).
        // --max-payload [value]    packets with TCP payload data more than [value] won't be processed.
        //                          Use this option to reduce CPU usage by skipping huge amount of data
        //                          (like file transfers) in already established sessions.
        //                          May skip some huge HTTP requests from being processed.
        // Note: combination of --wrong-seq and --wrong-chksum generates two different fake packets.

        #region Properties
        private bool _manual;
        private string _arguments;

        public bool Manual
        {
            get => _manual;
            set
            {
                _manual = value;
                NotifyPropertyChanged();
            }
        }

        public string Arguments
        {
            get => _arguments;
            set
            {
                _arguments = value;
                NotifyPropertyChanged();
            }
        }

        #endregion Properties

        public object Clone() => MemberwiseClone();

        public string ToArguments()
        {
            var SB = new StringBuilder();
            if (P) { SB.Append(" -p"); }
            if (Q) { SB.Append(" -q"); }
            if (R) { SB.Append(" -r"); }
            if (S) { SB.Append(" -s"); }
            if (M) { SB.Append(" -m"); }
            if (F) { SB.Append($" -f {F_V}"); }
            if (K) { SB.Append($" -k {K_V}"); }
            if (N) { SB.Append(" -n"); }
            if (E) { SB.Append($" -e {E_V}"); }
            if (A) { SB.Append(" -a"); }
            if (W) { SB.Append(" -w"); }

            if (DNS_State) { SB.Append($" --dns-addr {DNS_Addr} --dns-port {DNS_Port}"); }
            if (DNS6_State) { SB.Append($" --dns-addr {DNS6_Addr} --dns-port {DNS6_Port}"); }
            if (SNI) { SB.Append(" --allow-no-sni"); }
            if (STTL) { SB.Append($" --set-ttl {STTL_V}"); }
            if (ATTL) { SB.Append(" --auto-ttl"); }
            if (MTTL) { SB.Append($" --min-ttl {MTTL_V}"); }
            if (ChkSum) { SB.Append(" --wrong-chksum"); }
            if (Seq) { SB.Append(" --wrong-seq"); }
            if (NFrag) { SB.Append(" --native-frag "); }
            if (RFrag) { SB.Append(" --reverse-frag "); }

            if (FakeHex) { SB.Append($" --fake-from-hex {FakeHex_V}"); }
            if (FakeGen) { SB.Append($" --fake-gen {FakeGen_V}"); }
            if (FakeResend) { SB.Append($" --fake-resend {FakeResend_V}"); }

            if (MP) { SB.Append($" --max-payload {MP_V}"); }
            return SB.ToString().Trim();
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