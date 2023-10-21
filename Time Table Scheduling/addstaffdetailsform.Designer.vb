<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addstaffdetailsform
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
        deletestaffdet = New Button()
        editstaffdet = New Button()
        slist = New Label()
        stafflstbox = New ListBox()
        staffcodetext = New TextBox()
        scode = New Label()
        addstaffbtn = New Button()
        sname = New Label()
        staffnametext = New TextBox()
        SuspendLayout()
        ' 
        ' deletestaffdet
        ' 
        deletestaffdet.Location = New Point(500, 280)
        deletestaffdet.Name = "deletestaffdet"
        deletestaffdet.Size = New Size(94, 29)
        deletestaffdet.TabIndex = 19
        deletestaffdet.Text = "Delete "
        deletestaffdet.UseVisualStyleBackColor = True
        ' 
        ' editstaffdet
        ' 
        editstaffdet.Location = New Point(500, 215)
        editstaffdet.Name = "editstaffdet"
        editstaffdet.Size = New Size(94, 29)
        editstaffdet.TabIndex = 17
        editstaffdet.Text = "Edit"
        editstaffdet.UseVisualStyleBackColor = True
        ' 
        ' slist
        ' 
        slist.AutoSize = True
        slist.Location = New Point(44, 139)
        slist.Name = "slist"
        slist.Size = New Size(69, 20)
        slist.TabIndex = 16
        slist.Text = "Staff List:"
        ' 
        ' stafflstbox
        ' 
        stafflstbox.FormattingEnabled = True
        stafflstbox.ItemHeight = 20
        stafflstbox.Location = New Point(44, 162)
        stafflstbox.Name = "stafflstbox"
        stafflstbox.Size = New Size(427, 224)
        stafflstbox.TabIndex = 15
        ' 
        ' staffcodetext
        ' 
        staffcodetext.Location = New Point(147, 36)
        staffcodetext.Name = "staffcodetext"
        staffcodetext.Size = New Size(273, 27)
        staffcodetext.TabIndex = 14
        ' 
        ' scode
        ' 
        scode.AutoSize = True
        scode.Location = New Point(44, 39)
        scode.Name = "scode"
        scode.Size = New Size(79, 20)
        scode.TabIndex = 13
        scode.Text = "Staff Code"
        ' 
        ' addstaffbtn
        ' 
        addstaffbtn.Location = New Point(457, 39)
        addstaffbtn.Name = "addstaffbtn"
        addstaffbtn.Size = New Size(94, 64)
        addstaffbtn.TabIndex = 12
        addstaffbtn.Text = "Add Staff"
        addstaffbtn.UseVisualStyleBackColor = True
        ' 
        ' sname
        ' 
        sname.AutoSize = True
        sname.Location = New Point(44, 80)
        sname.Name = "sname"
        sname.Size = New Size(84, 20)
        sname.TabIndex = 11
        sname.Text = "Staff Name"
        ' 
        ' staffnametext
        ' 
        staffnametext.Location = New Point(147, 75)
        staffnametext.Name = "staffnametext"
        staffnametext.Size = New Size(273, 27)
        staffnametext.TabIndex = 10
        ' 
        ' addstaffdetailsform
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(658, 450)
        Controls.Add(deletestaffdet)
        Controls.Add(editstaffdet)
        Controls.Add(slist)
        Controls.Add(stafflstbox)
        Controls.Add(staffcodetext)
        Controls.Add(scode)
        Controls.Add(addstaffbtn)
        Controls.Add(sname)
        Controls.Add(staffnametext)
        Name = "addstaffdetailsform"
        Text = "addstaffdetailsform"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents deletestaffdet As Button
    Friend WithEvents editstaffdet As Button
    Friend WithEvents slist As Label
    Friend WithEvents stafflstbox As ListBox
    Friend WithEvents staffcodetext As TextBox
    Friend WithEvents scode As Label
    Friend WithEvents addstaffbtn As Button
    Friend WithEvents sname As Label
    Friend WithEvents staffnametext As TextBox
End Class
