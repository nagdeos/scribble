Imports System.IO
Partial Class Account_EditStory
    Inherits System.Web.UI.Page
    Public doAction As New SiteFunctionsDataContext

    Protected Sub btnPost_Click(sender As Object, e As EventArgs)
        Dim getID As String = Request.QueryString("StoryID")
        Dim getUserName As String = Context.User.Identity.Name

        Try
            Dim getCaption As TextBox = lv.FindControl("CaptionTextBox")
            Dim postedFile As HttpPostedFile = FileUpload.PostedFile
            Dim imgName As String = Path.GetFileName(postedFile.FileName)
            FileUpload.SaveAs(Server.MapPath("~/images/") + imgName)
            'Dim fileExtension As String = Path.GetExtension(imgName)

            'Dim fileSize As Int32 = postedFile.ContentLength
            'If fileExtension.ToLower() = "*.jpg" Or fileExtension.ToLower() = "*.bmp" Or fileExtension.ToLower() = "*.png" Or fileExtension.ToLower() = "*.gif" Then
            Dim stream As Stream = postedFile.InputStream
            Dim binaryReader As New BinaryReader(stream)
            Dim bytes As Byte() = binaryReader.ReadBytes(Convert.ToInt32(stream.Length))

            doAction.UpdateStory(Convert.ToInt32(getID), bytes, getCaption.Text, Date.Now.ToString("yyyy/MM/dd HH:mm:ss"))


            'ProfileImage.ImageUrl = "~/images/" + imgName

            lblImageUpload.Text = getUserName + "' Story is successfully updated."
            lblImageUpload.CssClass = "text-success"

            'Response.Redirect("~/Account/Profile.aspx?UserName=")

            ' End If

        Catch ex As Exception

            lblImageUpload.Text = ex.Message
            lblImageUpload.CssClass = "text-danger"

        End Try
    End Sub
End Class
