Namespace Data
	Public Class GDPISettings

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

		Public Property F_Value As Integer

		''' <summary>
		''' Enable HTTP persistent (keep-alive) fragmentation and set it to value
		''' </summary>
		Public Property K_State As Boolean

		Public Property K_Value As Integer

		''' <summary>
		''' Do not wait for first segment ACK when -k is enabled
		''' </summary>
		Public Property N As Boolean

		''' <summary>
		''' Set HTTPS fragmentation to value
		''' </summary>
		Public Property E_State As Boolean

		Public Property E_Value As Integer

		''' <summary>
		''' Additional space between Method And Request-URI (enables -s, may break sites)
		''' </summary>
		Public Property A As Boolean

		''' <summary>
		''' Try to find And parse HTTP traffic on all processed ports (Not only on port 80)
		''' </summary>
		Public Property W As Boolean

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
			Return MyBase.ToString()
		End Function

	End Class
End Namespace