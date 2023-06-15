<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateMinor
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboxGender = New System.Windows.Forms.ComboBox()
        Me.lbGender = New System.Windows.Forms.Label()
        Me.tbResidency = New System.Windows.Forms.TextBox()
        Me.lbResidency = New System.Windows.Forms.Label()
        Me.lbIDCard = New System.Windows.Forms.Label()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.lbName = New System.Windows.Forms.Label()
        Me.lbIndications = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.cboId = New System.Windows.Forms.ComboBox()
        Me.dtPickBirth = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtPickOut = New System.Windows.Forms.DateTimePicker()
        Me.dtPickIn = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(663, 32)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Seleccione o digite la cédula del menor a actualizar"
        '
        'cboxGender
        '
        Me.cboxGender.FormattingEnabled = True
        Me.cboxGender.Location = New System.Drawing.Point(283, 603)
        Me.cboxGender.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboxGender.Name = "cboxGender"
        Me.cboxGender.Size = New System.Drawing.Size(614, 28)
        Me.cboxGender.TabIndex = 59
        '
        'lbGender
        '
        Me.lbGender.AutoSize = True
        Me.lbGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbGender.Location = New System.Drawing.Point(65, 599)
        Me.lbGender.Name = "lbGender"
        Me.lbGender.Size = New System.Drawing.Size(100, 29)
        Me.lbGender.TabIndex = 58
        Me.lbGender.Text = "Género:"
        '
        'tbResidency
        '
        Me.tbResidency.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbResidency.Location = New System.Drawing.Point(283, 475)
        Me.tbResidency.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbResidency.Multiline = True
        Me.tbResidency.Name = "tbResidency"
        Me.tbResidency.Size = New System.Drawing.Size(614, 102)
        Me.tbResidency.TabIndex = 55
        '
        'lbResidency
        '
        Me.lbResidency.AutoSize = True
        Me.lbResidency.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbResidency.Location = New System.Drawing.Point(65, 476)
        Me.lbResidency.Name = "lbResidency"
        Me.lbResidency.Size = New System.Drawing.Size(140, 29)
        Me.lbResidency.TabIndex = 54
        Me.lbResidency.Text = "Residencia:"
        '
        'lbIDCard
        '
        Me.lbIDCard.AutoSize = True
        Me.lbIDCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIDCard.Location = New System.Drawing.Point(65, 130)
        Me.lbIDCard.Name = "lbIDCard"
        Me.lbIDCard.Size = New System.Drawing.Size(96, 29)
        Me.lbIDCard.TabIndex = 47
        Me.lbIDCard.Text = "Cédula:"
        '
        'tbName
        '
        Me.tbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbName.Location = New System.Drawing.Point(283, 232)
        Me.tbName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(614, 32)
        Me.tbName.TabIndex = 46
        '
        'lbName
        '
        Me.lbName.AutoSize = True
        Me.lbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbName.Location = New System.Drawing.Point(65, 235)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(213, 29)
        Me.lbName.TabIndex = 45
        Me.lbName.Text = "Nombre completo:"
        '
        'lbIndications
        '
        Me.lbIndications.AutoSize = True
        Me.lbIndications.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIndications.Location = New System.Drawing.Point(64, 185)
        Me.lbIndications.Name = "lbIndications"
        Me.lbIndications.Size = New System.Drawing.Size(451, 32)
        Me.lbIndications.TabIndex = 44
        Me.lbIndications.Text = "Digite los datos que se le solicitan:"
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(405, 680)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(153, 50)
        Me.btnUpdate.TabIndex = 43
        Me.btnUpdate.Text = "Actualizar"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'cboId
        '
        Me.cboId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboId.FormattingEnabled = True
        Me.cboId.Location = New System.Drawing.Point(283, 127)
        Me.cboId.Name = "cboId"
        Me.cboId.Size = New System.Drawing.Size(614, 37)
        Me.cboId.TabIndex = 63
        '
        'dtPickBirth
        '
        Me.dtPickBirth.Location = New System.Drawing.Point(314, 291)
        Me.dtPickBirth.Name = "dtPickBirth"
        Me.dtPickBirth.Size = New System.Drawing.Size(583, 26)
        Me.dtPickBirth.TabIndex = 64
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(65, 288)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(243, 29)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Fecha de nacimiento:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(65, 349)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(207, 29)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Fecha de ingreso:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(65, 408)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(202, 29)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Fecha de egreso:"
        '
        'dtPickOut
        '
        Me.dtPickOut.Location = New System.Drawing.Point(314, 411)
        Me.dtPickOut.Name = "dtPickOut"
        Me.dtPickOut.Size = New System.Drawing.Size(583, 26)
        Me.dtPickOut.TabIndex = 68
        '
        'dtPickIn
        '
        Me.dtPickIn.Location = New System.Drawing.Point(314, 349)
        Me.dtPickIn.Name = "dtPickIn"
        Me.dtPickIn.Size = New System.Drawing.Size(583, 26)
        Me.dtPickIn.TabIndex = 69
        '
        'frmUpdateMinor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 840)
        Me.Controls.Add(Me.dtPickIn)
        Me.Controls.Add(Me.dtPickOut)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtPickBirth)
        Me.Controls.Add(Me.cboId)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboxGender)
        Me.Controls.Add(Me.lbGender)
        Me.Controls.Add(Me.tbResidency)
        Me.Controls.Add(Me.lbResidency)
        Me.Controls.Add(Me.lbIDCard)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.lbName)
        Me.Controls.Add(Me.lbIndications)
        Me.Controls.Add(Me.btnUpdate)
        Me.Name = "frmUpdateMinor"
        Me.Text = "frmUpdateMinor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents cboxGender As ComboBox
    Friend WithEvents lbGender As Label
    Friend WithEvents tbResidency As TextBox
    Friend WithEvents lbResidency As Label
    Friend WithEvents lbIDCard As Label
    Friend WithEvents tbName As TextBox
    Friend WithEvents lbName As Label
    Friend WithEvents lbIndications As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents cboId As ComboBox
    Friend WithEvents dtPickBirth As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtPickOut As DateTimePicker
    Friend WithEvents dtPickIn As DateTimePicker
End Class
