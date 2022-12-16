<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Perpustakaan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Perpustakaan))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KoleksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahKoleksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TSBtnTambah = New System.Windows.Forms.ToolStripButton()
        Me.TSBtnHapus = New System.Windows.Forms.ToolStripButton()
        Me.ListBoxKoleksi = New System.Windows.Forms.ListBox()
        Me.DataGridViewKoleksi = New System.Windows.Forms.DataGridView()
        Me.BtnShowSelect = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridViewKoleksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KoleksiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1039, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KoleksiToolStripMenuItem
        '
        Me.KoleksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahKoleksiToolStripMenuItem})
        Me.KoleksiToolStripMenuItem.Name = "KoleksiToolStripMenuItem"
        Me.KoleksiToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.KoleksiToolStripMenuItem.Text = "Koleksi"
        '
        'TambahKoleksiToolStripMenuItem
        '
        Me.TambahKoleksiToolStripMenuItem.Name = "TambahKoleksiToolStripMenuItem"
        Me.TambahKoleksiToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.TambahKoleksiToolStripMenuItem.Text = "Tambah Koleksi"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSBtnTambah, Me.TSBtnHapus})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1039, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TSBtnTambah
        '
        Me.TSBtnTambah.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBtnTambah.Image = CType(resources.GetObject("TSBtnTambah.Image"), System.Drawing.Image)
        Me.TSBtnTambah.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBtnTambah.Name = "TSBtnTambah"
        Me.TSBtnTambah.Size = New System.Drawing.Size(23, 22)
        Me.TSBtnTambah.Text = "TSBtnTambah"
        '
        'TSBtnHapus
        '
        Me.TSBtnHapus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBtnHapus.Image = CType(resources.GetObject("TSBtnHapus.Image"), System.Drawing.Image)
        Me.TSBtnHapus.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBtnHapus.Name = "TSBtnHapus"
        Me.TSBtnHapus.Size = New System.Drawing.Size(23, 22)
        Me.TSBtnHapus.Text = "TSBtnHapus"
        '
        'ListBoxKoleksi
        '
        Me.ListBoxKoleksi.FormattingEnabled = True
        Me.ListBoxKoleksi.ItemHeight = 15
        Me.ListBoxKoleksi.Location = New System.Drawing.Point(12, 52)
        Me.ListBoxKoleksi.Name = "ListBoxKoleksi"
        Me.ListBoxKoleksi.Size = New System.Drawing.Size(338, 334)
        Me.ListBoxKoleksi.TabIndex = 2
        '
        'DataGridViewKoleksi
        '
        Me.DataGridViewKoleksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewKoleksi.Location = New System.Drawing.Point(383, 52)
        Me.DataGridViewKoleksi.Name = "DataGridViewKoleksi"
        Me.DataGridViewKoleksi.RowTemplate.Height = 25
        Me.DataGridViewKoleksi.Size = New System.Drawing.Size(644, 334)
        Me.DataGridViewKoleksi.TabIndex = 3
        '
        'BtnShowSelect
        '
        Me.BtnShowSelect.Location = New System.Drawing.Point(835, 401)
        Me.BtnShowSelect.Name = "BtnShowSelect"
        Me.BtnShowSelect.Size = New System.Drawing.Size(93, 29)
        Me.BtnShowSelect.TabIndex = 4
        Me.BtnShowSelect.Text = "Select"
        Me.BtnShowSelect.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(736, 401)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(93, 29)
        Me.BtnUpdate.TabIndex = 5
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnRemove
        '
        Me.BtnRemove.Location = New System.Drawing.Point(934, 401)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(93, 29)
        Me.BtnRemove.TabIndex = 6
        Me.BtnRemove.Text = "Remove"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'Perpustakaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1039, 442)
        Me.Controls.Add(Me.BtnRemove)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnShowSelect)
        Me.Controls.Add(Me.DataGridViewKoleksi)
        Me.Controls.Add(Me.ListBoxKoleksi)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Perpustakaan"
        Me.Text = "Perpustakaan"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridViewKoleksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents KoleksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahKoleksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TSBtnTambah As ToolStripButton
    Friend WithEvents TSBtnHapus As ToolStripButton
    Friend WithEvents ListBoxKoleksi As ListBox
    Friend WithEvents DataGridViewKoleksi As DataGridView
    Friend WithEvents BtnShowSelect As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnRemove As Button
End Class
