
Imports System.IO

Partial Class Account_Wall
    Inherits System.Web.UI.Page
    Public doAction As New SiteFunctionsDataContext
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
    Protected Sub btnPost_Click(sender As Object, e As EventArgs) Handles btnPost.Click
        Dim getUserName As String = Request.QueryString("UserName")

        Try
            'Dim getCaption As TextBox = Page.FindControl("txtCaption")
            Dim postedFile As HttpPostedFile = FileUpload.PostedFile
            Dim imgName As String = Path.GetFileName(postedFile.FileName)
            FileUpload.SaveAs(Server.MapPath("~/images/") + imgName)




            'If fileExtension.ToLower() = "*.jpg" Or fileExtension.ToLower() = "*.bmp" Or fileExtension.ToLower() = "*.png" Or fileExtension.ToLower() = "*.gif" Then
            Dim stream As Stream = postedFile.InputStream
            Dim binaryReader As New BinaryReader(stream)
            Dim bytes As Byte() = binaryReader.ReadBytes(Convert.ToInt32(stream.Length))

            doAction.AddStory(User.Identity.Name, bytes, txtCaption.Text, Date.Now.ToString("yyyy/MM/dd HH:mm:ss"))


            Image.ImageUrl = "~/images/" + imgName

            lblResult.Text = "Story is successfully added to the Database."
            lblResult.CssClass = "text-success"

            Response.Redirect("~/Account/Wall.aspx")



        Catch ex As Exception

            lblResult.Text = ex.Message
            lblResult.CssClass = "text-danger"

        End Try

    End Sub


End Class
