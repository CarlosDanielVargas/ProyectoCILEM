Imports DOM
Imports BL

Public Class frmUserList
    ' This form is used to display a list of users
    Private users As List(Of User)

    ' This event handler is called when the form is loaded
    Private Sub frmUserList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvUsers.ReadOnly = True ' Set the DataGridView to read-only
        dgvUsers.AllowUserToAddRows = False ' Disable the ability to add new rows
        dgvUsers.AllowUserToDeleteRows = False ' Disable the ability to delete rows

        'Fill the combo box with the roles
        cboxRole.DataSource = [Enum].GetValues(GetType(User.Roles))
        cboxRole.SelectedIndex = 0

        'Fill the combo box with the states
        cboxStatus.DataSource = [Enum].GetValues(GetType(User.IsActived))
        cboxStatus.SelectedIndex = 0

        ' Add the columns to the DataGridView
        dgvUsers.Columns.Add("Nombre", "Nombre")
        dgvUsers.Columns.Add("Cédula", "Cédula")
        dgvUsers.Columns.Add("Rol", "Rol")
        dgvUsers.Columns.Add("Estado", "Estado")

        ' Add the buttons column to the DataGridView
        ' This columns will contain the "Eliminar" and "Editar" buttons

        Dim btnDeleteColumn As New DataGridViewButtonColumn()
        btnDeleteColumn.HeaderText = "Eliminar"
        btnDeleteColumn.Name = "Eliminar"
        btnDeleteColumn.Text = "Eliminar"
        btnDeleteColumn.UseColumnTextForButtonValue = True

        Dim btnEditColumn As New DataGridViewButtonColumn()
        btnEditColumn.HeaderText = "Editar"
        btnEditColumn.Name = "Editar"
        btnEditColumn.Text = "Editar"
        btnEditColumn.UseColumnTextForButtonValue = True

        dgvUsers.Columns.Add(btnDeleteColumn)
        dgvUsers.Columns.Add(btnEditColumn)

        ' Refresh the users list
        refreshUserList()

        ' Set message of filter label
        lbCurrentFilter.Text = "Se muestran todos los usuarios, un total de " & users.Count & " usuario(s)"
    End Sub

    Private Sub dgvUsers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellContentClick
        ' Check if the clicked cell is a button cell and the corresponding column index
        If e.ColumnIndex = dgvUsers.Columns("Eliminar").Index AndAlso e.RowIndex >= 0 Then
            ' "Eliminar" button clicked
            Dim rowIndex As Integer = e.RowIndex
            Dim user As User = users(rowIndex)
            ' Perform delete action using the user object
            Dim result As DialogResult = MessageBox.Show("¿Está seguro que desea eliminar el usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.No Then
                Return
            End If
            Try
                Dim userManager As New UserManager()
                userManager.DeleteFromDB(user)
                MessageBox.Show("Se eliminó el usuario", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("No se pudo eliminar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            ' Refresh the users list
            refreshUserList()
        ElseIf e.ColumnIndex = dgvUsers.Columns("Editar").Index AndAlso e.RowIndex >= 0 Then
            ' "Editar" button clicked
            Dim rowIndex As Integer = e.RowIndex
            Dim user As User = users(rowIndex)
            ' Open the form for editing the user details using the user object
            Dim form As New frmInsertUpdateUser(user, Me)
            form.MdiParent = Me.MdiParent
            form.Show()
        End If
    End Sub

    Public Sub refreshUserList()
        Dim userManager As New UserManager()
        users = userManager.LoadAllFromDB()

        ' Clear the existing rows in the DataGridView
        dgvUsers.Rows.Clear()

        ' Add the users to the DataGridView
        For Each user As User In users
            Dim role As String = ""
            role = If(user.Role = 0, "Administrador", "Usuario")
            Dim isActive As String = ""
            isActive = If(user.IsActive = 0, "Activo", "Inactivo")
            dgvUsers.Rows.Add(user.Name, user.IDCard, role, isActive)
        Next
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Dim IDCard As String = tbIDCard.Text
        Dim role As Integer = cboxRole.SelectedIndex
        Dim isActive As Integer = cboxStatus.SelectedIndex

        ' Apply the filter to the user list using LINQ
        Dim filteredUsers As IEnumerable(Of User) = users

        If Not String.IsNullOrEmpty(IDCard) Then
            filteredUsers = filteredUsers.Where(Function(user) user.IDCard <> IDCard)
        End If

        If role >= 0 Then
            filteredUsers = filteredUsers.Where(Function(user) user.Role = role)
        End If

        If isActive >= 0 Then
            filteredUsers = filteredUsers.Where(Function(user) user.IsActive = isActive)
        End If

        ' Get the string representation of the role and status
        Dim userRole As String = ""
        userRole = If(role = 0, "Administrador", "Usuario")
        Dim userStatus As String = ""
        userStatus = If(isActive, "Activo", "Inactivo")

        ' Clear the existing rows in the DataGridView
        dgvUsers.Rows.Clear()

        ' Add the filtered users to the DataGridView
        For Each user As User In filteredUsers
            dgvUsers.Rows.Add(user.Name, user.IDCard, userRole, userStatus)
        Next

        ' Set message of filter label
        lbCurrentFilter.Text = "Filtro aplicado: cédula = " & IDCard & ", rol = " & userRole & ", Estado = " & userStatus & " - Se muestran " & filteredUsers.Count() & " usuario(s)"
    End Sub
End Class
