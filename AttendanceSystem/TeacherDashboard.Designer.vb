<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeacherDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TeacherDashboard))
        Me.cmbTeacherCourses = New System.Windows.Forms.ComboBox()
        Me.btnViewAttendance = New System.Windows.Forms.Button()
        Me.dgvAttendance = New System.Windows.Forms.DataGridView()
        Me.btnHome = New System.Windows.Forms.Button()
        CType(Me.dgvAttendance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbTeacherCourses
        '
        Me.cmbTeacherCourses.FormattingEnabled = True
        Me.cmbTeacherCourses.Location = New System.Drawing.Point(33, 188)
        Me.cmbTeacherCourses.Name = "cmbTeacherCourses"
        Me.cmbTeacherCourses.Size = New System.Drawing.Size(202, 24)
        Me.cmbTeacherCourses.TabIndex = 0
        '
        'btnViewAttendance
        '
        Me.btnViewAttendance.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnViewAttendance.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewAttendance.Location = New System.Drawing.Point(33, 293)
        Me.btnViewAttendance.Name = "btnViewAttendance"
        Me.btnViewAttendance.Size = New System.Drawing.Size(202, 48)
        Me.btnViewAttendance.TabIndex = 1
        Me.btnViewAttendance.Text = "View Attendance"
        Me.btnViewAttendance.UseVisualStyleBackColor = False
        '
        'dgvAttendance
        '
        Me.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAttendance.Location = New System.Drawing.Point(410, 31)
        Me.dgvAttendance.Name = "dgvAttendance"
        Me.dgvAttendance.RowHeadersWidth = 51
        Me.dgvAttendance.RowTemplate.Height = 24
        Me.dgvAttendance.Size = New System.Drawing.Size(677, 565)
        Me.dgvAttendance.TabIndex = 2
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnHome.Font = New System.Drawing.Font("Palatino Linotype", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.Location = New System.Drawing.Point(33, 618)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(202, 43)
        Me.btnHome.TabIndex = 3
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'TeacherDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1174, 735)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.dgvAttendance)
        Me.Controls.Add(Me.btnViewAttendance)
        Me.Controls.Add(Me.cmbTeacherCourses)
        Me.Name = "TeacherDashboard"
        Me.Text = "TeacherDashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvAttendance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmbTeacherCourses As ComboBox
    Friend WithEvents btnViewAttendance As Button
    Friend WithEvents dgvAttendance As DataGridView
    Friend WithEvents btnHome As Button
End Class
