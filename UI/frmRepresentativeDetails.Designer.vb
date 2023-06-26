<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRepresentativeDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRepresentativeDetails))
        Me.lbIndications = New System.Windows.Forms.Label()
        Me.tbLPnlRepresentative = New System.Windows.Forms.TableLayoutPanel()
        Me.lbNombreCompleto = New System.Windows.Forms.Label()
        Me.lbGenero = New System.Windows.Forms.Label()
        Me.lbTelefono = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.Label()
        Me.txtGenero = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.Label()
        Me.lbOcupacion = New System.Windows.Forms.Label()
        Me.txtOcupacion = New System.Windows.Forms.Label()
        Me.txtResidencia = New System.Windows.Forms.Label()
        Me.lbResidencia = New System.Windows.Forms.Label()
        Me.lbLugarTrabajo = New System.Windows.Forms.Label()
        Me.txtLugarTrabajo = New System.Windows.Forms.Label()
        Me.lbEstadoCivil = New System.Windows.Forms.Label()
        Me.txtEstadoCivil = New System.Windows.Forms.Label()
        Me.lbCorreo = New System.Windows.Forms.Label()
        Me.txtCorreoElectronico = New System.Windows.Forms.Label()
        Me.txtCedula = New System.Windows.Forms.Label()
        Me.lbMinors = New System.Windows.Forms.Label()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.dgvMinors = New System.Windows.Forms.DataGridView()
        Me.tbLPnlRepresentative.SuspendLayout()
        CType(Me.dgvMinors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbIndications
        '
        Me.lbIndications.AutoSize = True
        Me.lbIndications.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIndications.Location = New System.Drawing.Point(11, 38)
        Me.lbIndications.Name = "lbIndications"
        Me.lbIndications.Size = New System.Drawing.Size(274, 29)
        Me.lbIndications.TabIndex = 6
        Me.lbIndications.Text = "Detalles del encargado: "
        '
        'tbLPnlRepresentative
        '
        Me.tbLPnlRepresentative.ColumnCount = 2
        Me.tbLPnlRepresentative.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tbLPnlRepresentative.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666!))
        Me.tbLPnlRepresentative.Controls.Add(Me.lbNombreCompleto, 0, 0)
        Me.tbLPnlRepresentative.Controls.Add(Me.lbGenero, 0, 1)
        Me.tbLPnlRepresentative.Controls.Add(Me.lbTelefono, 0, 2)
        Me.tbLPnlRepresentative.Controls.Add(Me.txtNombre, 1, 0)
        Me.tbLPnlRepresentative.Controls.Add(Me.txtGenero, 1, 1)
        Me.tbLPnlRepresentative.Controls.Add(Me.txtTelefono, 1, 2)
        Me.tbLPnlRepresentative.Controls.Add(Me.lbOcupacion, 0, 3)
        Me.tbLPnlRepresentative.Controls.Add(Me.txtOcupacion, 1, 3)
        Me.tbLPnlRepresentative.Controls.Add(Me.txtResidencia, 1, 4)
        Me.tbLPnlRepresentative.Controls.Add(Me.lbResidencia, 0, 4)
        Me.tbLPnlRepresentative.Controls.Add(Me.lbLugarTrabajo, 0, 5)
        Me.tbLPnlRepresentative.Controls.Add(Me.txtLugarTrabajo, 1, 5)
        Me.tbLPnlRepresentative.Controls.Add(Me.lbEstadoCivil, 0, 6)
        Me.tbLPnlRepresentative.Controls.Add(Me.txtEstadoCivil, 1, 6)
        Me.tbLPnlRepresentative.Controls.Add(Me.lbCorreo, 0, 7)
        Me.tbLPnlRepresentative.Controls.Add(Me.txtCorreoElectronico, 1, 7)
        Me.tbLPnlRepresentative.Location = New System.Drawing.Point(16, 101)
        Me.tbLPnlRepresentative.Margin = New System.Windows.Forms.Padding(4)
        Me.tbLPnlRepresentative.Name = "tbLPnlRepresentative"
        Me.tbLPnlRepresentative.RowCount = 8
        Me.tbLPnlRepresentative.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.9991!))
        Me.tbLPnlRepresentative.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.9991!))
        Me.tbLPnlRepresentative.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.9991!))
        Me.tbLPnlRepresentative.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.9991!))
        Me.tbLPnlRepresentative.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.9991!))
        Me.tbLPnlRepresentative.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.9991!))
        Me.tbLPnlRepresentative.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.9991!))
        Me.tbLPnlRepresentative.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0021!))
        Me.tbLPnlRepresentative.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0021!))
        Me.tbLPnlRepresentative.Size = New System.Drawing.Size(763, 283)
        Me.tbLPnlRepresentative.TabIndex = 8
        '
        'lbNombreCompleto
        '
        Me.lbNombreCompleto.AutoSize = True
        Me.lbNombreCompleto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNombreCompleto.Location = New System.Drawing.Point(4, 0)
        Me.lbNombreCompleto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbNombreCompleto.Name = "lbNombreCompleto"
        Me.lbNombreCompleto.Size = New System.Drawing.Size(176, 25)
        Me.lbNombreCompleto.TabIndex = 0
        Me.lbNombreCompleto.Text = "Nombre Completo:"
        '
        'lbGenero
        '
        Me.lbGenero.AutoSize = True
        Me.lbGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbGenero.Location = New System.Drawing.Point(4, 35)
        Me.lbGenero.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbGenero.Name = "lbGenero"
        Me.lbGenero.Size = New System.Drawing.Size(83, 25)
        Me.lbGenero.TabIndex = 1
        Me.lbGenero.Text = "Género:"
        '
        'lbTelefono
        '
        Me.lbTelefono.AutoSize = True
        Me.lbTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTelefono.Location = New System.Drawing.Point(4, 70)
        Me.lbTelefono.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTelefono.Name = "lbTelefono"
        Me.lbTelefono.Size = New System.Drawing.Size(95, 25)
        Me.lbTelefono.TabIndex = 2
        Me.lbTelefono.Text = "Teléfono:"
        '
        'txtNombre
        '
        Me.txtNombre.AutoSize = True
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(258, 0)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(81, 25)
        Me.txtNombre.TabIndex = 7
        Me.txtNombre.Text = "Nombre"
        '
        'txtGenero
        '
        Me.txtGenero.AutoSize = True
        Me.txtGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGenero.Location = New System.Drawing.Point(258, 35)
        Me.txtGenero.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtGenero.Name = "txtGenero"
        Me.txtGenero.Size = New System.Drawing.Size(77, 25)
        Me.txtGenero.TabIndex = 8
        Me.txtGenero.Text = "Genero"
        '
        'txtTelefono
        '
        Me.txtTelefono.AutoSize = True
        Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(258, 70)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(89, 25)
        Me.txtTelefono.TabIndex = 9
        Me.txtTelefono.Text = "Telefono"
        '
        'lbOcupacion
        '
        Me.lbOcupacion.AutoSize = True
        Me.lbOcupacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbOcupacion.Location = New System.Drawing.Point(4, 105)
        Me.lbOcupacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbOcupacion.Name = "lbOcupacion"
        Me.lbOcupacion.Size = New System.Drawing.Size(113, 25)
        Me.lbOcupacion.TabIndex = 4
        Me.lbOcupacion.Text = "Ocupación:"
        '
        'txtOcupacion
        '
        Me.txtOcupacion.AutoSize = True
        Me.txtOcupacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOcupacion.Location = New System.Drawing.Point(258, 105)
        Me.txtOcupacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtOcupacion.Name = "txtOcupacion"
        Me.txtOcupacion.Size = New System.Drawing.Size(107, 25)
        Me.txtOcupacion.TabIndex = 11
        Me.txtOcupacion.Text = "Ocupacion"
        '
        'txtResidencia
        '
        Me.txtResidencia.AutoSize = True
        Me.txtResidencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResidencia.Location = New System.Drawing.Point(258, 140)
        Me.txtResidencia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtResidencia.Name = "txtResidencia"
        Me.txtResidencia.Size = New System.Drawing.Size(108, 25)
        Me.txtResidencia.TabIndex = 10
        Me.txtResidencia.Text = "Residencia"
        '
        'lbResidencia
        '
        Me.lbResidencia.AutoSize = True
        Me.lbResidencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbResidencia.Location = New System.Drawing.Point(4, 140)
        Me.lbResidencia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbResidencia.Name = "lbResidencia"
        Me.lbResidencia.Size = New System.Drawing.Size(114, 25)
        Me.lbResidencia.TabIndex = 5
        Me.lbResidencia.Text = "Residencia:"
        '
        'lbLugarTrabajo
        '
        Me.lbLugarTrabajo.AutoSize = True
        Me.lbLugarTrabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLugarTrabajo.Location = New System.Drawing.Point(4, 175)
        Me.lbLugarTrabajo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbLugarTrabajo.Name = "lbLugarTrabajo"
        Me.lbLugarTrabajo.Size = New System.Drawing.Size(159, 25)
        Me.lbLugarTrabajo.TabIndex = 6
        Me.lbLugarTrabajo.Text = "Lugar de trabajo:"
        '
        'txtLugarTrabajo
        '
        Me.txtLugarTrabajo.AutoSize = True
        Me.txtLugarTrabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLugarTrabajo.Location = New System.Drawing.Point(258, 175)
        Me.txtLugarTrabajo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtLugarTrabajo.Name = "txtLugarTrabajo"
        Me.txtLugarTrabajo.Size = New System.Drawing.Size(62, 25)
        Me.txtLugarTrabajo.TabIndex = 13
        Me.txtLugarTrabajo.Text = "Lugar"
        '
        'lbEstadoCivil
        '
        Me.lbEstadoCivil.AutoSize = True
        Me.lbEstadoCivil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEstadoCivil.Location = New System.Drawing.Point(4, 210)
        Me.lbEstadoCivil.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbEstadoCivil.Name = "lbEstadoCivil"
        Me.lbEstadoCivil.Size = New System.Drawing.Size(121, 25)
        Me.lbEstadoCivil.TabIndex = 14
        Me.lbEstadoCivil.Text = "Estado Civil:"
        '
        'txtEstadoCivil
        '
        Me.txtEstadoCivil.AutoSize = True
        Me.txtEstadoCivil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstadoCivil.Location = New System.Drawing.Point(258, 210)
        Me.txtEstadoCivil.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtEstadoCivil.Name = "txtEstadoCivil"
        Me.txtEstadoCivil.Size = New System.Drawing.Size(73, 25)
        Me.txtEstadoCivil.TabIndex = 17
        Me.txtEstadoCivil.Text = "Estado"
        '
        'lbCorreo
        '
        Me.lbCorreo.AutoSize = True
        Me.lbCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCorreo.Location = New System.Drawing.Point(4, 245)
        Me.lbCorreo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbCorreo.Name = "lbCorreo"
        Me.lbCorreo.Size = New System.Drawing.Size(179, 25)
        Me.lbCorreo.TabIndex = 15
        Me.lbCorreo.Text = "Correo Electrónico:"
        '
        'txtCorreoElectronico
        '
        Me.txtCorreoElectronico.AutoSize = True
        Me.txtCorreoElectronico.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreoElectronico.Location = New System.Drawing.Point(258, 245)
        Me.txtCorreoElectronico.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtCorreoElectronico.Name = "txtCorreoElectronico"
        Me.txtCorreoElectronico.Size = New System.Drawing.Size(72, 25)
        Me.txtCorreoElectronico.TabIndex = 18
        Me.txtCorreoElectronico.Text = "Correo"
        '
        'txtCedula
        '
        Me.txtCedula.AutoSize = True
        Me.txtCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedula.Location = New System.Drawing.Point(311, 43)
        Me.txtCedula.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(75, 25)
        Me.txtCedula.TabIndex = 7
        Me.txtCedula.Text = "Cedula"
        '
        'lbMinors
        '
        Me.lbMinors.AutoSize = True
        Me.lbMinors.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbMinors.Location = New System.Drawing.Point(20, 401)
        Me.lbMinors.Name = "lbMinors"
        Me.lbMinors.Size = New System.Drawing.Size(507, 25)
        Me.lbMinors.TabIndex = 9
        Me.lbMinors.Text = "Menores asociados y relación que tiene el representante:"
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.ForeColor = System.Drawing.Color.White
        Me.btnExport.Location = New System.Drawing.Point(536, 36)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(243, 35)
        Me.btnExport.TabIndex = 30
        Me.btnExport.Text = "Descargar informe"
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'dgvMinors
        '
        Me.dgvMinors.AllowUserToAddRows = False
        Me.dgvMinors.AllowUserToDeleteRows = False
        Me.dgvMinors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMinors.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvMinors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMinors.Location = New System.Drawing.Point(12, 429)
        Me.dgvMinors.Name = "dgvMinors"
        Me.dgvMinors.ReadOnly = True
        Me.dgvMinors.RowHeadersWidth = 51
        Me.dgvMinors.RowTemplate.Height = 24
        Me.dgvMinors.Size = New System.Drawing.Size(767, 221)
        Me.dgvMinors.TabIndex = 31
        '
        'frmRepresentativeDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(796, 665)
        Me.Controls.Add(Me.dgvMinors)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.lbMinors)
        Me.Controls.Add(Me.lbIndications)
        Me.Controls.Add(Me.tbLPnlRepresentative)
        Me.Controls.Add(Me.txtCedula)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRepresentativeDetails"
        Me.Text = "Detalles de representante legal"
        Me.tbLPnlRepresentative.ResumeLayout(False)
        Me.tbLPnlRepresentative.PerformLayout()
        CType(Me.dgvMinors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbIndications As Label
	Friend WithEvents tbLPnlRepresentative As TableLayoutPanel
	Friend WithEvents lbNombreCompleto As Label
	Friend WithEvents lbGenero As Label
	Friend WithEvents lbTelefono As Label
    Friend WithEvents lbOcupacion As Label
    Friend WithEvents lbResidencia As Label
    Friend WithEvents lbLugarTrabajo As Label
    Friend WithEvents txtNombre As Label
    Friend WithEvents txtGenero As Label
    Friend WithEvents txtTelefono As Label
    Friend WithEvents txtResidencia As Label
    Friend WithEvents txtOcupacion As Label
    Friend WithEvents txtLugarTrabajo As Label
    Friend WithEvents txtCedula As Label
	Friend WithEvents lbEstadoCivil As Label
	Friend WithEvents lbCorreo As Label
	Friend WithEvents txtEstadoCivil As Label
	Friend WithEvents txtCorreoElectronico As Label
    Friend WithEvents lbMinors As Label
    Friend WithEvents btnExport As Button
    Friend WithEvents dgvMinors As DataGridView
End Class
