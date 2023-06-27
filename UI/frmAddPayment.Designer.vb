<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddPayment
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddPayment))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvPayments = New System.Windows.Forms.DataGridView()
        Me.btnAddPayment = New System.Windows.Forms.Button()
        Me.tbObservation = New System.Windows.Forms.TextBox()
        Me.lbObservations = New System.Windows.Forms.Label()
        Me.tbValue = New System.Windows.Forms.TextBox()
        Me.lbValue = New System.Windows.Forms.Label()
        Me.tbDepositNumber = New System.Windows.Forms.TextBox()
        Me.lbDepositNumber = New System.Windows.Forms.Label()
        Me.dtpDayPaid = New System.Windows.Forms.DateTimePicker()
        Me.lbPaymentDate = New System.Windows.Forms.Label()
        Me.tbMonth = New System.Windows.Forms.TextBox()
        Me.lbMonth = New System.Windows.Forms.Label()
        Me.lbPayments = New System.Windows.Forms.Label()
        Me.lnStudent = New System.Windows.Forms.Label()
        Me.txtStudent = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvPayments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgvPayments)
        Me.Panel2.Controls.Add(Me.btnAddPayment)
        Me.Panel2.Controls.Add(Me.tbObservation)
        Me.Panel2.Controls.Add(Me.lbObservations)
        Me.Panel2.Controls.Add(Me.tbValue)
        Me.Panel2.Controls.Add(Me.lbValue)
        Me.Panel2.Controls.Add(Me.tbDepositNumber)
        Me.Panel2.Controls.Add(Me.lbDepositNumber)
        Me.Panel2.Controls.Add(Me.dtpDayPaid)
        Me.Panel2.Controls.Add(Me.lbPaymentDate)
        Me.Panel2.Controls.Add(Me.tbMonth)
        Me.Panel2.Controls.Add(Me.lbMonth)
        Me.Panel2.Controls.Add(Me.lbPayments)
        Me.Panel2.Location = New System.Drawing.Point(12, 48)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1102, 271)
        Me.Panel2.TabIndex = 70
        '
        'dgvPayments
        '
        Me.dgvPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPayments.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPayments.Location = New System.Drawing.Point(17, 136)
        Me.dgvPayments.Name = "dgvPayments"
        Me.dgvPayments.RowHeadersWidth = 51
        Me.dgvPayments.RowTemplate.Height = 24
        Me.dgvPayments.Size = New System.Drawing.Size(1065, 132)
        Me.dgvPayments.TabIndex = 87
        '
        'btnAddPayment
        '
        Me.btnAddPayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnAddPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnAddPayment.ForeColor = System.Drawing.Color.White
        Me.btnAddPayment.Location = New System.Drawing.Point(976, 86)
        Me.btnAddPayment.Name = "btnAddPayment"
        Me.btnAddPayment.Size = New System.Drawing.Size(106, 44)
        Me.btnAddPayment.TabIndex = 86
        Me.btnAddPayment.Text = "Agregar"
        Me.btnAddPayment.UseVisualStyleBackColor = False
        '
        'tbObservation
        '
        Me.tbObservation.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbObservation.Location = New System.Drawing.Point(508, 86)
        Me.tbObservation.Multiline = True
        Me.tbObservation.Name = "tbObservation"
        Me.tbObservation.Size = New System.Drawing.Size(462, 44)
        Me.tbObservation.TabIndex = 85
        '
        'lbObservations
        '
        Me.lbObservations.AutoSize = True
        Me.lbObservations.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbObservations.Location = New System.Drawing.Point(352, 84)
        Me.lbObservations.Name = "lbObservations"
        Me.lbObservations.Size = New System.Drawing.Size(150, 25)
        Me.lbObservations.TabIndex = 84
        Me.lbObservations.Text = "Observaciones:"
        '
        'tbValue
        '
        Me.tbValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbValue.Location = New System.Drawing.Point(879, 49)
        Me.tbValue.Name = "tbValue"
        Me.tbValue.Size = New System.Drawing.Size(203, 28)
        Me.tbValue.TabIndex = 83
        '
        'lbValue
        '
        Me.lbValue.AutoSize = True
        Me.lbValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lbValue.Location = New System.Drawing.Point(805, 49)
        Me.lbValue.Name = "lbValue"
        Me.lbValue.Size = New System.Drawing.Size(68, 24)
        Me.lbValue.TabIndex = 82
        Me.lbValue.Text = "Monto:"
        '
        'tbDepositNumber
        '
        Me.tbDepositNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDepositNumber.Location = New System.Drawing.Point(163, 86)
        Me.tbDepositNumber.Name = "tbDepositNumber"
        Me.tbDepositNumber.Size = New System.Drawing.Size(183, 28)
        Me.tbDepositNumber.TabIndex = 81
        '
        'lbDepositNumber
        '
        Me.lbDepositNumber.AutoSize = True
        Me.lbDepositNumber.BackColor = System.Drawing.Color.White
        Me.lbDepositNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lbDepositNumber.Location = New System.Drawing.Point(13, 86)
        Me.lbDepositNumber.Name = "lbDepositNumber"
        Me.lbDepositNumber.Size = New System.Drawing.Size(140, 24)
        Me.lbDepositNumber.TabIndex = 80
        Me.lbDepositNumber.Text = "Nº de deposito:"
        '
        'dtpDayPaid
        '
        Me.dtpDayPaid.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDayPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.dtpDayPaid.Location = New System.Drawing.Point(453, 45)
        Me.dtpDayPaid.Name = "dtpDayPaid"
        Me.dtpDayPaid.Size = New System.Drawing.Size(346, 28)
        Me.dtpDayPaid.TabIndex = 79
        '
        'lbPaymentDate
        '
        Me.lbPaymentDate.AutoSize = True
        Me.lbPaymentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lbPaymentDate.Location = New System.Drawing.Point(303, 48)
        Me.lbPaymentDate.Name = "lbPaymentDate"
        Me.lbPaymentDate.Size = New System.Drawing.Size(144, 24)
        Me.lbPaymentDate.TabIndex = 78
        Me.lbPaymentDate.Text = "Fecha de pago:"
        '
        'tbMonth
        '
        Me.tbMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMonth.Location = New System.Drawing.Point(163, 45)
        Me.tbMonth.Name = "tbMonth"
        Me.tbMonth.Size = New System.Drawing.Size(134, 28)
        Me.tbMonth.TabIndex = 77
        '
        'lbMonth
        '
        Me.lbMonth.AutoSize = True
        Me.lbMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lbMonth.Location = New System.Drawing.Point(13, 45)
        Me.lbMonth.Name = "lbMonth"
        Me.lbMonth.Size = New System.Drawing.Size(144, 24)
        Me.lbMonth.TabIndex = 76
        Me.lbMonth.Text = "Mes cancelado:"
        '
        'lbPayments
        '
        Me.lbPayments.AutoSize = True
        Me.lbPayments.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.lbPayments.Location = New System.Drawing.Point(9, 9)
        Me.lbPayments.Name = "lbPayments"
        Me.lbPayments.Size = New System.Drawing.Size(82, 29)
        Me.lbPayments.TabIndex = 0
        Me.lbPayments.Text = "Pagos"
        '
        'lnStudent
        '
        Me.lnStudent.AutoSize = True
        Me.lnStudent.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lnStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnStudent.Location = New System.Drawing.Point(25, 9)
        Me.lnStudent.Name = "lnStudent"
        Me.lnStudent.Size = New System.Drawing.Size(179, 36)
        Me.lnStudent.TabIndex = 88
        Me.lnStudent.Text = "Estudiante:"
        '
        'txtStudent
        '
        Me.txtStudent.AutoSize = True
        Me.txtStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.txtStudent.Location = New System.Drawing.Point(171, 9)
        Me.txtStudent.Name = "txtStudent"
        Me.txtStudent.Size = New System.Drawing.Size(158, 36)
        Me.txtStudent.TabIndex = 88
        Me.txtStudent.Text = "Estudiante"
        '
        'frmAddPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1127, 331)
        Me.Controls.Add(Me.txtStudent)
        Me.Controls.Add(Me.lnStudent)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddPayment"
        Me.Text = "Agregar Pago"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvPayments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvPayments As DataGridView
    Friend WithEvents btnAddPayment As Button
    Friend WithEvents tbObservation As TextBox
    Friend WithEvents lbObservations As Label
    Friend WithEvents tbValue As TextBox
    Friend WithEvents lbValue As Label
    Friend WithEvents tbDepositNumber As TextBox
    Friend WithEvents lbDepositNumber As Label
    Friend WithEvents dtpDayPaid As DateTimePicker
    Friend WithEvents lbPaymentDate As Label
    Friend WithEvents tbMonth As TextBox
    Friend WithEvents lbMonth As Label
    Friend WithEvents lbPayments As Label
    Friend WithEvents lnStudent As Label
    Friend WithEvents txtStudent As Label
End Class
