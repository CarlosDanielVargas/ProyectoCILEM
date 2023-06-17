<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMinorList
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
        Me.lbIndications = New System.Windows.Forms.Label()
        Me.dgvMinors = New System.Windows.Forms.DataGridView()
        Me.lbFilters = New System.Windows.Forms.Label()
        Me.lbIDCard = New System.Windows.Forms.Label()
        Me.tbIDCard = New System.Windows.Forms.TextBox()
        Me.lbLevel = New System.Windows.Forms.Label()
        Me.cboxLevel = New System.Windows.Forms.ComboBox()
        Me.cboxGender = New System.Windows.Forms.ComboBox()
        Me.lbGender = New System.Windows.Forms.Label()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.btnClearFilters = New System.Windows.Forms.Button()
        Me.lbCurrentFilter = New System.Windows.Forms.Label()
        CType(Me.dgvMinors, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.dgvMinors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMinors.Location = New System.Drawing.Point(12, 159)
        Me.dgvMinors.Name = "dgvMinors"
        Me.dgvMinors.RowHeadersWidth = 51
        Me.dgvMinors.RowTemplate.Height = 24
        Me.dgvMinors.Size = New System.Drawing.Size(855, 505)
        Me.dgvMinors.TabIndex = 7
        '
        'lbFilters
        '
        Me.lbFilters.AutoSize = True
        Me.lbFilters.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lbFilters.Location = New System.Drawing.Point(12, 52)
        Me.lbFilters.Name = "lbFilters"
        Me.lbFilters.Size = New System.Drawing.Size(182, 24)
        Me.lbFilters.TabIndex = 8
        Me.lbFilters.Text = "Filtros de búsqueda:"
        '
        'lbIDCard
        '
        Me.lbIDCard.AutoSize = True
        Me.lbIDCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.lbIDCard.Location = New System.Drawing.Point(13, 82)
        Me.lbIDCard.Name = "lbIDCard"
        Me.lbIDCard.Size = New System.Drawing.Size(72, 22)
        Me.lbIDCard.TabIndex = 9
        Me.lbIDCard.Text = "Cédula:"
        '
        'tbIDCard
        '
        Me.tbIDCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.tbIDCard.Location = New System.Drawing.Point(90, 82)
        Me.tbIDCard.Name = "tbIDCard"
        Me.tbIDCard.Size = New System.Drawing.Size(184, 28)
        Me.tbIDCard.TabIndex = 10
        '
        'lbLevel
        '
        Me.lbLevel.AutoSize = True
        Me.lbLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.lbLevel.Location = New System.Drawing.Point(290, 82)
        Me.lbLevel.Name = "lbLevel"
        Me.lbLevel.Size = New System.Drawing.Size(55, 22)
        Me.lbLevel.TabIndex = 11
        Me.lbLevel.Text = "Nivel:"
        '
        'cboxLevel
        '
        Me.cboxLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.cboxLevel.FormattingEnabled = True
        Me.cboxLevel.Location = New System.Drawing.Point(344, 82)
        Me.cboxLevel.Name = "cboxLevel"
        Me.cboxLevel.Size = New System.Drawing.Size(121, 30)
        Me.cboxLevel.TabIndex = 12
        '
        'cboxGender
        '
        Me.cboxGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.cboxGender.FormattingEnabled = True
        Me.cboxGender.Location = New System.Drawing.Point(554, 80)
        Me.cboxGender.Name = "cboxGender"
        Me.cboxGender.Size = New System.Drawing.Size(121, 30)
        Me.cboxGender.TabIndex = 14
        '
        'lbGender
        '
        Me.lbGender.AutoSize = True
        Me.lbGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.lbGender.Location = New System.Drawing.Point(479, 80)
        Me.lbGender.Name = "lbGender"
        Me.lbGender.Size = New System.Drawing.Size(75, 22)
        Me.lbGender.TabIndex = 13
        Me.lbGender.Text = "Género:"
        '
        'btnFilter
        '
        Me.btnFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.btnFilter.Location = New System.Drawing.Point(725, 80)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(127, 32)
        Me.btnFilter.TabIndex = 15
        Me.btnFilter.Text = "Filtrar"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'btnClearFilters
        '
        Me.btnClearFilters.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.btnClearFilters.Location = New System.Drawing.Point(725, 118)
        Me.btnClearFilters.Name = "btnClearFilters"
        Me.btnClearFilters.Size = New System.Drawing.Size(127, 32)
        Me.btnClearFilters.TabIndex = 16
        Me.btnClearFilters.Text = "Limpiar filtros"
        Me.btnClearFilters.UseVisualStyleBackColor = True
        '
        'lbCurrentFilter
        '
        Me.lbCurrentFilter.AutoSize = True
        Me.lbCurrentFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.lbCurrentFilter.Location = New System.Drawing.Point(13, 118)
        Me.lbCurrentFilter.Name = "lbCurrentFilter"
        Me.lbCurrentFilter.Size = New System.Drawing.Size(64, 22)
        Me.lbCurrentFilter.TabIndex = 17
        Me.lbCurrentFilter.Text = "Label1"
        '
        'frmMinorList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 676)
        Me.Controls.Add(Me.lbCurrentFilter)
        Me.Controls.Add(Me.btnClearFilters)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.cboxGender)
        Me.Controls.Add(Me.lbGender)
        Me.Controls.Add(Me.cboxLevel)
        Me.Controls.Add(Me.lbLevel)
        Me.Controls.Add(Me.tbIDCard)
        Me.Controls.Add(Me.lbIDCard)
        Me.Controls.Add(Me.lbFilters)
        Me.Controls.Add(Me.dgvMinors)
        Me.Controls.Add(Me.lbIndications)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMinorList"
        Me.ShowIcon = False
        Me.Text = "Lista de menores"
        CType(Me.dgvMinors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbIndications As Label
	Friend WithEvents dgvMinors As DataGridView
    Friend WithEvents lbFilters As Label
    Friend WithEvents lbIDCard As Label
    Friend WithEvents tbIDCard As TextBox
    Friend WithEvents lbLevel As Label
    Friend WithEvents cboxLevel As ComboBox
    Friend WithEvents cboxGender As ComboBox
    Friend WithEvents lbGender As Label
    Friend WithEvents btnFilter As Button
    Friend WithEvents btnClearFilters As Button
    Friend WithEvents lbCurrentFilter As Label
End Class
