<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateRepresentative
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
        Me.tbMail = New System.Windows.Forms.TextBox()
        Me.lbMail = New System.Windows.Forms.Label()
        Me.cboxGender = New System.Windows.Forms.ComboBox()
        Me.lbGender = New System.Windows.Forms.Label()
        Me.tbWorkPlace = New System.Windows.Forms.TextBox()
        Me.lbWorkPlace = New System.Windows.Forms.Label()
        Me.tbResidency = New System.Windows.Forms.TextBox()
        Me.lbResidency = New System.Windows.Forms.Label()
        Me.tbOccupation = New System.Windows.Forms.TextBox()
        Me.lbOccupation = New System.Windows.Forms.Label()
        Me.cboxMaritalStatus = New System.Windows.Forms.ComboBox()
        Me.lbMaritalStatus = New System.Windows.Forms.Label()
        Me.tbPhone = New System.Windows.Forms.TextBox()
        Me.lbPhone = New System.Windows.Forms.Label()
        Me.lbIDCard = New System.Windows.Forms.Label()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.lbName = New System.Windows.Forms.Label()
        Me.lbIndications = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbIDCard = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'tbMail
        '
        Me.tbMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMail.Location = New System.Drawing.Point(249, 223)
        Me.tbMail.Name = "tbMail"
        Me.tbMail.Size = New System.Drawing.Size(551, 28)
        Me.tbMail.TabIndex = 40
        '
        'lbMail
        '
        Me.lbMail.AutoSize = True
        Me.lbMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMail.Location = New System.Drawing.Point(55, 223)
        Me.lbMail.Name = "lbMail"
        Me.lbMail.Size = New System.Drawing.Size(177, 25)
        Me.lbMail.TabIndex = 39
        Me.lbMail.Text = "Correo electrónico:"
        '
        'cboxGender
        '
        Me.cboxGender.FormattingEnabled = True
        Me.cboxGender.Location = New System.Drawing.Point(249, 546)
        Me.cboxGender.Name = "cboxGender"
        Me.cboxGender.Size = New System.Drawing.Size(551, 24)
        Me.cboxGender.TabIndex = 38
        '
        'lbGender
        '
        Me.lbGender.AutoSize = True
        Me.lbGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbGender.Location = New System.Drawing.Point(55, 542)
        Me.lbGender.Name = "lbGender"
        Me.lbGender.Size = New System.Drawing.Size(83, 25)
        Me.lbGender.TabIndex = 37
        Me.lbGender.Text = "Género:"
        '
        'tbWorkPlace
        '
        Me.tbWorkPlace.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbWorkPlace.Location = New System.Drawing.Point(249, 443)
        Me.tbWorkPlace.Multiline = True
        Me.tbWorkPlace.Name = "tbWorkPlace"
        Me.tbWorkPlace.Size = New System.Drawing.Size(551, 82)
        Me.tbWorkPlace.TabIndex = 36
        '
        'lbWorkPlace
        '
        Me.lbWorkPlace.AutoSize = True
        Me.lbWorkPlace.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbWorkPlace.Location = New System.Drawing.Point(55, 443)
        Me.lbWorkPlace.Name = "lbWorkPlace"
        Me.lbWorkPlace.Size = New System.Drawing.Size(159, 25)
        Me.lbWorkPlace.TabIndex = 35
        Me.lbWorkPlace.Text = "Lugar de trabajo:"
        '
        'tbResidency
        '
        Me.tbResidency.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbResidency.Location = New System.Drawing.Point(249, 346)
        Me.tbResidency.Multiline = True
        Me.tbResidency.Name = "tbResidency"
        Me.tbResidency.Size = New System.Drawing.Size(551, 82)
        Me.tbResidency.TabIndex = 34
        '
        'lbResidency
        '
        Me.lbResidency.AutoSize = True
        Me.lbResidency.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbResidency.Location = New System.Drawing.Point(55, 346)
        Me.lbResidency.Name = "lbResidency"
        Me.lbResidency.Size = New System.Drawing.Size(114, 25)
        Me.lbResidency.TabIndex = 33
        Me.lbResidency.Text = "Residencia:"
        '
        'tbOccupation
        '
        Me.tbOccupation.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbOccupation.Location = New System.Drawing.Point(249, 299)
        Me.tbOccupation.Name = "tbOccupation"
        Me.tbOccupation.Size = New System.Drawing.Size(551, 28)
        Me.tbOccupation.TabIndex = 32
        '
        'lbOccupation
        '
        Me.lbOccupation.AutoSize = True
        Me.lbOccupation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbOccupation.Location = New System.Drawing.Point(55, 299)
        Me.lbOccupation.Name = "lbOccupation"
        Me.lbOccupation.Size = New System.Drawing.Size(113, 25)
        Me.lbOccupation.TabIndex = 31
        Me.lbOccupation.Text = "Ocupación:"
        '
        'cboxMaritalStatus
        '
        Me.cboxMaritalStatus.FormattingEnabled = True
        Me.cboxMaritalStatus.Location = New System.Drawing.Point(249, 264)
        Me.cboxMaritalStatus.Name = "cboxMaritalStatus"
        Me.cboxMaritalStatus.Size = New System.Drawing.Size(551, 24)
        Me.cboxMaritalStatus.TabIndex = 30
        '
        'lbMaritalStatus
        '
        Me.lbMaritalStatus.AutoSize = True
        Me.lbMaritalStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMaritalStatus.Location = New System.Drawing.Point(55, 261)
        Me.lbMaritalStatus.Name = "lbMaritalStatus"
        Me.lbMaritalStatus.Size = New System.Drawing.Size(116, 25)
        Me.lbMaritalStatus.TabIndex = 29
        Me.lbMaritalStatus.Text = "Estado civil:"
        '
        'tbPhone
        '
        Me.tbPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPhone.Location = New System.Drawing.Point(249, 184)
        Me.tbPhone.Name = "tbPhone"
        Me.tbPhone.Size = New System.Drawing.Size(551, 28)
        Me.tbPhone.TabIndex = 28
        '
        'lbPhone
        '
        Me.lbPhone.AutoSize = True
        Me.lbPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPhone.Location = New System.Drawing.Point(55, 186)
        Me.lbPhone.Name = "lbPhone"
        Me.lbPhone.Size = New System.Drawing.Size(175, 25)
        Me.lbPhone.TabIndex = 27
        Me.lbPhone.Text = "Número telefónico:"
        '
        'lbIDCard
        '
        Me.lbIDCard.AutoSize = True
        Me.lbIDCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIDCard.Location = New System.Drawing.Point(55, 67)
        Me.lbIDCard.Name = "lbIDCard"
        Me.lbIDCard.Size = New System.Drawing.Size(81, 25)
        Me.lbIDCard.TabIndex = 25
        Me.lbIDCard.Text = "Cédula:"
        '
        'tbName
        '
        Me.tbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbName.Location = New System.Drawing.Point(249, 145)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(551, 28)
        Me.tbName.TabIndex = 24
        '
        'lbName
        '
        Me.lbName.AutoSize = True
        Me.lbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbName.Location = New System.Drawing.Point(55, 147)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(171, 25)
        Me.lbName.TabIndex = 23
        Me.lbName.Text = "Nombre completo:"
        '
        'lbIndications
        '
        Me.lbIndications.AutoSize = True
        Me.lbIndications.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIndications.Location = New System.Drawing.Point(54, 106)
        Me.lbIndications.Name = "lbIndications"
        Me.lbIndications.Size = New System.Drawing.Size(384, 29)
        Me.lbIndications.TabIndex = 22
        Me.lbIndications.Text = "Digite los datos que se le solicitan:"
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(357, 607)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(136, 40)
        Me.btnUpdate.TabIndex = 21
        Me.btnUpdate.Text = "Actualizar"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(644, 29)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Seleccione o digite la cédula del representante a actualizar"
        '
        'tbIDCard
        '
        Me.tbIDCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.tbIDCard.Location = New System.Drawing.Point(249, 66)
        Me.tbIDCard.Name = "tbIDCard"
        Me.tbIDCard.Size = New System.Drawing.Size(551, 28)
        Me.tbIDCard.TabIndex = 42
        '
        'frmUpdateRepresentative
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 658)
        Me.Controls.Add(Me.tbIDCard)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbMail)
        Me.Controls.Add(Me.lbMail)
        Me.Controls.Add(Me.cboxGender)
        Me.Controls.Add(Me.lbGender)
        Me.Controls.Add(Me.tbWorkPlace)
        Me.Controls.Add(Me.lbWorkPlace)
        Me.Controls.Add(Me.tbResidency)
        Me.Controls.Add(Me.lbResidency)
        Me.Controls.Add(Me.tbOccupation)
        Me.Controls.Add(Me.lbOccupation)
        Me.Controls.Add(Me.cboxMaritalStatus)
        Me.Controls.Add(Me.lbMaritalStatus)
        Me.Controls.Add(Me.tbPhone)
        Me.Controls.Add(Me.lbPhone)
        Me.Controls.Add(Me.lbIDCard)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.lbName)
        Me.Controls.Add(Me.lbIndications)
        Me.Controls.Add(Me.btnUpdate)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmUpdateRepresentative"
        Me.Text = "frmUpdateRepresentative"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbMail As TextBox
    Friend WithEvents lbMail As Label
    Friend WithEvents cboxGender As ComboBox
    Friend WithEvents lbGender As Label
    Friend WithEvents tbWorkPlace As TextBox
    Friend WithEvents lbWorkPlace As Label
    Friend WithEvents tbResidency As TextBox
    Friend WithEvents lbResidency As Label
    Friend WithEvents tbOccupation As TextBox
    Friend WithEvents lbOccupation As Label
    Friend WithEvents cboxMaritalStatus As ComboBox
    Friend WithEvents lbMaritalStatus As Label
    Friend WithEvents tbPhone As TextBox
    Friend WithEvents lbPhone As Label
    Friend WithEvents lbIDCard As Label
    Friend WithEvents tbName As TextBox
    Friend WithEvents lbName As Label
    Friend WithEvents lbIndications As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tbIDCard As TextBox
End Class
