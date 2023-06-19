<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoggin
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
        Me.lbInstructions = New System.Windows.Forms.Label()
        Me.lbIDCard = New System.Windows.Forms.Label()
        Me.tbIDCard = New System.Windows.Forms.TextBox()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.lbPassword = New System.Windows.Forms.Label()
        Me.btnLoggin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbInstructions
        '
        Me.lbInstructions.AutoSize = True
        Me.lbInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lbInstructions.Location = New System.Drawing.Point(24, 48)
        Me.lbInstructions.Name = "lbInstructions"
        Me.lbInstructions.Size = New System.Drawing.Size(734, 26)
        Me.lbInstructions.TabIndex = 0
        Me.lbInstructions.Text = "Para acceder al sistema de registro de estudiantes del CILEM inicie sesión"
        '
        'lbIDCard
        '
        Me.lbIDCard.AutoSize = True
        Me.lbIDCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbIDCard.Location = New System.Drawing.Point(161, 148)
        Me.lbIDCard.Name = "lbIDCard"
        Me.lbIDCard.Size = New System.Drawing.Size(81, 25)
        Me.lbIDCard.TabIndex = 1
        Me.lbIDCard.Text = "Cédula:"
        '
        'tbIDCard
        '
        Me.tbIDCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.tbIDCard.Location = New System.Drawing.Point(259, 147)
        Me.tbIDCard.Name = "tbIDCard"
        Me.tbIDCard.Size = New System.Drawing.Size(383, 28)
        Me.tbIDCard.TabIndex = 2
        '
        'tbPassword
        '
        Me.tbPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.tbPassword.Location = New System.Drawing.Point(287, 204)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(355, 28)
        Me.tbPassword.TabIndex = 4
        '
        'lbPassword
        '
        Me.lbPassword.AutoSize = True
        Me.lbPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbPassword.Location = New System.Drawing.Point(161, 205)
        Me.lbPassword.Name = "lbPassword"
        Me.lbPassword.Size = New System.Drawing.Size(120, 25)
        Me.lbPassword.TabIndex = 3
        Me.lbPassword.Text = "Contraseña:"
        '
        'btnLoggin
        '
        Me.btnLoggin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnLoggin.Location = New System.Drawing.Point(316, 290)
        Me.btnLoggin.Name = "btnLoggin"
        Me.btnLoggin.Size = New System.Drawing.Size(169, 37)
        Me.btnLoggin.TabIndex = 5
        Me.btnLoggin.Text = "Iniciar Sesión"
        Me.btnLoggin.UseVisualStyleBackColor = True
        '
        'frmLoggin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 339)
        Me.Controls.Add(Me.btnLoggin)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.lbPassword)
        Me.Controls.Add(Me.tbIDCard)
        Me.Controls.Add(Me.lbIDCard)
        Me.Controls.Add(Me.lbInstructions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmLoggin"
        Me.Text = "Inicio de sesión"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbInstructions As Label
    Friend WithEvents lbIDCard As Label
    Friend WithEvents tbIDCard As TextBox
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents lbPassword As Label
    Friend WithEvents btnLoggin As Button
End Class
