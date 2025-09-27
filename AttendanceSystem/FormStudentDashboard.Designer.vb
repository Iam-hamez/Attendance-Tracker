<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStudentDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormStudentDashboard))
        Me.btnMarkAttendance = New System.Windows.Forms.Button()
        Me.btnLoadHistory = New System.Windows.Forms.Button()
        Me.picWebcam = New System.Windows.Forms.PictureBox()
        Me.btnCapture = New System.Windows.Forms.Button()
        Me.dgvMyHistory = New System.Windows.Forms.DataGridView()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.cmbCourses = New System.Windows.Forms.ComboBox()
        CType(Me.picWebcam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMyHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMarkAttendance
        '
        Me.btnMarkAttendance.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnMarkAttendance.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMarkAttendance.Location = New System.Drawing.Point(6, 415)
        Me.btnMarkAttendance.Name = "btnMarkAttendance"
        Me.btnMarkAttendance.Size = New System.Drawing.Size(296, 67)
        Me.btnMarkAttendance.TabIndex = 0
        Me.btnMarkAttendance.Text = "Mark Attendance"
        Me.btnMarkAttendance.UseVisualStyleBackColor = False
        '
        'btnLoadHistory
        '
        Me.btnLoadHistory.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnLoadHistory.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadHistory.Location = New System.Drawing.Point(6, 488)
        Me.btnLoadHistory.Name = "btnLoadHistory"
        Me.btnLoadHistory.Size = New System.Drawing.Size(296, 72)
        Me.btnLoadHistory.TabIndex = 1
        Me.btnLoadHistory.Text = "My Attendance History"
        Me.btnLoadHistory.UseVisualStyleBackColor = False
        '
        'picWebcam
        '
        Me.picWebcam.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picWebcam.Location = New System.Drawing.Point(457, 12)
        Me.picWebcam.Name = "picWebcam"
        Me.picWebcam.Size = New System.Drawing.Size(779, 370)
        Me.picWebcam.TabIndex = 2
        Me.picWebcam.TabStop = False
        '
        'btnCapture
        '
        Me.btnCapture.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnCapture.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCapture.Location = New System.Drawing.Point(6, 566)
        Me.btnCapture.Name = "btnCapture"
        Me.btnCapture.Size = New System.Drawing.Size(296, 70)
        Me.btnCapture.TabIndex = 3
        Me.btnCapture.Text = "Capture Photo"
        Me.btnCapture.UseVisualStyleBackColor = False
        '
        'dgvMyHistory
        '
        Me.dgvMyHistory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMyHistory.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.dgvMyHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMyHistory.Location = New System.Drawing.Point(570, 388)
        Me.dgvMyHistory.Name = "dgvMyHistory"
        Me.dgvMyHistory.RowHeadersWidth = 51
        Me.dgvMyHistory.RowTemplate.Height = 24
        Me.dgvMyHistory.Size = New System.Drawing.Size(480, 335)
        Me.dgvMyHistory.TabIndex = 4
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnBack.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(6, 642)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(296, 81)
        Me.btnBack.TabIndex = 5
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'cmbCourses
        '
        Me.cmbCourses.FormattingEnabled = True
        Me.cmbCourses.Location = New System.Drawing.Point(362, 488)
        Me.cmbCourses.Name = "cmbCourses"
        Me.cmbCourses.Size = New System.Drawing.Size(159, 24)
        Me.cmbCourses.TabIndex = 6
        '
        'FormStudentDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1266, 724)
        Me.Controls.Add(Me.cmbCourses)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dgvMyHistory)
        Me.Controls.Add(Me.btnCapture)
        Me.Controls.Add(Me.picWebcam)
        Me.Controls.Add(Me.btnLoadHistory)
        Me.Controls.Add(Me.btnMarkAttendance)
        Me.DoubleBuffered = True
        Me.Name = "FormStudentDashboard"
        Me.Text = "FormStudentDashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picWebcam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMyHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnMarkAttendance As Button
    Friend WithEvents btnLoadHistory As Button
    Friend WithEvents picWebcam As PictureBox
    Friend WithEvents btnCapture As Button
    Friend WithEvents dgvMyHistory As DataGridView
    Friend WithEvents btnBack As Button
    Friend WithEvents cmbCourses As ComboBox
End Class
