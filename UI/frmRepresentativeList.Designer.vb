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
        Me.dgvRepresentatives.Location = New System.Drawing.Point(12, 60)
        Me.dgvRepresentatives.Name = "dgvRepresentatives"
        Me.dgvRepresentatives.RowHeadersWidth = 51
        Me.dgvRepresentatives.RowTemplate.Height = 24
        Me.dgvRepresentatives.Size = New System.Drawing.Size(844, 616)
        Me.dgvRepresentatives.TabIndex = 8
        '
        'frmRepresentativeList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 688)
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
End Class
