

Imports Microsoft.Owin.Security
Imports Microsoft.Owin.Security.OpenIdConnect

Partial Class Default1
    Inherits System.Web.UI.Page
    Public Sub Form1_load(sender As Object, e As EventArgs)





    End Sub

    Protected Sub Unnamed_Click(sender As Object, e As EventArgs)
        'If Not Request.IsAuthenticated Then
        '    HttpContext.Current.GetOwinContext().Authentication.Challenge(
        '        New AuthenticationProperties With {.RedirectUri = "/"},
        '        OpenIdConnectAuthenticationDefaults.AuthenticationType)
        'End If
    End Sub
End Class
