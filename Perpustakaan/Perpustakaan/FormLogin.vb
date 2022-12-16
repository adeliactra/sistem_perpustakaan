Public Class FormLogin

    Public Shared users As Users

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        users = New Users()
    End Sub
    Private Sub TxtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPassword.KeyPress
        TxtPassword.PasswordChar = "*"c
    End Sub
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim plainUsername As String = TxtUsername.Text
        Dim plainPassword As String = TxtPassword.Text
        Dim cek = users.CheckAuthDatabase(plainUsername, plainPassword)
        Dim count = cek.Count

        If count > 0 Then
            users.GSUsername = cek(0)(1)
            Perpustakaan.Show()
            Me.Hide()
        Else
            MessageBox.Show("Salah Password atau Username")
        End If




    End Sub

    Private Sub BtnSIgnUp_Click(sender As Object, e As EventArgs) Handles BtnSIgnUp.Click
        Register.Show()
    End Sub

End Class