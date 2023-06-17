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
        Me.lbBeca = New System.Windows.Forms.Label()
        Me.txtBeca = New System.Windows.Forms.Label()
        Me.lbNivel = New System.Windows.Forms.Label()
        Me.txtNivel = New System.Windows.Forms.Label()
        Me.lbResidencia = New System.Windows.Forms.Label()
        Me.txtResidencia = New System.Windows.Forms.Label()
        Me.txtFechaNacimiento = New System.Windows.Forms.Label()
        Me.txtFechaIngreso = New System.Windows.Forms.Label()
        Me.txtFechaEgreso = New System.Windows.Forms.Label()
        Me.txtGenero = New System.Windows.Forms.Label()
        Me.txtNombreCompleto = New System.Windows.Forms.Label()
        Me.lbFechaNacimiento = New System.Windows.Forms.Label()
        Me.lbFechaIngreso = New System.Windows.Forms.Label()
        Me.lbFechaEgreso = New System.Windows.Forms.Label()
        Me.lbGenero = New System.Windows.Forms.Label()
        Me.lbNombreCompleto = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtPago = New System.Windows.Forms.Label()
        Me.lbPago = New System.Windows.Forms.Label()
        Me.lbRepresentatives = New System.Windows.Forms.Label()
        Me.lboxRepresentatives = New System.Windows.Forms.ListBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbIndications
        '
        Me.lbIndications.AutoSize = True
        Me.lbIndications.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIndications.Location = New System.Drawing.Point(15, 25)
        Me.lbIndications.Name = "lbIndications"
        Me.lbIndications.Size = New System.Drawing.Size(228, 29)
        Me.lbIndications.TabIndex = 3
        Me.lbIndications.Text = "Detalles del menor: "
        '
        'txtCedulaMenor
        '
        Me.txtCedulaMenor.AutoSize = True
        Me.txtCedulaMenor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedulaMenor.Location = New System.Drawing.Point(257, 30)
        Me.txtCedulaMenor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtCedulaMenor.Name = "txtCedulaMenor"
        Me.txtCedulaMenor.Size = New System.Drawing.Size(75, 25)
        Me.txtCedulaMenor.TabIndex = 4
        Me.txtCedulaMenor.Text = "Cedula"
        '
        'lbBeca
        '
        Me.lbBeca.AutoSize = True
        Me.lbBeca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBeca.Location = New System.Drawing.Point(629, 60)
        Me.lbBeca.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbBeca.Name = "lbBeca"
        Me.lbBeca.Size = New System.Drawing.Size(145, 25)
        Me.lbBeca.TabIndex = 22
        Me.lbBeca.Text = "¿Posee beca?:"
        '
        'txtBeca
        '
        Me.txtBeca.AutoSize = True
        Me.txtBeca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBeca.Location = New System.Drawing.Point(791, 60)
        Me.txtBeca.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtBeca.Name = "txtBeca"
        Me.txtBeca.Size = New System.Drawing.Size(57, 25)
        Me.txtBeca.TabIndex = 21
        Me.txtBeca.Text = "Beca"
        '
        'lbNivel
        '
        Me.lbNivel.AutoSize = True
        Me.lbNivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNivel.Location = New System.Drawing.Point(629, 30)
        Me.lbNivel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbNivel.Name = "lbNivel"
        Me.lbNivel.Size = New System.Drawing.Size(61, 25)
        Me.lbNivel.TabIndex = 20
        Me.lbNivel.Text = "Nivel:"
        '
        'txtNivel
        '
        Me.txtNivel.AutoSize = True
        Me.txtNivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNivel.Location = New System.Drawing.Point(791, 30)
        Me.txtNivel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtNivel.Name = "txtNivel"
        Me.txtNivel.Size = New System.Drawing.Size(55, 25)
        Me.txtNivel.TabIndex = 19
        Me.txtNivel.Text = "Nivel"
        '
        'lbResidencia
        '
        Me.lbResidencia.AutoSize = True
        Me.lbResidencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbResidencia.Location = New System.Drawing.Point(629, 0)
        Me.lbResidencia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbResidencia.Name = "lbResidencia"
        Me.lbResidencia.Size = New System.Drawing.Size(114, 25)
        Me.lbResidencia.TabIndex = 17
        Me.lbResidencia.Text = "Residencia:"
        '
        'txtResidencia
        '
        Me.txtResidencia.AutoSize = True
        Me.txtResidencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResidencia.Location = New System.Drawing.Point(791, 0)
        Me.txtResidencia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtResidencia.Name = "txtResidencia"
        Me.txtResidencia.Size = New System.Drawing.Size(108, 25)
        Me.txtResidencia.TabIndex = 18
        Me.txtResidencia.Text = "Residencia"
        '
        'txtFechaNacimiento
        '
        Me.txtFechaNacimiento.AutoSize = True
        Me.txtFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaNacimiento.Location = New System.Drawing.Point(200, 120)
        Me.txtFechaNacimiento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtFechaNacimiento.Name = "txtFechaNacimiento"
        Me.txtFechaNacimiento.Size = New System.Drawing.Size(169, 25)
        Me.txtFechaNacimiento.TabIndex = 11
        Me.txtFechaNacimiento.Text = "Fecha Nacimiento"
        '
        'txtFechaIngreso
        '
        Me.txtFechaIngreso.AutoSize = True
        Me.txtFechaIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaIngreso.Location = New System.Drawing.Point(200, 90)
        Me.txtFechaIngreso.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtFechaIngreso.Name = "txtFechaIngreso"
        Me.txtFechaIngreso.Size = New System.Drawing.Size(136, 25)
        Me.txtFechaIngreso.TabIndex = 10
        Me.txtFechaIngreso.Text = "Fecha ingreso"
        '
        'txtFechaEgreso
        '
        Me.txtFechaEgreso.AutoSize = True
        Me.txtFechaEgreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaEgreso.Location = New System.Drawing.Point(200, 60)
        Me.txtFechaEgreso.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtFechaEgreso.Name = "txtFechaEgreso"
        Me.txtFechaEgreso.Size = New System.Drawing.Size(134, 25)
        Me.txtFechaEgreso.TabIndex = 9
        Me.txtFechaEgreso.Text = "Fecha Egreso"
        '
        'txtGenero
        '
        Me.txtGenero.AutoSize = True
        Me.txtGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGenero.Location = New System.Drawing.Point(200, 30)
        Me.txtGenero.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtGenero.Name = "txtGenero"
        Me.txtGenero.Size = New System.Drawing.Size(77, 25)
        Me.txtGenero.TabIndex = 8
        Me.txtGenero.Text = "Genero"
        '
        'txtNombreCompleto
        '
        Me.txtNombreCompleto.AutoSize = True
        Me.txtNombreCompleto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCompleto.Location = New System.Drawing.Point(200, 0)
        Me.txtNombreCompleto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtNombreCompleto.Name = "txtNombreCompleto"
        Me.txtNombreCompleto.Size = New System.Drawing.Size(81, 25)
        Me.txtNombreCompleto.TabIndex = 7
        Me.txtNombreCompleto.Text = "Nombre"
        '
        'lbFechaNacimiento
        '
        Me.lbFechaNacimiento.AutoSize = True
        Me.lbFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFechaNacimiento.Location = New System.Drawing.Point(4, 120)
        Me.lbFechaNacimiento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbFechaNacimiento.Name = "lbFechaNacimiento"
        Me.lbFechaNacimiento.Size = New System.Drawing.Size(175, 25)
        Me.lbFechaNacimiento.TabIndex = 4
        Me.lbFechaNacimiento.Text = "Fecha Nacimiento:"
        '
        'lbFechaIngreso
        '
        Me.lbFechaIngreso.AutoSize = True
        Me.lbFechaIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFechaIngreso.Location = New System.Drawing.Point(4, 90)
        Me.lbFechaIngreso.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbFechaIngreso.Name = "lbFechaIngreso"
        Me.lbFechaIngreso.Size = New System.Drawing.Size(143, 25)
        Me.lbFechaIngreso.TabIndex = 3
        Me.lbFechaIngreso.Text = "Fecha Ingreso:"
        '
        'lbFechaEgreso
        '
        Me.lbFechaEgreso.AutoSize = True
        Me.lbFechaEgreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFechaEgreso.Location = New System.Drawing.Point(4, 60)
        Me.lbFechaEgreso.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbFechaEgreso.Name = "lbFechaEgreso"
        Me.lbFechaEgreso.Size = New System.Drawing.Size(140, 25)
        Me.lbFechaEgreso.TabIndex = 2
        Me.lbFechaEgreso.Text = "Fecha Egreso:"
        '
        'lbGenero
        '
        Me.lbGenero.AutoSize = True
        Me.lbGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbGenero.Location = New System.Drawing.Point(4, 30)
        Me.lbGenero.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbGenero.Name = "lbGenero"
        Me.lbGenero.Size = New System.Drawing.Size(83, 25)
        Me.lbGenero.TabIndex = 1
        Me.lbGenero.Text = "Género:"
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.46067!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.53933!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 246.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtPago, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lbPago, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtBeca, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lbNombreCompleto, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbGenero, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtNivel, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbNivel, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbFechaEgreso, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lbFechaIngreso, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtResidencia, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbResidencia, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbFechaNacimiento, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtNombreCompleto, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtGenero, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtFechaEgreso, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtFechaIngreso, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtFechaNacimiento, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lbBeca, 2, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(16, 90)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1034, 151)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'txtPago
        '
        Me.txtPago.AutoSize = True
        Me.txtPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPago.Location = New System.Drawing.Point(791, 90)
        Me.txtPago.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtPago.Name = "txtPago"
        Me.txtPago.Size = New System.Drawing.Size(58, 25)
        Me.txtPago.TabIndex = 24
        Me.txtPago.Text = "Pago"
        '
        'lbPago
        '
        Me.lbPago.AutoSize = True
        Me.lbPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPago.Location = New System.Drawing.Point(629, 90)
        Me.lbPago.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbPago.Name = "lbPago"
        Me.lbPago.Size = New System.Drawing.Size(143, 25)
        Me.lbPago.TabIndex = 23
        Me.lbPago.Text = "Pago mensual:"
        '
        'lbRepresentatives
        '
        Me.lbRepresentatives.AutoSize = True
        Me.lbRepresentatives.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRepresentatives.Location = New System.Drawing.Point(11, 255)
        Me.lbRepresentatives.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbRepresentatives.Name = "lbRepresentatives"
        Me.lbRepresentatives.Size = New System.Drawing.Size(313, 25)
        Me.lbRepresentatives.TabIndex = 25
        Me.lbRepresentatives.Text = "Representantes legales del menor:"
        '
        'lboxRepresentatives
        '
        Me.lboxRepresentatives.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lboxRepresentatives.FormattingEnabled = True
        Me.lboxRepresentatives.ItemHeight = 22
        Me.lboxRepresentatives.Location = New System.Drawing.Point(12, 289)
        Me.lboxRepresentatives.Name = "lboxRepresentatives"
        Me.lboxRepresentatives.Size = New System.Drawing.Size(1039, 334)
        Me.lboxRepresentatives.TabIndex = 26
        '
        'frmMinorDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1063, 631)
        Me.Controls.Add(Me.lboxRepresentatives)
        Me.Controls.Add(Me.lbRepresentatives)
        Me.Controls.Add(Me.lbIndications)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.txtCedulaMenor)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMinorDetails"
        Me.Text = "Detalles de estudiante"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbIndications As Label
	Friend WithEvents txtCedulaMenor As Label
    Friend WithEvents lbBeca As Label
    Friend WithEvents txtBeca As Label
    Friend WithEvents lbNivel As Label
    Friend WithEvents txtNivel As Label
    Friend WithEvents lbResidencia As Label
    Friend WithEvents txtResidencia As Label
    Friend WithEvents txtFechaNacimiento As Label
    Friend WithEvents txtFechaIngreso As Label
    Friend WithEvents txtFechaEgreso As Label
    Friend WithEvents txtGenero As Label
    Friend WithEvents txtNombreCompleto As Label
    Friend WithEvents lbFechaNacimiento As Label
    Friend WithEvents lbFechaIngreso As Label
    Friend WithEvents lbFechaEgreso As Label
    Friend WithEvents lbGenero As Label
    Friend WithEvents lbNombreCompleto As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txtPago As Label
    Friend WithEvents lbPago As Label
    Friend WithEvents lbRepresentatives As Label
    Friend WithEvents lboxRepresentatives As ListBox
End Class
