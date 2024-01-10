
Imports System.Net



Partial Class Site
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

        If Not Request.IsAuthenticated Then

            Dim h As HttpContext = HttpContext.Current
            Dim vbAuth = New VBAuth.Startup()
            vbAuth.login(h)
        End If
    End Sub
End Class

