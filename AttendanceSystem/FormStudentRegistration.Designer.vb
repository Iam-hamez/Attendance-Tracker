<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStudentRegistration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormStudentRegistration))
        Me.txtFullname = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblFullname = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnEmail = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtPreferredUsername = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtFullname
        '
        Me.txtFullname.Location = New System.Drawing.Point(242, 326)
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Size = New System.Drawing.Size(324, 22)
        Me.txtFullname.TabIndex = 2
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(242, 397)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(324, 22)
        Me.txtPassword.TabIndex = 3
        '
        'lblFullname
        '
        Me.lblFullname.AutoSize = True
        Me.lblFullname.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lblFullname.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullname.Location = New System.Drawing.Point(44, 321)
        Me.lblFullname.Name = "lblFullname"
        Me.lblFullname.Size = New System.Drawing.Size(97, 27)
        Me.lblFullname.TabIndex = 4
        Me.lblFullname.Text = "Fullname"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lblPassword.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(44, 397)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(97, 27)
        Me.lblPassword.TabIndex = 5
        Me.lblPassword.Text = "Password"
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnRegister.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.Location = New System.Drawing.Point(477, 564)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(254, 60)
        Me.btnRegister.TabIndex = 6
        Me.btnRegister.Text = "Complete Registration"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(242, 240)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(324, 22)
        Me.txtEmail.TabIndex = 7
        '
        'btnEmail
        '
        Me.btnEmail.AutoSize = True
        Me.btnEmail.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnEmail.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmail.Location = New System.Drawing.Point(44, 235)
        Me.btnEmail.Name = "btnEmail"
        Me.btnEmail.Size = New System.Drawing.Size(64, 27)
        Me.btnEmail.TabIndex = 8
        Me.btnEmail.Text = "Email"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnBack.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(45, 572)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(147, 52)
        Me.btnBack.TabIndex = 9
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Tomato
        Me.btnExit.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(1024, 572)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(149, 52)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lblUsername.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(40, 155)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(104, 27)
        Me.lblUsername.TabIndex = 11
        Me.lblUsername.Text = "Username"
        '
        'txtPreferredUsername
        '
        Me.txtPreferredUsername.Location = New System.Drawing.Point(242, 155)
        Me.txtPreferredUsername.Name = "txtPreferredUsername"
        Me.txtPreferredUsername.Size = New System.Drawing.Size(324, 22)
        Me.txtPreferredUsername.TabIndex = 12
        '
        'FormStudentRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1295, 721)
        Me.Controls.Add(Me.txtPreferredUsername)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnEmail)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblFullname)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtFullname)
        Me.DoubleBuffered = True
        Me.Name = "FormStudentRegistration"
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFullname As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblFullname As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnEmail As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtPreferredUsername As TextBox
End Class
