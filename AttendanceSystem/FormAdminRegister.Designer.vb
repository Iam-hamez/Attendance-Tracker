<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdminRegistration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAdminRegistration))
        Me.txtAdminUsername = New System.Windows.Forms.TextBox()
        Me.txtAdminPassword = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.btnRegisterAdmin = New System.Windows.Forms.Button()
        Me.lblHello = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtAdminUsername
        '
        Me.txtAdminUsername.Location = New System.Drawing.Point(590, 222)
        Me.txtAdminUsername.Name = "txtAdminUsername"
        Me.txtAdminUsername.Size = New System.Drawing.Size(276, 22)
        Me.txtAdminUsername.TabIndex = 0
        '
        'txtAdminPassword
        '
        Me.txtAdminPassword.Location = New System.Drawing.Point(590, 321)
        Me.txtAdminPassword.Name = "txtAdminPassword"
        Me.txtAdminPassword.Size = New System.Drawing.Size(276, 22)
        Me.txtAdminPassword.TabIndex = 1
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(394, 222)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(119, 31)
        Me.lblUsername.TabIndex = 2
        Me.lblUsername.Text = "Username"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(394, 321)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(113, 31)
        Me.lblPassword.TabIndex = 3
        Me.lblPassword.Text = "Password"
        '
        'btnRegisterAdmin
        '
        Me.btnRegisterAdmin.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnRegisterAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegisterAdmin.Location = New System.Drawing.Point(553, 500)
        Me.btnRegisterAdmin.Name = "btnRegisterAdmin"
        Me.btnRegisterAdmin.Size = New System.Drawing.Size(313, 74)
        Me.btnRegisterAdmin.TabIndex = 4
        Me.btnRegisterAdmin.Text = "Register Admin"
        Me.btnRegisterAdmin.UseVisualStyleBackColor = False
        '
        'lblHello
        '
        Me.lblHello.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblHello.AutoSize = True
        Me.lblHello.Font = New System.Drawing.Font("Palatino Linotype", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHello.Location = New System.Drawing.Point(590, 50)
        Me.lblHello.Name = "lblHello"
        Me.lblHello.Size = New System.Drawing.Size(237, 50)
        Me.lblHello.TabIndex = 5
        Me.lblHello.Text = "Hello,Admin"
        '
        'FormAdminRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1276, 710)
        Me.Controls.Add(Me.lblHello)
        Me.Controls.Add(Me.btnRegisterAdmin)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.txtAdminPassword)
        Me.Controls.Add(Me.txtAdminUsername)
        Me.DoubleBuffered = True
        Me.Name = "FormAdminRegistration"
        Me.Text = "FormAdminRegistration"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAdminUsername As TextBox
    Friend WithEvents txtAdminPassword As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents btnRegisterAdmin As Button
    Friend WithEvents lblHello As Label
End Class
