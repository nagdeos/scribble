
Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.UI.WebControls


Partial Class Account_Comment
    Inherits System.Web.UI.Page
    Public doAction As New SiteFunctionsDataContext


    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim getID As String = Request.QueryString("StoryID")
        Dim getUserName As String = Context.User.Identity.Name



        Dim cs As String = ConfigurationManager.ConnectionStrings("DefaultConnection").ConnectionString
        Dim con As New SqlConnection(cs)

        con.Open()

        Dim cmd As New SqlCommand("GetUserNameByStoryID", con)
        cmd.CommandType = CommandType.StoredProcedure

        Dim paramId As New SqlParameter("@StoryID", Convert.ToInt32((getID)))

        cmd.Parameters.Add(paramId)

        Dim userName As String = CType(cmd.ExecuteScalar(), String)

        con.Close()





    End Sub
    Protected Sub btnAddComment_Click(sender As Object, e As EventArgs)

        Dim getID As String = Request.QueryString("StoryID")
        Dim getUserName As String = Context.User.Identity.Name

        Try
            doAction.AddComment(txtComment.Text, getUserName, getID)
            doAction.SetOpinion(getID)
            lblResult.Text = "Comment is successfully added."
            lblResult.CssClass = "text-success"
            Response.Redirect("~/Account/Comment.aspx?StoryID=" + getID)
        Catch ex As Exception
            lblResult.Text = ex.Message
            lblResult.CssClass = "text-danger"

        End Try

    End Sub
End Class
