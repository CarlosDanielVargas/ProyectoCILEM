<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInsertUpdateUser
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbInstructions = New System.Windows.Forms.Label()
        Me.lbName = New System.Windows.Forms.Label()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.lbRole = New System.Windows.Forms.Label()
        Me.cboxRole = New System.Windows.Forms.ComboBox()
        Me.cboxIsActive = New System.Windows.Forms.ComboBox()
        Me.Estado = New System.Windows.Forms.Label()
        Me.lbPassword = New System.Windows.Forms.Label()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.tbPasswordConfirmation = New System.Windows.Forms.TextBox()
        Me.lbPasswordConfirmation = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbInstructions
        '
        Me.lbInstructions.AutoSize = True
        Me.lbInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.lbInstructions.Location = New System.Drawing.Point(12, 35)
        Me.lbInstructions.Name = "lbInstructions"
        Me.lbInstructions.Size = New System.Drawing.Size(480, 36)
        Me.lbInstructions.TabIndex = 0
        Me.lbInstructions.Text = "Digite los datos que se le solicitan:"
        '
        'lbName
        '
        Me.lbName.AutoSize = True
        Me.lbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbName.Location = New System.Drawing.Point(14, 88)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(171, 25)
        Me.lbName.TabIndex = 1
        Me.lbName.Text = "Nombre completo:"
        '
        'tbName
        '
        Me.tbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.tbName.Location = New System.Drawing.Point(202, 88)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(420, 28)
        Me.tbName.TabIndex = 2
        '
        'lbRole
        '
        Me.lbRole.AutoSize = True
        Me.lbRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbRole.Location = New System.Drawing.Point(14, 136)
        Me.lbRole.Name = "lbRole"
        Me.lbRole.Size = New System.Drawing.Size(58, 31)
        Me.lbRole.TabIndex = 3
        Me.lbRole.Text = "Rol:"
        '
        'cboxRole
        '
        Me.cboxRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.cboxRole.FormattingEnabled = True
        Me.cboxRole.Location = New System.Drawing.Point(78, 135)
        Me.cboxRole.Name = "cboxRole"
        Me.cboxRole.Size = New System.Drawing.Size(544, 30)
        Me.cboxRole.TabIndex = 4
        '
        'cboxIsActive
        '
        Me.cboxIsActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.cboxIsActive.FormattingEnabled = True
        Me.cboxIsActive.Location = New System.Drawing.Point(202, 184)
        Me.cboxIsActive.Name = "cboxIsActive"
        Me.cboxIsActive.Size = New System.Drawing.Size(420, 30)
        Me.cboxIsActive.TabIndex = 6
        '
        'Estado
        '
        Me.Estado.AutoSize = True
        Me.Estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Estado.Location = New System.Drawing.Point(14, 185)
        Me.Estado.Name = "Estado"
        Me.Estado.Size = New System.Drawing.Size(213, 31)
        Me.Estado.TabIndex = 5
        Me.Estado.Text = "Estado de cuenta:"
        '
        'lbPassword
        '
        Me.lbPassword.AutoSize = True
        Me.lbPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbPassword.Location = New System.Drawing.Point(15, 234)
        Me.lbPassword.Name = "lbPassword"
        Me.lbPassword.Size = New System.Drawing.Size(150, 31)
        Me.lbPassword.TabIndex = 7
        Me.lbPassword.Text = "Contraseña:"
        '
        'tbPassword
        '
        Me.tbPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.tbPassword.Location = New System.Drawing.Point(145, 237)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(477, 28)
        Me.tbPassword.TabIndex = 8
        '
        'tbPasswordConfirmation
        '
        Me.tbPasswordConfirmation.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.tbPasswordConfirmation.Location = New System.Drawing.Point(282, 291)
        Me.tbPasswordConfirmation.Name = "tbPasswordConfirmation"
        Me.tbPasswordConfirmation.Size = New System.Drawing.Size(340, 28)
        Me.tbPasswordConfirmation.TabIndex = 10
        '
        'lbPasswordConfirmation
        '
        Me.lbPasswordConfirmation.AutoSize = True
        Me.lbPasswordConfirmation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbPasswordConfirmation.Location = New System.Drawing.Point(15, 288)
        Me.lbPasswordConfirmation.Name = "lbPasswordConfirmation"
        Me.lbPasswordConfirmation.Size = New System.Drawing.Size(328, 31)
        Me.lbPasswordConfirmation.TabIndex = 9
        Me.lbPasswordConfirmation.Text = "Confirmación de contraseña:"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnSave.Location = New System.Drawing.Point(257, 354)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(114, 35)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Guardar"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmInsertUpdateUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(639, 401)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.tbPasswordConfirmation)
        Me.Controls.Add(Me.lbPasswordConfirmation)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.lbPassword)
        Me.Controls.Add(Me.cboxIsActive)
        Me.Controls.Add(Me.Estado)
        Me.Controls.Add(Me.cboxRole)
        Me.Controls.Add(Me.lbRole)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.lbName)
        Me.Controls.Add(Me.lbInstructions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmInsertUpdateUser"
        Me.Text = "Agregar usuario nuevo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbInstructions As Label
    Friend WithEvents lbName As Label
    Friend WithEvents tbName As TextBox
    Friend WithEvents lbRole As Label
    Friend WithEvents cboxRole As ComboBox
    Friend WithEvents cboxIsActive As ComboBox
    Friend WithEvents Estado As Label
    Friend WithEvents lbPassword As Label
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents tbPasswordConfirmation As TextBox
    Friend WithEvents lbPasswordConfirmation As Label
    Friend WithEvents btnSave As Button
End Class
