<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInsertUpdateMinor
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInsertUpdateMinor))
        Me.lbIndications = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.DirectoryEntry1 = New System.DirectoryServices.DirectoryEntry()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cboxWorkDay = New System.Windows.Forms.ComboBox()
        Me.lbWorkDay = New System.Windows.Forms.Label()
        Me.cboxRecommendationMethod = New System.Windows.Forms.ComboBox()
        Me.cboxLevels = New System.Windows.Forms.ComboBox()
        Me.lbLevel = New System.Windows.Forms.Label()
        Me.lbRecommendationMethod = New System.Windows.Forms.Label()
        Me.cboxSchoolarship = New System.Windows.Forms.ComboBox()
        Me.dtpLeaveDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpEnterDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpBirthDate = New System.Windows.Forms.DateTimePicker()
        Me.lbEnterDate = New System.Windows.Forms.Label()
        Me.cboxGender = New System.Windows.Forms.ComboBox()
        Me.lbGender = New System.Windows.Forms.Label()
        Me.lbSchoolarship = New System.Windows.Forms.Label()
        Me.tbResidency = New System.Windows.Forms.TextBox()
        Me.lbResidency = New System.Windows.Forms.Label()
        Me.lbLeaveDate = New System.Windows.Forms.Label()
        Me.lbBirthDate = New System.Windows.Forms.Label()
        Me.tbIDCard = New System.Windows.Forms.TextBox()
        Me.lbIDCard = New System.Windows.Forms.Label()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.lbName = New System.Windows.Forms.Label()
        Me.pnlRepresentatives = New System.Windows.Forms.Panel()
        Me.dgvRepresentatives = New System.Windows.Forms.DataGridView()
        Me.lbRelation = New System.Windows.Forms.Label()
        Me.lbAssociatedRepresentatives = New System.Windows.Forms.Label()
        Me.btnAddRepresentativeMinor = New System.Windows.Forms.Button()
        Me.cbRelationship = New System.Windows.Forms.ComboBox()
        Me.tbSelectedRepresentative = New System.Windows.Forms.TextBox()
        Me.lbSelectedRepresentantText = New System.Windows.Forms.Label()
        Me.lbFoundRepresentatives = New System.Windows.Forms.Label()
        Me.lboxFoundRepresentants = New System.Windows.Forms.ListBox()
        Me.btnSearchRepresentative = New System.Windows.Forms.Button()
        Me.tbRepresentativeName = New System.Windows.Forms.TextBox()
        Me.lbRepresentativeName = New System.Windows.Forms.Label()
        Me.lbRepresentatives = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
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
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1.SuspendLayout()
        Me.pnlRepresentatives.SuspendLayout()
        CType(Me.dgvRepresentatives, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvPayments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbIndications
        '
        Me.lbIndications.AutoSize = True
        Me.lbIndications.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIndications.Location = New System.Drawing.Point(24, 9)
        Me.lbIndications.Name = "lbIndications"
        Me.lbIndications.Size = New System.Drawing.Size(384, 29)
        Me.lbIndications.TabIndex = 22
        Me.lbIndications.Text = "Digite los datos que se le solicitan:"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(900, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(199, 40)
        Me.btnSave.TabIndex = 21
        Me.btnSave.Text = "Guardar"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cboxWorkDay)
        Me.Panel1.Controls.Add(Me.lbWorkDay)
        Me.Panel1.Controls.Add(Me.cboxRecommendationMethod)
        Me.Panel1.Controls.Add(Me.cboxLevels)
        Me.Panel1.Controls.Add(Me.lbLevel)
        Me.Panel1.Controls.Add(Me.lbRecommendationMethod)
        Me.Panel1.Controls.Add(Me.cboxSchoolarship)
        Me.Panel1.Controls.Add(Me.dtpLeaveDate)
        Me.Panel1.Controls.Add(Me.dtpEnterDate)
        Me.Panel1.Controls.Add(Me.dtpBirthDate)
        Me.Panel1.Controls.Add(Me.lbEnterDate)
        Me.Panel1.Controls.Add(Me.cboxGender)
        Me.Panel1.Controls.Add(Me.lbGender)
        Me.Panel1.Controls.Add(Me.lbSchoolarship)
        Me.Panel1.Controls.Add(Me.tbResidency)
        Me.Panel1.Controls.Add(Me.lbResidency)
        Me.Panel1.Controls.Add(Me.lbLeaveDate)
        Me.Panel1.Controls.Add(Me.lbBirthDate)
        Me.Panel1.Controls.Add(Me.tbIDCard)
        Me.Panel1.Controls.Add(Me.lbIDCard)
        Me.Panel1.Controls.Add(Me.tbName)
        Me.Panel1.Controls.Add(Me.lbName)
        Me.Panel1.Location = New System.Drawing.Point(12, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1102, 496)
        Me.Panel1.TabIndex = 65
        '
        'cboxWorkDay
        '
        Me.cboxWorkDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboxWorkDay.FormattingEnabled = True
        Me.cboxWorkDay.Location = New System.Drawing.Point(288, 340)
        Me.cboxWorkDay.Name = "cboxWorkDay"
        Me.cboxWorkDay.Size = New System.Drawing.Size(791, 28)
        Me.cboxWorkDay.TabIndex = 86
        '
        'lbWorkDay
        '
        Me.lbWorkDay.AutoSize = True
        Me.lbWorkDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbWorkDay.Location = New System.Drawing.Point(9, 340)
        Me.lbWorkDay.Name = "lbWorkDay"
        Me.lbWorkDay.Size = New System.Drawing.Size(90, 25)
        Me.lbWorkDay.TabIndex = 85
        Me.lbWorkDay.Text = "Jornada:"
        '
        'cboxRecommendationMethod
        '
        Me.cboxRecommendationMethod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cboxRecommendationMethod.FormattingEnabled = True
        Me.cboxRecommendationMethod.Location = New System.Drawing.Point(288, 233)
        Me.cboxRecommendationMethod.Name = "cboxRecommendationMethod"
        Me.cboxRecommendationMethod.Size = New System.Drawing.Size(794, 33)
        Me.cboxRecommendationMethod.TabIndex = 84
        '
        'cboxLevels
        '
        Me.cboxLevels.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboxLevels.FormattingEnabled = True
        Me.cboxLevels.Location = New System.Drawing.Point(288, 377)
        Me.cboxLevels.Name = "cboxLevels"
        Me.cboxLevels.Size = New System.Drawing.Size(791, 28)
        Me.cboxLevels.TabIndex = 83
        '
        'lbLevel
        '
        Me.lbLevel.AutoSize = True
        Me.lbLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLevel.Location = New System.Drawing.Point(9, 377)
        Me.lbLevel.Name = "lbLevel"
        Me.lbLevel.Size = New System.Drawing.Size(61, 25)
        Me.lbLevel.TabIndex = 82
        Me.lbLevel.Text = "Nivel:"
        '
        'lbRecommendationMethod
        '
        Me.lbRecommendationMethod.AutoSize = True
        Me.lbRecommendationMethod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRecommendationMethod.Location = New System.Drawing.Point(7, 236)
        Me.lbRecommendationMethod.Name = "lbRecommendationMethod"
        Me.lbRecommendationMethod.Size = New System.Drawing.Size(83, 25)
        Me.lbRecommendationMethod.TabIndex = 81
        Me.lbRecommendationMethod.Text = "Vínculo:"
        '
        'cboxSchoolarship
        '
        Me.cboxSchoolarship.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboxSchoolarship.FormattingEnabled = True
        Me.cboxSchoolarship.Location = New System.Drawing.Point(288, 411)
        Me.cboxSchoolarship.Name = "cboxSchoolarship"
        Me.cboxSchoolarship.Size = New System.Drawing.Size(791, 28)
        Me.cboxSchoolarship.TabIndex = 80
        '
        'dtpLeaveDate
        '
        Me.dtpLeaveDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpLeaveDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.dtpLeaveDate.Location = New System.Drawing.Point(288, 185)
        Me.dtpLeaveDate.Name = "dtpLeaveDate"
        Me.dtpLeaveDate.Size = New System.Drawing.Size(794, 28)
        Me.dtpLeaveDate.TabIndex = 79
        '
        'dtpEnterDate
        '
        Me.dtpEnterDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEnterDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.dtpEnterDate.Location = New System.Drawing.Point(288, 139)
        Me.dtpEnterDate.Name = "dtpEnterDate"
        Me.dtpEnterDate.Size = New System.Drawing.Size(794, 28)
        Me.dtpEnterDate.TabIndex = 78
        '
        'dtpBirthDate
        '
        Me.dtpBirthDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBirthDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.dtpBirthDate.Location = New System.Drawing.Point(288, 96)
        Me.dtpBirthDate.Name = "dtpBirthDate"
        Me.dtpBirthDate.Size = New System.Drawing.Size(794, 28)
        Me.dtpBirthDate.TabIndex = 77
        '
        'lbEnterDate
        '
        Me.lbEnterDate.AutoSize = True
        Me.lbEnterDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEnterDate.Location = New System.Drawing.Point(9, 143)
        Me.lbEnterDate.Name = "lbEnterDate"
        Me.lbEnterDate.Size = New System.Drawing.Size(171, 25)
        Me.lbEnterDate.TabIndex = 76
        Me.lbEnterDate.Text = "Fecha de entrada:"
        '
        'cboxGender
        '
        Me.cboxGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboxGender.FormattingEnabled = True
        Me.cboxGender.Location = New System.Drawing.Point(288, 448)
        Me.cboxGender.Name = "cboxGender"
        Me.cboxGender.Size = New System.Drawing.Size(791, 28)
        Me.cboxGender.TabIndex = 75
        '
        'lbGender
        '
        Me.lbGender.AutoSize = True
        Me.lbGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbGender.Location = New System.Drawing.Point(9, 440)
        Me.lbGender.Name = "lbGender"
        Me.lbGender.Size = New System.Drawing.Size(83, 25)
        Me.lbGender.TabIndex = 74
        Me.lbGender.Text = "Género:"
        '
        'lbSchoolarship
        '
        Me.lbSchoolarship.AutoSize = True
        Me.lbSchoolarship.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSchoolarship.Location = New System.Drawing.Point(9, 411)
        Me.lbSchoolarship.Name = "lbSchoolarship"
        Me.lbSchoolarship.Size = New System.Drawing.Size(122, 25)
        Me.lbSchoolarship.TabIndex = 73
        Me.lbSchoolarship.Text = "Posee beca:"
        '
        'tbResidency
        '
        Me.tbResidency.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbResidency.Location = New System.Drawing.Point(288, 281)
        Me.tbResidency.Multiline = True
        Me.tbResidency.Name = "tbResidency"
        Me.tbResidency.Size = New System.Drawing.Size(794, 54)
        Me.tbResidency.TabIndex = 72
        '
        'lbResidency
        '
        Me.lbResidency.AutoSize = True
        Me.lbResidency.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbResidency.Location = New System.Drawing.Point(9, 293)
        Me.lbResidency.Name = "lbResidency"
        Me.lbResidency.Size = New System.Drawing.Size(114, 25)
        Me.lbResidency.TabIndex = 71
        Me.lbResidency.Text = "Residencia:"
        '
        'lbLeaveDate
        '
        Me.lbLeaveDate.AutoSize = True
        Me.lbLeaveDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLeaveDate.Location = New System.Drawing.Point(7, 189)
        Me.lbLeaveDate.Name = "lbLeaveDate"
        Me.lbLeaveDate.Size = New System.Drawing.Size(202, 25)
        Me.lbLeaveDate.TabIndex = 70
        Me.lbLeaveDate.Text = "Fecha de graduación:"
        '
        'lbBirthDate
        '
        Me.lbBirthDate.AutoSize = True
        Me.lbBirthDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBirthDate.Location = New System.Drawing.Point(9, 100)
        Me.lbBirthDate.Name = "lbBirthDate"
        Me.lbBirthDate.Size = New System.Drawing.Size(199, 25)
        Me.lbBirthDate.TabIndex = 69
        Me.lbBirthDate.Text = "Fecha de nacimiento:"
        '
        'tbIDCard
        '
        Me.tbIDCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbIDCard.Location = New System.Drawing.Point(288, 54)
        Me.tbIDCard.Name = "tbIDCard"
        Me.tbIDCard.Size = New System.Drawing.Size(794, 28)
        Me.tbIDCard.TabIndex = 68
        '
        'lbIDCard
        '
        Me.lbIDCard.AutoSize = True
        Me.lbIDCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIDCard.Location = New System.Drawing.Point(9, 55)
        Me.lbIDCard.Name = "lbIDCard"
        Me.lbIDCard.Size = New System.Drawing.Size(81, 25)
        Me.lbIDCard.TabIndex = 67
        Me.lbIDCard.Text = "Cédula:"
        '
        'tbName
        '
        Me.tbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbName.Location = New System.Drawing.Point(288, 11)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(794, 28)
        Me.tbName.TabIndex = 66
        '
        'lbName
        '
        Me.lbName.AutoSize = True
        Me.lbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbName.Location = New System.Drawing.Point(9, 12)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(171, 25)
        Me.lbName.TabIndex = 65
        Me.lbName.Text = "Nombre completo:"
        '
        'pnlRepresentatives
        '
        Me.pnlRepresentatives.Controls.Add(Me.dgvRepresentatives)
        Me.pnlRepresentatives.Controls.Add(Me.lbRelation)
        Me.pnlRepresentatives.Controls.Add(Me.lbAssociatedRepresentatives)
        Me.pnlRepresentatives.Controls.Add(Me.btnAddRepresentativeMinor)
        Me.pnlRepresentatives.Controls.Add(Me.cbRelationship)
        Me.pnlRepresentatives.Controls.Add(Me.tbSelectedRepresentative)
        Me.pnlRepresentatives.Controls.Add(Me.lbSelectedRepresentantText)
        Me.pnlRepresentatives.Controls.Add(Me.lbFoundRepresentatives)
        Me.pnlRepresentatives.Controls.Add(Me.lboxFoundRepresentants)
        Me.pnlRepresentatives.Controls.Add(Me.btnSearchRepresentative)
        Me.pnlRepresentatives.Controls.Add(Me.tbRepresentativeName)
        Me.pnlRepresentatives.Controls.Add(Me.lbRepresentativeName)
        Me.pnlRepresentatives.Controls.Add(Me.lbRepresentatives)
        Me.pnlRepresentatives.Location = New System.Drawing.Point(12, 552)
        Me.pnlRepresentatives.Name = "pnlRepresentatives"
        Me.pnlRepresentatives.Size = New System.Drawing.Size(1102, 467)
        Me.pnlRepresentatives.TabIndex = 66
        '
        'dgvRepresentatives
        '
        Me.dgvRepresentatives.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRepresentatives.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvRepresentatives.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRepresentatives.Location = New System.Drawing.Point(17, 370)
        Me.dgvRepresentatives.Name = "dgvRepresentatives"
        Me.dgvRepresentatives.RowHeadersWidth = 51
        Me.dgvRepresentatives.RowTemplate.Height = 24
        Me.dgvRepresentatives.Size = New System.Drawing.Size(1065, 82)
        Me.dgvRepresentatives.TabIndex = 76
        '
        'lbRelation
        '
        Me.lbRelation.AutoSize = True
        Me.lbRelation.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lbRelation.Location = New System.Drawing.Point(13, 255)
        Me.lbRelation.Name = "lbRelation"
        Me.lbRelation.Size = New System.Drawing.Size(172, 24)
        Me.lbRelation.TabIndex = 75
        Me.lbRelation.Text = "Lazo con el menor:"
        '
        'lbAssociatedRepresentatives
        '
        Me.lbAssociatedRepresentatives.AutoSize = True
        Me.lbAssociatedRepresentatives.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbAssociatedRepresentatives.Location = New System.Drawing.Point(13, 346)
        Me.lbAssociatedRepresentatives.Name = "lbAssociatedRepresentatives"
        Me.lbAssociatedRepresentatives.Size = New System.Drawing.Size(329, 20)
        Me.lbAssociatedRepresentatives.TabIndex = 74
        Me.lbAssociatedRepresentatives.Text = "Representantes asociados con este menor"
        '
        'btnAddRepresentativeMinor
        '
        Me.btnAddRepresentativeMinor.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnAddRepresentativeMinor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddRepresentativeMinor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnAddRepresentativeMinor.ForeColor = System.Drawing.Color.White
        Me.btnAddRepresentativeMinor.Location = New System.Drawing.Point(776, 285)
        Me.btnAddRepresentativeMinor.Name = "btnAddRepresentativeMinor"
        Me.btnAddRepresentativeMinor.Size = New System.Drawing.Size(306, 47)
        Me.btnAddRepresentativeMinor.TabIndex = 73
        Me.btnAddRepresentativeMinor.Text = "Asociar representante"
        Me.btnAddRepresentativeMinor.UseVisualStyleBackColor = False
        '
        'cbRelationship
        '
        Me.cbRelationship.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cbRelationship.FormattingEnabled = True
        Me.cbRelationship.Location = New System.Drawing.Point(285, 251)
        Me.cbRelationship.Name = "cbRelationship"
        Me.cbRelationship.Size = New System.Drawing.Size(797, 28)
        Me.cbRelationship.TabIndex = 72
        '
        'tbSelectedRepresentative
        '
        Me.tbSelectedRepresentative.Enabled = False
        Me.tbSelectedRepresentative.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSelectedRepresentative.Location = New System.Drawing.Point(285, 206)
        Me.tbSelectedRepresentative.Name = "tbSelectedRepresentative"
        Me.tbSelectedRepresentative.Size = New System.Drawing.Size(797, 28)
        Me.tbSelectedRepresentative.TabIndex = 71
        '
        'lbSelectedRepresentantText
        '
        Me.lbSelectedRepresentantText.AutoSize = True
        Me.lbSelectedRepresentantText.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lbSelectedRepresentantText.Location = New System.Drawing.Point(13, 209)
        Me.lbSelectedRepresentantText.Name = "lbSelectedRepresentantText"
        Me.lbSelectedRepresentantText.Size = New System.Drawing.Size(256, 24)
        Me.lbSelectedRepresentantText.TabIndex = 70
        Me.lbSelectedRepresentantText.Text = "Representante seleccionado:"
        '
        'lbFoundRepresentatives
        '
        Me.lbFoundRepresentatives.AutoSize = True
        Me.lbFoundRepresentatives.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbFoundRepresentatives.Location = New System.Drawing.Point(13, 101)
        Me.lbFoundRepresentatives.Name = "lbFoundRepresentatives"
        Me.lbFoundRepresentatives.Size = New System.Drawing.Size(229, 20)
        Me.lbFoundRepresentatives.TabIndex = 69
        Me.lbFoundRepresentatives.Text = "Representantes encontrados:"
        '
        'lboxFoundRepresentants
        '
        Me.lboxFoundRepresentants.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lboxFoundRepresentants.FormattingEnabled = True
        Me.lboxFoundRepresentants.ItemHeight = 22
        Me.lboxFoundRepresentants.Location = New System.Drawing.Point(17, 124)
        Me.lboxFoundRepresentants.Name = "lboxFoundRepresentants"
        Me.lboxFoundRepresentants.ScrollAlwaysVisible = True
        Me.lboxFoundRepresentants.Size = New System.Drawing.Size(1062, 70)
        Me.lboxFoundRepresentants.TabIndex = 68
        '
        'btnSearchRepresentative
        '
        Me.btnSearchRepresentative.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnSearchRepresentative.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchRepresentative.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnSearchRepresentative.ForeColor = System.Drawing.Color.White
        Me.btnSearchRepresentative.Location = New System.Drawing.Point(973, 45)
        Me.btnSearchRepresentative.Name = "btnSearchRepresentative"
        Me.btnSearchRepresentative.Size = New System.Drawing.Size(106, 44)
        Me.btnSearchRepresentative.TabIndex = 67
        Me.btnSearchRepresentative.Text = "Buscar"
        Me.btnSearchRepresentative.UseVisualStyleBackColor = False
        '
        'tbRepresentativeName
        '
        Me.tbRepresentativeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRepresentativeName.Location = New System.Drawing.Point(246, 54)
        Me.tbRepresentativeName.Name = "tbRepresentativeName"
        Me.tbRepresentativeName.Size = New System.Drawing.Size(699, 28)
        Me.tbRepresentativeName.TabIndex = 66
        '
        'lbRepresentativeName
        '
        Me.lbRepresentativeName.AutoSize = True
        Me.lbRepresentativeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRepresentativeName.Location = New System.Drawing.Point(12, 57)
        Me.lbRepresentativeName.Name = "lbRepresentativeName"
        Me.lbRepresentativeName.Size = New System.Drawing.Size(171, 25)
        Me.lbRepresentativeName.TabIndex = 65
        Me.lbRepresentativeName.Text = "Nombre completo:"
        '
        'lbRepresentatives
        '
        Me.lbRepresentatives.AutoSize = True
        Me.lbRepresentatives.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRepresentatives.Location = New System.Drawing.Point(7, 7)
        Me.lbRepresentatives.Name = "lbRepresentatives"
        Me.lbRepresentatives.Size = New System.Drawing.Size(268, 29)
        Me.lbRepresentatives.TabIndex = 64
        Me.lbRepresentatives.Text = "Representantes legales"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnSave)
        Me.Panel3.Location = New System.Drawing.Point(12, 1302)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1102, 48)
        Me.Panel3.TabIndex = 68
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
        Me.Panel2.Location = New System.Drawing.Point(12, 1025)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1102, 271)
        Me.Panel2.TabIndex = 69
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
        'frmInsertUpdateMinor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1156, 500)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.pnlRepresentatives)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbIndications)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInsertUpdateMinor"
        Me.ShowInTaskbar = False
        Me.Text = "Agregar menor"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlRepresentatives.ResumeLayout(False)
        Me.pnlRepresentatives.PerformLayout()
        CType(Me.dgvRepresentatives, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvPayments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbIndications As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents BindingSource2 As BindingSource
    Friend WithEvents DirectoryEntry1 As DirectoryServices.DirectoryEntry
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cboxRecommendationMethod As ComboBox
    Friend WithEvents cboxLevels As ComboBox
    Friend WithEvents lbLevel As Label
    Friend WithEvents lbRecommendationMethod As Label
    Friend WithEvents cboxSchoolarship As ComboBox
    Friend WithEvents dtpLeaveDate As DateTimePicker
    Friend WithEvents dtpEnterDate As DateTimePicker
    Friend WithEvents dtpBirthDate As DateTimePicker
    Friend WithEvents lbEnterDate As Label
    Friend WithEvents cboxGender As ComboBox
    Friend WithEvents lbGender As Label
    Friend WithEvents lbSchoolarship As Label
    Friend WithEvents tbResidency As TextBox
    Friend WithEvents lbResidency As Label
    Friend WithEvents lbLeaveDate As Label
    Friend WithEvents lbBirthDate As Label
    Friend WithEvents tbIDCard As TextBox
    Friend WithEvents lbIDCard As Label
    Friend WithEvents tbName As TextBox
    Friend WithEvents lbName As Label
    Friend WithEvents pnlRepresentatives As Panel
    Friend WithEvents dgvRepresentatives As DataGridView
    Friend WithEvents lbRelation As Label
    Friend WithEvents lbAssociatedRepresentatives As Label
    Friend WithEvents btnAddRepresentativeMinor As Button
    Friend WithEvents cbRelationship As ComboBox
    Friend WithEvents tbSelectedRepresentative As TextBox
    Friend WithEvents lbSelectedRepresentantText As Label
    Friend WithEvents lbFoundRepresentatives As Label
    Friend WithEvents lboxFoundRepresentants As ListBox
    Friend WithEvents btnSearchRepresentative As Button
    Friend WithEvents tbRepresentativeName As TextBox
    Friend WithEvents lbRepresentativeName As Label
    Friend WithEvents lbRepresentatives As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbMonth As Label
    Friend WithEvents lbPayments As Label
    Friend WithEvents tbMonth As TextBox
    Friend WithEvents dtpDayPaid As DateTimePicker
    Friend WithEvents lbPaymentDate As Label
    Friend WithEvents tbValue As TextBox
    Friend WithEvents lbValue As Label
    Friend WithEvents tbDepositNumber As TextBox
    Friend WithEvents lbDepositNumber As Label
    Friend WithEvents tbObservation As TextBox
    Friend WithEvents lbObservations As Label
    Friend WithEvents dgvPayments As DataGridView
    Friend WithEvents btnAddPayment As Button
    Friend WithEvents cboxWorkDay As ComboBox
    Friend WithEvents lbWorkDay As Label
End Class
