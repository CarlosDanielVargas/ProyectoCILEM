Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Windows.Forms

Public Module ExcelUtility
    Public Sub ExportDataGridViewToExcel(dataGridView As DataGridView, fileName As String)
        ' Create an instance of SaveFileDialog
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx"
        saveFileDialog.FileName = fileName

        ' Show the SaveFileDialog and get the selected file path
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = saveFileDialog.FileName

            ' Check if the file already exists
            If File.Exists(filePath) Then
                MessageBox.Show("El archivo ya existe. Por favor, elija otro nombre o ubicación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Create an instance of Excel application
            Dim excelApp As New Excel.Application()

            ' Create a new workbook
            Dim workbook As Excel.Workbook = excelApp.Workbooks.Add()

            ' Get the first worksheet
            Dim worksheet As Excel.Worksheet = workbook.Sheets(1)

            ' Set the column headers
            For colIndex As Integer = 1 To dataGridView.Columns.Count
                Dim columnName As String = dataGridView.Columns(colIndex - 1).Name

                ' Skip columns with specified names
                If columnName = "Eliminar" Or columnName = "Editar" Or columnName = "Detalles" Then
                    Continue For
                End If

                worksheet.Cells(1, colIndex).Value = dataGridView.Columns(colIndex - 1).HeaderText
            Next

            ' Set the cell values from the DataGridView
            For rowIndex As Integer = 0 To dataGridView.Rows.Count - 1
                For colIndex As Integer = 0 To dataGridView.Columns.Count - 1
                    Dim columnName As String = dataGridView.Columns(colIndex).Name

                    ' Skip columns with specified names
                    If columnName = "Eliminar" Or columnName = "Editar" Or columnName = "Detalles" Then
                        Continue For
                    End If

                    worksheet.Cells(rowIndex + 2, colIndex + 1).Value = dataGridView.Rows(rowIndex).Cells(colIndex).Value
                Next
            Next

            ' Save the workbook
            workbook.SaveAs(filePath)

            ' Close the workbook and Excel application
            workbook.Close()
            excelApp.Quit()

            ' Release the COM objects to avoid memory leaks
            ReleaseComObject(worksheet)
            ReleaseComObject(workbook)
            ReleaseComObject(excelApp)

            MessageBox.Show("Datos exportados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ReleaseComObject(obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
End Module
