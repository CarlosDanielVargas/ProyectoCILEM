<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MdiMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MdiMain))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.EstudiantesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuItemAddMinor = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuItemShowStudents = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncargadosLegalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuItemAddRepresentative = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuItemShowRepresentatives = New System.Windows.Forms.ToolStripMenuItem()
        Me.NivelesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuItemManageLevels = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuItemAddUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuItemListUsers = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuItemMyAccount = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EstudiantesToolStripMenuItem, Me.EncargadosLegalesToolStripMenuItem, Me.NivelesToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.menuItemMyAccount})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(975, 28)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'EstudiantesToolStripMenuItem
        '
        Me.EstudiantesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuItemAddMinor, Me.menuItemShowStudents})
        Me.EstudiantesToolStripMenuItem.Name = "EstudiantesToolStripMenuItem"
        Me.EstudiantesToolStripMenuItem.Size = New System.Drawing.Size(98, 24)
        Me.EstudiantesToolStripMenuItem.Text = "Estudiantes"
        '
        'menuItemAddMinor
        '
        Me.menuItemAddMinor.Name = "menuItemAddMinor"
        Me.menuItemAddMinor.Size = New System.Drawing.Size(225, 26)
        Me.menuItemAddMinor.Text = "Agregar estudiantes"
        '
        'menuItemShowStudents
        '
        Me.menuItemShowStudents.Name = "menuItemShowStudents"
        Me.menuItemShowStudents.Size = New System.Drawing.Size(225, 26)
        Me.menuItemShowStudents.Text = "Mostrar estudiantes"
        '
        'EncargadosLegalesToolStripMenuItem
        '
        Me.EncargadosLegalesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuItemAddRepresentative, Me.menuItemShowRepresentatives})
        Me.EncargadosLegalesToolStripMenuItem.Name = "EncargadosLegalesToolStripMenuItem"
        Me.EncargadosLegalesToolStripMenuItem.Size = New System.Drawing.Size(151, 24)
        Me.EncargadosLegalesToolStripMenuItem.Text = "Encargados legales"
        '
        'menuItemAddRepresentative
        '
        Me.menuItemAddRepresentative.Name = "menuItemAddRepresentative"
        Me.menuItemAddRepresentative.Size = New System.Drawing.Size(224, 26)
        Me.menuItemAddRepresentative.Text = "Agregar Encargado"
        '
        'menuItemShowRepresentatives
        '
        Me.menuItemShowRepresentatives.Name = "menuItemShowRepresentatives"
        Me.menuItemShowRepresentatives.Size = New System.Drawing.Size(224, 26)
        Me.menuItemShowRepresentatives.Text = "Mostrar Encargados"
        '
        'NivelesToolStripMenuItem
        '
        Me.NivelesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuItemManageLevels})
        Me.NivelesToolStripMenuItem.Name = "NivelesToolStripMenuItem"
        Me.NivelesToolStripMenuItem.Size = New System.Drawing.Size(71, 24)
        Me.NivelesToolStripMenuItem.Text = "Niveles"
        '
        'menuItemManageLevels
        '
        Me.menuItemManageLevels.Name = "menuItemManageLevels"
        Me.menuItemManageLevels.Size = New System.Drawing.Size(218, 26)
        Me.menuItemManageLevels.Text = "Administrar niveles"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuItemAddUser, Me.menuItemListUsers})
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(79, 24)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'menuItemAddUser
        '
        Me.menuItemAddUser.Name = "menuItemAddUser"
        Me.menuItemAddUser.Size = New System.Drawing.Size(198, 26)
        Me.menuItemAddUser.Text = "Agregar usuario"
        '
        'menuItemListUsers
        '
        Me.menuItemListUsers.Name = "menuItemListUsers"
        Me.menuItemListUsers.Size = New System.Drawing.Size(198, 26)
        Me.menuItemListUsers.Text = "Listar usuarios"
        '
        'menuItemMyAccount
        '
        Me.menuItemMyAccount.Name = "menuItemMyAccount"
        Me.menuItemMyAccount.Size = New System.Drawing.Size(88, 24)
        Me.menuItemMyAccount.Text = "Mi cuenta"
        '
        'ToolStrip
        '
        Me.ToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator2})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 28)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(975, 27)
        Me.ToolStrip.TabIndex = 6
        Me.ToolStrip.Text = "ToolStrip"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 447)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(975, 26)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(54, 20)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'MdiMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = Global.UI.My.Resources.Resources.logo_san_ramon_33_op
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(975, 473)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MdiMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Estudiantes CILEM"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents EstudiantesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menuItemAddMinor As ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents menuItemShowStudents As ToolStripMenuItem
    Friend WithEvents EncargadosLegalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menuItemAddRepresentative As ToolStripMenuItem
    Friend WithEvents menuItemShowRepresentatives As ToolStripMenuItem
    Friend WithEvents NivelesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menuItemManageLevels As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menuItemAddUser As ToolStripMenuItem
    Friend WithEvents menuItemListUsers As ToolStripMenuItem
    Friend WithEvents menuItemMyAccount As ToolStripMenuItem
End Class
