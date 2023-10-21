<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addclassesform
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
        closeaddstaffdetail = New Button()
        deletestaffdet = New Button()
        editstaffdet = New Button()
        courselistlable = New Label()
        courselistbox = New ListBox()
        staffcodetext = New TextBox()
        ccode = New Label()
        addcoursebtn = New Button()
        cname = New Label()
        staffnametext = New TextBox()
        coursetypelable = New Label()
        hcsubject = New RadioButton()
        scsubject = New RadioButton()
        labcourse = New RadioButton()
        sksubject = New RadioButton()
        SuspendLayout()
        ' 
        ' closeaddstaffdetail
        ' 
        closeaddstaffdetail.Location = New Point(547, 578)
        closeaddstaffdetail.Name = "closeaddstaffdetail"
        closeaddstaffdetail.Size = New Size(94, 29)
        closeaddstaffdetail.TabIndex = 30
        closeaddstaffdetail.Text = "Close"
        closeaddstaffdetail.UseVisualStyleBackColor = True
        ' 
        ' deletestaffdet
        ' 
        deletestaffdet.Location = New Point(501, 443)
        deletestaffdet.Name = "deletestaffdet"
        deletestaffdet.Size = New Size(94, 29)
        deletestaffdet.TabIndex = 29
        deletestaffdet.Text = "Delete "
        deletestaffdet.UseVisualStyleBackColor = True
        ' 
        ' editstaffdet
        ' 
        editstaffdet.Location = New Point(501, 378)
        editstaffdet.Name = "editstaffdet"
        editstaffdet.Size = New Size(94, 29)
        editstaffdet.TabIndex = 28
        editstaffdet.Text = "Edit"
        editstaffdet.UseVisualStyleBackColor = True
        ' 
        ' courselistlable
        ' 
        courselistlable.AutoSize = True
        courselistlable.Location = New Point(45, 293)
        courselistlable.Name = "courselistlable"
        courselistlable.Size = New Size(80, 20)
        courselistlable.TabIndex = 27
        courselistlable.Text = "Course List"
        ' 
        ' courselistbox
        ' 
        courselistbox.FormattingEnabled = True
        courselistbox.ItemHeight = 20
        courselistbox.Location = New Point(45, 325)
        courselistbox.Name = "courselistbox"
        courselistbox.Size = New Size(427, 224)
        courselistbox.TabIndex = 26
        ' 
        ' staffcodetext
        ' 
        staffcodetext.Location = New Point(148, 31)
        staffcodetext.Name = "staffcodetext"
        staffcodetext.Size = New Size(273, 27)
        staffcodetext.TabIndex = 25
        ' 
        ' ccode
        ' 
        ccode.AutoSize = True
        ccode.Location = New Point(45, 34)
        ccode.Name = "ccode"
        ccode.Size = New Size(93, 20)
        ccode.TabIndex = 24
        ccode.Text = "Course Code"
        ' 
        ' addcoursebtn
        ' 
        addcoursebtn.Location = New Point(148, 212)
        addcoursebtn.Name = "addcoursebtn"
        addcoursebtn.Size = New Size(196, 35)
        addcoursebtn.TabIndex = 23
        addcoursebtn.Text = "Add Course"
        addcoursebtn.UseVisualStyleBackColor = True
        ' 
        ' cname
        ' 
        cname.AutoSize = True
        cname.Location = New Point(45, 75)
        cname.Name = "cname"
        cname.Size = New Size(98, 20)
        cname.TabIndex = 22
        cname.Text = "Course Name"
        ' 
        ' staffnametext
        ' 
        staffnametext.Location = New Point(148, 70)
        staffnametext.Name = "staffnametext"
        staffnametext.Size = New Size(273, 27)
        staffnametext.TabIndex = 21
        ' 
        ' coursetypelable
        ' 
        coursetypelable.AutoSize = True
        coursetypelable.Location = New Point(45, 122)
        coursetypelable.Name = "coursetypelable"
        coursetypelable.Size = New Size(89, 20)
        coursetypelable.TabIndex = 31
        coursetypelable.Text = "Course Type"
        ' 
        ' hcsubject
        ' 
        hcsubject.AutoSize = True
        hcsubject.Location = New Point(153, 125)
        hcsubject.Name = "hcsubject"
        hcsubject.Size = New Size(98, 24)
        hcsubject.TabIndex = 32
        hcsubject.TabStop = True
        hcsubject.Text = "Hard Core"
        hcsubject.UseVisualStyleBackColor = True
        ' 
        ' scsubject
        ' 
        scsubject.AutoSize = True
        scsubject.Location = New Point(293, 125)
        scsubject.Name = "scsubject"
        scsubject.Size = New Size(92, 24)
        scsubject.TabIndex = 33
        scsubject.TabStop = True
        scsubject.Text = "Soft Core"
        scsubject.UseVisualStyleBackColor = True
        ' 
        ' labcourse
        ' 
        labcourse.AutoSize = True
        labcourse.Location = New Point(153, 168)
        labcourse.Name = "labcourse"
        labcourse.Size = New Size(54, 24)
        labcourse.TabIndex = 34
        labcourse.TabStop = True
        labcourse.Text = "Lab"
        labcourse.UseVisualStyleBackColor = True
        ' 
        ' sksubject
        ' 
        sksubject.AutoSize = True
        sksubject.Location = New Point(293, 168)
        sksubject.Name = "sksubject"
        sksubject.Size = New Size(150, 24)
        sksubject.TabIndex = 35
        sksubject.TabStop = True
        sksubject.Text = "Skill Enhancement"
        sksubject.UseVisualStyleBackColor = True
        ' 
        ' addclassesform
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(666, 635)
        Controls.Add(sksubject)
        Controls.Add(labcourse)
        Controls.Add(scsubject)
        Controls.Add(hcsubject)
        Controls.Add(coursetypelable)
        Controls.Add(closeaddstaffdetail)
        Controls.Add(deletestaffdet)
        Controls.Add(editstaffdet)
        Controls.Add(courselistlable)
        Controls.Add(courselistbox)
        Controls.Add(staffcodetext)
        Controls.Add(ccode)
        Controls.Add(addcoursebtn)
        Controls.Add(cname)
        Controls.Add(staffnametext)
        Name = "addclassesform"
        Text = "addclassesform"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents closeaddstaffdetail As Button
    Friend WithEvents deletestaffdet As Button
    Friend WithEvents editstaffdet As Button
    Friend WithEvents courselistlable As Label
    Friend WithEvents courselistbox As ListBox
    Friend WithEvents staffcodetext As TextBox
    Friend WithEvents ccode As Label
    Friend WithEvents addcoursebtn As Button
    Friend WithEvents cname As Label
    Friend WithEvents staffnametext As TextBox
    Friend WithEvents coursetypelable As Label
    Friend WithEvents hcsubject As RadioButton
    Friend WithEvents scsubject As RadioButton
    Friend WithEvents labcourse As RadioButton
    Friend WithEvents sksubject As RadioButton
End Class
