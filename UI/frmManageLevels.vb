Imports BL
Imports DOM

Public Class frmManageLevels
    Private editing As Boolean = False

    Private Sub frmNewLevel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configuración inicial del DataGridView y otros elementos de la interfaz de usuario
        dgvLevels.ReadOnly = True
        dgvLevels.AllowUserToAddRows = False
        dgvLevels.AllowUserToDeleteRows = False

        dgvLevels.Columns.Add("LevelID", "LevelID")
        dgvLevels.Columns("LevelID").Visible = False
        dgvLevels.Columns.Add("Nombre", "Nombre")
        Dim btnEditColumn As New DataGridViewButtonColumn()
        btnEditColumn.HeaderText = "Editar"
        btnEditColumn.Name = "Editar"
        btnEditColumn.Text = "Editar"
        btnEditColumn.UseColumnTextForButtonValue = True

        dgvLevels.Columns.Add(btnEditColumn)
        Dim btnDeleteColumn As New DataGridViewButtonColumn()
        btnDeleteColumn.HeaderText = "Eliminar"
        btnDeleteColumn.Name = "Eliminar"
        btnDeleteColumn.Text = "Eliminar"
        btnDeleteColumn.UseColumnTextForButtonValue = True

        dgvLevels.Columns.Add(btnDeleteColumn)

        refreshDataGridView()

        lbMode.Text = "Agregar niveles"

        btnResetMode.Visible = False
    End Sub

    Private Sub refreshDataGridView()
        dgvLevels.Rows.Clear()

        ' Obtener los niveles desde tu lógica de negocios (BL) o fuente de datos
        Dim levelManager As New LevelManager()
        Dim levels As List(Of Level) = levelManager.loadAllFromDB()

        ' Agregar cada nivel como una fila en el DataGridView
        For Each level As Level In levels
            dgvLevels.Rows.Add(level.LevelID, level.Name)
        Next
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim levelManager As New LevelManager()
            Dim level As New Level()
            level.Name = tbName.Text
            level.ValidateAll()
            If Not editing Then
                levelManager.saveToDB(level)
                MessageBox.Show("Nivel agregado exitosamente")
            Else
                ' Obtener el LevelID del nivel seleccionado en el DataGridView
                Dim levelID As Integer = Convert.ToInt32(dgvLevels.SelectedRows(0).Cells("LevelID").Value)
                level.LevelID = levelID
                levelManager.updateToDB(level)
                MessageBox.Show("Nivel editado exitosamente")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        refreshDataGridView()
        changeMode()
    End Sub

    Private Sub dgvLevels_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLevels.CellContentClick
        ' Verificar si se hizo clic en la columna "Editar"
        If e.ColumnIndex = dgvLevels.Columns("Editar").Index AndAlso e.RowIndex >= 0 Then
            ' Obtener los datos de la fila seleccionada
            Dim rowIndex As Integer = e.RowIndex
            Dim levelID As Integer = Convert.ToInt32(dgvLevels.Rows(rowIndex).Cells("LevelID").Value)
            Dim levelName As String = dgvLevels.Rows(rowIndex).Cells("Nombre").Value.ToString()

            ' Realizar acciones de edición según sea necesario
            editing = True
            tbName.Text = levelName
            lbMode.Text = "Editando nivel: " & levelName
            MessageBox.Show("Editando nivel: " & levelName)
            btnResetMode.Visible = True
        End If

        ' Verificar si se hizo clic en la columna "Eliminar"
        If e.ColumnIndex = dgvLevels.Columns("Eliminar").Index AndAlso e.RowIndex >= 0 Then
            ' Obtener los datos de la fila seleccionada
            Dim rowIndex As Integer = e.RowIndex
            Dim levelID As Integer = Convert.ToInt32(dgvLevels.Rows(rowIndex).Cells("LevelID").Value)
            Dim levelName As String = dgvLevels.Rows(rowIndex).Cells("Nombre").Value.ToString()

            ' Realizar acciones de eliminación según sea necesario
            MessageBox.Show("Eliminar nivel: " & levelName)
            Try
                Dim levelManager As New LevelManager()
                Dim level As New Level()
                level.LevelID = levelID
                levelManager.deleteFromDB(level)
                MessageBox.Show("Nivel eliminado exitosamente")
            Catch ex As Exception
                MessageBox.Show("El nivel no pudo eliminarse, ya que posee estudiantes asociados")
            End Try

            refreshDataGridView()
            changeMode()
        End If
    End Sub

    Private Sub btnResetMode_Click(sender As Object, e As EventArgs) Handles btnResetMode.Click
        changeMode()
    End Sub

    Private Sub changeMode()
        editing = False
        tbName.Text = ""
        lbMode.Text = "Agregar niveles"
        btnResetMode.Visible = False
    End Sub
End Class
