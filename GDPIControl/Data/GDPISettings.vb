Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Namespace Data
	Public Class GDPISettings
		Implements INotifyPropertyChanged

		Private _TTL_State As Boolean
		Private _TTL_Value As Integer
		Private _ChkSum As Boolean
		Private _F_State As Boolean
		Private _K_State As Boolean
		Private _E_State As Boolean
		Private _DNS_State As Boolean
		Private _DNS6_State As Boolean

		''' <summary>
		''' Block passive DPI
		''' </summary>
		Public Property P As Boolean

		''' <summary>
		''' Replace Host with hoSt
		''' </summary>
		Public Property R As Boolean

		''' <summary>
		''' Remove space between host header and its value
		''' </summary>
		Public Property S As Boolean

		''' <summary>
		''' Mix host header case (test.com -> tEsT.cOm)
		''' </summary>
		Public Property M As Boolean

		''' <summary>
		''' Set HTTP fragmentation to value
		''' </summary>
		Public Property F_State As Boolean
			Get
				Return _F_State
			End Get
			Set
				_F_State = Value
				NotifyPropertyChanged()
			End Set
		End Property

		Public Property F_Value As Integer

		''' <summary>
		''' Enable HTTP persistent (keep-alive) fragmentation and set it to value
		''' </summary>
		Public Property K_State As Boolean
			Get
				Return _K_State
			End Get
			Set
				_K_State = Value
				NotifyPropertyChanged()
			End Set
		End Property

		Public Property K_Value As Integer

		''' <summary>
		''' Do not wait for first segment ACK when -k is enabled
		''' </summary>
		Public Property N As Boolean

		''' <summary>
		''' Set HTTPS fragmentation to value
		''' </summary>
		Public Property E_State As Boolean
			Get
				Return _E_State
			End Get
			Set
				_E_State = Value
				NotifyPropertyChanged()
			End Set
		End Property

		Public Property E_Value As Integer

		''' <summary>
		''' Additional space between Method And Request-URI (enables -s, may break sites)
		''' </summary>
		Public Property A As Boolean

		''' <summary>
		''' Try to find And parse HTTP traffic on all processed ports (Not only on port 80)
		''' </summary>
		Public Property W As Boolean

#Region "DNS"

		Public Property DNS_State As Boolean
			Get
				Return _DNS_State
			End Get
			Set
				_DNS_State = Value
				NotifyPropertyChanged()
			End Set
		End Property

		''' <summary>
		''' Redirect UDP DNS requests to the supplied IP address (experimental)
		''' </summary>
		''' <returns></returns>
		Public Property DNS_IP As String

		''' <summary>
		''' Redirect UDP DNS requests to the supplied port (53 by default)
		''' </summary>
		''' <returns></returns>
		Public Property DNS_Port As Integer = 53

		Public Property DNS6_State As Boolean
			Get
				Return _DNS6_State
			End Get
			Set
				_DNS6_State = Value
				NotifyPropertyChanged()
			End Set
		End Property

		''' <summary>
		''' Redirect UDPv6 DNS requests to the supplied IPv6 address (experimental)
		''' </summary>
		''' <returns></returns>
		Public Property DNS6_IP As String

		''' <summary>
		''' Redirect UDPv6 DNS requests to the supplied port (53 by default)
		''' </summary>
		''' <returns></returns>
		Public Property DNS6_Port As Integer = 53

#End Region

		''' <summary>
		''' Activate Fake Request Mode And send it with supplied TTL value.
		''' DANGEROUS! May break websites In unexpected ways. Use With care.
		''' </summary>
		''' <returns></returns>
		Public Property TTL_State As Boolean
			Get
				Return _TTL_State
			End Get
			Set
				_TTL_State = Value
				NotifyPropertyChanged()
			End Set
		End Property

		Public Property TTL_Value As Integer
			Get
				Return _TTL_Value
			End Get
			Set
				_TTL_Value = Value
				NotifyPropertyChanged()
			End Set
		End Property

		''' <summary>
		''' Activate Fake Request Mode And send it with incorrect TCP checksum.
		''' May Not work in a VM Or with some routers, but Is safer than set-ttl.
		''' </summary>
		''' <returns></returns>
		Public Property ChkSum As Boolean
			Get
				Return _ChkSum
			End Get
			Set
				_ChkSum = Value
				NotifyPropertyChanged()
			End Set
		End Property

		' -p          block passive DPI
		' -r          replace Host with hoSt
		' -s          remove space between host header And its value
		' -m          mix Host header case (test.com -> tEsT.cOm)
		' -f [value]  set HTTP fragmentation to value
		' -k [value]  enable HTTP persistent (keep-alive) fragmentation And set it to value
		' -n          do Not wait for first segment ACK when -k Is enabled
		' -e [value]  set HTTPS fragmentation to value
		' -a          additional space between Method And Request-URI (enables -s, may break sites)
		' -w          try to find And parse HTTP traffic on all processed ports (Not only on port 80)
		' --port        [value]    additional TCP port to perform fragmentation on (And HTTP tricks with -w)
		' --ip-id       [value]    handle additional IP ID (decimal, drop redirects And TCP RSTs with this ID).
		'                          This option can be supplied multiple times.
		' --dns-addr    [value]    redirect UDP DNS requests to the supplied IP address (experimental)
		' --dns-port    [value]    redirect UDP DNS requests to the supplied port (53 by default)
		' --dnsv6-addr  [value]    redirect UDPv6 DNS requests to the supplied IPv6 address (experimental)
		' --dnsv6-port  [value]    redirect UDPv6 DNS requests to the supplied port (53 by default)
		' --dns-verb               print verbose DNS redirection messages
		' --blacklist   [txtfile]  perform HTTP tricks only to host names And subdomains from
		'                          supplied text file. This Option can be supplied multiple times.
		' --set-ttl     [value]    activate Fake Request Mode And send it with supplied TTL value.
		'                          DANGEROUS! May break websites In unexpected ways. Use With care.
		' --wrong-chksum           activate Fake Request Mode And send it with incorrect TCP checksum.
		'                          May Not work in a VM Or with some routers, but Is safer than set-ttl.

		Public Overrides Function ToString() As String
			Dim Params = New List(Of String)
			If P Then Params.Add("-p")
			If R Then Params.Add("-r")
			If S Then Params.Add("-s")
			If M Then Params.Add("-m")
			If F_State Then Params.Add($"-f {F_Value}")
			If K_State Then Params.Add($"-k {K_Value}")
			If N Then Params.Add("-n")
			If E_State Then Params.Add($"-e {E_Value}")
			If A Then Params.Add("-a")
			If W Then Params.Add("-w")

			If DNS_State Then Params.Add($"--dns-addr {DNS_IP} --dns-port {DNS_Port}")
			If DNS6_State Then Params.Add($"--dnsv6-addr {DNS6_IP} --dnsv6-port {DNS6_Port}")
			If TTL_State Then Params.Add($"--set-ttl {TTL_Value}")
			If ChkSum Then Params.Add("--wrong-chksum")
			Return String.Join(" ", Params)
		End Function

		Public Shared ReadOnly Property C1 As GDPISettings
			Get
				Return New GDPISettings With {.P = True, .R = True, .S = True, .F_State = True, .F_Value = 2, .K_State = True, .K_Value = 2, .N = True, .E_State = True, .E_Value = 2}
			End Get
		End Property

		Public Shared ReadOnly Property C2 As GDPISettings
			Get
				Return New GDPISettings With {.P = True, .R = True, .S = True, .F_State = True, .F_Value = 2, .K_State = True, .K_Value = 2, .N = True, .E_State = True, .E_Value = 40}
			End Get
		End Property

		Public Shared ReadOnly Property C3 As GDPISettings
			Get
				Return New GDPISettings With {.P = True, .R = True, .S = True, .E_State = True, .E_Value = 40}
			End Get
		End Property

		Public Shared ReadOnly Property C4 As GDPISettings
			Get
				Return New GDPISettings With {.P = True, .R = True, .S = True}
			End Get
		End Property

		Protected Sub NotifyPropertyChanged(<CallerMemberName()> Optional ByVal propertyName As String = Nothing)
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End Sub

		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

	End Class
End Namespace