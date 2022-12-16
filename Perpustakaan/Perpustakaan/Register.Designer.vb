<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Me.LblRegister = New System.Windows.Forms.Label()
        Me.BtnRegist = New System.Windows.Forms.Button()
        Me.TxtRegistPassword = New System.Windows.Forms.TextBox()
        Me.LblRegistPassword = New System.Windows.Forms.Label()
        Me.LblRegistUsername = New System.Windows.Forms.Label()
        Me.TxtRegistUsername = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LblRegister
        '
        Me.LblRegister.AutoSize = True
        Me.LblRegister.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblRegister.Location = New System.Drawing.Point(144, 21)
        Me.LblRegister.Name = "LblRegister"
        Me.LblRegister.Size = New System.Drawing.Size(296, 32)
        Me.LblRegister.TabIndex = 11
        Me.LblRegister.Text = "REGISTER YOUR ACCOUNT"
        '
        'BtnRegist
        '
        Me.BtnRegist.Location = New System.Drawing.Point(382, 205)
        Me.BtnRegist.Name = "BtnRegist"
        Me.BtnRegist.Size = New System.Drawing.Size(75, 23)
        Me.BtnRegist.TabIndex = 10
        Me.BtnRegist.Text = "Regist"
        Me.BtnRegist.UseVisualStyleBackColor = True
        '
        'TxtRegistPassword
        '
        Me.TxtRegistPassword.Location = New System.Drawing.Point(218, 153)
        Me.TxtRegistPassword.Name = "TxtRegistPassword"
        Me.TxtRegistPassword.Size = New System.Drawing.Size(239, 23)
        Me.TxtRegistPassword.TabIndex = 9
        '
        'LblRegistPassword
        '
        Me.LblRegistPassword.AutoSize = True
        Me.LblRegistPassword.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblRegistPassword.Location = New System.Drawing.Point(100, 151)
        Me.LblRegistPassword.Name = "LblRegistPassword"
        Me.LblRegistPassword.Size = New System.Drawing.Size(91, 25)
        Me.LblRegistPassword.TabIndex = 8
        Me.LblRegistPassword.Text = "Password"
        '
        'LblRegistUsername
        '
        Me.LblRegistUsername.AutoSize = True
        Me.LblRegistUsername.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblRegistUsername.Location = New System.Drawing.Point(100, 99)
        Me.LblRegistUsername.Name = "LblRegistUsername"
        Me.LblRegistUsername.Size = New System.Drawing.Size(97, 25)
        Me.LblRegistUsername.TabIndex = 7
        Me.LblRegistUsername.Text = "Username"
        '
        'TxtRegistUsername
        '
        Me.TxtRegistUsername.Location = New System.Drawing.Point(218, 101)
        Me.TxtRegistUsername.Name = "TxtRegistUsername"
        Me.TxtRegistUsername.Size = New System.Drawing.Size(239, 23)
        Me.TxtRegistUsername.TabIndex = 6
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 272)
        Me.Controls.Add(Me.LblRegister)
        Me.Controls.Add(Me.BtnRegist)
        Me.Controls.Add(Me.TxtRegistPassword)
        Me.Controls.Add(Me.LblRegistPassword)
        Me.Controls.Add(Me.LblRegistUsername)
        Me.Controls.Add(Me.TxtRegistUsername)
        Me.Name = "Register"
        Me.Text = "Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblRegister As Label
    Friend WithEvents BtnRegist As Button
    Friend WithEvents TxtRegistPassword As TextBox
    Friend WithEvents LblRegistPassword As Label
    Friend WithEvents LblRegistUsername As Label
    Friend WithEvents TxtRegistUsername As TextBox
End Class
