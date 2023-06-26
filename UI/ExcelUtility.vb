Imports BL
Imports DOM
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Windows.Forms

Public Module ExcelUtility
    Public Sub ExportDataGridViewToExcel(dataGridView As DataGridView, fileName As String)
        ' Create an instance of SaveFileDialog
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx"
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
            Dim headerRange As Excel.Range = worksheet.Range("A1").Resize(ColumnSize:=dataGridView.Columns.Count)
            headerRange.Value = dataGridView.Columns.Cast(Of DataGridViewColumn).Where(Function(col) col.Name <> "Eliminar" AndAlso col.Name <> "Editar" AndAlso col.Name <> "Detalles").Select(Function(col) col.HeaderText).ToArray()
            headerRange.Font.Bold = True
            headerRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray)

            ' Set the cell values from the DataGridView
            Dim rowCount As Integer = dataGridView.Rows.Count
            Dim columnCount As Integer = dataGridView.Columns.Cast(Of DataGridViewColumn).Count(Function(col) col.Name <> "Eliminar" AndAlso col.Name <> "Editar" AndAlso col.Name <> "Detalles")
            Dim dataValues(rowCount - 1, columnCount - 1) As Object

            For rowIndex As Integer = 0 To rowCount - 1
                Dim columnOffset As Integer = 0

                For colIndex As Integer = 0 To dataGridView.Columns.Count - 1
                    Dim columnName As String = dataGridView.Columns(colIndex).Name

                    ' Skip columns with specified names
                    If columnName = "Eliminar" Or columnName = "Editar" Or columnName = "Detalles" Then
                        Continue For
                    End If

                    dataValues(rowIndex, colIndex - columnOffset) = dataGridView.Rows(rowIndex).Cells(colIndex).Value
                Next
            Next

            Dim dataRange As Excel.Range = worksheet.Range("A2").Resize(rowCount, columnCount)
            dataRange.Value = dataValues

            ' Auto-fit columns
            worksheet.Columns.AutoFit()

            ' Save the workbook
            workbook.SaveAs(filePath)

            ' Close the workbook and Excel application
            workbook.Close()
            excelApp.Quit()

            ' Release the COM objects to avoid memory leaks
            ReleaseComObject(dataRange)
            ReleaseComObject(headerRange)
            ReleaseComObject(worksheet)
            ReleaseComObject(workbook)
            ReleaseComObject(excelApp)

            MessageBox.Show("Datos exportados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Public Sub ExportMinorDetailsToExcel(minorForm As frmMinorDetails)
        If minorForm Is Nothing Then
            Throw New ArgumentNullException(NameOf(minorForm))
        End If
        ' Create an instance of SaveFileDialog
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx"
        saveFileDialog.FileName = "Reporte_Menor_" & minorForm.minor.MinorID & ".xlsx"

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

            ' Set the minor details
            worksheet.Range("A1").Value = "Información del Menor"
            worksheet.Range("A1:E1").Merge()
            worksheet.Range("A1:E1").Font.Bold = True
            worksheet.Range("A1:E1").HorizontalAlignment = Excel.Constants.xlCenter
            worksheet.Range("A1:E1").Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray)

            worksheet.Cells(2, 1).Value = "Nombre Completo:"
            worksheet.Cells(2, 2).Value = minorForm.txtNombreCompleto.Text

            worksheet.Cells(3, 1).Value = "Fecha de Egreso:"
            worksheet.Cells(3, 2).Value = minorForm.txtFechaEgreso.Text

            worksheet.Cells(4, 1).Value = "Fecha de Ingreso:"
            worksheet.Cells(4, 2).Value = minorForm.txtFechaIngreso.Text

            worksheet.Cells(5, 1).Value = "Fecha de Nacimiento:"
            worksheet.Cells(5, 2).Value = minorForm.txtFechaNacimiento.Text

            worksheet.Cells(6, 1).Value = "Residencia:"
            worksheet.Cells(6, 2).Value = minorForm.txtResidencia.Text

            worksheet.Cells(7, 1).Value = "Nivel:"
            worksheet.Cells(7, 2).Value = minorForm.txtNivel.Text

            worksheet.Cells(8, 1).Value = "Género:"
            worksheet.Cells(8, 2).Value = minorForm.txtGenero.Text

            worksheet.Cells(9, 1).Value = "Beca:"
            worksheet.Cells(9, 2).Value = minorForm.txtBeca.Text

            worksheet.Cells(10, 1).Value = "Método de Recomendación:"
            worksheet.Cells(10, 2).Value = minorForm.txtMetodoRecomendacion.Text

            worksheet.Cells(11, 1).Value = "Cédula Menor:"
            worksheet.Cells(11, 2).Value = minorForm.txtCedulaMenor.Text

            worksheet.Cells(12, 1).Value = "Jornada:"
            worksheet.Cells(12, 2).Value = minorForm.txtJornada.Text

            ' Set the column headers for representatives
            Dim headerRow As Integer = 14
            worksheet.Cells(headerRow, 1).Value = "Representantes Legales"
            worksheet.Range("A" & headerRow.ToString() & ":E" & headerRow.ToString()).Merge()
            worksheet.Range("A" & headerRow.ToString() & ":E" & headerRow.ToString()).Font.Bold = True
            worksheet.Range("A" & headerRow.ToString() & ":E" & headerRow.ToString()).HorizontalAlignment = Excel.Constants.xlCenter
            worksheet.Range("A" & headerRow.ToString() & ":E" & headerRow.ToString()).Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray)

            ' Set the column headers
            Dim columnHeaders() As String = {"Nombre", "Cédula", "Correo", "Teléfono"}
            For colIndex As Integer = 1 To columnHeaders.Length
                worksheet.Cells(headerRow + 1, colIndex).Value = columnHeaders(colIndex - 1)
                worksheet.Columns(colIndex).AutoFit()
                worksheet.Range(worksheet.Cells(headerRow + 1, colIndex), worksheet.Cells(headerRow + 1, colIndex)).Font.Bold = True
                worksheet.Range(worksheet.Cells(headerRow + 1, colIndex), worksheet.Cells(headerRow + 1, colIndex)).Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray)
            Next

            ' Set the representatives data
            Dim representativesRow As Integer = headerRow + 2
            For rowIndex As Integer = 0 To minorForm.dgvRepresentatives.Rows.Count - 1
                For colIndex As Integer = 0 To minorForm.dgvRepresentatives.Columns.Count - 1
                    Dim columnName As String = minorForm.dgvRepresentatives.Columns(colIndex).Name

                    If columnName = "Eliminar" Or columnName = "Editar" Or columnName = "Detalles" Then
                        Continue For
                    End If

                    worksheet.Cells(representativesRow + rowIndex, colIndex + 1).Value = minorForm.dgvRepresentatives.Rows(rowIndex).Cells(colIndex).Value
                    worksheet.Columns(colIndex + 1).AutoFit()
                Next
            Next

            ' Set the column headers for payments
            Dim paymentsHeaderRow As Integer = representativesRow + minorForm.dgvRepresentatives.Rows.Count + 2
            worksheet.Cells(paymentsHeaderRow, 1).Value = "Pagos Realizados"
            worksheet.Range("A" & paymentsHeaderRow.ToString() & ":E" & paymentsHeaderRow.ToString()).Merge()
            worksheet.Range("A" & paymentsHeaderRow.ToString() & ":E" & paymentsHeaderRow.ToString()).Font.Bold = True
            worksheet.Range("A" & paymentsHeaderRow.ToString() & ":E" & paymentsHeaderRow.ToString()).HorizontalAlignment = Excel.Constants.xlCenter
            worksheet.Range("A" & paymentsHeaderRow.ToString() & ":E" & paymentsHeaderRow.ToString()).Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray)

            ' Set the column headers
            Dim paymentsColumnHeaders() As String = {"Fecha", "Monto", "Mes cancelado", "Observaciones", "Nº Depósito"}
            For colIndex As Integer = 1 To paymentsColumnHeaders.Length
                worksheet.Cells(paymentsHeaderRow + 1, colIndex).Value = paymentsColumnHeaders(colIndex - 1)
                worksheet.Columns(colIndex).AutoFit()
                worksheet.Range(worksheet.Cells(paymentsHeaderRow + 1, colIndex), worksheet.Cells(paymentsHeaderRow + 1, colIndex)).Font.Bold = True
                worksheet.Range(worksheet.Cells(paymentsHeaderRow + 1, colIndex), worksheet.Cells(paymentsHeaderRow + 1, colIndex)).Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray)
            Next

            ' Set the payments data
            Dim paymentsRow As Integer = paymentsHeaderRow + 2
            For rowIndex As Integer = 0 To minorForm.dgvPayments.Rows.Count - 1
                For colIndex As Integer = 0 To minorForm.dgvPayments.Columns.Count - 1
                    worksheet.Cells(paymentsRow + rowIndex, colIndex + 1).Value = minorForm.dgvPayments.Rows(rowIndex).Cells(colIndex).Value
                    worksheet.Columns(colIndex + 1).AutoFit()
                Next
            Next

            ' Save the workbook
            workbook.SaveAs(filePath)

            ' Close the workbook and Excel application
            workbook.Close()
            excelApp.Quit()

            ' Release the resources
            ReleaseComObject(worksheet)
            ReleaseComObject(workbook)
            ReleaseComObject(excelApp)

            ' Show a success message
            MessageBox.Show("La información se ha exportado exitosamente.", "Exportación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Public Sub ExportRepresentativeDetailsToExcel(form As frmRepresentativeDetails)
        ' Create a new Excel application
        Dim excelApp As New Excel.Application()

        ' Create a new workbook and worksheet
        Dim workbook As Excel.Workbook = excelApp.Workbooks.Add()
        Dim worksheet As Excel.Worksheet = workbook.Sheets(1)

        ' Set the worksheet name
        worksheet.Name = "Detalles del Representante"

        ' Set the header row
        Dim headerRow As Integer = 1
        worksheet.Range("A" & headerRow.ToString() & ":B" & headerRow.ToString()).Merge()
        worksheet.Range("A" & headerRow.ToString() & ":B" & headerRow.ToString()).Font.Bold = True
        worksheet.Range("A" & headerRow.ToString() & ":B" & headerRow.ToString()).HorizontalAlignment = Excel.Constants.xlCenter
        worksheet.Range("A" & headerRow.ToString() & ":B" & headerRow.ToString()).Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray)

        ' Set the column headers
        worksheet.Cells(headerRow, 1).Value = "Campo"
        worksheet.Cells(headerRow, 2).Value = "Valor"
        worksheet.Columns("A:B").AutoFit()

        ' Set the representative details
        Dim representative As Representative = form.representative
        Dim representativeDetails As String(,) = {
        {"Género", representative.Gender.ToString()},
        {"Ocupación", representative.Occupation},
        {"Estado Civil", representative.MaritalStatus.ToString()},
        {"Teléfono", representative.Phone},
        {"Lugar de Trabajo", representative.WorkPlace},
        {"Residencia", representative.Residency},
        {"Correo Electrónico", representative.Mail},
        {"Nombre", representative.Name},
        {"Cédula", representative.RepresentativeID}
    }
        Dim detailsRow As Integer = headerRow + 1
        For rowIndex As Integer = 0 To representativeDetails.GetLength(0) - 1
            worksheet.Cells(detailsRow + rowIndex, 1).Value = representativeDetails(rowIndex, 0)
            worksheet.Cells(detailsRow + rowIndex, 2).Value = representativeDetails(rowIndex, 1)
        Next

        ' Set the minors table
        Dim minorManager As New MinorManager()
        Dim minors As List(Of Minor) = minorManager.searchByRepresentativeID(representative.RepresentativeID)
        Dim minorsTableHeaderRow As Integer = detailsRow + representativeDetails.GetLength(0) + 2
        worksheet.Cells(minorsTableHeaderRow, 1).Value = "Menores Relacionados"
        worksheet.Range("A" & minorsTableHeaderRow.ToString() & ":E" & minorsTableHeaderRow.ToString()).Merge()
        worksheet.Range("A" & minorsTableHeaderRow.ToString() & ":E" & minorsTableHeaderRow.ToString()).Font.Bold = True
        worksheet.Range("A" & minorsTableHeaderRow.ToString() & ":E" & minorsTableHeaderRow.ToString()).HorizontalAlignment = Excel.Constants.xlCenter
        worksheet.Range("A" & minorsTableHeaderRow.ToString() & ":E" & minorsTableHeaderRow.ToString()).Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray)

        ' Set the column headers for minors table
        Dim minorsTableColumnHeaders() As String = {"Cédula", "Nombre completo", "Nivel", "Vínculo", "Género"}
        For colIndex As Integer = 1 To minorsTableColumnHeaders.Length
            worksheet.Cells(minorsTableHeaderRow + 1, colIndex).Value = minorsTableColumnHeaders(colIndex - 1)
        Next
        worksheet.Columns("A:E").AutoFit()

        ' Set the data rows for minors table
        Dim minorsDataRow As Integer = minorsTableHeaderRow + 2
        For rowIndex As Integer = 0 To minors.Count - 1
            worksheet.Cells(minorsDataRow + rowIndex, 1).Value = minors(rowIndex).MinorID
            worksheet.Cells(minorsDataRow + rowIndex, 2).Value = minors(rowIndex).Name
            worksheet.Cells(minorsDataRow + rowIndex, 3).Value = minors(rowIndex).Level.Name
            worksheet.Cells(minorsDataRow + rowIndex, 4).Value = minors(rowIndex).RecommendationMethod
            worksheet.Cells(minorsDataRow + rowIndex, 5).Value = minors(rowIndex).Gender
        Next

        ' Save the workbook
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Title = "Guardar archivo de Excel"
        saveFileDialog.Filter = "Archivos de Excel|*.xlsx"
        saveFileDialog.FileName = "Reporte_" & representative.Name & "_" & DateTime.Now.ToString("dd-MM-yyyy") & ".xlsx"
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = saveFileDialog.FileName
            workbook.SaveAs(filePath)
            workbook.Close()
            excelApp.Quit()
            ReleaseComObject(worksheet)
            ReleaseComObject(workbook)
            ReleaseComObject(excelApp)
            MessageBox.Show("La información se ha exportado exitosamente.", "Exportación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
