Public Class Register

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnRegist_Click(sender As Object, e As EventArgs) Handles BtnRegist.Click

        If TxtRegistUsername.Text.Length > 0 And TxtRegistPassword.Text.Length > 0 Then
            FormLogin.users.AddUsersDatabase(TxtRegistUsername.Text, TxtRegistPassword.Text)
            Me.Close()
        Else
            MessageBox.Show("Lengkapi Data")
        End If
    End Sub

End Class