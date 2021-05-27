<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageProduk
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
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TbOwner = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Btncancel = New System.Windows.Forms.Button()
        Me.Btndelete = New System.Windows.Forms.Button()
        Me.BtnInsert = New System.Windows.Forms.Button()
        Me.Tbtelphone = New System.Windows.Forms.TextBox()
        Me.TbId = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbAlamat = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbNama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(398, 123)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(447, 505)
        Me.DGV.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(361, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 37)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "PRODUK"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TbOwner)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Btncancel)
        Me.GroupBox1.Controls.Add(Me.Btndelete)
        Me.GroupBox1.Controls.Add(Me.BtnInsert)
        Me.GroupBox1.Controls.Add(Me.Tbtelphone)
        Me.GroupBox1.Controls.Add(Me.TbId)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TbAlamat)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TbNama)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(55, 123)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(305, 505)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'TbOwner
        '
        Me.TbOwner.Location = New System.Drawing.Point(136, 219)
        Me.TbOwner.Name = "TbOwner"
        Me.TbOwner.Size = New System.Drawing.Size(144, 22)
        Me.TbOwner.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(51, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Owner"
        '
        'Btncancel
        '
        Me.Btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btncancel.ForeColor = System.Drawing.Color.White
        Me.Btncancel.Location = New System.Drawing.Point(205, 287)
        Me.Btncancel.Name = "Btncancel"
        Me.Btncancel.Size = New System.Drawing.Size(75, 23)
        Me.Btncancel.TabIndex = 19
        Me.Btncancel.Text = "CANCEL"
        Me.Btncancel.UseVisualStyleBackColor = True
        '
        'Btndelete
        '
        Me.Btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btndelete.ForeColor = System.Drawing.Color.White
        Me.Btndelete.Location = New System.Drawing.Point(124, 287)
        Me.Btndelete.Name = "Btndelete"
        Me.Btndelete.Size = New System.Drawing.Size(75, 23)
        Me.Btndelete.TabIndex = 18
        Me.Btndelete.Text = "DELETE"
        Me.Btndelete.UseVisualStyleBackColor = True
        '
        'BtnInsert
        '
        Me.BtnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInsert.ForeColor = System.Drawing.Color.White
        Me.BtnInsert.Location = New System.Drawing.Point(43, 287)
        Me.BtnInsert.Name = "BtnInsert"
        Me.BtnInsert.Size = New System.Drawing.Size(75, 23)
        Me.BtnInsert.TabIndex = 17
        Me.BtnInsert.Text = "INSERT"
        Me.BtnInsert.UseVisualStyleBackColor = True
        '
        'Tbtelphone
        '
        Me.Tbtelphone.Location = New System.Drawing.Point(136, 176)
        Me.Tbtelphone.Name = "Tbtelphone"
        Me.Tbtelphone.Size = New System.Drawing.Size(144, 22)
        Me.Tbtelphone.TabIndex = 16
        '
        'TbId
        '
        Me.TbId.Location = New System.Drawing.Point(136, 62)
        Me.TbId.Name = "TbId"
        Me.TbId.Size = New System.Drawing.Size(100, 22)
        Me.TbId.TabIndex = 14
        Me.TbId.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(51, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Telephon"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(51, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 6
        '
        'TbAlamat
        '
        Me.TbAlamat.Location = New System.Drawing.Point(136, 134)
        Me.TbAlamat.Name = "TbAlamat"
        Me.TbAlamat.Size = New System.Drawing.Size(144, 22)
        Me.TbAlamat.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(51, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Alamat"
        '
        'TbNama
        '
        Me.TbNama.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbNama.Location = New System.Drawing.Point(136, 90)
        Me.TbNama.Name = "TbNama"
        Me.TbNama.Size = New System.Drawing.Size(144, 22)
        Me.TbNama.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(51, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nama"
        '
        'ManageProduk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(900, 670)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManageProduk"
        Me.Text = "ManageProduk"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TbOwner As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Btncancel As Button
    Friend WithEvents Btndelete As Button
    Friend WithEvents BtnInsert As Button
    Friend WithEvents Tbtelphone As TextBox
    Friend WithEvents TbId As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TbAlamat As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TbNama As TextBox
    Friend WithEvents Label2 As Label
End Class
