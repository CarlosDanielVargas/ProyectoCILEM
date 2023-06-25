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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInsertUpdateUser))
        Me.lbInstructions = New System.Windows.Forms.Label()
        Me.lbIDCard = New System.Windows.Forms.Label()
        Me.tbIDCard = New System.Windows.Forms.TextBox()
        Me.lbRole = New System.Windows.Forms.Label()
        Me.cboxRole = New System.Windows.Forms.ComboBox()
        Me.cboxIsActive = New System.Windows.Forms.ComboBox()
        Me.Estado = New System.Windows.Forms.Label()
        Me.lbPassword = New System.Windows.Forms.Label()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.tbPasswordConfirmation = New System.Windows.Forms.TextBox()
        Me.lbPasswordConfirmation = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.tblpPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.lbName = New System.Windows.Forms.Label()
        Me.tblpPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbInstructions
        '
        Me.lbInstructions.AutoSize = True
        Me.lbInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.lbInstructions.Location = New System.Drawing.Point(12, 35)
        Me.lbInstructions.Name = "lbInstructions"
        Me.lbInstructions.Size = New System.Drawing.Size(384, 29)
        Me.lbInstructions.TabIndex = 0
        Me.lbInstructions.Text = "Digite los datos que se le solicitan:"
        '
        'lbIDCard
        '
        Me.lbIDCard.AutoSize = True
        Me.lbIDCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbIDCard.Location = New System.Drawing.Point(3, 0)
        Me.lbIDCard.Name = "lbIDCard"
        Me.lbIDCard.Size = New System.Drawing.Size(177, 25)
        Me.lbIDCard.TabIndex = 1
        Me.lbIDCard.Text = "Número de cédula:"
        '
        'tbIDCard
        '
        Me.tbIDCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.tbIDCard.Location = New System.Drawing.Point(331, 3)
        Me.tbIDCard.Name = "tbIDCard"
        Me.tbIDCard.Size = New System.Drawing.Size(572, 28)
        Me.tbIDCard.TabIndex = 2
        '
        'lbRole
        '
        Me.lbRole.AutoSize = True
        Me.lbRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbRole.Location = New System.Drawing.Point(3, 89)
        Me.lbRole.Name = "lbRole"
        Me.lbRole.Size = New System.Drawing.Size(46, 25)
        Me.lbRole.TabIndex = 3
        Me.lbRole.Text = "Rol:"
        '
        'cboxRole
        '
        Me.cboxRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.cboxRole.FormattingEnabled = True
        Me.cboxRole.Location = New System.Drawing.Point(331, 92)
        Me.cboxRole.Name = "cboxRole"
        Me.cboxRole.Size = New System.Drawing.Size(572, 30)
        Me.cboxRole.TabIndex = 4
        '
        'cboxIsActive
        '
        Me.cboxIsActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.cboxIsActive.FormattingEnabled = True
        Me.cboxIsActive.Location = New System.Drawing.Point(331, 131)
        Me.cboxIsActive.Name = "cboxIsActive"
        Me.cboxIsActive.Size = New System.Drawing.Size(572, 30)
        Me.cboxIsActive.TabIndex = 6
        '
        'Estado
        '
        Me.Estado.AutoSize = True
        Me.Estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Estado.Location = New System.Drawing.Point(3, 128)
        Me.Estado.Name = "Estado"
        Me.Estado.Size = New System.Drawing.Size(170, 25)
        Me.Estado.TabIndex = 5
        Me.Estado.Text = "Estado de cuenta:"
        '
        'lbPassword
        '
        Me.lbPassword.AutoSize = True
        Me.lbPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbPassword.Location = New System.Drawing.Point(3, 173)
        Me.lbPassword.Name = "lbPassword"
        Me.lbPassword.Size = New System.Drawing.Size(120, 25)
        Me.lbPassword.TabIndex = 7
        Me.lbPassword.Text = "Contraseña:"
        '
        'tbPassword
        '
        Me.tbPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.tbPassword.Location = New System.Drawing.Point(331, 213)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(572, 28)
        Me.tbPassword.TabIndex = 8
        '
        'tbPasswordConfirmation
        '
        Me.tbPasswordConfirmation.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.tbPasswordConfirmation.Location = New System.Drawing.Point(331, 176)
        Me.tbPasswordConfirmation.Name = "tbPasswordConfirmation"
        Me.tbPasswordConfirmation.Size = New System.Drawing.Size(572, 28)
        Me.tbPasswordConfirmation.TabIndex = 10
        '
        'lbPasswordConfirmation
        '
        Me.lbPasswordConfirmation.AutoSize = True
        Me.lbPasswordConfirmation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbPasswordConfirmation.Location = New System.Drawing.Point(3, 210)
        Me.lbPasswordConfirmation.Name = "lbPasswordConfirmation"
        Me.lbPasswordConfirmation.Size = New System.Drawing.Size(262, 25)
        Me.lbPasswordConfirmation.TabIndex = 9
        Me.lbPasswordConfirmation.Text = "Confirmación de contraseña:"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(809, 364)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(114, 35)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Guardar"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'tblpPanel
        '
        Me.tblpPanel.ColumnCount = 2
        Me.tblpPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.20309!))
        Me.tblpPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.79691!))
        Me.tblpPanel.Controls.Add(Me.tbName, 1, 1)
        Me.tblpPanel.Controls.Add(Me.lbName, 0, 1)
        Me.tblpPanel.Controls.Add(Me.lbIDCard, 0, 0)
        Me.tblpPanel.Controls.Add(Me.tbIDCard, 1, 0)
        Me.tblpPanel.Controls.Add(Me.lbPasswordConfirmation, 0, 5)
        Me.tblpPanel.Controls.Add(Me.tbPassword, 1, 5)
        Me.tblpPanel.Controls.Add(Me.lbPassword, 0, 4)
        Me.tblpPanel.Controls.Add(Me.tbPasswordConfirmation, 1, 4)
        Me.tblpPanel.Controls.Add(Me.Estado, 0, 3)
        Me.tblpPanel.Controls.Add(Me.cboxIsActive, 1, 3)
        Me.tblpPanel.Controls.Add(Me.lbRole, 0, 2)
        Me.tblpPanel.Controls.Add(Me.cboxRole, 1, 2)
        Me.tblpPanel.Location = New System.Drawing.Point(17, 78)
        Me.tblpPanel.Margin = New System.Windows.Forms.Padding(5)
        Me.tblpPanel.Name = "tblpPanel"
        Me.tblpPanel.RowCount = 6
        Me.tblpPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.31579!))
        Me.tblpPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.68421!))
        Me.tblpPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.tblpPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.tblpPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.tblpPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.tblpPanel.Size = New System.Drawing.Size(906, 243)
        Me.tblpPanel.TabIndex = 12
        '
        'tbName
        '
        Me.tbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.tbName.Location = New System.Drawing.Point(331, 49)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(572, 28)
        Me.tbName.TabIndex = 12
        '
        'lbName
        '
        Me.lbName.AutoSize = True
        Me.lbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbName.Location = New System.Drawing.Point(3, 46)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(171, 25)
        Me.lbName.TabIndex = 11
        Me.lbName.Text = "Nombre completo:"
        '
        'frmInsertUpdateUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(932, 411)
        Me.Controls.Add(Me.tblpPanel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lbInstructions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInsertUpdateUser"
        Me.Text = "Agregar usuario nuevo"
        Me.tblpPanel.ResumeLayout(False)
        Me.tblpPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbInstructions As Label
    Friend WithEvents lbIDCard As Label
    Friend WithEvents tbIDCard As TextBox
    Friend WithEvents lbRole As Label
    Friend WithEvents cboxRole As ComboBox
    Friend WithEvents cboxIsActive As ComboBox
    Friend WithEvents Estado As Label
    Friend WithEvents lbPassword As Label
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents tbPasswordConfirmation As TextBox
    Friend WithEvents lbPasswordConfirmation As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents tblpPanel As TableLayoutPanel
    Friend WithEvents lbName As Label
    Friend WithEvents tbName As TextBox
End Class
