<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewLevel
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
        Me.lbLevelName = New System.Windows.Forms.Label()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lbLevelList = New System.Windows.Forms.Label()
        Me.lboxLevels = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lbLevelName
        '
        Me.lbLevelName.AutoSize = True
        Me.lbLevelName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbLevelName.Location = New System.Drawing.Point(12, 20)
        Me.lbLevelName.Name = "lbLevelName"
        Me.lbLevelName.Size = New System.Drawing.Size(204, 31)
        Me.lbLevelName.TabIndex = 0
        Me.lbLevelName.Text = "Nombre del nivel:"
        '
        'tbName
        '
        Me.tbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.tbName.Location = New System.Drawing.Point(185, 19)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(317, 28)
        Me.tbName.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnSave.Location = New System.Drawing.Point(196, 84)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(103, 32)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Guardar"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lbLevelList
        '
        Me.lbLevelList.AutoSize = True
        Me.lbLevelList.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lbLevelList.Location = New System.Drawing.Point(12, 133)
        Me.lbLevelList.Name = "lbLevelList"
        Me.lbLevelList.Size = New System.Drawing.Size(298, 30)
        Me.lbLevelList.TabIndex = 3
        Me.lbLevelList.Text = "Lista de niveles agregados:"
        '
        'lboxLevels
        '
        Me.lboxLevels.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lboxLevels.FormattingEnabled = True
        Me.lboxLevels.ItemHeight = 25
        Me.lboxLevels.Location = New System.Drawing.Point(17, 166)
        Me.lboxLevels.Name = "lboxLevels"
        Me.lboxLevels.Size = New System.Drawing.Size(486, 104)
        Me.lboxLevels.TabIndex = 4
        '
        'frmNewLevel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 293)
        Me.Controls.Add(Me.lboxLevels)
        Me.Controls.Add(Me.lbLevelList)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.lbLevelName)
        Me.Name = "frmNewLevel"
        Me.Text = "Agregar Nivel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbLevelName As Label
    Friend WithEvents tbName As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents lbLevelList As Label
    Friend WithEvents lboxLevels As ListBox
End Class
