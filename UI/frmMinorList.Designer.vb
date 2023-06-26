<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMinorList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMinorList))
        Me.lbIndications = New System.Windows.Forms.Label()
        Me.dgvMinors = New System.Windows.Forms.DataGridView()
        Me.pnlFilters = New System.Windows.Forms.Panel()
        Me.lbFilters = New System.Windows.Forms.Label()
        Me.lbName = New System.Windows.Forms.Label()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.lbLevel = New System.Windows.Forms.Label()
        Me.cboxLevel = New System.Windows.Forms.ComboBox()
        Me.cboxGender = New System.Windows.Forms.ComboBox()
        Me.lbGender = New System.Windows.Forms.Label()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.btnClearFilters = New System.Windows.Forms.Button()
        Me.pnlCurrentFilter = New System.Windows.Forms.Panel()
        Me.lbCurrentFilter = New System.Windows.Forms.Label()
        Me.btnExportToExcel = New System.Windows.Forms.Button()
        CType(Me.dgvMinors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbIndications
        '
        Me.lbIndications.AutoSize = True
        Me.lbIndications.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIndications.Location = New System.Drawing.Point(255, 11)
        Me.lbIndications.Name = "lbIndications"
        Me.lbIndications.Size = New System.Drawing.Size(331, 29)
        Me.lbIndications.TabIndex = 6
        Me.lbIndications.Text = "Lista de menores registrados "
        '
        'dgvMinors
        '
        Me.dgvMinors.AllowUserToAddRows = False
        Me.dgvMinors.AllowUserToDeleteRows = False
        Me.dgvMinors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMinors.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvMinors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMinors.Location = New System.Drawing.Point(12, 137)
        Me.dgvMinors.Name = "dgvMinors"
        Me.dgvMinors.ReadOnly = True
        Me.dgvMinors.RowHeadersWidth = 51
        Me.dgvMinors.RowTemplate.Height = 24
        Me.dgvMinors.Size = New System.Drawing.Size(855, 416)
        Me.dgvMinors.TabIndex = 7
        '
        'pnlFilters
        '
        Me.pnlFilters.BackColor = System.Drawing.Color.White
        Me.pnlFilters.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFilters.Location = New System.Drawing.Point(0, 0)
        Me.pnlFilters.Name = "pnlFilters"
        Me.pnlFilters.Size = New System.Drawing.Size(879, 126)
        Me.pnlFilters.TabIndex = 8
        '
        'lbFilters
        '
        Me.lbFilters.AutoSize = True
        Me.lbFilters.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lbFilters.Location = New System.Drawing.Point(12, 17)
        Me.lbFilters.Name = "lbFilters"
        Me.lbFilters.Size = New System.Drawing.Size(182, 24)
        Me.lbFilters.TabIndex = 8
        Me.lbFilters.Text = "Filtros de búsqueda:"
        '
        'lbName
        '
        Me.lbName.AutoSize = True
        Me.lbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.lbName.Location = New System.Drawing.Point(13, 47)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(91, 28)
        Me.lbName.TabIndex = 9
        Me.lbName.Text = "Nombre"
        '
        'tbName
        '
        Me.tbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.tbName.Location = New System.Drawing.Point(90, 47)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(184, 28)
        Me.tbName.TabIndex = 10
        '
        'lbLevel
        '
        Me.lbLevel.AutoSize = True
        Me.lbLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.lbLevel.Location = New System.Drawing.Point(290, 47)
        Me.lbLevel.Name = "lbLevel"
        Me.lbLevel.Size = New System.Drawing.Size(55, 22)
        Me.lbLevel.TabIndex = 11
        Me.lbLevel.Text = "Nivel:"
        '
        'cboxLevel
        '
        Me.cboxLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.cboxLevel.FormattingEnabled = True
        Me.cboxLevel.Location = New System.Drawing.Point(344, 47)
        Me.cboxLevel.Name = "cboxLevel"
        Me.cboxLevel.Size = New System.Drawing.Size(230, 30)
        Me.cboxLevel.TabIndex = 12
        '
        'cboxGender
        '
        Me.cboxGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.cboxGender.FormattingEnabled = True
        Me.cboxGender.Location = New System.Drawing.Point(662, 45)
        Me.cboxGender.Name = "cboxGender"
        Me.cboxGender.Size = New System.Drawing.Size(156, 30)
        Me.cboxGender.TabIndex = 14
        '
        'lbGender
        '
        Me.lbGender.AutoSize = True
        Me.lbGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.lbGender.Location = New System.Drawing.Point(587, 45)
        Me.lbGender.Name = "lbGender"
        Me.lbGender.Size = New System.Drawing.Size(75, 22)
        Me.lbGender.TabIndex = 13
        Me.lbGender.Text = "Género:"
        '
        'pnlButtons
        '
        Me.pnlButtons.Controls.Add(Me.btnExportToExcel)
        Me.pnlButtons.Controls.Add(Me.btnFilter)
        Me.pnlButtons.Controls.Add(Me.btnClearFilters)
        Me.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlButtons.Location = New System.Drawing.Point(0, 559)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(879, 40)
        Me.pnlButtons.TabIndex = 16
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
        Me.btnClearFilters.Location = New System.Drawing.Point(510, 3)
        Me.btnClearFilters.Name = "btnClearFilters"
        Me.btnClearFilters.Size = New System.Drawing.Size(209, 32)
        Me.btnClearFilters.TabIndex = 16
        Me.btnClearFilters.Text = "Limpiar filtros"
        Me.btnClearFilters.UseVisualStyleBackColor = False
        '
        'pnlCurrentFilter
        '
        Me.pnlCurrentFilter.Location = New System.Drawing.Point(0, 0)
        Me.pnlCurrentFilter.Name = "pnlCurrentFilter"
        Me.pnlCurrentFilter.Size = New System.Drawing.Size(200, 100)
        Me.pnlCurrentFilter.TabIndex = 0
        '
        'lbCurrentFilter
        '
        Me.lbCurrentFilter.AutoSize = True
        Me.lbCurrentFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.lbCurrentFilter.Location = New System.Drawing.Point(13, 82)
        Me.lbCurrentFilter.Name = "lbCurrentFilter"
        Me.lbCurrentFilter.Size = New System.Drawing.Size(64, 22)
        Me.lbCurrentFilter.TabIndex = 17
        Me.lbCurrentFilter.Text = "Label1"
        '
        'btnExportToExcel
        '
        Me.btnExportToExcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnExportToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportToExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.btnExportToExcel.ForeColor = System.Drawing.Color.White
        Me.btnExportToExcel.Location = New System.Drawing.Point(247, 3)
        Me.btnExportToExcel.Name = "btnExportToExcel"
        Me.btnExportToExcel.Size = New System.Drawing.Size(257, 32)
        Me.btnExportToExcel.TabIndex = 17
        Me.btnExportToExcel.Text = "Descargar información"
        Me.btnExportToExcel.UseVisualStyleBackColor = False
        '
        'frmMinorList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(879, 599)
        Me.Controls.Add(Me.lbCurrentFilter)
        Me.Controls.Add(Me.pnlButtons)
        Me.Controls.Add(Me.cboxGender)
        Me.Controls.Add(Me.lbGender)
        Me.Controls.Add(Me.cboxLevel)
        Me.Controls.Add(Me.lbLevel)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.lbName)
        Me.Controls.Add(Me.lbFilters)
        Me.Controls.Add(Me.pnlFilters)
        Me.Controls.Add(Me.dgvMinors)
        Me.Controls.Add(Me.lbIndications)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMinorList"
        Me.Text = "Lista de menores"
        CType(Me.dgvMinors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlButtons.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbIndications As Label
    Friend WithEvents dgvMinors As DataGridView
    Friend WithEvents pnlFilters As Panel
    Friend WithEvents lbFilters As Label
    Friend WithEvents lbName As Label
    Friend WithEvents tbName As TextBox
    Friend WithEvents lbLevel As Label
    Friend WithEvents cboxLevel As ComboBox
    Friend WithEvents cboxGender As ComboBox
    Friend WithEvents lbGender As Label
    Friend WithEvents pnlButtons As Panel
    Friend WithEvents btnFilter As Button
    Friend WithEvents btnClearFilters As Button
    Private pnlCurrentFilter As Panel
    Friend WithEvents lbCurrentFilter As Label
    Friend WithEvents btnExportToExcel As Button
End Class
