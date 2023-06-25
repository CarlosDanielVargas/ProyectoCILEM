Imports BL
Imports DOM

Public Class frmInsertUpdateUser

    Private user As User
    Private isNew As Boolean
    Private parent As frmUserList
    Private toChangePassword As Boolean = False

    'Constructor
    'Insert mode
    Public Sub New()
        InitializeComponent()
        user = New User()
        isNew = True
    End Sub

    'Update mode
    Public Sub New(user As User, parent As frmUserList)
        InitializeComponent()
        Me.user = user
        isNew = False
        Me.parent = parent
    End Sub

    Public Sub New(user As User)
        InitializeComponent()
        Me.user = user
        isNew = False
        toChangePassword = True
    End Sub

    Private Sub frmInsertUpdateUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler lbPassword.VisibleChanged, AddressOf ElementVisibleChanged
        AddHandler lbPasswordConfirmation.VisibleChanged, AddressOf ElementVisibleChanged
        AddHandler tbPassword.VisibleChanged, AddressOf ElementVisibleChanged
        AddHandler tbPasswordConfirmation.VisibleChanged, AddressOf ElementVisibleChanged

        'Load as insert mode
        cboxIsActive.DataSource = [Enum].GetValues(GetType(User.IsActived))
        cboxRole.DataSource = [Enum].GetValues(GetType(User.Roles))
        If isNew Then
            Me.Text = "Insertar usuario"
            lbPasswordConfirmation.Visible = False
            tbPasswordConfirmation.Visible = False
            lbPassword.Visible = False
            tbPassword.Visible = False
            tblpPanel.RowStyles(4).Height = 0
            tblpPanel.RowStyles(5).Height = 0
        Else
            Me.Text = "Actualizar usuario"
            tbIDCard.Text = user.IDCard
            tbName.Text = user.Name
            tbIDCard.Enabled = False
            cboxRole.SelectedIndex = user.Role
            cboxIsActive.SelectedIndex = user.IsActive
            If user.Name = Globals.current_user.Name And toChangePassword Then
                cboxIsActive.Visible = False
                cboxRole.Visible = False
                tblpPanel.RowStyles(2).Height = 0
                tblpPanel.RowStyles(3).Height = 0

            Else
                cboxIsActive.Enabled = True
                cboxRole.Enabled = True
                lbPasswordConfirmation.Visible = False
                tbPasswordConfirmation.Visible = False
                lbPassword.Visible = False
                tbPassword.Visible = False
                tblpPanel.RowStyles(4).Height = 0
                tblpPanel.RowStyles(5).Height = 0
            End If
        End If

        ' Establecer el AutoSizeMode del formulario en GrowAndShrink
        Me.AutoSizeMode = AutoSizeMode.GrowAndShrink

        ' Ajustar el tamaño del formulario inicialmente
        AdjustFormSize()
    End Sub

    Private Sub ElementVisibleChanged(sender As Object, e As EventArgs)
        ' Ajustar el tamaño del formulario cuando cambia la visibilidad de un elemento
        AdjustFormSize()
    End Sub

    Private Sub AdjustFormSize()
        ' Calcular la nueva altura deseada del formulario
        Dim newHeight As Integer = 0
        For Each control As Control In tblpPanel.Controls
            If control.Visible Then
                newHeight = Math.Max(newHeight, control.Bottom)
            End If
        Next

        ' Ajustar la altura del formulario
        Me.Height = newHeight
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim userManager As New UserManager()
            user.IDCard = tbIDCard.Text
            user.Name = tbName.Text
            user.Role = cboxRole.SelectedIndex
            user.IsActive = cboxIsActive.SelectedIndex
            user.ValidateAll()
            If Not isNew Then
                If user.Name = Globals.current_user.Name Then
                    user.Password = tbPassword.Text
                    user.PasswordConfirm = tbPasswordConfirmation.Text
                    user.ValidateAllChangePassword()
                    user.HasChangedPassword = User.ChangedPassword.Sí
                Else
                    parent.refreshUserList()
                End If
                userManager.UpdateToDB(user)
            Else
                    user.GenerateRandomPassword()
                user.HasChangedPassword = User.ChangedPassword.No
                userManager.SaveToDB(user)
            End If
            MessageBox.Show("Usuario guardado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
