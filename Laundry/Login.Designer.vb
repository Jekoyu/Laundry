<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbUsername = New System.Windows.Forms.TextBox()
        Me.TbPassword = New System.Windows.Forms.TextBox()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 30.0!)
        Me.Label1.Location = New System.Drawing.Point(46, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label2.Location = New System.Drawing.Point(50, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(211, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hello Let's Get Started "
        '
        'TbUsername
        '
        Me.TbUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TbUsername.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.TbUsername.Location = New System.Drawing.Point(17, 84)
        Me.TbUsername.Multiline = True
        Me.TbUsername.Name = "TbUsername"
        Me.TbUsername.Size = New System.Drawing.Size(258, 36)
        Me.TbUsername.TabIndex = 2
        Me.TbUsername.Text = "Username"
        '
        'TbPassword
        '
        Me.TbPassword.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.TbPassword.Location = New System.Drawing.Point(17, 147)
        Me.TbPassword.Multiline = True
        Me.TbPassword.Name = "TbPassword"
        Me.TbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TbPassword.Size = New System.Drawing.Size(258, 35)
        Me.TbPassword.TabIndex = 3
        Me.TbPassword.Text = "Password"
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.White
        Me.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogin.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.BtnLogin.Location = New System.Drawing.Point(322, 115)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(63, 31)
        Me.BtnLogin.TabIndex = 6
        Me.BtnLogin.Text = "LOGIN"
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnLogin)
        Me.Panel1.Controls.Add(Me.TbPassword)
        Me.Panel1.Controls.Add(Me.TbUsername)
        Me.Panel1.Location = New System.Drawing.Point(43, 241)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(417, 280)
        Me.Panel1.TabIndex = 7
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 700)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TbUsername As TextBox
    Friend WithEvents TbPassword As TextBox
    Friend WithEvents BtnLogin As Button
    Friend WithEvents Panel1 As Panel
End Class
