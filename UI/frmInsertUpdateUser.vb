Imports DOM

Public Class frmInsertUpdateUser

    Private user As User
    Private isNew As Boolean

    'Constructor
    'Insert mode
    Public Sub New()
        InitializeComponent()
        user = New User()
        isNew = True
    End Sub

    'Update mode
    Public Sub New(user As User)
        InitializeComponent()
        Me.user = user
        isNew = False
    End Sub

    Private Sub frmInsertUpdateUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler lbPassword.VisibleChanged, AddressOf ElementVisibleChanged
        AddHandler lbPasswordConfirmation.VisibleChanged, AddressOf ElementVisibleChanged
        AddHandler tbPassword.VisibleChanged, AddressOf ElementVisibleChanged
        AddHandler tbPasswordConfirmation.VisibleChanged, AddressOf ElementVisibleChanged

        'Load as insert mode
        cboxIsActive.DataSource = [Enum].GetValues(GetType(User.IsActived))
        cboxIsActive.SelectedIndex = 0
        cboxRole.DataSource = [Enum].GetValues(GetType(User.Roles))
        cboxRole.SelectedIndex = 0
        If isNew Then
            Me.Text = "Insertar usuario"
            lbPasswordConfirmation.Visible = False
            tbPasswordConfirmation.Visible = False
            lbPassword.Visible = False
            tbPassword.Visible = False
        Else
            Me.Text = "Actualizar usuario"
            tbName.Text = user.Name
            cboxRole.SelectedIndex = user.Role
            cboxIsActive.SelectedIndex = user.IsActive
        End If

        ' Establecer el AutoSizeMode del formulario en GrowAndShrink
        Me.AutoSizeMode = AutoSizeMode.GrowAndShrink
    End Sub

    Private Sub ElementVisibleChanged(sender As Object, e As EventArgs)
        ' Ajustar el tamaño del formulario cuando cambia la visibilidad de un elemento
        AdjustFormSize()
    End Sub

    Private Sub AdjustFormSize()
        ' Calcular la nueva altura deseada del formulario
        Dim newHeight As Integer = 0
        For Each control As Control In tableLayoutPanel1.Controls
            If control.Visible Then
                newHeight = Math.Max(newHeight, control.Bottom)
            End If
        Next

        ' Ajustar la altura del formulario
        Me.Height = newHeight
    End Sub
End Class
