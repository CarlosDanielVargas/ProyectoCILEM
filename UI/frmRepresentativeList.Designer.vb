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
		Me.UserList = New System.Windows.Forms.ListView()
		Me.SuspendLayout()
		'
		'lbIndications
		'
		Me.lbIndications.AutoSize = True
		Me.lbIndications.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbIndications.Location = New System.Drawing.Point(175, 9)
		Me.lbIndications.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lbIndications.Name = "lbIndications"
		Me.lbIndications.Size = New System.Drawing.Size(306, 24)
		Me.lbIndications.TabIndex = 7
		Me.lbIndications.Text = "Lista de representantes registrados "
		'
		'UserList
		'
		Me.UserList.HideSelection = False
		Me.UserList.Location = New System.Drawing.Point(12, 60)
		Me.UserList.Name = "UserList"
		Me.UserList.Size = New System.Drawing.Size(635, 487)
		Me.UserList.TabIndex = 10
		Me.UserList.UseCompatibleStateImageBehavior = False
		'
		'frmRepresentativeList
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(658, 559)
		Me.Controls.Add(Me.UserList)
		Me.Controls.Add(Me.lbIndications)
		Me.Name = "frmRepresentativeList"
		Me.Text = "frmRepresentativeList"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lbIndications As Label
	Friend WithEvents UserList As ListView
End Class
