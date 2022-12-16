<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HapusKoleksi
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
        Me.LblKonfrmasiHapus = New System.Windows.Forms.Label()
        Me.LblNamaKoleksiHapus = New System.Windows.Forms.Label()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblKonfrmasiHapus
        '
        Me.LblKonfrmasiHapus.AutoSize = True
        Me.LblKonfrmasiHapus.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblKonfrmasiHapus.Location = New System.Drawing.Point(95, 24)
        Me.LblKonfrmasiHapus.Name = "LblKonfrmasiHapus"
        Me.LblKonfrmasiHapus.Size = New System.Drawing.Size(247, 21)
        Me.LblKonfrmasiHapus.TabIndex = 0
        Me.LblKonfrmasiHapus.Text = "Apakah Ingin Menghapus Koleksi?"
        '
        'LblNamaKoleksiHapus
        '
        Me.LblNamaKoleksiHapus.AutoSize = True
        Me.LblNamaKoleksiHapus.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblNamaKoleksiHapus.ForeColor = System.Drawing.Color.Maroon
        Me.LblNamaKoleksiHapus.Location = New System.Drawing.Point(158, 94)
        Me.LblNamaKoleksiHapus.Name = "LblNamaKoleksiHapus"
        Me.LblNamaKoleksiHapus.Size = New System.Drawing.Size(120, 32)
        Me.LblNamaKoleksiHapus.TabIndex = 1
        Me.LblNamaKoleksiHapus.Text = "Koleksi A"
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(179, 186)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(75, 23)
        Me.BtnHapus.TabIndex = 2
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'HapusKoleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 239)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.LblNamaKoleksiHapus)
        Me.Controls.Add(Me.LblKonfrmasiHapus)
        Me.Name = "HapusKoleksi"
        Me.Text = "HapusKoleksi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblKonfrmasiHapus As Label
    Friend WithEvents LblNamaKoleksiHapus As Label
    Friend WithEvents BtnHapus As Button
End Class
