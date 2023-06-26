<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUserList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserList))
        Me.lbCurrentFilter = New System.Windows.Forms.Label()
        Me.cboxStatus = New System.Windows.Forms.ComboBox()
        Me.lbStatus = New System.Windows.Forms.Label()
        Me.tbIDCard = New System.Windows.Forms.TextBox()
        Me.lbIDCard = New System.Windows.Forms.Label()
        Me.lbFilters = New System.Windows.Forms.Label()
        Me.dgvUsers = New System.Windows.Forms.DataGridView()
        Me.cboxRole = New System.Windows.Forms.ComboBox()
        Me.lbRole = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlFilters = New System.Windows.Forms.Panel()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.btnClearFilters = New System.Windows.Forms.Button()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFilters.SuspendLayout()
        Me.pnlButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbCurrentFilter
        '
        Me.lbCurrentFilter.AutoSize = True
        Me.lbCurrentFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.lbCurrentFilter.Location = New System.Drawing.Point(15, 78)
        Me.lbCurrentFilter.Name = "lbCurrentFilter"
        Me.lbCurrentFilter.Size = New System.Drawing.Size(64, 22)
        Me.lbCurrentFilter.TabIndex = 29
        Me.lbCurrentFilter.Text = "Label1"
        '
        'cboxStatus
        '
        Me.cboxStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.cboxStatus.FormattingEnabled = True
        Me.cboxStatus.Location = New System.Drawing.Point(368, 42)
        Me.cboxStatus.Name = "cboxStatus"
        Me.cboxStatus.Size = New System.Drawing.Size(206, 30)
        Me.cboxStatus.TabIndex = 24
        '
        'lbStatus
        '
        Me.lbStatus.AutoSize = True
        Me.lbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.lbStatus.Location = New System.Drawing.Point(292, 42)
        Me.lbStatus.Name = "lbStatus"
        Me.lbStatus.Size = New System.Drawing.Size(71, 22)
        Me.lbStatus.TabIndex = 23
        Me.lbStatus.Text = "Estado:"
        '
        'tbIDCard
        '
        Me.tbIDCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.tbIDCard.Location = New System.Drawing.Point(92, 42)
        Me.tbIDCard.Name = "tbIDCard"
        Me.tbIDCard.Size = New System.Drawing.Size(184, 28)
        Me.tbIDCard.TabIndex = 22
        '
        'lbIDCard
        '
        Me.lbIDCard.AutoSize = True
        Me.lbIDCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.lbIDCard.Location = New System.Drawing.Point(15, 42)
        Me.lbIDCard.Name = "lbIDCard"
        Me.lbIDCard.Size = New System.Drawing.Size(72, 22)
        Me.lbIDCard.TabIndex = 21
        Me.lbIDCard.Text = "Cédula:"
        '
        'lbFilters
        '
        Me.lbFilters.AutoSize = True
        Me.lbFilters.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lbFilters.Location = New System.Drawing.Point(14, 12)
        Me.lbFilters.Name = "lbFilters"
        Me.lbFilters.Size = New System.Drawing.Size(182, 24)
        Me.lbFilters.TabIndex = 20
        Me.lbFilters.Text = "Filtros de búsqueda:"
        '
        'dgvUsers
        '
        Me.dgvUsers.AllowUserToAddRows = False
        Me.dgvUsers.AllowUserToDeleteRows = False
        Me.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUsers.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsers.Location = New System.Drawing.Point(12, 130)
        Me.dgvUsers.Name = "dgvUsers"
        Me.dgvUsers.ReadOnly = True
        Me.dgvUsers.RowHeadersWidth = 51
        Me.dgvUsers.RowTemplate.Height = 24
        Me.dgvUsers.Size = New System.Drawing.Size(981, 505)
        Me.dgvUsers.TabIndex = 19
        '
        'cboxRole
        '
        Me.cboxRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.cboxRole.FormattingEnabled = True
        Me.cboxRole.Location = New System.Drawing.Point(625, 40)
        Me.cboxRole.Name = "cboxRole"
        Me.cboxRole.Size = New System.Drawing.Size(216, 30)
        Me.cboxRole.TabIndex = 26
        '
        'lbRole
        '
        Me.lbRole.AutoSize = True
        Me.lbRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.lbRole.Location = New System.Drawing.Point(580, 42)
        Me.lbRole.Name = "lbRole"
        Me.lbRole.Size = New System.Drawing.Size(42, 22)
        Me.lbRole.TabIndex = 25
        Me.lbRole.Text = "Rol:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(1048, 19)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(200, 100)
        Me.TableLayoutPanel1.TabIndex = 30
        '
        'pnlFilters
        '
        Me.pnlFilters.BackColor = System.Drawing.Color.White
        Me.pnlFilters.Controls.Add(Me.lbCurrentFilter)
        Me.pnlFilters.Controls.Add(Me.cboxRole)
        Me.pnlFilters.Controls.Add(Me.lbRole)
        Me.pnlFilters.Controls.Add(Me.lbFilters)
        Me.pnlFilters.Controls.Add(Me.cboxStatus)
        Me.pnlFilters.Controls.Add(Me.lbIDCard)
        Me.pnlFilters.Controls.Add(Me.lbStatus)
        Me.pnlFilters.Controls.Add(Me.tbIDCard)
        Me.pnlFilters.Location = New System.Drawing.Point(-3, 0)
        Me.pnlFilters.Name = "pnlFilters"
        Me.pnlFilters.Size = New System.Drawing.Size(1009, 124)
        Me.pnlFilters.TabIndex = 31
        '
        'pnlButtons
        '
        Me.pnlButtons.Controls.Add(Me.btnFilter)
        Me.pnlButtons.Controls.Add(Me.btnClearFilters)
        Me.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlButtons.Location = New System.Drawing.Point(0, 645)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(1005, 40)
        Me.pnlButtons.TabIndex = 32
        '
        'btnFilter
        '
        Me.btnFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.btnFilter.ForeColor = System.Drawing.Color.White
        Me.btnFilter.Location = New System.Drawing.Point(866, 3)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(129, 32)
        Me.btnFilter.TabIndex = 15
        Me.btnFilter.Text = "Filtrar"
        Me.btnFilter.UseVisualStyleBackColor = False
        '
        'btnClearFilters
        '
        Me.btnClearFilters.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnClearFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearFilters.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.btnClearFilters.ForeColor = System.Drawing.Color.White
        Me.btnClearFilters.Location = New System.Drawing.Point(733, 3)
        Me.btnClearFilters.Name = "btnClearFilters"
        Me.btnClearFilters.Size = New System.Drawing.Size(129, 32)
        Me.btnClearFilters.TabIndex = 16
        Me.btnClearFilters.Text = "Limpiar filtros"
        Me.btnClearFilters.UseVisualStyleBackColor = False
        '
        'frmUserList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1005, 685)
        Me.Controls.Add(Me.pnlButtons)
        Me.Controls.Add(Me.pnlFilters)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.dgvUsers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUserList"
        Me.Text = "Lista de Usuarios"
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFilters.ResumeLayout(False)
        Me.pnlFilters.PerformLayout()
        Me.pnlButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbCurrentFilter As Label
    Friend WithEvents cboxStatus As ComboBox
    Friend WithEvents lbStatus As Label
    Friend WithEvents tbIDCard As TextBox
    Friend WithEvents lbIDCard As Label
    Friend WithEvents lbFilters As Label
    Friend WithEvents dgvUsers As DataGridView
    Friend WithEvents cboxRole As ComboBox
    Friend WithEvents lbRole As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents pnlFilters As Panel
    Friend WithEvents pnlButtons As Panel
    Friend WithEvents btnFilter As Button
    Friend WithEvents btnClearFilters As Button
End Class
