<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserList
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbCurrentFilter = New System.Windows.Forms.Label()
        Me.btnClearFilters = New System.Windows.Forms.Button()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.cboxStatus = New System.Windows.Forms.ComboBox()
        Me.lbStatus = New System.Windows.Forms.Label()
        Me.tbIDCard = New System.Windows.Forms.TextBox()
        Me.lbIDCard = New System.Windows.Forms.Label()
        Me.lbFilters = New System.Windows.Forms.Label()
        Me.dgvUsers = New System.Windows.Forms.DataGridView()
        Me.lbIndications = New System.Windows.Forms.Label()
        Me.cboxRole = New System.Windows.Forms.ComboBox()
        Me.lbRole = New System.Windows.Forms.Label()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbCurrentFilter
        '
        Me.lbCurrentFilter.AutoSize = True
        Me.lbCurrentFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.lbCurrentFilter.Location = New System.Drawing.Point(12, 130)
        Me.lbCurrentFilter.Name = "lbCurrentFilter"
        Me.lbCurrentFilter.Size = New System.Drawing.Size(64, 22)
        Me.lbCurrentFilter.TabIndex = 29
        Me.lbCurrentFilter.Text = "Label1"
        '
        'btnClearFilters
        '
        Me.btnClearFilters.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.btnClearFilters.Location = New System.Drawing.Point(859, 127)
        Me.btnClearFilters.Name = "btnClearFilters"
        Me.btnClearFilters.Size = New System.Drawing.Size(127, 32)
        Me.btnClearFilters.TabIndex = 28
        Me.btnClearFilters.Text = "Limpiar filtros"
        Me.btnClearFilters.UseVisualStyleBackColor = True
        '
        'btnFilter
        '
        Me.btnFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.btnFilter.Location = New System.Drawing.Point(859, 89)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(127, 32)
        Me.btnFilter.TabIndex = 27
        Me.btnFilter.Text = "Filtrar"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'cboxStatus
        '
        Me.cboxStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.cboxStatus.FormattingEnabled = True
        Me.cboxStatus.Location = New System.Drawing.Point(365, 94)
        Me.cboxStatus.Name = "cboxStatus"
        Me.cboxStatus.Size = New System.Drawing.Size(206, 30)
        Me.cboxStatus.TabIndex = 24
        '
        'lbStatus
        '
        Me.lbStatus.AutoSize = True
        Me.lbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.lbStatus.Location = New System.Drawing.Point(289, 94)
        Me.lbStatus.Name = "lbStatus"
        Me.lbStatus.Size = New System.Drawing.Size(71, 22)
        Me.lbStatus.TabIndex = 23
        Me.lbStatus.Text = "Estado:"
        '
        'tbIDCard
        '
        Me.tbIDCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.tbIDCard.Location = New System.Drawing.Point(89, 94)
        Me.tbIDCard.Name = "tbIDCard"
        Me.tbIDCard.Size = New System.Drawing.Size(184, 28)
        Me.tbIDCard.TabIndex = 22
        '
        'lbIDCard
        '
        Me.lbIDCard.AutoSize = True
        Me.lbIDCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.lbIDCard.Location = New System.Drawing.Point(12, 94)
        Me.lbIDCard.Name = "lbIDCard"
        Me.lbIDCard.Size = New System.Drawing.Size(72, 22)
        Me.lbIDCard.TabIndex = 21
        Me.lbIDCard.Text = "Cédula:"
        '
        'lbFilters
        '
        Me.lbFilters.AutoSize = True
        Me.lbFilters.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lbFilters.Location = New System.Drawing.Point(11, 64)
        Me.lbFilters.Name = "lbFilters"
        Me.lbFilters.Size = New System.Drawing.Size(182, 24)
        Me.lbFilters.TabIndex = 20
        Me.lbFilters.Text = "Filtros de búsqueda:"
        '
        'dgvUsers
        '
        Me.dgvUsers.AllowUserToAddRows = False
        Me.dgvUsers.AllowUserToDeleteRows = False
        Me.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsers.Location = New System.Drawing.Point(12, 168)
        Me.dgvUsers.Name = "dgvUsers"
        Me.dgvUsers.ReadOnly = True
        Me.dgvUsers.RowHeadersWidth = 51
        Me.dgvUsers.RowTemplate.Height = 24
        Me.dgvUsers.Size = New System.Drawing.Size(981, 505)
        Me.dgvUsers.TabIndex = 19
        '
        'lbIndications
        '
        Me.lbIndications.AutoSize = True
        Me.lbIndications.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIndications.Location = New System.Drawing.Point(310, 20)
        Me.lbIndications.Name = "lbIndications"
        Me.lbIndications.Size = New System.Drawing.Size(327, 29)
        Me.lbIndications.TabIndex = 18
        Me.lbIndications.Text = "Lista de usuarios registrados "
        '
        'cboxRole
        '
        Me.cboxRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.cboxRole.FormattingEnabled = True
        Me.cboxRole.Location = New System.Drawing.Point(622, 92)
        Me.cboxRole.Name = "cboxRole"
        Me.cboxRole.Size = New System.Drawing.Size(216, 30)
        Me.cboxRole.TabIndex = 26
        '
        'lbRole
        '
        Me.lbRole.AutoSize = True
        Me.lbRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.lbRole.Location = New System.Drawing.Point(577, 94)
        Me.lbRole.Name = "lbRole"
        Me.lbRole.Size = New System.Drawing.Size(42, 22)
        Me.lbRole.TabIndex = 25
        Me.lbRole.Text = "Rol:"
        '
        'frmUserList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1005, 692)
        Me.Controls.Add(Me.lbCurrentFilter)
        Me.Controls.Add(Me.btnClearFilters)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.cboxRole)
        Me.Controls.Add(Me.lbRole)
        Me.Controls.Add(Me.cboxStatus)
        Me.Controls.Add(Me.lbStatus)
        Me.Controls.Add(Me.tbIDCard)
        Me.Controls.Add(Me.lbIDCard)
        Me.Controls.Add(Me.lbFilters)
        Me.Controls.Add(Me.dgvUsers)
        Me.Controls.Add(Me.lbIndications)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmUserList"
        Me.Text = "Listar usuarios"
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbCurrentFilter As Label
    Friend WithEvents btnClearFilters As Button
    Friend WithEvents btnFilter As Button
    Friend WithEvents cboxStatus As ComboBox
    Friend WithEvents lbStatus As Label
    Friend WithEvents tbIDCard As TextBox
    Friend WithEvents lbIDCard As Label
    Friend WithEvents lbFilters As Label
    Friend WithEvents dgvUsers As DataGridView
    Friend WithEvents lbIndications As Label
    Friend WithEvents cboxRole As ComboBox
    Friend WithEvents lbRole As Label
End Class
