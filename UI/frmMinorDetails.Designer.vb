<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMinorDetails
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
		Me.lbIndications = New System.Windows.Forms.Label()
		Me.txtCedulaMenor = New System.Windows.Forms.Label()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.lbNombreCompleto = New System.Windows.Forms.Label()
		Me.lbGenero = New System.Windows.Forms.Label()
		Me.lbFechaEgreso = New System.Windows.Forms.Label()
		Me.lbFechaIngreso = New System.Windows.Forms.Label()
		Me.lbFechaNacimiento = New System.Windows.Forms.Label()
		Me.lbResidencia = New System.Windows.Forms.Label()
		Me.lbEncargadoLegal = New System.Windows.Forms.Label()
		Me.txtNombreCompleto = New System.Windows.Forms.Label()
		Me.txtGenero = New System.Windows.Forms.Label()
		Me.txtFechaEgreso = New System.Windows.Forms.Label()
		Me.txtFechaIngreso = New System.Windows.Forms.Label()
		Me.txtFechaNacimiento = New System.Windows.Forms.Label()
		Me.txtResidencia = New System.Windows.Forms.Label()
		Me.txtEncargadoLegal = New System.Windows.Forms.Label()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'lbIndications
		'
		Me.lbIndications.AutoSize = True
		Me.lbIndications.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbIndications.Location = New System.Drawing.Point(11, 20)
		Me.lbIndications.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lbIndications.Name = "lbIndications"
		Me.lbIndications.Size = New System.Drawing.Size(177, 24)
		Me.lbIndications.TabIndex = 3
		Me.lbIndications.Text = "Detalles del menor: "
		'
		'txtCedulaMenor
		'
		Me.txtCedulaMenor.AutoSize = True
		Me.txtCedulaMenor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCedulaMenor.Location = New System.Drawing.Point(193, 24)
		Me.txtCedulaMenor.Name = "txtCedulaMenor"
		Me.txtCedulaMenor.Size = New System.Drawing.Size(59, 20)
		Me.txtCedulaMenor.TabIndex = 4
		Me.txtCedulaMenor.Text = "Cedula"
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.ColumnCount = 2
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666!))
		Me.TableLayoutPanel1.Controls.Add(Me.lbNombreCompleto, 0, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.lbGenero, 0, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.lbFechaEgreso, 0, 2)
		Me.TableLayoutPanel1.Controls.Add(Me.lbFechaIngreso, 0, 3)
		Me.TableLayoutPanel1.Controls.Add(Me.lbFechaNacimiento, 0, 4)
		Me.TableLayoutPanel1.Controls.Add(Me.lbResidencia, 0, 5)
		Me.TableLayoutPanel1.Controls.Add(Me.lbEncargadoLegal, 0, 6)
		Me.TableLayoutPanel1.Controls.Add(Me.txtNombreCompleto, 1, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.txtGenero, 1, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.txtFechaEgreso, 1, 2)
		Me.TableLayoutPanel1.Controls.Add(Me.txtFechaIngreso, 1, 3)
		Me.TableLayoutPanel1.Controls.Add(Me.txtFechaNacimiento, 1, 4)
		Me.TableLayoutPanel1.Controls.Add(Me.txtResidencia, 1, 5)
		Me.TableLayoutPanel1.Controls.Add(Me.txtEncargadoLegal, 1, 6)
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 73)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 7
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(587, 428)
		Me.TableLayoutPanel1.TabIndex = 5
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
		Me.lbGenero.Location = New System.Drawing.Point(3, 61)
		Me.lbGenero.Name = "lbGenero"
		Me.lbGenero.Size = New System.Drawing.Size(67, 20)
		Me.lbGenero.TabIndex = 1
		Me.lbGenero.Text = "Género:"
		'
		'lbFechaEgreso
		'
		Me.lbFechaEgreso.AutoSize = True
		Me.lbFechaEgreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbFechaEgreso.Location = New System.Drawing.Point(3, 122)
		Me.lbFechaEgreso.Name = "lbFechaEgreso"
		Me.lbFechaEgreso.Size = New System.Drawing.Size(113, 20)
		Me.lbFechaEgreso.TabIndex = 2
		Me.lbFechaEgreso.Text = "Fecha Egreso:"
		'
		'lbFechaIngreso
		'
		Me.lbFechaIngreso.AutoSize = True
		Me.lbFechaIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbFechaIngreso.Location = New System.Drawing.Point(3, 183)
		Me.lbFechaIngreso.Name = "lbFechaIngreso"
		Me.lbFechaIngreso.Size = New System.Drawing.Size(116, 20)
		Me.lbFechaIngreso.TabIndex = 3
		Me.lbFechaIngreso.Text = "Fecha Ingreso:"
		'
		'lbFechaNacimiento
		'
		Me.lbFechaNacimiento.AutoSize = True
		Me.lbFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbFechaNacimiento.Location = New System.Drawing.Point(3, 244)
		Me.lbFechaNacimiento.Name = "lbFechaNacimiento"
		Me.lbFechaNacimiento.Size = New System.Drawing.Size(141, 20)
		Me.lbFechaNacimiento.TabIndex = 4
		Me.lbFechaNacimiento.Text = "Fecha Nacimiento:"
		'
		'lbResidencia
		'
		Me.lbResidencia.AutoSize = True
		Me.lbResidencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbResidencia.Location = New System.Drawing.Point(3, 305)
		Me.lbResidencia.Name = "lbResidencia"
		Me.lbResidencia.Size = New System.Drawing.Size(92, 20)
		Me.lbResidencia.TabIndex = 5
		Me.lbResidencia.Text = "Residencia:"
		'
		'lbEncargadoLegal
		'
		Me.lbEncargadoLegal.AutoSize = True
		Me.lbEncargadoLegal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbEncargadoLegal.Location = New System.Drawing.Point(3, 366)
		Me.lbEncargadoLegal.Name = "lbEncargadoLegal"
		Me.lbEncargadoLegal.Size = New System.Drawing.Size(134, 20)
		Me.lbEncargadoLegal.TabIndex = 6
		Me.lbEncargadoLegal.Text = "Encargado Legal:"
		'
		'txtNombreCompleto
		'
		Me.txtNombreCompleto.AutoSize = True
		Me.txtNombreCompleto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtNombreCompleto.Location = New System.Drawing.Point(198, 0)
		Me.txtNombreCompleto.Name = "txtNombreCompleto"
		Me.txtNombreCompleto.Size = New System.Drawing.Size(65, 20)
		Me.txtNombreCompleto.TabIndex = 7
		Me.txtNombreCompleto.Text = "Nombre"
		'
		'txtGenero
		'
		Me.txtGenero.AutoSize = True
		Me.txtGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtGenero.Location = New System.Drawing.Point(198, 61)
		Me.txtGenero.Name = "txtGenero"
		Me.txtGenero.Size = New System.Drawing.Size(63, 20)
		Me.txtGenero.TabIndex = 8
		Me.txtGenero.Text = "Genero"
		'
		'txtFechaEgreso
		'
		Me.txtFechaEgreso.AutoSize = True
		Me.txtFechaEgreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtFechaEgreso.Location = New System.Drawing.Point(198, 122)
		Me.txtFechaEgreso.Name = "txtFechaEgreso"
		Me.txtFechaEgreso.Size = New System.Drawing.Size(109, 20)
		Me.txtFechaEgreso.TabIndex = 9
		Me.txtFechaEgreso.Text = "Fecha Egreso"
		'
		'txtFechaIngreso
		'
		Me.txtFechaIngreso.AutoSize = True
		Me.txtFechaIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtFechaIngreso.Location = New System.Drawing.Point(198, 183)
		Me.txtFechaIngreso.Name = "txtFechaIngreso"
		Me.txtFechaIngreso.Size = New System.Drawing.Size(110, 20)
		Me.txtFechaIngreso.TabIndex = 10
		Me.txtFechaIngreso.Text = "Fecha ingreso"
		'
		'txtFechaNacimiento
		'
		Me.txtFechaNacimiento.AutoSize = True
		Me.txtFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtFechaNacimiento.Location = New System.Drawing.Point(198, 244)
		Me.txtFechaNacimiento.Name = "txtFechaNacimiento"
		Me.txtFechaNacimiento.Size = New System.Drawing.Size(137, 20)
		Me.txtFechaNacimiento.TabIndex = 11
		Me.txtFechaNacimiento.Text = "Fecha Nacimiento"
		'
		'txtResidencia
		'
		Me.txtResidencia.AutoSize = True
		Me.txtResidencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtResidencia.Location = New System.Drawing.Point(198, 305)
		Me.txtResidencia.Name = "txtResidencia"
		Me.txtResidencia.Size = New System.Drawing.Size(88, 20)
		Me.txtResidencia.TabIndex = 12
		Me.txtResidencia.Text = "Residencia"
		'
		'txtEncargadoLegal
		'
		Me.txtEncargadoLegal.AutoSize = True
		Me.txtEncargadoLegal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtEncargadoLegal.Location = New System.Drawing.Point(198, 366)
		Me.txtEncargadoLegal.Name = "txtEncargadoLegal"
		Me.txtEncargadoLegal.Size = New System.Drawing.Size(87, 20)
		Me.txtEncargadoLegal.TabIndex = 13
		Me.txtEncargadoLegal.Text = "Encargado"
		'
		'frmMinorDetails
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(611, 513)
		Me.Controls.Add(Me.lbIndications)
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.Controls.Add(Me.txtCedulaMenor)
		Me.Name = "frmMinorDetails"
		Me.Text = "frmMinorDetails"
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.TableLayoutPanel1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents lbIndications As Label
	Friend WithEvents txtCedulaMenor As Label
	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
	Friend WithEvents lbNombreCompleto As Label
	Friend WithEvents lbGenero As Label
	Friend WithEvents lbFechaEgreso As Label
	Friend WithEvents lbFechaIngreso As Label
	Friend WithEvents lbFechaNacimiento As Label
	Friend WithEvents lbResidencia As Label
	Friend WithEvents lbEncargadoLegal As Label
	Friend WithEvents txtNombreCompleto As Label
	Friend WithEvents txtGenero As Label
	Friend WithEvents txtFechaEgreso As Label
	Friend WithEvents txtFechaIngreso As Label
	Friend WithEvents txtFechaNacimiento As Label
	Friend WithEvents txtResidencia As Label
	Friend WithEvents txtEncargadoLegal As Label
End Class
