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
        Me.lbIndications = New System.Windows.Forms.Label()
        Me.dgvRepresentatives = New System.Windows.Forms.DataGridView()
        Me.lbCurrentFilter = New System.Windows.Forms.Label()
        Me.btnClearFilters = New System.Windows.Forms.Button()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.cboxGender = New System.Windows.Forms.ComboBox()
        Me.lbGender = New System.Windows.Forms.Label()
        Me.cboxMaritalStatus = New System.Windows.Forms.ComboBox()
        Me.lbLevel = New System.Windows.Forms.Label()
        Me.tbIDCard = New System.Windows.Forms.TextBox()
        Me.lbIDCard = New System.Windows.Forms.Label()
        Me.lbFilters = New System.Windows.Forms.Label()
        CType(Me.dgvRepresentatives, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbIndications
        '
        Me.lbIndications.AutoSize = True
        Me.lbIndications.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIndications.Location = New System.Drawing.Point(233, 11)
        Me.lbIndications.Name = "lbIndications"
        Me.lbIndications.Size = New System.Drawing.Size(397, 29)
        Me.lbIndications.TabIndex = 7
        Me.lbIndications.Text = "Lista de representantes registrados "
        '
        'dgvRepresentatives
        '
        Me.dgvRepresentatives.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRepresentatives.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRepresentatives.Location = New System.Drawing.Point(12, 179)
        Me.dgvRepresentatives.Name = "dgvRepresentatives"
        Me.dgvRepresentatives.RowHeadersWidth = 51
        Me.dgvRepresentatives.RowTemplate.Height = 24
        Me.dgvRepresentatives.Size = New System.Drawing.Size(853, 497)
        Me.dgvRepresentatives.TabIndex = 8
        '
        'lbCurrentFilter
        '
        Me.lbCurrentFilter.AutoSize = True
        Me.lbCurrentFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.lbCurrentFilter.Location = New System.Drawing.Point(19, 131)
        Me.lbCurrentFilter.Name = "lbCurrentFilter"
        Me.lbCurrentFilter.Size = New System.Drawing.Size(64, 22)
        Me.lbCurrentFilter.TabIndex = 27
        Me.lbCurrentFilter.Text = "Label1"
        '
        'btnClearFilters
        '
        Me.btnClearFilters.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.btnClearFilters.Location = New System.Drawing.Point(731, 131)
        Me.btnClearFilters.Name = "btnClearFilters"
        Me.btnClearFilters.Size = New System.Drawing.Size(127, 32)
        Me.btnClearFilters.TabIndex = 26
        Me.btnClearFilters.Text = "Limpiar filtros"
        Me.btnClearFilters.UseVisualStyleBackColor = True
        '
        'btnFilter
        '
        Me.btnFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.btnFilter.Location = New System.Drawing.Point(731, 93)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(127, 32)
        Me.btnFilter.TabIndex = 25
        Me.btnFilter.Text = "Filtrar"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'cboxGender
        '
        Me.cboxGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.cboxGender.FormattingEnabled = True
        Me.cboxGender.Location = New System.Drawing.Point(586, 93)
        Me.cboxGender.Name = "cboxGender"
        Me.cboxGender.Size = New System.Drawing.Size(121, 30)
        Me.cboxGender.TabIndex = 24
        '
        'lbGender
        '
        Me.lbGender.AutoSize = True
        Me.lbGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.lbGender.Location = New System.Drawing.Point(505, 95)
        Me.lbGender.Name = "lbGender"
        Me.lbGender.Size = New System.Drawing.Size(75, 22)
        Me.lbGender.TabIndex = 23
        Me.lbGender.Text = "Género:"
        '
        'cboxMaritalStatus
        '
        Me.cboxMaritalStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.cboxMaritalStatus.FormattingEnabled = True
        Me.cboxMaritalStatus.Location = New System.Drawing.Point(371, 95)
        Me.cboxMaritalStatus.Name = "cboxMaritalStatus"
        Me.cboxMaritalStatus.Size = New System.Drawing.Size(121, 30)
        Me.cboxMaritalStatus.TabIndex = 22
        '
        'lbLevel
        '
        Me.lbLevel.AutoSize = True
        Me.lbLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.lbLevel.Location = New System.Drawing.Point(259, 95)
        Me.lbLevel.Name = "lbLevel"
        Me.lbLevel.Size = New System.Drawing.Size(106, 22)
        Me.lbLevel.TabIndex = 21
        Me.lbLevel.Text = "Estado civil:"
        '
        'tbIDCard
        '
        Me.tbIDCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.tbIDCard.Location = New System.Drawing.Point(96, 95)
        Me.tbIDCard.Name = "tbIDCard"
        Me.tbIDCard.Size = New System.Drawing.Size(146, 28)
        Me.tbIDCard.TabIndex = 20
        '
        'lbIDCard
        '
        Me.lbIDCard.AutoSize = True
        Me.lbIDCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.lbIDCard.Location = New System.Drawing.Point(19, 95)
        Me.lbIDCard.Name = "lbIDCard"
        Me.lbIDCard.Size = New System.Drawing.Size(72, 22)
        Me.lbIDCard.TabIndex = 19
        Me.lbIDCard.Text = "Cédula:"
        '
        'lbFilters
        '
        Me.lbFilters.AutoSize = True
        Me.lbFilters.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lbFilters.Location = New System.Drawing.Point(18, 65)
        Me.lbFilters.Name = "lbFilters"
        Me.lbFilters.Size = New System.Drawing.Size(182, 24)
        Me.lbFilters.TabIndex = 18
        Me.lbFilters.Text = "Filtros de búsqueda:"
        '
        'frmRepresentativeList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 688)
        Me.Controls.Add(Me.lbCurrentFilter)
        Me.Controls.Add(Me.btnClearFilters)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.cboxGender)
        Me.Controls.Add(Me.lbGender)
        Me.Controls.Add(Me.cboxMaritalStatus)
        Me.Controls.Add(Me.lbLevel)
        Me.Controls.Add(Me.tbIDCard)
        Me.Controls.Add(Me.lbIDCard)
        Me.Controls.Add(Me.lbFilters)
        Me.Controls.Add(Me.dgvRepresentatives)
        Me.Controls.Add(Me.lbIndications)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmRepresentativeList"
        Me.Text = "Lista de representantes"
        CType(Me.dgvRepresentatives, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbIndications As Label
    Friend WithEvents dgvRepresentatives As DataGridView
    Friend WithEvents lbCurrentFilter As Label
    Friend WithEvents btnClearFilters As Button
    Friend WithEvents btnFilter As Button
    Friend WithEvents cboxGender As ComboBox
    Friend WithEvents lbGender As Label
    Friend WithEvents cboxMaritalStatus As ComboBox
    Friend WithEvents lbLevel As Label
    Friend WithEvents tbIDCard As TextBox
    Friend WithEvents lbIDCard As Label
    Friend WithEvents lbFilters As Label
End Class
