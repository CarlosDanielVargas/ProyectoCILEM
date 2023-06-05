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
		Me.lbIndications = New System.Windows.Forms.Label()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.lbNombreCompleto = New System.Windows.Forms.Label()
		Me.lbGenero = New System.Windows.Forms.Label()
		Me.lbTelefono = New System.Windows.Forms.Label()
		Me.lbRelacion = New System.Windows.Forms.Label()
		Me.lbOcupacion = New System.Windows.Forms.Label()
		Me.lbResidencia = New System.Windows.Forms.Label()
		Me.lbLugarTrabajo = New System.Windows.Forms.Label()
		Me.txtNombre = New System.Windows.Forms.Label()
		Me.txtGenero = New System.Windows.Forms.Label()
		Me.txtTelefono = New System.Windows.Forms.Label()
		Me.txtRelacion = New System.Windows.Forms.Label()
		Me.txtOcupacion = New System.Windows.Forms.Label()
		Me.txtResidencia = New System.Windows.Forms.Label()
		Me.txtLugarTrabajo = New System.Windows.Forms.Label()
		Me.lbEstadoCivil = New System.Windows.Forms.Label()
		Me.lbCorreo = New System.Windows.Forms.Label()
		Me.txtEstadoCivil = New System.Windows.Forms.Label()
		Me.txtCorreoElectronico = New System.Windows.Forms.Label()
		Me.txtCedula = New System.Windows.Forms.Label()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'lbIndications
		'
		Me.lbIndications.AutoSize = True
		Me.lbIndications.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbIndications.Location = New System.Drawing.Point(8, 31)
		Me.lbIndications.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lbIndications.Name = "lbIndications"
		Me.lbIndications.Size = New System.Drawing.Size(213, 24)
		Me.lbIndications.TabIndex = 6
		Me.lbIndications.Text = "Detalles del encargado: "
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.ColumnCount = 2
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666!))
		Me.TableLayoutPanel1.Controls.Add(Me.lbNombreCompleto, 0, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.lbGenero, 0, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.lbTelefono, 0, 2)
		Me.TableLayoutPanel1.Controls.Add(Me.lbRelacion, 0, 3)
		Me.TableLayoutPanel1.Controls.Add(Me.lbOcupacion, 0, 4)
		Me.TableLayoutPanel1.Controls.Add(Me.lbResidencia, 0, 5)
		Me.TableLayoutPanel1.Controls.Add(Me.lbLugarTrabajo, 0, 6)
		Me.TableLayoutPanel1.Controls.Add(Me.txtNombre, 1, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.txtGenero, 1, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.txtTelefono, 1, 2)
		Me.TableLayoutPanel1.Controls.Add(Me.txtRelacion, 1, 3)
		Me.TableLayoutPanel1.Controls.Add(Me.txtOcupacion, 1, 4)
		Me.TableLayoutPanel1.Controls.Add(Me.txtResidencia, 1, 5)
		Me.TableLayoutPanel1.Controls.Add(Me.txtLugarTrabajo, 1, 6)
		Me.TableLayoutPanel1.Controls.Add(Me.lbEstadoCivil, 0, 7)
		Me.TableLayoutPanel1.Controls.Add(Me.lbCorreo, 0, 8)
		Me.TableLayoutPanel1.Controls.Add(Me.txtEstadoCivil, 1, 7)
		Me.TableLayoutPanel1.Controls.Add(Me.txtCorreoElectronico, 1, 8)
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 82)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 9
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.9991!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.9991!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.9991!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.9991!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.9991!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.9991!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.9991!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0021!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0021!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(591, 446)
		Me.TableLayoutPanel1.TabIndex = 8
		'
		'lbNombreCompleto
		'
		Me.lbNombreCompleto.AutoSize = True
		Me.lbNombreCompleto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbNombreCompleto.Location = New System.Drawing.Point(3, 0)
		Me.lbNombreCompleto.Name = "lbNombreCompleto"
		Me.lbNombreCompleto.Size = New System.Drawing.Size(141, 20)
		Me.lbNombreCompleto.TabIndex = 0
		Me.lbNombreCompleto.Text = "Nombre Completo:"
		'
		'lbGenero
		'
		Me.lbGenero.AutoSize = True
		Me.lbGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbGenero.Location = New System.Drawing.Point(3, 49)
		Me.lbGenero.Name = "lbGenero"
		Me.lbGenero.Size = New System.Drawing.Size(67, 20)
		Me.lbGenero.TabIndex = 1
		Me.lbGenero.Text = "Género:"
		'
		'lbTelefono
		'
		Me.lbTelefono.AutoSize = True
		Me.lbTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbTelefono.Location = New System.Drawing.Point(3, 98)
		Me.lbTelefono.Name = "lbTelefono"
		Me.lbTelefono.Size = New System.Drawing.Size(75, 20)
		Me.lbTelefono.TabIndex = 2
		Me.lbTelefono.Text = "Teléfono:"
		'
		'lbRelacion
		'
		Me.lbRelacion.AutoSize = True
		Me.lbRelacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbRelacion.Location = New System.Drawing.Point(3, 147)
		Me.lbRelacion.Name = "lbRelacion"
		Me.lbRelacion.Size = New System.Drawing.Size(75, 20)
		Me.lbRelacion.TabIndex = 3
		Me.lbRelacion.Text = "Relación:"
		'
		'lbOcupacion
		'
		Me.lbOcupacion.AutoSize = True
		Me.lbOcupacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbOcupacion.Location = New System.Drawing.Point(3, 196)
		Me.lbOcupacion.Name = "lbOcupacion"
		Me.lbOcupacion.Size = New System.Drawing.Size(89, 20)
		Me.lbOcupacion.TabIndex = 4
		Me.lbOcupacion.Text = "Ocupación:"
		'
		'lbResidencia
		'
		Me.lbResidencia.AutoSize = True
		Me.lbResidencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbResidencia.Location = New System.Drawing.Point(3, 245)
		Me.lbResidencia.Name = "lbResidencia"
		Me.lbResidencia.Size = New System.Drawing.Size(92, 20)
		Me.lbResidencia.TabIndex = 5
		Me.lbResidencia.Text = "Residencia:"
		'
		'lbLugarTrabajo
		'
		Me.lbLugarTrabajo.AutoSize = True
		Me.lbLugarTrabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbLugarTrabajo.Location = New System.Drawing.Point(3, 294)
		Me.lbLugarTrabajo.Name = "lbLugarTrabajo"
		Me.lbLugarTrabajo.Size = New System.Drawing.Size(129, 20)
		Me.lbLugarTrabajo.TabIndex = 6
		Me.lbLugarTrabajo.Text = "Lugar de trabajo:"
		'
		'txtNombre
		'
		Me.txtNombre.AutoSize = True
		Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtNombre.Location = New System.Drawing.Point(199, 0)
		Me.txtNombre.Name = "txtNombre"
		Me.txtNombre.Size = New System.Drawing.Size(65, 20)
		Me.txtNombre.TabIndex = 7
		Me.txtNombre.Text = "Nombre"
		'
		'txtGenero
		'
		Me.txtGenero.AutoSize = True
		Me.txtGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtGenero.Location = New System.Drawing.Point(199, 49)
		Me.txtGenero.Name = "txtGenero"
		Me.txtGenero.Size = New System.Drawing.Size(63, 20)
		Me.txtGenero.TabIndex = 8
		Me.txtGenero.Text = "Genero"
		'
		'txtTelefono
		'
		Me.txtTelefono.AutoSize = True
		Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTelefono.Location = New System.Drawing.Point(199, 98)
		Me.txtTelefono.Name = "txtTelefono"
		Me.txtTelefono.Size = New System.Drawing.Size(71, 20)
		Me.txtTelefono.TabIndex = 9
		Me.txtTelefono.Text = "Telefono"
		'
		'txtRelacion
		'
		Me.txtRelacion.AutoSize = True
		Me.txtRelacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtRelacion.Location = New System.Drawing.Point(199, 147)
		Me.txtRelacion.Name = "txtRelacion"
		Me.txtRelacion.Size = New System.Drawing.Size(110, 20)
		Me.txtRelacion.TabIndex = 10
		Me.txtRelacion.Text = "Fecha ingreso"
		'
		'txtOcupacion
		'
		Me.txtOcupacion.AutoSize = True
		Me.txtOcupacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtOcupacion.Location = New System.Drawing.Point(199, 196)
		Me.txtOcupacion.Name = "txtOcupacion"
		Me.txtOcupacion.Size = New System.Drawing.Size(85, 20)
		Me.txtOcupacion.TabIndex = 11
		Me.txtOcupacion.Text = "Ocupacion"
		'
		'txtResidencia
		'
		Me.txtResidencia.AutoSize = True
		Me.txtResidencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtResidencia.Location = New System.Drawing.Point(199, 245)
		Me.txtResidencia.Name = "txtResidencia"
		Me.txtResidencia.Size = New System.Drawing.Size(88, 20)
		Me.txtResidencia.TabIndex = 12
		Me.txtResidencia.Text = "Residencia"
		'
		'txtLugarTrabajo
		'
		Me.txtLugarTrabajo.AutoSize = True
		Me.txtLugarTrabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtLugarTrabajo.Location = New System.Drawing.Point(199, 294)
		Me.txtLugarTrabajo.Name = "txtLugarTrabajo"
		Me.txtLugarTrabajo.Size = New System.Drawing.Size(50, 20)
		Me.txtLugarTrabajo.TabIndex = 13
		Me.txtLugarTrabajo.Text = "Lugar"
		'
		'lbEstadoCivil
		'
		Me.lbEstadoCivil.AutoSize = True
		Me.lbEstadoCivil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbEstadoCivil.Location = New System.Drawing.Point(3, 343)
		Me.lbEstadoCivil.Name = "lbEstadoCivil"
		Me.lbEstadoCivil.Size = New System.Drawing.Size(95, 20)
		Me.lbEstadoCivil.TabIndex = 14
		Me.lbEstadoCivil.Text = "Estado Civil:"
		'
		'lbCorreo
		'
		Me.lbCorreo.AutoSize = True
		Me.lbCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbCorreo.Location = New System.Drawing.Point(3, 392)
		Me.lbCorreo.Name = "lbCorreo"
		Me.lbCorreo.Size = New System.Drawing.Size(144, 20)
		Me.lbCorreo.TabIndex = 15
		Me.lbCorreo.Text = "Correo Electrónico:"
		'
		'txtEstadoCivil
		'
		Me.txtEstadoCivil.AutoSize = True
		Me.txtEstadoCivil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtEstadoCivil.Location = New System.Drawing.Point(199, 343)
		Me.txtEstadoCivil.Name = "txtEstadoCivil"
		Me.txtEstadoCivil.Size = New System.Drawing.Size(60, 20)
		Me.txtEstadoCivil.TabIndex = 17
		Me.txtEstadoCivil.Text = "Estado"
		'
		'txtCorreoElectronico
		'
		Me.txtCorreoElectronico.AutoSize = True
		Me.txtCorreoElectronico.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCorreoElectronico.Location = New System.Drawing.Point(199, 392)
		Me.txtCorreoElectronico.Name = "txtCorreoElectronico"
		Me.txtCorreoElectronico.Size = New System.Drawing.Size(57, 20)
		Me.txtCorreoElectronico.TabIndex = 18
		Me.txtCorreoElectronico.Text = "Correo"
		'
		'txtCedula
		'
		Me.txtCedula.AutoSize = True
		Me.txtCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCedula.Location = New System.Drawing.Point(233, 35)
		Me.txtCedula.Name = "txtCedula"
		Me.txtCedula.Size = New System.Drawing.Size(59, 20)
		Me.txtCedula.TabIndex = 7
		Me.txtCedula.Text = "Cedula"
		'
		'frmRepresentativeDetails
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(615, 540)
		Me.Controls.Add(Me.lbIndications)
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.Controls.Add(Me.txtCedula)
		Me.Name = "frmRepresentativeDetails"
		Me.Text = "frmRepresentativeDetails"
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.TableLayoutPanel1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lbIndications As Label
	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
	Friend WithEvents lbNombreCompleto As Label
	Friend WithEvents lbGenero As Label
	Friend WithEvents lbTelefono As Label
	Friend WithEvents lbRelacion As Label
	Friend WithEvents lbOcupacion As Label
	Friend WithEvents lbResidencia As Label
	Friend WithEvents lbLugarTrabajo As Label
	Friend WithEvents txtNombre As Label
	Friend WithEvents txtGenero As Label
	Friend WithEvents txtTelefono As Label
	Friend WithEvents txtRelacion As Label
	Friend WithEvents txtOcupacion As Label
	Friend WithEvents txtResidencia As Label
	Friend WithEvents txtLugarTrabajo As Label
	Friend WithEvents txtCedula As Label
	Friend WithEvents lbEstadoCivil As Label
	Friend WithEvents lbCorreo As Label
	Friend WithEvents txtEstadoCivil As Label
	Friend WithEvents txtCorreoElectronico As Label
End Class
