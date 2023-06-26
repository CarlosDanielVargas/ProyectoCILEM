<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmManageLevels
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManageLevels))
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.lbLevelName = New System.Windows.Forms.Label()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.pnlLevels = New System.Windows.Forms.Panel()
        Me.lbLevelList = New System.Windows.Forms.Label()
        Me.dgvLevels = New System.Windows.Forms.DataGridView()
        Me.pnlMode = New System.Windows.Forms.Panel()
        Me.lbCurrentMode = New System.Windows.Forms.Label()
        Me.lbMode = New System.Windows.Forms.Label()
        Me.btnResetMode = New System.Windows.Forms.Button()
        Me.pnlMain.SuspendLayout()
        Me.pnlLevels.SuspendLayout()
        CType(Me.dgvLevels, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMode.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.lbLevelName)
        Me.pnlMain.Controls.Add(Me.tbName)
        Me.pnlMain.Controls.Add(Me.btnSave)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlMain.Size = New System.Drawing.Size(511, 163)
        Me.pnlMain.TabIndex = 0
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
        Me.tbName.Size = New System.Drawing.Size(313, 28)
        Me.tbName.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(395, 95)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(103, 32)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Guardar"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'pnlLevels
        '
        Me.pnlLevels.Controls.Add(Me.lbLevelList)
        Me.pnlLevels.Controls.Add(Me.dgvLevels)
        Me.pnlLevels.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLevels.Location = New System.Drawing.Point(0, 163)
        Me.pnlLevels.Name = "pnlLevels"
        Me.pnlLevels.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlLevels.Size = New System.Drawing.Size(511, 375)
        Me.pnlLevels.TabIndex = 1
        '
        'lbLevelList
        '
        Me.lbLevelList.AutoSize = True
        Me.lbLevelList.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lbLevelList.Location = New System.Drawing.Point(12, 10)
        Me.lbLevelList.Name = "lbLevelList"
        Me.lbLevelList.Size = New System.Drawing.Size(238, 24)
        Me.lbLevelList.TabIndex = 3
        Me.lbLevelList.Text = "Lista de niveles agregados:"
        '
        'dgvLevels
        '
        Me.dgvLevels.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvLevels.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvLevels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLevels.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvLevels.Location = New System.Drawing.Point(10, 54)
        Me.dgvLevels.Name = "dgvLevels"
        Me.dgvLevels.RowHeadersWidth = 51
        Me.dgvLevels.RowTemplate.Height = 24
        Me.dgvLevels.Size = New System.Drawing.Size(491, 311)
        Me.dgvLevels.TabIndex = 4
        '
        'pnlMode
        '
        Me.pnlMode.Controls.Add(Me.lbCurrentMode)
        Me.pnlMode.Controls.Add(Me.lbMode)
        Me.pnlMode.Controls.Add(Me.btnResetMode)
        Me.pnlMode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMode.Location = New System.Drawing.Point(0, 538)
        Me.pnlMode.Name = "pnlMode"
        Me.pnlMode.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlMode.Size = New System.Drawing.Size(511, 103)
        Me.pnlMode.TabIndex = 2
        '
        'lbCurrentMode
        '
        Me.lbCurrentMode.AutoSize = True
        Me.lbCurrentMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbCurrentMode.Location = New System.Drawing.Point(12, 20)
        Me.lbCurrentMode.Name = "lbCurrentMode"
        Me.lbCurrentMode.Size = New System.Drawing.Size(125, 25)
        Me.lbCurrentMode.TabIndex = 5
        Me.lbCurrentMode.Text = "Modo actual:"
        '
        'lbMode
        '
        Me.lbMode.AutoSize = True
        Me.lbMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMode.Location = New System.Drawing.Point(138, 20)
        Me.lbMode.Name = "lbMode"
        Me.lbMode.Size = New System.Drawing.Size(137, 25)
        Me.lbMode.TabIndex = 6
        Me.lbMode.Text = "Modo actual:"
        '
        'btnResetMode
        '
        Me.btnResetMode.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnResetMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnResetMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResetMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnResetMode.ForeColor = System.Drawing.Color.White
        Me.btnResetMode.Location = New System.Drawing.Point(323, 58)
        Me.btnResetMode.Name = "btnResetMode"
        Me.btnResetMode.Size = New System.Drawing.Size(175, 32)
        Me.btnResetMode.TabIndex = 7
        Me.btnResetMode.Text = "Cambiar modo"
        Me.btnResetMode.UseVisualStyleBackColor = False
        '
        'frmManageLevels
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(511, 641)
        Me.Controls.Add(Me.pnlMode)
        Me.Controls.Add(Me.pnlLevels)
        Me.Controls.Add(Me.pnlMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmManageLevels"
        Me.Text = "Administrar Niveles"
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.pnlLevels.ResumeLayout(False)
        Me.pnlLevels.PerformLayout()
        CType(Me.dgvLevels, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMode.ResumeLayout(False)
        Me.pnlMode.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents lbLevelName As Label
    Friend WithEvents tbName As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents pnlLevels As Panel
    Friend WithEvents lbLevelList As Label
    Friend WithEvents dgvLevels As DataGridView
    Friend WithEvents pnlMode As Panel
    Friend WithEvents lbCurrentMode As Label
    Friend WithEvents lbMode As Label
    Friend WithEvents btnResetMode As Button
End Class
