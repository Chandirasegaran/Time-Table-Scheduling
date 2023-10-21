Imports MySql.Data.MySqlClient

Public Class addstaffdetailsform
    Private connectionString As String = "server=localhost;user=root;password=2503;database=timetableall"
    Private connection As MySqlConnection

    Public Sub New()
        InitializeComponent()
        InitializeDatabase()
    End Sub

    Private Sub InitializeDatabase()
        connection = New MySqlConnection(connectionString)

        Try
            connection.Open()

            ' Create the staffdetailstable if it doesn't exist
            Using command As New MySqlCommand()
                command.Connection = connection
                command.CommandText = "CREATE TABLE IF NOT EXISTS staffdetailstable (StaffCode VARCHAR(255), StaffName VARCHAR(255))"
                command.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error connecting to the database: " & ex.Message)
        Finally
            connection.Close()
        End Try

        ' Load data from the database into the list box
        LoadData()
    End Sub

    Private Sub LoadData()
        stafflstbox.Items.Clear()

        Try
            ' Open the connection only once here
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Using command As New MySqlCommand()
                command.Connection = connection
                command.CommandText = "SELECT * FROM staffdetailstable"
                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim staffCode As String = reader("StaffCode").ToString()
                        Dim staffName As String = reader("StaffName").ToString()
                        stafflstbox.Items.Add($"{staffCode} - {staffName}")
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading data from the database: " & ex.Message)
        Finally
            ' Close the connection here after the data is loaded
            connection.Close()
        End Try
    End Sub

    Private Sub addstaffbtn_Click(sender As Object, e As EventArgs) Handles addstaffbtn.Click
        ' Get values from text boxes
        Dim staffCode As String = staffcodetext.Text
        Dim staffName As String = staffnametext.Text

        Try
            ' Open the connection only once here
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Using command As New MySqlCommand()
                command.Connection = connection
                ' Insert data into the database
                command.CommandText = "INSERT INTO staffdetailstable (StaffCode, StaffName) VALUES (@staffCode, @staffName)"
                command.Parameters.AddWithValue("@staffCode", staffCode)
                command.Parameters.AddWithValue("@staffName", staffName)
                command.ExecuteNonQuery()
            End Using

            ' Clear and reload the list box
            staffcodetext.Clear()
            staffnametext.Clear()
            LoadData()
        Catch ex As Exception
            MessageBox.Show("Error adding data to the database: " & ex.Message)
        Finally
            ' Close the connection here after the data is inserted
            connection.Close()
        End Try
    End Sub

    ' Edit and Delete methods can be implemented similarly to the above code.
    Private Sub editstaffdet_Click(sender As Object, e As EventArgs) Handles editstaffdet.Click
        ' Check if an item is selected in the list box
        If stafflstbox.SelectedIndex >= 0 Then
            ' Get the selected item
            Dim selectedItem As String = stafflstbox.SelectedItem.ToString()
            Dim parts() As String = selectedItem.Split("-")
            Dim staffCode As String = parts(0).Trim()

            ' Open a message box to edit the selected record
            Dim newStaffCode As String = InputBox("Enter new Staff Code:", "Edit Staff Code", staffCode)
            If String.IsNullOrEmpty(newStaffCode) Then
                Return ' User canceled editing
            End If

            Dim newStaffName As String = InputBox("Enter new Staff Name:", "Edit Staff Name")
            If String.IsNullOrEmpty(newStaffName) Then
                Return ' User canceled editing
            End If

            Try
                connection.Open()

                Using editCommand As New MySqlCommand()
                    editCommand.Connection = connection
                    ' Update the database with the new values
                    editCommand.CommandText = "UPDATE staffdetailstable SET StaffCode = @newStaffCode, StaffName = @newStaffName WHERE StaffCode = @staffCode"
                    editCommand.Parameters.AddWithValue("@newStaffCode", newStaffCode)
                    editCommand.Parameters.AddWithValue("@newStaffName", newStaffName)
                    editCommand.Parameters.AddWithValue("@staffCode", staffCode)
                    editCommand.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error updating data in the database: " & ex.Message)
            Finally
                connection.Close()
            End Try

            ' Reload the list box after the update
            LoadData()
        End If
    End Sub

    Private Sub deletestaffdet_Click(sender As Object, e As EventArgs) Handles deletestaffdet.Click
        ' Check if an item is selected in the list box
        If stafflstbox.SelectedIndex >= 0 Then
            ' Get the selected item
            Dim selectedItem As String = stafflstbox.SelectedItem.ToString()
            Dim parts() As String = selectedItem.Split("-")
            Dim staffCode As String = parts(0).Trim()

            ' Confirm with the user before deleting
            Dim confirmation As DialogResult = MessageBox.Show("Are you sure you want to delete this staff record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If confirmation = DialogResult.Yes Then
                Try
                    connection.Open()

                    Using deleteCommand As New MySqlCommand()
                        deleteCommand.Connection = connection
                        ' Delete the selected record from the database
                        deleteCommand.CommandText = "DELETE FROM staffdetailstable WHERE StaffCode = @staffCode"
                        deleteCommand.Parameters.AddWithValue("@staffCode", staffCode)
                        deleteCommand.ExecuteNonQuery()
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error deleting data from the database: " & ex.Message)
                Finally
                    connection.Close()
                End Try

                ' Clear and reload the list box
                LoadData()
            End If
        End If
    End Sub

    Private Sub closeaddstaffdetail_Click(sender As Object, e As EventArgs) Handles closeaddstaffdetail.Click
        Me.Close()
    End Sub

    Private Sub addstaffdetailsform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load data when the form loads
        LoadData()
    End Sub
End Class
