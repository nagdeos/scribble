Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Partial Class Account_ProfileSetting
    Inherits System.Web.UI.Page
    Public doAction As New SiteFunctionsDataContext


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim getUserName As String = Request.QueryString("UserName")


        If Not User.Identity.IsAuthenticated = True Then
            Response.Redirect("~/Account/Login.aspx")
        End If

        DetailsDS.SelectParameters("UserName").DefaultValue = getUserName

        Dim cs As String = ConfigurationManager.ConnectionStrings("DefaultConnection").ConnectionString
        Dim con As New SqlConnection(cs)
        con.Open()
        Dim cmd As New SqlCommand("GetImageByUserName", con)
        cmd.CommandType = CommandType.StoredProcedure

        Dim paramId As New SqlParameter("@UserName", getUserName)

        cmd.Parameters.Add(paramId)


        Dim bytes As Byte() = CType(cmd.ExecuteScalar(), Byte())

        Dim strBase64 As String = Convert.ToBase64String(bytes)

        ProfileImage.ImageUrl = "data:Image/png;base64," + strBase64

        con.Close()





    End Sub

    Protected Sub btnRedirect_Click(sender As Object, e As EventArgs)
        Dim getUserName As String = Request.QueryString("UserName")
        Response.Redirect("~/Account/Profile.aspx?UserName=" + getUserName)
    End Sub


    Protected Sub btnUpdateProfile_Click(sender As Object, e As EventArgs)
        Dim getUserName As TextBox = FormView1.FindControl("UserNameTextBox")
        Dim getName As TextBox = FormView1.FindControl("NameTextBox")
        Dim getEmail As TextBox = FormView1.FindControl("EmailTextBox")
        Dim getPhoneNumber As TextBox = FormView1.FindControl("PhoneNumberTextBox")
        Dim getGender As TextBox = FormView1.FindControl("GenderTextBox")
        Dim getDate As TextBox = FormView1.FindControl("DobTextBox")
        Dim getEducation As TextBox = FormView1.FindControl("EducationTextBox")
        Dim getWork As TextBox = FormView1.FindControl("WorkProfileTextBox")
        Dim getInterest As TextBox = FormView1.FindControl("InterestTextBox")
        Dim getStatus As TextBox = FormView1.FindControl("statusTextBox")


        Try
            doAction.UpdateProfileDetails(User.Identity.Name, getName.Text, getEmail.Text, getPhoneNumber.Text, getGender.Text, getEducation.Text, getWork.Text, getInterest.Text, getDate.Text, getStatus.Text)
            lblResult.Text = "Profile Details are successfully added to the Database."
            lblResult.CssClass = "text-success"

        Catch ex As Exception
            lblResult.Text = ex.Message
            lblResult.CssClass = "text-danger"

        End Try
    End Sub
    Protected Sub btnPost_Click(sender As Object, e As EventArgs)
        Dim getUserName As String = Request.QueryString("UserName")

        Try

            Dim postedFile As HttpPostedFile = FileUpload.PostedFile
            Dim imgName As String = Path.GetFileName(postedFile.FileName)
            FileUpload.SaveAs(Server.MapPath("~/images/") + imgName)
            Dim fileExtension As String = Path.GetExtension(imgName)

            Dim fileSize As Int32 = postedFile.ContentLength

            'If fileExtension.ToLower() = "*.jpg" Or fileExtension.ToLower() = "*.bmp" Or fileExtension.ToLower() = "*.png" Or fileExtension.ToLower() = "*.gif" Then
            Dim stream As Stream = postedFile.InputStream
            Dim binaryReader As New BinaryReader(stream)
            Dim bytes As Byte() = binaryReader.ReadBytes(Convert.ToInt32(stream.Length))

            doAction.UploadImage(bytes, fileSize, getUserName)

            ProfileImage.ImageUrl = "~/images/" + imgName

            lblImageUpload.Text = "Profile Picture is successfully added to the Database."
            lblImageUpload.CssClass = "text-success"

            Response.Redirect("~/Account/Profile.aspx?UserName=" + getUserName)

            ' End If

        Catch ex As Exception

            lblImageUpload.Text = ex.Message
            lblImageUpload.CssClass = "text-danger"

        End Try

    End Sub

End Class
