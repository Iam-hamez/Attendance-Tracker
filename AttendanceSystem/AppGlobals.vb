Module AppGlobals
    Public ConnString As String = "server=localhost;userid=root;password=;database=Maindb"

    ' --- Student session ---
    Public LoggedStudentDbId As Integer = -1          ' students.student_id (PK)
    Public LoggedStudentUsername As String = ""       ' students.username (login id)
    Public LoggedStudentName As String = ""           ' students.full_name
    Public LoggedStudentNumber As String = ""         ' students.username (login id)
    ' --- Teacher session ---
    Public LoggedTeacherDbId As Integer = -1          ' teachers.teacher_id (PK)
    Public LoggedTeacherUsername As String = ""       ' teachers.username
    Public LoggedTeacherName As String = ""           ' teachers.full_name

    ' --- Admin session ---
    Public LoggedAdminId As Integer = -1
    Public LoggedAdminUsername As String = ""         ' admin.username
    Public LoggedAdminName As String = ""             ' admin.full_name
End Module