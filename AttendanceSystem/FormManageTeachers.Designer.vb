<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormManageTeachers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormManageTeachers))
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnAddTeacher = New System.Windows.Forms.Button()
        Me.btnRefreshTeachers = New System.Windows.Forms.Button()
        Me.dgvTeachers = New System.Windows.Forms.DataGridView()
        Me.lblFullname = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.dgvTeachers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(247, 81)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(161, 22)
        Me.txtFullName.TabIndex = 0
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(247, 174)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(161, 22)
        Me.txtUsername.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(247, 274)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(161, 22)
        Me.txtPassword.TabIndex = 2
        '
        'btnAddTeacher
        '
        Me.btnAddTeacher.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnAddTeacher.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddTeacher.Location = New System.Drawing.Point(259, 393)
        Me.btnAddTeacher.Name = "btnAddTeacher"
        Me.btnAddTeacher.Size = New System.Drawing.Size(149, 41)
        Me.btnAddTeacher.TabIndex = 3
        Me.btnAddTeacher.Text = "AddTeacher"
        Me.btnAddTeacher.UseVisualStyleBackColor = False
        '
        'btnRefreshTeachers
        '
        Me.btnRefreshTeachers.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnRefreshTeachers.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefreshTeachers.Location = New System.Drawing.Point(259, 459)
        Me.btnRefreshTeachers.Name = "btnRefreshTeachers"
        Me.btnRefreshTeachers.Size = New System.Drawing.Size(149, 37)
        Me.btnRefreshTeachers.TabIndex = 4
        Me.btnRefreshTeachers.Text = "Refresh Teachers"
        Me.btnRefreshTeachers.UseVisualStyleBackColor = False
        '
        'dgvTeachers
        '
        Me.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTeachers.Location = New System.Drawing.Point(528, 61)
        Me.dgvTeachers.Name = "dgvTeachers"
        Me.dgvTeachers.RowHeadersWidth = 51
        Me.dgvTeachers.RowTemplate.Height = 24
        Me.dgvTeachers.Size = New System.Drawing.Size(663, 523)
        Me.dgvTeachers.TabIndex = 5
        '
        'lblFullname
        '
        Me.lblFullname.AutoSize = True
        Me.lblFullname.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullname.Location = New System.Drawing.Point(32, 76)
        Me.lblFullname.Name = "lblFullname"
        Me.lblFullname.Size = New System.Drawing.Size(186, 27)
        Me.lblFullname.TabIndex = 6
        Me.lblFullname.Text = "Teachers Fullname:"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(32, 169)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(193, 27)
        Me.lblUsername.TabIndex = 7
        Me.lblUsername.Text = "Teachers Username:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(32, 269)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(186, 27)
        Me.lblPassword.TabIndex = 8
        Me.lblPassword.Text = "Teachers Password:"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnBack.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(69, 628)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(149, 41)
        Me.btnBack.TabIndex = 9
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'FormManageTeachers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1248, 693)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblFullname)
        Me.Controls.Add(Me.dgvTeachers)
        Me.Controls.Add(Me.btnRefreshTeachers)
        Me.Controls.Add(Me.btnAddTeacher)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtFullName)
        Me.DoubleBuffered = True
        Me.Name = "FormManageTeachers"
        Me.Text = "FormManageTeachers"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvTeachers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFullName As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnAddTeacher As Button
    Friend WithEvents btnRefreshTeachers As Button
    Friend WithEvents dgvTeachers As DataGridView
    Friend WithEvents lblFullname As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents btnBack As Button
End Class
