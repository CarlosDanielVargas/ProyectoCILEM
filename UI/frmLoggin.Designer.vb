<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLoggin
    Inherits System.Windows.Forms.Form

    ' Form reemplaza a Dispose para limpiar la lista de componentes.
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

    ' Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    ' NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    ' Se puede modificar usando el Diseñador de Windows Forms.  
    ' No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoggin))
        Me.panelContent = New System.Windows.Forms.Panel()
        Me.btnLoggin = New System.Windows.Forms.Button()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.lbPassword = New System.Windows.Forms.Label()
        Me.tbIDCard = New System.Windows.Forms.TextBox()
        Me.lbIDCard = New System.Windows.Forms.Label()
        Me.lbInstructions = New System.Windows.Forms.Label()
        Me.panelContent.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelContent
        '
        Me.panelContent.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.panelContent.BackColor = System.Drawing.Color.White
        Me.panelContent.Controls.Add(Me.btnLoggin)
        Me.panelContent.Controls.Add(Me.tbPassword)
        Me.panelContent.Controls.Add(Me.lbPassword)
        Me.panelContent.Controls.Add(Me.tbIDCard)
        Me.panelContent.Controls.Add(Me.lbIDCard)
        Me.panelContent.Controls.Add(Me.lbInstructions)
        Me.panelContent.Location = New System.Drawing.Point(0, 0)
        Me.panelContent.Name = "panelContent"
        Me.panelContent.Size = New System.Drawing.Size(800, 407)
        Me.panelContent.TabIndex = 0
        '
        'btnLoggin
        '
        Me.btnLoggin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnLoggin.FlatAppearance.BorderSize = 0
        Me.btnLoggin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoggin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnLoggin.ForeColor = System.Drawing.Color.White
        Me.btnLoggin.Location = New System.Drawing.Point(313, 242)
        Me.btnLoggin.Name = "btnLoggin"
        Me.btnLoggin.Size = New System.Drawing.Size(169, 37)
        Me.btnLoggin.TabIndex = 5
        Me.btnLoggin.Text = "Iniciar Sesión"
        Me.btnLoggin.UseVisualStyleBackColor = False
        '
        'tbPassword
        '
        Me.tbPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.tbPassword.Location = New System.Drawing.Point(282, 178)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(355, 28)
        Me.tbPassword.TabIndex = 4
        Me.tbPassword.UseSystemPasswordChar = True
        '
        'lbPassword
        '
        Me.lbPassword.AutoSize = True
        Me.lbPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbPassword.Location = New System.Drawing.Point(156, 179)
        Me.lbPassword.Name = "lbPassword"
        Me.lbPassword.Size = New System.Drawing.Size(120, 25)
        Me.lbPassword.TabIndex = 3
        Me.lbPassword.Text = "Contraseña:"
        Me.lbPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbIDCard
        '
        Me.tbIDCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.tbIDCard.Location = New System.Drawing.Point(254, 121)
        Me.tbIDCard.Name = "tbIDCard"
        Me.tbIDCard.Size = New System.Drawing.Size(383, 28)
        Me.tbIDCard.TabIndex = 2
        '
        'lbIDCard
        '
        Me.lbIDCard.AutoSize = True
        Me.lbIDCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbIDCard.Location = New System.Drawing.Point(156, 122)
        Me.lbIDCard.Name = "lbIDCard"
        Me.lbIDCard.Size = New System.Drawing.Size(81, 25)
        Me.lbIDCard.TabIndex = 1
        Me.lbIDCard.Text = "Cédula:"
        Me.lbIDCard.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbInstructions
        '
        Me.lbInstructions.AutoSize = True
        Me.lbInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lbInstructions.Location = New System.Drawing.Point(104, 40)
        Me.lbInstructions.Name = "lbInstructions"
        Me.lbInstructions.Size = New System.Drawing.Size(473, 26)
        Me.lbInstructions.TabIndex = 0
        Me.lbInstructions.Text = "Digite sus credenciales para acceder al sistema"
        Me.lbInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmLoggin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 407)
        Me.Controls.Add(Me.panelContent)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLoggin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de sesión"
        Me.panelContent.ResumeLayout(False)
        Me.panelContent.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelContent As Panel
    Friend WithEvents lbInstructions As Label
    Friend WithEvents lbIDCard As Label
    Friend WithEvents tbIDCard As TextBox
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents lbPassword As Label
    Friend WithEvents btnLoggin As Button
End Class
