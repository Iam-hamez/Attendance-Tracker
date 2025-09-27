<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAddAdmin))
        Me.lblAdminUSername = New System.Windows.Forms.Label()
        Me.txtAdminUsername = New System.Windows.Forms.TextBox()
        Me.txtAdminPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAdminUSername
        '
        Me.lblAdminUSername.AutoSize = True
        Me.lblAdminUSername.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdminUSername.Location = New System.Drawing.Point(289, 123)
        Me.lblAdminUSername.Name = "lblAdminUSername"
        Me.lblAdminUSername.Size = New System.Drawing.Size(203, 31)
        Me.lblAdminUSername.TabIndex = 0
        Me.lblAdminUSername.Text = "Admin Username:"
        '
        'txtAdminUsername
        '
        Me.txtAdminUsername.Location = New System.Drawing.Point(535, 132)
        Me.txtAdminUsername.Name = "txtAdminUsername"
        Me.txtAdminUsername.Size = New System.Drawing.Size(266, 22)
        Me.txtAdminUsername.TabIndex = 1
        '
        'txtAdminPassword
        '
        Me.txtAdminPassword.Location = New System.Drawing.Point(535, 241)
        Me.txtAdminPassword.Name = "txtAdminPassword"
        Me.txtAdminPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtAdminPassword.Size = New System.Drawing.Size(266, 22)
        Me.txtAdminPassword.TabIndex = 2
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(362, 233)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(119, 31)
        Me.lblPassword.TabIndex = 3
        Me.lblPassword.Text = "Password:"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnSave.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(834, 534)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(181, 55)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnBack.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(292, 534)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(175, 55)
        Me.btnBack.TabIndex = 5
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'FormAddAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1284, 665)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtAdminPassword)
        Me.Controls.Add(Me.txtAdminUsername)
        Me.Controls.Add(Me.lblAdminUSername)
        Me.DoubleBuffered = True
        Me.Name = "FormAddAdmin"
        Me.Text = "FormAddAdmin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAdminUSername As Label
    Friend WithEvents txtAdminUsername As TextBox
    Friend WithEvents txtAdminPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnBack As Button
End Class
