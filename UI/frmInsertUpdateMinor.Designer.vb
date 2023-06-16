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
        Me.lbEnterDate = New System.Windows.Forms.Label()
        Me.cboxGender = New System.Windows.Forms.ComboBox()
        Me.lbGender = New System.Windows.Forms.Label()
        Me.lbSchoolarship = New System.Windows.Forms.Label()
        Me.tbResidency = New System.Windows.Forms.TextBox()
        Me.lbResidency = New System.Windows.Forms.Label()
        Me.tbCurrentPayment = New System.Windows.Forms.TextBox()
        Me.lbCurrentPayment = New System.Windows.Forms.Label()
        Me.lbLeaveDate = New System.Windows.Forms.Label()
        Me.lbBirthDate = New System.Windows.Forms.Label()
        Me.tbIDCard = New System.Windows.Forms.TextBox()
        Me.lbIDCard = New System.Windows.Forms.Label()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.lbName = New System.Windows.Forms.Label()
        Me.lbIndications = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dtpBirthDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpEnterDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpLeaveDate = New System.Windows.Forms.DateTimePicker()
        Me.cboxSchoolarship = New System.Windows.Forms.ComboBox()
        Me.lbRepresentatives = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.tbRepresentativeName = New System.Windows.Forms.TextBox()
        Me.lbRepresentativeName = New System.Windows.Forms.Label()
        Me.btnSearchRepresentative = New System.Windows.Forms.Button()
        Me.lboxFoundRepresentants = New System.Windows.Forms.ListBox()
        Me.lbFoundRepresentatives = New System.Windows.Forms.Label()
        Me.lbSelectedRepresentantText = New System.Windows.Forms.Label()
        Me.tbSelectedRepresentative = New System.Windows.Forms.TextBox()
        Me.cbRelationship = New System.Windows.Forms.ComboBox()
        Me.lbRelationship = New System.Windows.Forms.Label()
        Me.btnAddRepresentativeMinor = New System.Windows.Forms.Button()
        Me.lboxAssociatedRepresentatives = New System.Windows.Forms.ListBox()
        Me.lbAssociatedRepresentatives = New System.Windows.Forms.Label()
        Me.lbRelation = New System.Windows.Forms.Label()
        Me.tbRecommendationMethod = New System.Windows.Forms.TextBox()
        Me.lbRecommendationMethod = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.lbLevel = New System.Windows.Forms.Label()
        Me.cboxLevels = New System.Windows.Forms.ComboBox()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbEnterDate
        '
        Me.lbEnterDate.AutoSize = True
        Me.lbEnterDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEnterDate.Location = New System.Drawing.Point(51, 157)
        Me.lbEnterDate.Name = "lbEnterDate"
        Me.lbEnterDate.Size = New System.Drawing.Size(171, 25)
        Me.lbEnterDate.TabIndex = 39
        Me.lbEnterDate.Text = "Fecha de entrada:"
        '
        'cboxGender
        '
        Me.cboxGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboxGender.FormattingEnabled = True
        Me.cboxGender.Location = New System.Drawing.Point(256, 544)
        Me.cboxGender.Name = "cboxGender"
        Me.cboxGender.Size = New System.Drawing.Size(557, 28)
        Me.cboxGender.TabIndex = 38
        '
        'lbGender
        '
        Me.lbGender.AutoSize = True
        Me.lbGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbGender.Location = New System.Drawing.Point(51, 547)
        Me.lbGender.Name = "lbGender"
        Me.lbGender.Size = New System.Drawing.Size(83, 25)
        Me.lbGender.TabIndex = 37
        Me.lbGender.Text = "Género:"
        '
        'lbSchoolarship
        '
        Me.lbSchoolarship.AutoSize = True
        Me.lbSchoolarship.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSchoolarship.Location = New System.Drawing.Point(51, 500)
        Me.lbSchoolarship.Name = "lbSchoolarship"
        Me.lbSchoolarship.Size = New System.Drawing.Size(122, 25)
        Me.lbSchoolarship.TabIndex = 35
        Me.lbSchoolarship.Text = "Posee beca:"
        '
        'tbResidency
        '
        Me.tbResidency.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbResidency.Location = New System.Drawing.Point(256, 339)
        Me.tbResidency.Multiline = True
        Me.tbResidency.Name = "tbResidency"
        Me.tbResidency.Size = New System.Drawing.Size(554, 95)
        Me.tbResidency.TabIndex = 34
        '
        'lbResidency
        '
        Me.lbResidency.AutoSize = True
        Me.lbResidency.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbResidency.Location = New System.Drawing.Point(51, 339)
        Me.lbResidency.Name = "lbResidency"
        Me.lbResidency.Size = New System.Drawing.Size(114, 25)
        Me.lbResidency.TabIndex = 33
        Me.lbResidency.Text = "Residencia:"
        '
        'tbCurrentPayment
        '
        Me.tbCurrentPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbCurrentPayment.Location = New System.Drawing.Point(256, 245)
        Me.tbCurrentPayment.Name = "tbCurrentPayment"
        Me.tbCurrentPayment.Size = New System.Drawing.Size(554, 30)
        Me.tbCurrentPayment.TabIndex = 32
        '
        'lbCurrentPayment
        '
        Me.lbCurrentPayment.AutoSize = True
        Me.lbCurrentPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCurrentPayment.Location = New System.Drawing.Point(51, 248)
        Me.lbCurrentPayment.Name = "lbCurrentPayment"
        Me.lbCurrentPayment.Size = New System.Drawing.Size(121, 25)
        Me.lbCurrentPayment.TabIndex = 31
        Me.lbCurrentPayment.Text = "Pago actual:"
        '
        'lbLeaveDate
        '
        Me.lbLeaveDate.AutoSize = True
        Me.lbLeaveDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLeaveDate.Location = New System.Drawing.Point(51, 205)
        Me.lbLeaveDate.Name = "lbLeaveDate"
        Me.lbLeaveDate.Size = New System.Drawing.Size(202, 25)
        Me.lbLeaveDate.TabIndex = 29
        Me.lbLeaveDate.Text = "Fecha de graduación:"
        '
        'lbBirthDate
        '
        Me.lbBirthDate.AutoSize = True
        Me.lbBirthDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBirthDate.Location = New System.Drawing.Point(51, 111)
        Me.lbBirthDate.Name = "lbBirthDate"
        Me.lbBirthDate.Size = New System.Drawing.Size(199, 25)
        Me.lbBirthDate.TabIndex = 27
        Me.lbBirthDate.Text = "Fecha de nacimiento:"
        '
        'tbIDCard
        '
        Me.tbIDCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbIDCard.Location = New System.Drawing.Point(256, 64)
        Me.tbIDCard.Name = "tbIDCard"
        Me.tbIDCard.Size = New System.Drawing.Size(554, 28)
        Me.tbIDCard.TabIndex = 26
        '
        'lbIDCard
        '
        Me.lbIDCard.AutoSize = True
        Me.lbIDCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIDCard.Location = New System.Drawing.Point(51, 64)
        Me.lbIDCard.Name = "lbIDCard"
        Me.lbIDCard.Size = New System.Drawing.Size(81, 25)
        Me.lbIDCard.TabIndex = 25
        Me.lbIDCard.Text = "Cédula:"
        '
        'tbName
        '
        Me.tbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbName.Location = New System.Drawing.Point(256, 19)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(554, 28)
        Me.tbName.TabIndex = 24
        '
        'lbName
        '
        Me.lbName.AutoSize = True
        Me.lbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbName.Location = New System.Drawing.Point(51, 19)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(171, 25)
        Me.lbName.TabIndex = 23
        Me.lbName.Text = "Nombre completo:"
        '
        'lbIndications
        '
        Me.lbIndications.AutoSize = True
        Me.lbIndications.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIndications.Location = New System.Drawing.Point(51, -60)
        Me.lbIndications.Name = "lbIndications"
        Me.lbIndications.Size = New System.Drawing.Size(384, 29)
        Me.lbIndications.TabIndex = 22
        Me.lbIndications.Text = "Digite los datos que se le solicitan:"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(343, 1120)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(129, 40)
        Me.btnSave.TabIndex = 21
        Me.btnSave.Text = "Guardar"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'dtpBirthDate
        '
        Me.dtpBirthDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBirthDate.Location = New System.Drawing.Point(256, 114)
        Me.dtpBirthDate.Name = "dtpBirthDate"
        Me.dtpBirthDate.Size = New System.Drawing.Size(554, 22)
        Me.dtpBirthDate.TabIndex = 41
        '
        'dtpEnterDate
        '
        Me.dtpEnterDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEnterDate.Location = New System.Drawing.Point(256, 157)
        Me.dtpEnterDate.Name = "dtpEnterDate"
        Me.dtpEnterDate.Size = New System.Drawing.Size(554, 22)
        Me.dtpEnterDate.TabIndex = 42
        '
        'dtpLeaveDate
        '
        Me.dtpLeaveDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpLeaveDate.Location = New System.Drawing.Point(256, 205)
        Me.dtpLeaveDate.Name = "dtpLeaveDate"
        Me.dtpLeaveDate.Size = New System.Drawing.Size(554, 22)
        Me.dtpLeaveDate.TabIndex = 43
        '
        'cboxSchoolarship
        '
        Me.cboxSchoolarship.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboxSchoolarship.FormattingEnabled = True
        Me.cboxSchoolarship.Location = New System.Drawing.Point(256, 497)
        Me.cboxSchoolarship.Name = "cboxSchoolarship"
        Me.cboxSchoolarship.Size = New System.Drawing.Size(554, 28)
        Me.cboxSchoolarship.TabIndex = 44
        '
        'lbRepresentatives
        '
        Me.lbRepresentatives.AutoSize = True
        Me.lbRepresentatives.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRepresentatives.Location = New System.Drawing.Point(53, 624)
        Me.lbRepresentatives.Name = "lbRepresentatives"
        Me.lbRepresentatives.Size = New System.Drawing.Size(268, 29)
        Me.lbRepresentatives.TabIndex = 45
        Me.lbRepresentatives.Text = "Representantes legales"
        '
        'tbRepresentativeName
        '
        Me.tbRepresentativeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRepresentativeName.Location = New System.Drawing.Point(262, 670)
        Me.tbRepresentativeName.Name = "tbRepresentativeName"
        Me.tbRepresentativeName.Size = New System.Drawing.Size(420, 28)
        Me.tbRepresentativeName.TabIndex = 47
        '
        'lbRepresentativeName
        '
        Me.lbRepresentativeName.AutoSize = True
        Me.lbRepresentativeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRepresentativeName.Location = New System.Drawing.Point(53, 671)
        Me.lbRepresentativeName.Name = "lbRepresentativeName"
        Me.lbRepresentativeName.Size = New System.Drawing.Size(171, 25)
        Me.lbRepresentativeName.TabIndex = 46
        Me.lbRepresentativeName.Text = "Nombre completo:"
        '
        'btnSearchRepresentative
        '
        Me.btnSearchRepresentative.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnSearchRepresentative.Location = New System.Drawing.Point(701, 665)
        Me.btnSearchRepresentative.Name = "btnSearchRepresentative"
        Me.btnSearchRepresentative.Size = New System.Drawing.Size(112, 36)
        Me.btnSearchRepresentative.TabIndex = 48
        Me.btnSearchRepresentative.Text = "Buscar"
        Me.btnSearchRepresentative.UseVisualStyleBackColor = True
        '
        'lboxFoundRepresentants
        '
        Me.lboxFoundRepresentants.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lboxFoundRepresentants.FormattingEnabled = True
        Me.lboxFoundRepresentants.ItemHeight = 22
        Me.lboxFoundRepresentants.Location = New System.Drawing.Point(56, 740)
        Me.lboxFoundRepresentants.Name = "lboxFoundRepresentants"
        Me.lboxFoundRepresentants.ScrollAlwaysVisible = True
        Me.lboxFoundRepresentants.Size = New System.Drawing.Size(757, 92)
        Me.lboxFoundRepresentants.TabIndex = 49
        '
        'lbFoundRepresentatives
        '
        Me.lbFoundRepresentatives.AutoSize = True
        Me.lbFoundRepresentatives.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbFoundRepresentatives.Location = New System.Drawing.Point(54, 709)
        Me.lbFoundRepresentatives.Name = "lbFoundRepresentatives"
        Me.lbFoundRepresentatives.Size = New System.Drawing.Size(229, 20)
        Me.lbFoundRepresentatives.TabIndex = 50
        Me.lbFoundRepresentatives.Text = "Representantes encontrados:"
        '
        'lbSelectedRepresentantText
        '
        Me.lbSelectedRepresentantText.AutoSize = True
        Me.lbSelectedRepresentantText.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lbSelectedRepresentantText.Location = New System.Drawing.Point(62, 851)
        Me.lbSelectedRepresentantText.Name = "lbSelectedRepresentantText"
        Me.lbSelectedRepresentantText.Size = New System.Drawing.Size(256, 24)
        Me.lbSelectedRepresentantText.TabIndex = 51
        Me.lbSelectedRepresentantText.Text = "Representante seleccionado:"
        '
        'tbSelectedRepresentative
        '
        Me.tbSelectedRepresentative.Enabled = False
        Me.tbSelectedRepresentative.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSelectedRepresentative.Location = New System.Drawing.Point(324, 848)
        Me.tbSelectedRepresentative.Name = "tbSelectedRepresentative"
        Me.tbSelectedRepresentative.Size = New System.Drawing.Size(489, 28)
        Me.tbSelectedRepresentative.TabIndex = 52
        '
        'cbRelationship
        '
        Me.cbRelationship.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cbRelationship.FormattingEnabled = True
        Me.cbRelationship.Location = New System.Drawing.Point(324, 893)
        Me.cbRelationship.Name = "cbRelationship"
        Me.cbRelationship.Size = New System.Drawing.Size(489, 28)
        Me.cbRelationship.TabIndex = 54
        '
        'lbRelationship
        '
        Me.lbRelationship.AutoSize = True
        Me.lbRelationship.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRelationship.Location = New System.Drawing.Point(51, 1019)
        Me.lbRelationship.Name = "lbRelationship"
        Me.lbRelationship.Size = New System.Drawing.Size(210, 25)
        Me.lbRelationship.TabIndex = 53
        Me.lbRelationship.Text = "Relación con el menor:"
        '
        'btnAddRepresentativeMinor
        '
        Me.btnAddRepresentativeMinor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnAddRepresentativeMinor.Location = New System.Drawing.Point(583, 939)
        Me.btnAddRepresentativeMinor.Name = "btnAddRepresentativeMinor"
        Me.btnAddRepresentativeMinor.Size = New System.Drawing.Size(232, 36)
        Me.btnAddRepresentativeMinor.TabIndex = 55
        Me.btnAddRepresentativeMinor.Text = "Asociar representante"
        Me.btnAddRepresentativeMinor.UseVisualStyleBackColor = True
        '
        'lboxAssociatedRepresentatives
        '
        Me.lboxAssociatedRepresentatives.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lboxAssociatedRepresentatives.FormattingEnabled = True
        Me.lboxAssociatedRepresentatives.ItemHeight = 22
        Me.lboxAssociatedRepresentatives.Location = New System.Drawing.Point(56, 1011)
        Me.lboxAssociatedRepresentatives.Name = "lboxAssociatedRepresentatives"
        Me.lboxAssociatedRepresentatives.ScrollAlwaysVisible = True
        Me.lboxAssociatedRepresentatives.Size = New System.Drawing.Size(756, 92)
        Me.lboxAssociatedRepresentatives.TabIndex = 56
        '
        'lbAssociatedRepresentatives
        '
        Me.lbAssociatedRepresentatives.AutoSize = True
        Me.lbAssociatedRepresentatives.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbAssociatedRepresentatives.Location = New System.Drawing.Point(52, 978)
        Me.lbAssociatedRepresentatives.Name = "lbAssociatedRepresentatives"
        Me.lbAssociatedRepresentatives.Size = New System.Drawing.Size(329, 20)
        Me.lbAssociatedRepresentatives.TabIndex = 57
        Me.lbAssociatedRepresentatives.Text = "Representantes asociados con este menor"
        '
        'lbRelation
        '
        Me.lbRelation.AutoSize = True
        Me.lbRelation.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lbRelation.Location = New System.Drawing.Point(62, 894)
        Me.lbRelation.Name = "lbRelation"
        Me.lbRelation.Size = New System.Drawing.Size(206, 24)
        Me.lbRelation.TabIndex = 58
        Me.lbRelation.Text = "Relación con el menor:"
        '
        'tbRecommendationMethod
        '
        Me.tbRecommendationMethod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbRecommendationMethod.Location = New System.Drawing.Point(256, 293)
        Me.tbRecommendationMethod.Name = "tbRecommendationMethod"
        Me.tbRecommendationMethod.Size = New System.Drawing.Size(554, 30)
        Me.tbRecommendationMethod.TabIndex = 60
        '
        'lbRecommendationMethod
        '
        Me.lbRecommendationMethod.AutoSize = True
        Me.lbRecommendationMethod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRecommendationMethod.Location = New System.Drawing.Point(51, 296)
        Me.lbRecommendationMethod.Name = "lbRecommendationMethod"
        Me.lbRecommendationMethod.Size = New System.Drawing.Size(159, 25)
        Me.lbRecommendationMethod.TabIndex = 59
        Me.lbRecommendationMethod.Text = "Recomendación:"
        '
        'lbLevel
        '
        Me.lbLevel.AutoSize = True
        Me.lbLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLevel.Location = New System.Drawing.Point(53, 460)
        Me.lbLevel.Name = "lbLevel"
        Me.lbLevel.Size = New System.Drawing.Size(122, 25)
        Me.lbLevel.TabIndex = 61
        Me.lbLevel.Text = "Posee beca:"
        '
        'cboxLevels
        '
        Me.cboxLevels.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboxLevels.FormattingEnabled = True
        Me.cboxLevels.Location = New System.Drawing.Point(256, 457)
        Me.cboxLevels.Name = "cboxLevels"
        Me.cboxLevels.Size = New System.Drawing.Size(554, 28)
        Me.cboxLevels.TabIndex = 62
        '
        'frmInsertUpdateMinor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(887, 438)
        Me.Controls.Add(Me.cboxLevels)
        Me.Controls.Add(Me.lbLevel)
        Me.Controls.Add(Me.tbRecommendationMethod)
        Me.Controls.Add(Me.lbRecommendationMethod)
        Me.Controls.Add(Me.lbRelation)
        Me.Controls.Add(Me.lbAssociatedRepresentatives)
        Me.Controls.Add(Me.lboxAssociatedRepresentatives)
        Me.Controls.Add(Me.btnAddRepresentativeMinor)
        Me.Controls.Add(Me.cbRelationship)
        Me.Controls.Add(Me.lbRelationship)
        Me.Controls.Add(Me.tbSelectedRepresentative)
        Me.Controls.Add(Me.lbSelectedRepresentantText)
        Me.Controls.Add(Me.lbFoundRepresentatives)
        Me.Controls.Add(Me.lboxFoundRepresentants)
        Me.Controls.Add(Me.btnSearchRepresentative)
        Me.Controls.Add(Me.tbRepresentativeName)
        Me.Controls.Add(Me.lbRepresentativeName)
        Me.Controls.Add(Me.lbRepresentatives)
        Me.Controls.Add(Me.cboxSchoolarship)
        Me.Controls.Add(Me.dtpLeaveDate)
        Me.Controls.Add(Me.dtpEnterDate)
        Me.Controls.Add(Me.dtpBirthDate)
        Me.Controls.Add(Me.lbEnterDate)
        Me.Controls.Add(Me.cboxGender)
        Me.Controls.Add(Me.lbGender)
        Me.Controls.Add(Me.lbSchoolarship)
        Me.Controls.Add(Me.tbResidency)
        Me.Controls.Add(Me.lbResidency)
        Me.Controls.Add(Me.tbCurrentPayment)
        Me.Controls.Add(Me.lbCurrentPayment)
        Me.Controls.Add(Me.lbLeaveDate)
        Me.Controls.Add(Me.lbBirthDate)
        Me.Controls.Add(Me.tbIDCard)
        Me.Controls.Add(Me.lbIDCard)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.lbName)
        Me.Controls.Add(Me.lbIndications)
        Me.Controls.Add(Me.btnSave)
        Me.Name = "frmInsertUpdateMinor"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Agregar menor"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbEnterDate As Label
    Friend WithEvents cboxGender As ComboBox
    Friend WithEvents lbGender As Label
    Friend WithEvents lbSchoolarship As Label
    Friend WithEvents tbResidency As TextBox
    Friend WithEvents lbResidency As Label
    Friend WithEvents tbCurrentPayment As TextBox
    Friend WithEvents lbCurrentPayment As Label
    Friend WithEvents lbLeaveDate As Label
    Friend WithEvents lbBirthDate As Label
    Friend WithEvents tbIDCard As TextBox
    Friend WithEvents lbIDCard As Label
    Friend WithEvents tbName As TextBox
    Friend WithEvents lbName As Label
    Friend WithEvents lbIndications As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents dtpBirthDate As DateTimePicker
    Friend WithEvents dtpEnterDate As DateTimePicker
    Friend WithEvents dtpLeaveDate As DateTimePicker
    Friend WithEvents cboxSchoolarship As ComboBox
    Friend WithEvents lbRepresentatives As Label
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents tbRepresentativeName As TextBox
    Friend WithEvents lbRepresentativeName As Label
    Friend WithEvents btnSearchRepresentative As Button
    Friend WithEvents lboxFoundRepresentants As ListBox
    Friend WithEvents lbFoundRepresentatives As Label
    Friend WithEvents lbSelectedRepresentantText As Label
    Friend WithEvents tbSelectedRepresentative As TextBox
    Friend WithEvents cbRelationship As ComboBox
    Friend WithEvents lbRelationship As Label
    Friend WithEvents btnAddRepresentativeMinor As Button
    Friend WithEvents lboxAssociatedRepresentatives As ListBox
    Friend WithEvents lbAssociatedRepresentatives As Label
    Friend WithEvents lbRelation As Label
    Friend WithEvents tbRecommendationMethod As TextBox
    Friend WithEvents lbRecommendationMethod As Label
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents BindingSource2 As BindingSource
    Friend WithEvents lbLevel As Label
    Friend WithEvents cboxLevels As ComboBox
End Class
