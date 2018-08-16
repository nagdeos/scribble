Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Partial Class Account_Profile
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim getUserName As String = Request.QueryString("UserName")

        If getUserName = Nothing Then
            getUserName = User.Identity.Name
        End If

        ProfileDS.SelectParameters("UserName").DefaultValue = getUserName

        If Not User.Identity.IsAuthenticated = True Then
            Response.Redirect("~/Account/Login.aspx")
        Else
            Dim retrieveUserName As TextBox = FormView1.FindControl("UserNameTextBox")
            Dim editProfileLink As HyperLink = FormView1.FindControl("hlEdit")
            Dim editProfileImageLink As HyperLink = FormView1.FindControl("hlEditProfileImage")



            If User.Identity.Name = retrieveUserName.Text Then
                editProfileLink.Visible = True
                editProfileImageLink.Visible = True

            Else
                editProfileImageLink.Visible = False
                editProfileLink.Visible = False
            End If

        End If



    End Sub
End Class
