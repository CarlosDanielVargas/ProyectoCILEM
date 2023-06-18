<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManageLevels
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
        Me.dgvLevels = New System.Windows.Forms.DataGridView()
        Me.lbCurrentMode = New System.Windows.Forms.Label()
        Me.lbMode = New System.Windows.Forms.Label()
        Me.btnResetMode = New System.Windows.Forms.Button()
        CType(Me.dgvLevels, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbLevelName
        '
        Me.lbLevelName.AutoSize = True
        Me.lbLevelName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbLevelName.Location = New System.Drawing.Point(12, 20)
        Me.lbLevelName.Name = "lbLevelName"
        Me.lbLevelName.Size = New System.Drawing.Size(163, 25)
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
        Me.btnSave.Location = New System.Drawing.Point(399, 93)
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
        Me.lbLevelList.Size = New System.Drawing.Size(238, 24)
        Me.lbLevelList.TabIndex = 3
        Me.lbLevelList.Text = "Lista de niveles agregados:"
        '
        'dgvLevels
        '
        Me.dgvLevels.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvLevels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLevels.Location = New System.Drawing.Point(17, 160)
        Me.dgvLevels.Name = "dgvLevels"
        Me.dgvLevels.RowHeadersWidth = 51
        Me.dgvLevels.RowTemplate.Height = 24
        Me.dgvLevels.Size = New System.Drawing.Size(485, 121)
        Me.dgvLevels.TabIndex = 4
        '
        'lbCurrentMode
        '
        Me.lbCurrentMode.AutoSize = True
        Me.lbCurrentMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbCurrentMode.Location = New System.Drawing.Point(12, 63)
        Me.lbCurrentMode.Name = "lbCurrentMode"
        Me.lbCurrentMode.Size = New System.Drawing.Size(125, 25)
        Me.lbCurrentMode.TabIndex = 5
        Me.lbCurrentMode.Text = "Modo actual:"
        '
        'lbMode
        '
        Me.lbMode.AutoSize = True
        Me.lbMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMode.Location = New System.Drawing.Point(138, 65)
        Me.lbMode.Name = "lbMode"
        Me.lbMode.Size = New System.Drawing.Size(171, 31)
        Me.lbMode.TabIndex = 6
        Me.lbMode.Text = "Modo actual:"
        '
        'btnResetMode
        '
        Me.btnResetMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnResetMode.Location = New System.Drawing.Point(218, 93)
        Me.btnResetMode.Name = "btnResetMode"
        Me.btnResetMode.Size = New System.Drawing.Size(175, 32)
        Me.btnResetMode.TabIndex = 7
        Me.btnResetMode.Text = "Cambiar modo"
        Me.btnResetMode.UseVisualStyleBackColor = True
        '
        'frmManageLevels
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 293)
        Me.Controls.Add(Me.btnResetMode)
        Me.Controls.Add(Me.lbMode)
        Me.Controls.Add(Me.lbCurrentMode)
        Me.Controls.Add(Me.dgvLevels)
        Me.Controls.Add(Me.lbLevelList)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.lbLevelName)
        Me.Name = "frmManageLevels"
        Me.Text = "Administrar Niveles"
        CType(Me.dgvLevels, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbLevelName As Label
    Friend WithEvents tbName As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents lbLevelList As Label
    Friend WithEvents dgvLevels As DataGridView
    Friend WithEvents lbCurrentMode As Label
    Friend WithEvents lbMode As Label
    Friend WithEvents btnResetMode As Button
End Class
