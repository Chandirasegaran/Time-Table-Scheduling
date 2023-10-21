<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class homeform
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
        addstaff = New Button()
        addclasses = New Button()
        SuspendLayout()
        ' 
        ' addstaff
        ' 
        addstaff.Location = New Point(133, 100)
        addstaff.Name = "addstaff"
        addstaff.Size = New Size(94, 29)
        addstaff.TabIndex = 0
        addstaff.Text = "Add Staff"
        addstaff.UseVisualStyleBackColor = True
        ' 
        ' addclasses
        ' 
        addclasses.Location = New Point(133, 232)
        addclasses.Name = "addclasses"
        addclasses.Size = New Size(94, 29)
        addclasses.TabIndex = 1
        addclasses.Text = "Add Class"
        addclasses.UseVisualStyleBackColor = True
        ' 
        ' homeform
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(364, 393)
        Controls.Add(addclasses)
        Controls.Add(addstaff)
        MaximizeBox = False
        Name = "homeform"
        Text = "homeForm"
        ResumeLayout(False)
    End Sub

    Friend WithEvents addstaff As Button
    Friend WithEvents addclasses As Button
End Class
