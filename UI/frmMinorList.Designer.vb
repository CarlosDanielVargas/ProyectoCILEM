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
        Me.dvgMinors = New System.Windows.Forms.DataGridView()
        CType(Me.dvgMinors, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'dvgMinors
        '
        Me.dvgMinors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgMinors.Location = New System.Drawing.Point(12, 72)
        Me.dvgMinors.Name = "dvgMinors"
        Me.dvgMinors.RowHeadersWidth = 51
        Me.dvgMinors.RowTemplate.Height = 24
        Me.dvgMinors.Size = New System.Drawing.Size(855, 592)
        Me.dvgMinors.TabIndex = 7
        '
        'frmMinorList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 676)
        Me.Controls.Add(Me.dvgMinors)
        Me.Controls.Add(Me.lbIndications)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmMinorList"
        Me.ShowIcon = False
        Me.Text = "Lista de menores"
        CType(Me.dvgMinors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbIndications As Label
	Friend WithEvents dvgMinors As DataGridView
End Class
