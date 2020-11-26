Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub BTN_1_Click(sender As Object, e As EventArgs) Handles BTN_1.Click
        Label1.Visible = True
        Label1.Text = "Welcome to Tutorials Point: " + ED_1.Text
        Label2.Text = "You visited us at: " + DateTime.Now.ToString()
    End Sub
End Class