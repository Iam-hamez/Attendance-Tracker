<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormManageCourses
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormManageCourses))
        Me.txtCourseName = New System.Windows.Forms.TextBox()
        Me.txtCourseCode = New System.Windows.Forms.TextBox()
        Me.btnAddCourse = New System.Windows.Forms.Button()
        Me.btnRefreshCourses = New System.Windows.Forms.Button()
        Me.dgvCourses = New System.Windows.Forms.DataGridView()
        Me.lblCourseName = New System.Windows.Forms.Label()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.btnReturn = New System.Windows.Forms.Button()
        CType(Me.dgvCourses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCourseName
        '
        Me.txtCourseName.Location = New System.Drawing.Point(195, 150)
        Me.txtCourseName.Name = "txtCourseName"
        Me.txtCourseName.Size = New System.Drawing.Size(187, 22)
        Me.txtCourseName.TabIndex = 0
        '
        'txtCourseCode
        '
        Me.txtCourseCode.Location = New System.Drawing.Point(195, 235)
        Me.txtCourseCode.Name = "txtCourseCode"
        Me.txtCourseCode.Size = New System.Drawing.Size(187, 22)
        Me.txtCourseCode.TabIndex = 1
        '
        'btnAddCourse
        '
        Me.btnAddCourse.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnAddCourse.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCourse.Location = New System.Drawing.Point(18, 358)
        Me.btnAddCourse.Name = "btnAddCourse"
        Me.btnAddCourse.Size = New System.Drawing.Size(178, 44)
        Me.btnAddCourse.TabIndex = 2
        Me.btnAddCourse.Text = "AddCourse"
        Me.btnAddCourse.UseVisualStyleBackColor = False
        '
        'btnRefreshCourses
        '
        Me.btnRefreshCourses.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnRefreshCourses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRefreshCourses.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefreshCourses.Location = New System.Drawing.Point(18, 449)
        Me.btnRefreshCourses.Name = "btnRefreshCourses"
        Me.btnRefreshCourses.Size = New System.Drawing.Size(178, 45)
        Me.btnRefreshCourses.TabIndex = 3
        Me.btnRefreshCourses.Text = "RefreshCourses"
        Me.btnRefreshCourses.UseVisualStyleBackColor = False
        '
        'dgvCourses
        '
        Me.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCourses.Location = New System.Drawing.Point(479, 119)
        Me.dgvCourses.Name = "dgvCourses"
        Me.dgvCourses.RowHeadersWidth = 51
        Me.dgvCourses.RowTemplate.Height = 24
        Me.dgvCourses.Size = New System.Drawing.Size(727, 401)
        Me.dgvCourses.TabIndex = 4
        '
        'lblCourseName
        '
        Me.lblCourseName.AutoSize = True
        Me.lblCourseName.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourseName.Location = New System.Drawing.Point(13, 145)
        Me.lblCourseName.Name = "lblCourseName"
        Me.lblCourseName.Size = New System.Drawing.Size(136, 27)
        Me.lblCourseName.TabIndex = 5
        Me.lblCourseName.Text = "CourseName:"
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.BackColor = System.Drawing.SystemColors.Control
        Me.lblCode.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(21, 230)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(128, 27)
        Me.lblCode.TabIndex = 6
        Me.lblCode.Text = "CourseCode:"
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnReturn.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(18, 549)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(178, 45)
        Me.btnReturn.TabIndex = 7
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'FormManageCourses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1247, 660)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.lblCode)
        Me.Controls.Add(Me.lblCourseName)
        Me.Controls.Add(Me.dgvCourses)
        Me.Controls.Add(Me.btnRefreshCourses)
        Me.Controls.Add(Me.btnAddCourse)
        Me.Controls.Add(Me.txtCourseCode)
        Me.Controls.Add(Me.txtCourseName)
        Me.DoubleBuffered = True
        Me.Name = "FormManageCourses"
        Me.Text = "FormManageCourses"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvCourses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCourseName As TextBox
    Friend WithEvents txtCourseCode As TextBox
    Friend WithEvents btnAddCourse As Button
    Friend WithEvents btnRefreshCourses As Button
    Friend WithEvents dgvCourses As DataGridView
    Friend WithEvents lblCourseName As Label
    Friend WithEvents lblCode As Label
    Friend WithEvents btnReturn As Button
End Class
