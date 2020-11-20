Imports System.Net
Imports System.Text.RegularExpressions

Public Class FormMain
	Private G As Data.GDPISettings
	Private IP_R As New Regex("((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])\.){3,3}(25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])")

	Public Sub New()

		' Этот вызов является обязательным для конструктора.
		InitializeComponent()

		' Добавить код инициализации после вызова InitializeComponent().

	End Sub

	Private Sub TrayControl_DoubleClick(sender As Object, e As EventArgs) Handles TrayControl.DoubleClick

	End Sub

	Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles Me.Load
		G = New Data.GDPISettings With {
			.P = True,
			.F_State = True, .F_Value = 10}
		BS_GDPISettings.DataSource = G
	End Sub

	Private Sub FormMain_Closed(sender As Object, e As EventArgs) Handles Me.Closed

	End Sub

#Region "Validating"

	Private Sub DNS_IP_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles DNS_IP.Validating
		Try
			Dim M = IP_R.Match(DNS_IP.Text)
			e.Cancel = Not M.Success
		Catch ex As Exception
			e.Cancel = True
		End Try
	End Sub

	Private Sub DNS_Port_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles DNS_Port.Validating
		Try
			Dim p = CInt(DNS_Port.Text)
			e.Cancel = p <= 0 Or p > 65535
		Catch ex As Exception
			e.Cancel = True
		End Try
	End Sub

	Private Sub DNS6_IP_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles DNS6_IP.Validating
		Try
			Dim IP As IPAddress
			Dim r = IPAddress.TryParse(DNS6_IP.Text, IP)
			Dim T = IP.AddressFamily
		Catch ex As Exception
			e.Cancel = True
		End Try
	End Sub

	Private Sub DNS6_Port_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles DNS6_Port.Validating
		Try
			Dim p = CInt(DNS6_Port.Text)
			e.Cancel = p <= 0 Or p > 65535
		Catch ex As Exception
			e.Cancel = True
		End Try
	End Sub

#End Region

	'Usage: goodbyedpi.exe [OPTION...]
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

	' -1          -p -r -s -f 2 -k 2 -n -e 2 (most compatible mode, default)
	' -2          -p -r -s -f 2 -k 2 -n -e 40 (better speed for HTTPS yet still compatible)
	' -3          -p -r -s -e 40 (better speed for HTTP And HTTPS)
	' -4          -p -r -s (best speed)
End Class