Imports MySql.Data.MySqlClient

Public Class addclassesform
    Private connectionString As String = "server=localhost;user=root;password=2503;database=timetableall"

    Public Sub New()
        InitializeComponent()
        InitializeDatabase()
    End Sub

    Private Sub InitializeDatabase()
        ' Create the coursestable if it doesn't exist
        Using connection As New MySqlConnection(connectionString),
              command As New MySqlCommand("CREATE TABLE IF NOT EXISTS coursestable (CourseCode VARCHAR(255), CourseName VARCHAR(255), CourseType VARCHAR(255))", connection)
            connection.Open()
            command.ExecuteNonQuery()
        End Using

        ' Load data from the database into the list box
        LoadData()
    End Sub

    Private Sub LoadData()
        courselistbox.Items.Clear()

        Using connection As New MySqlConnection(connectionString),
              command As New MySqlCommand("SELECT * FROM coursestable", connection)
            connection.Open()

            Using reader As MySqlDataReader = command.ExecuteReader()
                While reader.Read()
                    Dim courseCode As String = reader("CourseCode").ToString()
                    Dim courseName As String = reader("CourseName").ToString()
                    Dim courseType As String = reader("CourseType").ToString()
                    courselistbox.Items.Add($"{courseCode} - {courseName} ({courseType})")
                End While
            End Using
        End Using
    End Sub

    Private Sub addcoursebtn_Click(sender As Object, e As EventArgs) Handles addcoursebtn.Click
        ' Get values from text boxes and radio buttons
        Dim courseCode As String = staffcodetext.Text
        Dim courseName As String = staffnametext.Text
        Dim courseType As String = GetSelectedCourseType()

        Using connection As New MySqlConnection(connectionString),
              command As New MySqlCommand("INSERT INTO coursestable (CourseCode, CourseName, CourseType) VALUES (@courseCode, @courseName, @courseType)", connection)
            command.Parameters.AddWithValue("@courseCode", courseCode)
            command.Parameters.AddWithValue("@courseName", courseName)
            command.Parameters.AddWithValue("@courseType", courseType)

            Try
                connection.Open()
                command.ExecuteNonQuery()

                ' Clear and reload the list box
                staffcodetext.Clear()
                staffnametext.Clear()
                ClearCourseTypeSelection()
                LoadData()
            Catch ex As Exception
                MessageBox.Show("Error adding data to the database: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Function GetSelectedCourseType() As String
        If hcsubject.Checked Then
            Return "Hard Core"
        ElseIf scsubject.Checked Then
            Return "Soft Core"
        ElseIf labcourse.Checked Then
            Return "Lab"
        ElseIf sksubject.Checked Then
            Return "Skill Enhancement"
        Else
            Return String.Empty
        End If
    End Function

    Private Sub ClearCourseTypeSelection()
        hcsubject.Checked = False
        scsubject.Checked = False
        labcourse.Checked = False
        sksubject.Checked = False
    End Sub

    Private Sub editstaffdet_Click(sender As Object, e As EventArgs) Handles editstaffdet.Click
        ' Check if an item is selected in the list box
        If courselistbox.SelectedIndex >= 0 Then
            ' Get the selected item
            Dim selectedItem As String = courselistbox.SelectedItem.ToString()
            Dim parts() As String = selectedItem.Split("-")
            Dim courseCode As String = parts(0).Trim()

            ' Open a message box to edit the selected record
            Dim newCourseCode As String = InputBox("Enter new Course Code:", "Edit Course Code", courseCode)
            If String.IsNullOrEmpty(newCourseCode) Then
                Return ' User canceled editing
            End If

            Dim newCourseName As String = InputBox("Enter new Course Name:", "Edit Course Name")
            If String.IsNullOrEmpty(newCourseName) Then
                Return ' User canceled editing
            End If

            Dim newCourseType As String = GetSelectedCourseType()
            If String.IsNullOrEmpty(newCourseType) Then
                MessageBox.Show("Please select a course type.", "Edit Course")
                Return ' Don't proceed with the update
            End If

            ' Pre-select the radio button for the current course type
            If newCourseType = "Hard Core" Then
                hcsubject.Checked = True
            ElseIf newCourseType = "Soft Core" Then
                scsubject.Checked = True
            ElseIf newCourseType = "Lab" Then
                labcourse.Checked = True
            ElseIf newCourseType = "Skill Enhancement" Then
                sksubject.Checked = True
            End If

            Using connection As New MySqlConnection(connectionString),
              command As New MySqlCommand("UPDATE coursestable SET CourseCode = @newCourseCode, CourseName = @newCourseName, CourseType = @newCourseType WHERE CourseCode = @courseCode", connection)
                command.Parameters.AddWithValue("@newCourseCode", newCourseCode)
                command.Parameters.AddWithValue("@newCourseName", newCourseName)
                command.Parameters.AddWithValue("@newCourseType", newCourseType)
                command.Parameters.AddWithValue("@courseCode", courseCode)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show("Error updating data in the database: " & ex.Message)
                End Try
            End Using

            ' Reload the list box after the update
            LoadData()
        End If
    End Sub

    Private Sub deletestaffdet_Click(sender As Object, e As EventArgs) Handles deletestaffdet.Click
        ' Check if an item is selected in the list box
        If courselistbox.SelectedIndex >= 0 Then
            ' Get the selected item
            Dim selectedItem As String = courselistbox.SelectedItem.ToString()
            Dim parts() As String = selectedItem.Split("-")
            Dim courseCode As String = parts(0).Trim()

            ' Confirm with the user before deleting
            Dim confirmation As DialogResult = MessageBox.Show("Are you sure you want to delete this course record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If confirmation = DialogResult.Yes Then
                Using connection As New MySqlConnection(connectionString),
                      command As New MySqlCommand("DELETE FROM coursestable WHERE CourseCode = @courseCode", connection)
                    command.Parameters.AddWithValue("@courseCode", courseCode)

                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                    Catch ex As Exception
                        MessageBox.Show("Error deleting data from the database: " & ex.Message)
                    End Try
                End Using

                ' Clear and reload the list box
                LoadData()
            End If
        End If
    End Sub

    Private Sub closeaddstaffdetail_Click(sender As Object, e As EventArgs) Handles closeaddstaffdetail.Click
        Me.Close()
    End Sub
End Class
