Partial Class Admin_UpdateKeyword
    Inherits System.Web.UI.Page
    Public doAction As New SiteFunctionsDataContext

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        KeywordUpdateDS.SelectParameters("KeywordID").DefaultValue = Request.QueryString("KeywordID")

    End Sub

    Protected Sub btnKeyword_Click(sender As Object, e As EventArgs)
        Dim getKeyword As TextBox = FormView1.FindControl("KeywordNameTextBox")
        Dim getRating As TextBox = FormView1.FindControl("RatingTextBox")
        Dim getID As String = Request.QueryString("KeywordID")
        Try
            doAction.UpdateKeyword(Convert.ToInt32(getID), getKeyword.Text, Convert.ToInt32(getRating.Text))
            lblResult.Text = "Keyword Details are successfully updated in the Database."
            lblResult.CssClass = "text-success"

        Catch ex As Exception
            lblResult.Text = ex.Message
            lblResult.CssClass = "text-danger"

        End Try



    End Sub
    Protected Sub btnRedirect_Click(sender As Object, e As EventArgs)
        Response.Redirect("~/Admin/Admin.aspx")
    End Sub

End Class
