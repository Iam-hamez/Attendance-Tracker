<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdminDashboard2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAdminDashboard2))
        Me.btnAddStudent = New System.Windows.Forms.Button()
        Me.btnAttendanceHistory = New System.Windows.Forms.Button()
        Me.dgvStudents = New System.Windows.Forms.DataGridView()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnAddAdmin = New System.Windows.Forms.Button()
        Me.btnShowStudents = New System.Windows.Forms.Button()
        Me.btnDeleteStudent = New System.Windows.Forms.Button()
        Me.cmbSearchColumn = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnShowAll = New System.Windows.Forms.Button()
        Me.btnViewAttendance = New System.Windows.Forms.Button()
        Me.txtManageTeachers = New System.Windows.Forms.Button()
        Me.txtManageCourses = New System.Windows.Forms.Button()
        Me.btnAssignCourses = New System.Windows.Forms.Button()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAddStudent
        '
        Me.btnAddStudent.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnAddStudent.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddStudent.Location = New System.Drawing.Point(-1, 85)
        Me.btnAddStudent.Name = "btnAddStudent"
        Me.btnAddStudent.Size = New System.Drawing.Size(233, 73)
        Me.btnAddStudent.TabIndex = 0
        Me.btnAddStudent.Text = "AddStudent"
        Me.btnAddStudent.UseVisualStyleBackColor = False
        '
        'btnAttendanceHistory
        '
        Me.btnAttendanceHistory.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnAttendanceHistory.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAttendanceHistory.Location = New System.Drawing.Point(-1, 466)
        Me.btnAttendanceHistory.Name = "btnAttendanceHistory"
        Me.btnAttendanceHistory.Size = New System.Drawing.Size(233, 69)
        Me.btnAttendanceHistory.TabIndex = 2
        Me.btnAttendanceHistory.Text = "AttendanceHistory"
        Me.btnAttendanceHistory.UseVisualStyleBackColor = False
        '
        'dgvStudents
        '
        Me.dgvStudents.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudents.Location = New System.Drawing.Point(631, 85)
        Me.dgvStudents.Name = "dgvStudents"
        Me.dgvStudents.RowHeadersWidth = 51
        Me.dgvStudents.RowTemplate.Height = 24
        Me.dgvStudents.Size = New System.Drawing.Size(946, 415)
        Me.dgvStudents.TabIndex = 3
        '
        'btnHome
        '
        Me.btnHome.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnHome.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnHome.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.Location = New System.Drawing.Point(95, 563)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(137, 51)
        Me.btnHome.TabIndex = 4
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.Tomato
        Me.btnExit.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(1396, 563)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(119, 51)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnAddAdmin
        '
        Me.btnAddAdmin.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnAddAdmin.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAdmin.Location = New System.Drawing.Point(-1, 164)
        Me.btnAddAdmin.Name = "btnAddAdmin"
        Me.btnAddAdmin.Size = New System.Drawing.Size(233, 73)
        Me.btnAddAdmin.TabIndex = 6
        Me.btnAddAdmin.Text = "Add Admin"
        Me.btnAddAdmin.UseVisualStyleBackColor = False
        '
        'btnShowStudents
        '
        Me.btnShowStudents.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnShowStudents.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowStudents.Location = New System.Drawing.Point(-1, 243)
        Me.btnShowStudents.Name = "btnShowStudents"
        Me.btnShowStudents.Size = New System.Drawing.Size(233, 77)
        Me.btnShowStudents.TabIndex = 7
        Me.btnShowStudents.Text = "View Students"
        Me.btnShowStudents.UseVisualStyleBackColor = False
        '
        'btnDeleteStudent
        '
        Me.btnDeleteStudent.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnDeleteStudent.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteStudent.Location = New System.Drawing.Point(-1, 326)
        Me.btnDeleteStudent.Name = "btnDeleteStudent"
        Me.btnDeleteStudent.Size = New System.Drawing.Size(233, 72)
        Me.btnDeleteStudent.TabIndex = 8
        Me.btnDeleteStudent.Text = "Delete Student"
        Me.btnDeleteStudent.UseVisualStyleBackColor = False
        '
        'cmbSearchColumn
        '
        Me.cmbSearchColumn.FormattingEnabled = True
        Me.cmbSearchColumn.Location = New System.Drawing.Point(345, 95)
        Me.cmbSearchColumn.Name = "cmbSearchColumn"
        Me.cmbSearchColumn.Size = New System.Drawing.Size(229, 24)
        Me.cmbSearchColumn.TabIndex = 9
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(345, 164)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(234, 22)
        Me.txtSearch.TabIndex = 10
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(345, 234)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(117, 34)
        Me.btnSearch.TabIndex = 11
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnShowAll
        '
        Me.btnShowAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowAll.Location = New System.Drawing.Point(494, 234)
        Me.btnShowAll.Name = "btnShowAll"
        Me.btnShowAll.Size = New System.Drawing.Size(96, 32)
        Me.btnShowAll.TabIndex = 12
        Me.btnShowAll.Text = "End Search"
        Me.btnShowAll.UseVisualStyleBackColor = True
        '
        'btnViewAttendance
        '
        Me.btnViewAttendance.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnViewAttendance.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewAttendance.Location = New System.Drawing.Point(-1, 405)
        Me.btnViewAttendance.Name = "btnViewAttendance"
        Me.btnViewAttendance.Size = New System.Drawing.Size(233, 55)
        Me.btnViewAttendance.TabIndex = 13
        Me.btnViewAttendance.Text = "View Attendance"
        Me.btnViewAttendance.UseVisualStyleBackColor = False
        '
        'txtManageTeachers
        '
        Me.txtManageTeachers.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtManageTeachers.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtManageTeachers.Location = New System.Drawing.Point(358, 326)
        Me.txtManageTeachers.Name = "txtManageTeachers"
        Me.txtManageTeachers.Size = New System.Drawing.Size(232, 60)
        Me.txtManageTeachers.TabIndex = 14
        Me.txtManageTeachers.Text = "Manage Teachers"
        Me.txtManageTeachers.UseVisualStyleBackColor = False
        '
        'txtManageCourses
        '
        Me.txtManageCourses.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtManageCourses.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtManageCourses.Location = New System.Drawing.Point(358, 395)
        Me.txtManageCourses.Name = "txtManageCourses"
        Me.txtManageCourses.Size = New System.Drawing.Size(232, 65)
        Me.txtManageCourses.TabIndex = 15
        Me.txtManageCourses.Text = "Manage Courses"
        Me.txtManageCourses.UseVisualStyleBackColor = False
        '
        'btnAssignCourses
        '
        Me.btnAssignCourses.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnAssignCourses.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAssignCourses.Location = New System.Drawing.Point(358, 476)
        Me.btnAssignCourses.Name = "btnAssignCourses"
        Me.btnAssignCourses.Size = New System.Drawing.Size(232, 59)
        Me.btnAssignCourses.TabIndex = 16
        Me.btnAssignCourses.Text = "Assign Courses"
        Me.btnAssignCourses.UseVisualStyleBackColor = False
        '
        'FormAdminDashboard2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1589, 694)
        Me.Controls.Add(Me.btnAssignCourses)
        Me.Controls.Add(Me.txtManageCourses)
        Me.Controls.Add(Me.txtManageTeachers)
        Me.Controls.Add(Me.btnViewAttendance)
        Me.Controls.Add(Me.btnShowAll)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.cmbSearchColumn)
        Me.Controls.Add(Me.btnDeleteStudent)
        Me.Controls.Add(Me.btnShowStudents)
        Me.Controls.Add(Me.btnAddAdmin)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.dgvStudents)
        Me.Controls.Add(Me.btnAttendanceHistory)
        Me.Controls.Add(Me.btnAddStudent)
        Me.DoubleBuffered = True
        Me.Name = "FormAdminDashboard2"
        Me.Text = "FormAdminDashboard2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAddStudent As Button
    Friend WithEvents btnAttendanceHistory As Button
    Friend WithEvents dgvStudents As DataGridView
    Friend WithEvents btnHome As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnAddAdmin As Button
    Friend WithEvents btnShowStudents As Button
    Friend WithEvents btnDeleteStudent As Button
    Friend WithEvents cmbSearchColumn As ComboBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnShowAll As Button
    Friend WithEvents btnViewAttendance As Button
    Friend WithEvents txtManageTeachers As Button
    Friend WithEvents txtManageCourses As Button
    Friend WithEvents btnAssignCourses As Button
End Class
