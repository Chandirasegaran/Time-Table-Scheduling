Public Class homeform
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub addstaff_Click(sender As Object, e As EventArgs) Handles addstaff.Click
        Me.Hide()
        addstaffdetailsform.Show()
    End Sub

    Private Sub addclasses_Click(sender As Object, e As EventArgs) Handles addclasses.Click
        Me.Hide()
        addclassesform.Show()
    End Sub
End Class
