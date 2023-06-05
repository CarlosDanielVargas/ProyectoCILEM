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
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.lbNombreCompleto = New System.Windows.Forms.Label()
		Me.lbCorreo = New System.Windows.Forms.Label()
		Me.lbRol = New System.Windows.Forms.Label()
		Me.txtNombre = New System.Windows.Forms.Label()
		Me.txtCorreo = New System.Windows.Forms.Label()
		Me.txtRol = New System.Windows.Forms.Label()
		Me.UserList = New System.Windows.Forms.ListView()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'lbIndications
		'
		Me.lbIndications.AutoSize = True
		Me.lbIndications.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbIndications.Location = New System.Drawing.Point(191, 9)
		Me.lbIndications.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lbIndications.Name = "lbIndications"
		Me.lbIndications.Size = New System.Drawing.Size(252, 24)
		Me.lbIndications.TabIndex = 6
		Me.lbIndications.Text = "Lista de usuarios registrados "
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.ColumnCount = 2
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666!))
		Me.TableLayoutPanel1.Controls.Add(Me.lbNombreCompleto, 0, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.lbCorreo, 0, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.lbRol, 0, 2)
		Me.TableLayoutPanel1.Controls.Add(Me.txtNombre, 1, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.txtCorreo, 1, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.txtRol, 1, 2)
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 93)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 3
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.34001!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(609, 185)
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
		'lbCorreo
		'
		Me.lbCorreo.AutoSize = True
		Me.lbCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbCorreo.Location = New System.Drawing.Point(3, 61)
		Me.lbCorreo.Name = "lbCorreo"
		Me.lbCorreo.Size = New System.Drawing.Size(144, 20)
		Me.lbCorreo.TabIndex = 1
		Me.lbCorreo.Text = "Correo Electrónico:"
		'
		'lbRol
		'
		Me.lbRol.AutoSize = True
		Me.lbRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbRol.Location = New System.Drawing.Point(3, 122)
		Me.lbRol.Name = "lbRol"
		Me.lbRol.Size = New System.Drawing.Size(37, 20)
		Me.lbRol.TabIndex = 2
		Me.lbRol.Text = "Rol:"
		'
		'txtNombre
		'
		Me.txtNombre.AutoSize = True
		Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtNombre.Location = New System.Drawing.Point(205, 0)
		Me.txtNombre.Name = "txtNombre"
		Me.txtNombre.Size = New System.Drawing.Size(65, 20)
		Me.txtNombre.TabIndex = 7
		Me.txtNombre.Text = "Nombre"
		'
		'txtCorreo
		'
		Me.txtCorreo.AutoSize = True
		Me.txtCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCorreo.Location = New System.Drawing.Point(205, 61)
		Me.txtCorreo.Name = "txtCorreo"
		Me.txtCorreo.Size = New System.Drawing.Size(63, 20)
		Me.txtCorreo.TabIndex = 8
		Me.txtCorreo.Text = "Genero"
		'
		'txtRol
		'
		Me.txtRol.AutoSize = True
		Me.txtRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtRol.Location = New System.Drawing.Point(205, 122)
		Me.txtRol.Name = "txtRol"
		Me.txtRol.Size = New System.Drawing.Size(33, 20)
		Me.txtRol.TabIndex = 9
		Me.txtRol.Text = "Rol"
		'
		'UserList
		'
		Me.UserList.HideSelection = False
		Me.UserList.Location = New System.Drawing.Point(12, 298)
		Me.UserList.Name = "UserList"
		Me.UserList.Size = New System.Drawing.Size(635, 239)
		Me.UserList.TabIndex = 9
		Me.UserList.UseCompatibleStateImageBehavior = False
		'
		'frmUsersList
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(659, 549)
		Me.Controls.Add(Me.UserList)
		Me.Controls.Add(Me.lbIndications)
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.Name = "frmUsersList"
		Me.Text = "frmUserDetails"
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.TableLayoutPanel1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lbIndications As Label
	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
	Friend WithEvents lbNombreCompleto As Label
	Friend WithEvents lbCorreo As Label
	Friend WithEvents lbRol As Label
	Friend WithEvents txtNombre As Label
	Friend WithEvents txtCorreo As Label
	Friend WithEvents txtRol As Label
	Friend WithEvents UserList As ListView
End Class
