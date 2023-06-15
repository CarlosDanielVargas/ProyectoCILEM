Imports BL
Imports DOM

Public Class frmNewLevel
    Private Sub frmNewLevel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim levelManager As New LevelManager()
        Dim levels As List(Of Level) = levelManager.loadAllFromDB()
        lboxLevels.DataSource = levels
        lboxLevels.DisplayMember = "Name"
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim levelManager As New LevelManager()
        Dim level As New Level()
            level.Name = tbName.Text
            level.ValidateAll()
            levelManager.saveToDB(level)
            Dim levels As List(Of Level) = levelManager.loadAllFromDB()
            lboxLevels.DataSource = levels
            lboxLevels.DisplayMember = "Name"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class