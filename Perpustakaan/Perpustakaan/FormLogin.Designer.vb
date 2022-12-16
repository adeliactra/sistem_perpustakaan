<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.LblLogin = New System.Windows.Forms.Label()
        Me.BtnSIgnUp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtUsername
        '
        Me.TxtUsername.Location = New System.Drawing.Point(144, 66)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(239, 23)
        Me.TxtUsername.TabIndex = 0
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblUsername.Location = New System.Drawing.Point(26, 64)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(97, 25)
        Me.LblUsername.TabIndex = 1
        Me.LblUsername.Text = "Username"
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblPassword.Location = New System.Drawing.Point(26, 116)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(91, 25)
        Me.LblPassword.TabIndex = 2
        Me.LblPassword.Text = "Password"
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(144, 118)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(239, 23)
        Me.TxtPassword.TabIndex = 3
        '
        'BtnLogin
        '
        Me.BtnLogin.Location = New System.Drawing.Point(308, 170)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(75, 23)
        Me.BtnLogin.TabIndex = 4
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'LblLogin
        '
        Me.LblLogin.AutoSize = True
        Me.LblLogin.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblLogin.Location = New System.Drawing.Point(185, 9)
        Me.LblLogin.Name = "LblLogin"
        Me.LblLogin.Size = New System.Drawing.Size(82, 32)
        Me.LblLogin.TabIndex = 5
        Me.LblLogin.Text = "LOGIN"
        '
        'BtnSIgnUp
        '
        Me.BtnSIgnUp.Location = New System.Drawing.Point(227, 170)
        Me.BtnSIgnUp.Name = "BtnSIgnUp"
        Me.BtnSIgnUp.Size = New System.Drawing.Size(75, 23)
        Me.BtnSIgnUp.TabIndex = 6
        Me.BtnSIgnUp.Text = "Sign up"
        Me.BtnSIgnUp.UseVisualStyleBackColor = True
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 211)
        Me.Controls.Add(Me.BtnSIgnUp)
        Me.Controls.Add(Me.LblLogin)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.LblUsername)
        Me.Controls.Add(Me.TxtUsername)
        Me.Name = "FormLogin"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents LblUsername As Label
    Friend WithEvents LblPassword As Label
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents BtnLogin As Button
    Friend WithEvents LblLogin As Label
    Friend WithEvents BtnSIgnUp As Button
End Class
