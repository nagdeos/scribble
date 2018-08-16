Imports System.Threading.Thread


Partial Class Admin_KeywordMaster
    Inherits System.Web.UI.Page
    Public doAction As New SiteFunctionsDataContext


    Protected Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Try
            doAction.AddKeyword(TxtKeyword.Text, TxtRating.Text)
            lblResult.Text = "Keyword is successfully added to the Database."
            lblResult.CssClass = "text-success"

            TxtKeyword.Text = ""
            TxtRating.Text = ""


        Catch ex As Exception
            lblResult.Text = ex.Message
            lblResult.CssClass = "text-danger"
        End Try



    End Sub

    Protected Sub btnRedirect_Click(sender As Object, e As EventArgs) Handles btnRedirect.Click
        Response.Redirect("~/Admin/Admin.aspx")
    End Sub
End Class
