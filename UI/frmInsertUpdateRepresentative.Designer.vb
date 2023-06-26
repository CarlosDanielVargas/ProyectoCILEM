<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInsertUpdateRepresentative
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInsertUpdateRepresentative))
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lbIndications = New System.Windows.Forms.Label()
        Me.lbName = New System.Windows.Forms.Label()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.tbIDCard = New System.Windows.Forms.TextBox()
        Me.lbIDCard = New System.Windows.Forms.Label()
        Me.tbPhone = New System.Windows.Forms.TextBox()
        Me.lbPhone = New System.Windows.Forms.Label()
        Me.lbMaritalStatus = New System.Windows.Forms.Label()
        Me.cboxMaritalStatus = New System.Windows.Forms.ComboBox()
        Me.lbOccupation = New System.Windows.Forms.Label()
        Me.tbOccupation = New System.Windows.Forms.TextBox()
        Me.lbResidency = New System.Windows.Forms.Label()
        Me.tbResidency = New System.Windows.Forms.TextBox()
        Me.tbWorkPlace = New System.Windows.Forms.TextBox()
        Me.lbWorkPlace = New System.Windows.Forms.Label()
        Me.cboxGender = New System.Windows.Forms.ComboBox()
        Me.lbGender = New System.Windows.Forms.Label()
        Me.tbMail = New System.Windows.Forms.TextBox()
        Me.lbMail = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(729, 724)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(129, 40)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Guardar"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lbIndications
        '
        Me.lbIndications.AutoSize = True
        Me.lbIndications.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIndications.Location = New System.Drawing.Point(56, 41)
        Me.lbIndications.Name = "lbIndications"
        Me.lbIndications.Size = New System.Drawing.Size(384, 29)
        Me.lbIndications.TabIndex = 2
        Me.lbIndications.Text = "Digite los datos que se le solicitan:"
        '
        'lbName
        '
        Me.lbName.AutoSize = True
        Me.lbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbName.Location = New System.Drawing.Point(57, 105)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(81, 25)
        Me.lbName.TabIndex = 3
        Me.lbName.Text = "Nombre"
        '
        'tbName
        '
        Me.tbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbName.Location = New System.Drawing.Point(230, 102)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(628, 30)
        Me.tbName.TabIndex = 4
        '
        'tbIDCard
        '
        Me.tbIDCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbIDCard.Location = New System.Drawing.Point(230, 157)
        Me.tbIDCard.Name = "tbIDCard"
        Me.tbIDCard.Size = New System.Drawing.Size(628, 30)
        Me.tbIDCard.TabIndex = 6
        '
        'lbIDCard
        '
        Me.lbIDCard.AutoSize = True
        Me.lbIDCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIDCard.Location = New System.Drawing.Point(57, 160)
        Me.lbIDCard.Name = "lbIDCard"
        Me.lbIDCard.Size = New System.Drawing.Size(113, 25)
        Me.lbIDCard.TabIndex = 5
        Me.lbIDCard.Text = "Cédula (ID)"
        '
        'tbPhone
        '
        Me.tbPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPhone.Location = New System.Drawing.Point(230, 210)
        Me.tbPhone.Name = "tbPhone"
        Me.tbPhone.Size = New System.Drawing.Size(628, 30)
        Me.tbPhone.TabIndex = 8
        '
        'lbPhone
        '
        Me.lbPhone.AutoSize = True
        Me.lbPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPhone.Location = New System.Drawing.Point(57, 213)
        Me.lbPhone.Name = "lbPhone"
        Me.lbPhone.Size = New System.Drawing.Size(89, 25)
        Me.lbPhone.TabIndex = 7
        Me.lbPhone.Text = "Teléfono"
        '
        'lbMaritalStatus
        '
        Me.lbMaritalStatus.AutoSize = True
        Me.lbMaritalStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMaritalStatus.Location = New System.Drawing.Point(57, 265)
        Me.lbMaritalStatus.Name = "lbMaritalStatus"
        Me.lbMaritalStatus.Size = New System.Drawing.Size(110, 25)
        Me.lbMaritalStatus.TabIndex = 9
        Me.lbMaritalStatus.Text = "Estado civil"
        '
        'cboxMaritalStatus
        '
        Me.cboxMaritalStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxMaritalStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxMaritalStatus.FormattingEnabled = True
        Me.cboxMaritalStatus.Items.AddRange(New Object() {"Soltero/a", "Casado/a", "Divorciado/a", "Viudo/a"})
        Me.cboxMaritalStatus.Location = New System.Drawing.Point(230, 262)
        Me.cboxMaritalStatus.Name = "cboxMaritalStatus"
        Me.cboxMaritalStatus.Size = New System.Drawing.Size(628, 33)
        Me.cboxMaritalStatus.TabIndex = 10
        '
        'lbOccupation
        '
        Me.lbOccupation.AutoSize = True
        Me.lbOccupation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbOccupation.Location = New System.Drawing.Point(57, 318)
        Me.lbOccupation.Name = "lbOccupation"
        Me.lbOccupation.Size = New System.Drawing.Size(107, 25)
        Me.lbOccupation.TabIndex = 11
        Me.lbOccupation.Text = "Ocupación"
        '
        'tbOccupation
        '
        Me.tbOccupation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbOccupation.Location = New System.Drawing.Point(230, 315)
        Me.tbOccupation.Name = "tbOccupation"
        Me.tbOccupation.Size = New System.Drawing.Size(628, 30)
        Me.tbOccupation.TabIndex = 12
        '
        'lbResidency
        '
        Me.lbResidency.AutoSize = True
        Me.lbResidency.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbResidency.Location = New System.Drawing.Point(57, 370)
        Me.lbResidency.Name = "lbResidency"
        Me.lbResidency.Size = New System.Drawing.Size(108, 25)
        Me.lbResidency.TabIndex = 13
        Me.lbResidency.Text = "Residencia"
        '
        'tbResidency
        '
        Me.tbResidency.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbResidency.Location = New System.Drawing.Point(230, 367)
        Me.tbResidency.Multiline = True
        Me.tbResidency.Name = "tbResidency"
        Me.tbResidency.Size = New System.Drawing.Size(628, 91)
        Me.tbResidency.TabIndex = 14
        '
        'tbWorkPlace
        '
        Me.tbWorkPlace.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbWorkPlace.Location = New System.Drawing.Point(230, 481)
        Me.tbWorkPlace.Multiline = True
        Me.tbWorkPlace.Name = "tbWorkPlace"
        Me.tbWorkPlace.Size = New System.Drawing.Size(628, 103)
        Me.tbWorkPlace.TabIndex = 16
        '
        'lbWorkPlace
        '
        Me.lbWorkPlace.AutoSize = True
        Me.lbWorkPlace.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbWorkPlace.Location = New System.Drawing.Point(57, 484)
        Me.lbWorkPlace.Name = "lbWorkPlace"
        Me.lbWorkPlace.Size = New System.Drawing.Size(153, 25)
        Me.lbWorkPlace.TabIndex = 15
        Me.lbWorkPlace.Text = "Lugar de trabajo"
        '
        'cboxGender
        '
        Me.cboxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxGender.FormattingEnabled = True
        Me.cboxGender.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.cboxGender.Location = New System.Drawing.Point(230, 603)
        Me.cboxGender.Name = "cboxGender"
        Me.cboxGender.Size = New System.Drawing.Size(628, 33)
        Me.cboxGender.TabIndex = 18
        '
        'lbGender
        '
        Me.lbGender.AutoSize = True
        Me.lbGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbGender.Location = New System.Drawing.Point(57, 606)
        Me.lbGender.Name = "lbGender"
        Me.lbGender.Size = New System.Drawing.Size(77, 25)
        Me.lbGender.TabIndex = 17
        Me.lbGender.Text = "Género"
        '
        'tbMail
        '
        Me.tbMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMail.Location = New System.Drawing.Point(230, 656)
        Me.tbMail.Name = "tbMail"
        Me.tbMail.Size = New System.Drawing.Size(628, 30)
        Me.tbMail.TabIndex = 20
        '
        'lbMail
        '
        Me.lbMail.AutoSize = True
        Me.lbMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMail.Location = New System.Drawing.Point(57, 659)
        Me.lbMail.Name = "lbMail"
        Me.lbMail.Size = New System.Drawing.Size(60, 25)
        Me.lbMail.TabIndex = 19
        Me.lbMail.Text = "Email"
        '
        'frmInsertUpdateRepresentative
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(903, 780)
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
        Me.Controls.Add(Me.tbIDCard)
        Me.Controls.Add(Me.lbIDCard)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.lbName)
        Me.Controls.Add(Me.lbIndications)
        Me.Controls.Add(Me.btnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInsertUpdateRepresentative"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar/Actualizar Representante"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSave As Button
    Friend WithEvents lbIndications As Label
    Friend WithEvents lbName As Label
    Friend WithEvents tbName As TextBox
    Friend WithEvents tbIDCard As TextBox
    Friend WithEvents lbIDCard As Label
    Friend WithEvents tbPhone As TextBox
    Friend WithEvents lbPhone As Label
    Friend WithEvents lbMaritalStatus As Label
    Friend WithEvents cboxMaritalStatus As ComboBox
    Friend WithEvents lbOccupation As Label
    Friend WithEvents tbOccupation As TextBox
    Friend WithEvents lbResidency As Label
    Friend WithEvents tbResidency As TextBox
    Friend WithEvents tbWorkPlace As TextBox
    Friend WithEvents lbWorkPlace As Label
    Friend WithEvents cboxGender As ComboBox
    Friend WithEvents lbGender As Label
    Friend WithEvents tbMail As TextBox
    Friend WithEvents lbMail As Label
End Class
