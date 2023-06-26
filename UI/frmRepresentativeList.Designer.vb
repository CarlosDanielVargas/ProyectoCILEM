<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRepresentativeList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRepresentativeList))
        Me.dgvRepresentatives = New System.Windows.Forms.DataGridView()
        Me.lbCurrentFilter = New System.Windows.Forms.Label()
        Me.cboxGender = New System.Windows.Forms.ComboBox()
        Me.lbGender = New System.Windows.Forms.Label()
        Me.tbIDCard = New System.Windows.Forms.TextBox()
        Me.lbIDCard = New System.Windows.Forms.Label()
        Me.lbFilters = New System.Windows.Forms.Label()
        Me.pnlFilters = New System.Windows.Forms.Panel()
        Me.lbName = New System.Windows.Forms.Label()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.btnExportToExcel = New System.Windows.Forms.Button()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.btnClearFilters = New System.Windows.Forms.Button()
        CType(Me.dgvRepresentatives, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFilters.SuspendLayout()
        Me.pnlButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvRepresentatives
        '
        Me.dgvRepresentatives.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRepresentatives.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvRepresentatives.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRepresentatives.Location = New System.Drawing.Point(12, 132)
        Me.dgvRepresentatives.Name = "dgvRepresentatives"
        Me.dgvRepresentatives.RowHeadersWidth = 51
        Me.dgvRepresentatives.RowTemplate.Height = 24
        Me.dgvRepresentatives.Size = New System.Drawing.Size(853, 410)
        Me.dgvRepresentatives.TabIndex = 8
        '
        'lbCurrentFilter
        '
        Me.lbCurrentFilter.AutoSize = True
        Me.lbCurrentFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.lbCurrentFilter.Location = New System.Drawing.Point(13, 84)
        Me.lbCurrentFilter.Name = "lbCurrentFilter"
        Me.lbCurrentFilter.Size = New System.Drawing.Size(64, 22)
        Me.lbCurrentFilter.TabIndex = 27
        Me.lbCurrentFilter.Text = "Label1"
        '
        'cboxGender
        '
        Me.cboxGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.cboxGender.FormattingEnabled = True
        Me.cboxGender.Location = New System.Drawing.Point(661, 46)
        Me.cboxGender.Name = "cboxGender"
        Me.cboxGender.Size = New System.Drawing.Size(195, 30)
        Me.cboxGender.TabIndex = 24
        '
        'lbGender
        '
        Me.lbGender.AutoSize = True
        Me.lbGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.lbGender.Location = New System.Drawing.Point(580, 48)
        Me.lbGender.Name = "lbGender"
        Me.lbGender.Size = New System.Drawing.Size(75, 22)
        Me.lbGender.TabIndex = 23
        Me.lbGender.Text = "Género:"
        '
        'tbIDCard
        '
        Me.tbIDCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.tbIDCard.Location = New System.Drawing.Point(91, 48)
        Me.tbIDCard.Name = "tbIDCard"
        Me.tbIDCard.Size = New System.Drawing.Size(170, 28)
        Me.tbIDCard.TabIndex = 20
        '
        'lbIDCard
        '
        Me.lbIDCard.AutoSize = True
        Me.lbIDCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.lbIDCard.Location = New System.Drawing.Point(13, 48)
        Me.lbIDCard.Name = "lbIDCard"
        Me.lbIDCard.Size = New System.Drawing.Size(72, 22)
        Me.lbIDCard.TabIndex = 19
        Me.lbIDCard.Text = "Cédula:"
        '
        'lbFilters
        '
        Me.lbFilters.AutoSize = True
        Me.lbFilters.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lbFilters.Location = New System.Drawing.Point(12, 18)
        Me.lbFilters.Name = "lbFilters"
        Me.lbFilters.Size = New System.Drawing.Size(182, 24)
        Me.lbFilters.TabIndex = 18
        Me.lbFilters.Text = "Filtros de búsqueda:"
        '
        'pnlFilters
        '
        Me.pnlFilters.BackColor = System.Drawing.Color.White
        Me.pnlFilters.Controls.Add(Me.lbName)
        Me.pnlFilters.Controls.Add(Me.tbName)
        Me.pnlFilters.Controls.Add(Me.lbFilters)
        Me.pnlFilters.Controls.Add(Me.lbCurrentFilter)
        Me.pnlFilters.Controls.Add(Me.lbIDCard)
        Me.pnlFilters.Controls.Add(Me.tbIDCard)
        Me.pnlFilters.Controls.Add(Me.cboxGender)
        Me.pnlFilters.Controls.Add(Me.lbGender)
        Me.pnlFilters.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFilters.Location = New System.Drawing.Point(0, 0)
        Me.pnlFilters.Name = "pnlFilters"
        Me.pnlFilters.Size = New System.Drawing.Size(882, 126)
        Me.pnlFilters.TabIndex = 28
        '
        'lbName
        '
        Me.lbName.AutoSize = True
        Me.lbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.lbName.Location = New System.Drawing.Point(266, 48)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(78, 22)
        Me.lbName.TabIndex = 28
        Me.lbName.Text = "Nombre:"
        '
        'tbName
        '
        Me.tbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.tbName.Location = New System.Drawing.Point(350, 48)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(206, 28)
        Me.tbName.TabIndex = 29
        '
        'pnlButtons
        '
        Me.pnlButtons.Controls.Add(Me.btnExportToExcel)
        Me.pnlButtons.Controls.Add(Me.btnFilter)
        Me.pnlButtons.Controls.Add(Me.btnClearFilters)
        Me.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlButtons.Location = New System.Drawing.Point(0, 548)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(882, 35)
        Me.pnlButtons.TabIndex = 29
        '
        'btnExportToExcel
        '
        Me.btnExportToExcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnExportToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportToExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.btnExportToExcel.ForeColor = System.Drawing.Color.White
        Me.btnExportToExcel.Location = New System.Drawing.Point(329, 3)
        Me.btnExportToExcel.Name = "btnExportToExcel"
        Me.btnExportToExcel.Size = New System.Drawing.Size(257, 32)
        Me.btnExportToExcel.TabIndex = 18
        Me.btnExportToExcel.Text = "Descargar información"
        Me.btnExportToExcel.UseVisualStyleBackColor = False
        '
        'btnFilter
        '
        Me.btnFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.btnFilter.ForeColor = System.Drawing.Color.White
        Me.btnFilter.Location = New System.Drawing.Point(725, 3)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(127, 32)
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
        Me.btnClearFilters.Location = New System.Drawing.Point(592, 3)
        Me.btnClearFilters.Name = "btnClearFilters"
        Me.btnClearFilters.Size = New System.Drawing.Size(127, 32)
        Me.btnClearFilters.TabIndex = 16
        Me.btnClearFilters.Text = "Limpiar filtros"
        Me.btnClearFilters.UseVisualStyleBackColor = False
        '
        'frmRepresentativeList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(882, 583)
        Me.Controls.Add(Me.pnlButtons)
        Me.Controls.Add(Me.pnlFilters)
        Me.Controls.Add(Me.dgvRepresentatives)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRepresentativeList"
        Me.Text = "Lista de representantes"
        CType(Me.dgvRepresentatives, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFilters.ResumeLayout(False)
        Me.pnlFilters.PerformLayout()
        Me.pnlButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvRepresentatives As DataGridView
    Friend WithEvents lbCurrentFilter As Label
    Friend WithEvents cboxGender As ComboBox
    Friend WithEvents lbGender As Label
    Friend WithEvents tbIDCard As TextBox
    Friend WithEvents lbIDCard As Label
    Friend WithEvents lbFilters As Label
    Friend WithEvents pnlFilters As Panel
    Friend WithEvents lbName As Label
    Friend WithEvents tbName As TextBox
    Friend WithEvents pnlButtons As Panel
    Friend WithEvents btnFilter As Button
    Friend WithEvents btnClearFilters As Button
    Friend WithEvents btnExportToExcel As Button
End Class
