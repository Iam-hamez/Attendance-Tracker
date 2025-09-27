<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAssignCourses
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAssignCourses))
        Me.cmbTeachers = New System.Windows.Forms.ComboBox()
        Me.cmbCourses = New System.Windows.Forms.ComboBox()
        Me.btnAssign = New System.Windows.Forms.Button()
        Me.dgvAssignments = New System.Windows.Forms.DataGridView()
        Me.btnRefreshAssign = New System.Windows.Forms.Button()
        CType(Me.dgvAssignments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbTeachers
        '
        Me.cmbTeachers.FormattingEnabled = True
        Me.cmbTeachers.Location = New System.Drawing.Point(113, 125)
        Me.cmbTeachers.Name = "cmbTeachers"
        Me.cmbTeachers.Size = New System.Drawing.Size(121, 24)
        Me.cmbTeachers.TabIndex = 0
        '
        'cmbCourses
        '
        Me.cmbCourses.FormattingEnabled = True
        Me.cmbCourses.Location = New System.Drawing.Point(113, 195)
        Me.cmbCourses.Name = "cmbCourses"
        Me.cmbCourses.Size = New System.Drawing.Size(121, 24)
        Me.cmbCourses.TabIndex = 1
        '
        'btnAssign
        '
        Me.btnAssign.Location = New System.Drawing.Point(135, 374)
        Me.btnAssign.Name = "btnAssign"
        Me.btnAssign.Size = New System.Drawing.Size(117, 27)
        Me.btnAssign.TabIndex = 2
        Me.btnAssign.Text = "Assign"
        Me.btnAssign.UseVisualStyleBackColor = True
        '
        'dgvAssignments
        '
        Me.dgvAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAssignments.Location = New System.Drawing.Point(358, 64)
        Me.dgvAssignments.Name = "dgvAssignments"
        Me.dgvAssignments.RowHeadersWidth = 51
        Me.dgvAssignments.RowTemplate.Height = 24
        Me.dgvAssignments.Size = New System.Drawing.Size(727, 498)
        Me.dgvAssignments.TabIndex = 3
        '
        'btnRefreshAssign
        '
        Me.btnRefreshAssign.Location = New System.Drawing.Point(135, 437)
        Me.btnRefreshAssign.Name = "btnRefreshAssign"
        Me.btnRefreshAssign.Size = New System.Drawing.Size(117, 23)
        Me.btnRefreshAssign.TabIndex = 4
        Me.btnRefreshAssign.Text = "RefreshAssign"
        Me.btnRefreshAssign.UseVisualStyleBackColor = True
        '
        'FormAssignCourses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1145, 645)
        Me.Controls.Add(Me.btnRefreshAssign)
        Me.Controls.Add(Me.dgvAssignments)
        Me.Controls.Add(Me.btnAssign)
        Me.Controls.Add(Me.cmbCourses)
        Me.Controls.Add(Me.cmbTeachers)
        Me.Name = "FormAssignCourses"
        Me.Text = "FormAssignCourses"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvAssignments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmbTeachers As ComboBox
    Friend WithEvents cmbCourses As ComboBox
    Friend WithEvents btnAssign As Button
    Friend WithEvents dgvAssignments As DataGridView
    Friend WithEvents btnRefreshAssign As Button

    Private Sub FormAssighnCourses_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
