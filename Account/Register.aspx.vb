Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.EntityFramework
Imports Microsoft.AspNet.Identity.Owin
Imports System
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.IO

Public Partial Class Account_Register
    Inherits Page
    Public doAction As New SiteFunctionsDataContext



    Protected Sub CreateUser_Click(sender As Object, e As EventArgs)
        Dim manager = New UserManager()
        Dim user = New ApplicationUser() With {.UserName = userName.Text}
        Dim result = manager.Create(user, Password.Text)


        If result.Succeeded Then
            IdentityHelper.SignIn(manager, user, isPersistent:=False)
            doAction.SetDefaultImage(UserName.Text)
            IdentityHelper.RedirectToReturnUrl(UserName.Text, Request.QueryString("ReturnUrl"), Response)
        Else
            ErrorMessage.Text = result.Errors.FirstOrDefault()
        End If
    End Sub
End Class
