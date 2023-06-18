Imports BL
Imports DOM

Public Class frmInsertUpdateMinor
    Private selectedRepresentative As Representative
    Private representativeMinors As List(Of RepresentativeMinor)
    Private filteredRepresentatives As List(Of Representative)
    Private representatives As List(Of Representative)
    Private minor As Minor
    Private isNew As Boolean
    Private preexistingRepresentatives As List(Of Representative)
    Private preexistingRepresentativeMinors As List(Of RepresentativeMinor)
    Private parent As frmMinorList

    Private Sub frmNewMinor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the form controls and data
        Dim levelManager As New LevelManager()
        cboxGender.DataSource = [Enum].GetValues(GetType(Minor.GenderEnum))
        cboxGender.SelectedIndex = 0
        cboxSchoolarship.DataSource = [Enum].GetValues(GetType(Minor.HasSchoolarshipEnum))
        cboxSchoolarship.SelectedIndex = 0
        cbRelationship.DataSource = [Enum].GetValues(GetType(Representative.RelationshipEnum))
        cbRelationship.SelectedIndex = 0
        cboxLevels.DataSource = levelManager.loadAllFromDB()
        cboxLevels.DisplayMember = "Name"
        cboxLevels.ValueMember = "LevelID"

        ' Populate the form with the existing minor data if available
        If minor IsNot Nothing Then
            isNew = False
            cboxLevels.SelectedValue = minor.LevelID
            tbIDCard.Text = minor.MinorID
            tbName.Text = minor.Name
            tbResidency.Text = minor.Residency
            tbRecommendationMethod.Text = minor.RecommendationMethod
            tbCurrentPayment.Text = minor.CurrentPayment
            dtpBirthDate.Value = minor.BirthDate
            dtpEnterDate.Value = minor.EnteredDate
            dtpLeaveDate.Value = minor.GraduationDate
            btnSave.Text = "Actualizar"
            Me.Text = "Actualizar menor"
            representatives = minor.Representatives
            representativeMinors = minor.RepresentativeMinors
            preexistingRepresentatives = New List(Of Representative)
            preexistingRepresentativeMinors = New List(Of RepresentativeMinor)
            If representatives IsNot Nothing Then
                preexistingRepresentatives.AddRange(minor.Representatives)
            End If
            If representativeMinors IsNot Nothing Then
                preexistingRepresentativeMinors.AddRange(minor.RepresentativeMinors)
            End If

            poblateDataGridView()

            ' Set the value of cboxGender to match the minor's gender
            Dim gender As Minor.GenderEnum = [Enum].Parse(GetType(Minor.GenderEnum), minor.Gender)
            cboxGender.SelectedItem = gender

            ' Set the value of cboxSchoolarship to match the minor's schoolarship status
            Dim schoolarship As Minor.HasSchoolarshipEnum = [Enum].Parse(GetType(Minor.HasSchoolarshipEnum), minor.HasSchoolarship)
            cboxSchoolarship.SelectedItem = schoolarship
        End If

        ' Create a new Minor object if none exists
        If minor Is Nothing Then
            minor = New Minor()
            isNew = True
        End If
        btnAddRepresentativeMinor.Enabled = False
    End Sub

    Public Sub New(minor As Minor, parent As frmMinorList)
        ' Required method for the designer.
        InitializeComponent()

        Me.minor = minor
        Me.parent = parent
    End Sub

    Public Sub New(minor As Minor)
        ' Required method for the designer.
        InitializeComponent()

        Me.minor = minor
    End Sub

    Public Sub New()
        ' Required method for the designer.
        InitializeComponent()
    End Sub

    Private Sub btnSearchRepresentative_Click(sender As Object, e As EventArgs) Handles btnSearchRepresentative.Click
        ' Search for representatives by name
        Dim representativeManager As New RepresentativeManager()
        Dim representatives As List(Of Representative) = representativeManager.searchByName(tbRepresentativeName.Text)

        ' Filter out the representatives already associated with minors
        filteredRepresentatives = If(representativeMinors Is Nothing, representatives, representatives.Where(Function(rep) Not representativeMinors.Any(Function(minor) minor.RepresentativeID = rep.RepresentativeID)).ToList())

        lboxFoundRepresentants.DataSource = Nothing
        lboxFoundRepresentants.Items.Clear()
        lboxFoundRepresentants.DataSource = filteredRepresentatives
        lboxFoundRepresentants.DisplayMember = "IDAndName"
    End Sub

    Private Sub lboxFoundRepresentants_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lboxFoundRepresentants.SelectedIndexChanged
        ' Event handler when an item is selected in the lboxFoundRepresentants ListBox
        If lboxFoundRepresentants.SelectedItem IsNot Nothing Then
            Dim rep As Representative = lboxFoundRepresentants.SelectedItem
            tbSelectedRepresentative.Text = rep.Name
            selectedRepresentative = rep
            selectedRepresentative.Relationship = cbRelationship.SelectedItem.ToString()
            btnAddRepresentativeMinor.Enabled = True
            cbRelationship.DataSource = [Enum].GetValues(GetType(Representative.RelationshipEnum))
        End If
    End Sub

    Private Sub btnAddRepresentativeMinor_Click(sender As Object, e As EventArgs) Handles btnAddRepresentativeMinor.Click
        ' Event handler when the Add button for representative-minor association is clicked
        Dim minorManager As New MinorManager()
        Dim representativeMinor As RepresentativeMinor = New RepresentativeMinor()
        representativeMinor.MinorID = tbIDCard.Text
        representativeMinor.RepresentativeID = selectedRepresentative.RepresentativeID
        representativeMinor.Relationship = cbRelationship.SelectedItem.ToString()

        ' Add the representative-minor association to the list
        If representativeMinors Is Nothing Then
            representativeMinors = New List(Of RepresentativeMinor)
        End If
        representativeMinors.Add(representativeMinor)

        ' Add the selected representative to the list of representatives
        If representatives Is Nothing Then
            representatives = New List(Of Representative)
        End If
        representatives.Add(selectedRepresentative)
        poblateDataGridView()

        ' Remove the selected representative from the filtered list
        filteredRepresentatives.Remove(selectedRepresentative)
        lboxFoundRepresentants.DataSource = Nothing
        lboxFoundRepresentants.Items.Clear()
        lboxFoundRepresentants.DataSource = filteredRepresentatives
        lboxFoundRepresentants.DisplayMember = "IDandName"

        btnAddRepresentativeMinor.Enabled = False
        tbSelectedRepresentative.Text = ""
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Event handler when the Save button is clicked
        Try
            Dim minorManager As New MinorManager()
            Dim minor As Minor = New Minor()

            ' Set the properties of the Minor object based on the form inputs
            minor.Name = tbName.Text
            minor.MinorID = tbIDCard.Text
            minor.BirthDate = dtpBirthDate.Value
            minor.EnteredDate = dtpEnterDate.Value
            minor.GraduationDate = dtpLeaveDate.Value
            minor.HasSchoolarship = cboxSchoolarship.SelectedItem.ToString()
            minor.RecommendationMethod = tbRecommendationMethod.Text
            minor.Residency = tbResidency.Text
            minor.Gender = cboxGender.SelectedItem.ToString()
            minor.CurrentPayment = Double.Parse(tbCurrentPayment.Text)
            minor.RepresentativeMinors = representativeMinors
            minor.Representatives = representatives
            minor.LevelID = cboxLevels.SelectedItem.LevelID

            ' Validate the minor object
            minor.ValidateAll()

            ' Save or update the minor data in the database
            If isNew Then
                minorManager.saveToDB(minor)
                MessageBox.Show(Me.MdiParent, "Se ha creado correctamente el estudiante")
            Else
                minor.Representatives = representatives.Except(preexistingRepresentatives).ToList()
                minor.RepresentativeMinors = representativeMinors.Except(preexistingRepresentativeMinors).ToList()
                minorManager.updateToDB(minor)
                MessageBox.Show(Me.MdiParent, "Se ha actualizado correctamente la información del estudiante")
            End If

            ' Refresh the minor list
            If parent IsNot Nothing Then
                parent.refreshMinorList()
            End If

            ' Close the form after successful save/update
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub poblateDataGridView()
        ' Populate the DataGridView with the representatives associated with the minor
        dgvRepresentatives.Columns.Clear()
        dgvRepresentatives.ReadOnly = True ' Set the DataGridView to read-only
        dgvRepresentatives.AllowUserToAddRows = False ' Disable the ability to add new rows


        dgvRepresentatives.Columns.Add("Nombre", "Nombre")
        dgvRepresentatives.Columns.Add("Cédula", "Cédula")
        dgvRepresentatives.Columns.Add("Teléfono", "Teléfono")
        dgvRepresentatives.Columns.Add("Rol", "Rol")

        Dim btnDetallesColumn As New DataGridViewButtonColumn()
        btnDetallesColumn.HeaderText = "Detalles"
        btnDetallesColumn.Name = "Detalles"
        btnDetallesColumn.Text = "Detalles"
        btnDetallesColumn.UseColumnTextForButtonValue = True

        Dim btnDeleteColumn As New DataGridViewButtonColumn()
        btnDeleteColumn.HeaderText = "Eliminar"
        btnDeleteColumn.Name = "Eliminar"
        btnDeleteColumn.Text = "Eliminar"
        btnDeleteColumn.UseColumnTextForButtonValue = True


        dgvRepresentatives.Columns.Add(btnDetallesColumn)
        dgvRepresentatives.Columns.Add(btnDeleteColumn)

        For Each column As DataGridViewColumn In dgvRepresentatives.Columns
            column.ReadOnly = True ' Set individual columns to read-only
        Next

        dgvRepresentatives.Rows.Clear()

        For Each representative As Representative In representatives
            dgvRepresentatives.Rows.Add(representative.Name, representative.RepresentativeID, representative.Phone, representative.Relationship)
        Next

    End Sub

    Private Sub dgvRepresentatives_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRepresentatives.CellContentClick
        ' Check if the clicked cell is a button cell and the corresponding column index
        If e.ColumnIndex = dgvRepresentatives.Columns("Detalles").Index AndAlso e.RowIndex >= 0 Then
            ' "Detalles" button clicked
            Dim rowIndex As Integer = e.RowIndex
            Dim representative As Representative = representatives(rowIndex)
            Dim form As New frmRepresentativeDetails(representative)
            form.MdiParent = Me.MdiParent
            form.Show()
        ElseIf e.ColumnIndex = dgvRepresentatives.Columns("Eliminar").Index AndAlso e.RowIndex >= 0 Then
            ' "Eliminar" button clicked
            Dim rowIndex As Integer = e.RowIndex
            Dim representative As Representative = representatives(rowIndex)
            Try
                ' Perform delete action using the representative object
                Dim result As DialogResult = MessageBox.Show("¿Estás seguro de que deseas eliminar al representante?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                ' If the user confirms the deletion, perform the delete action
                If result = DialogResult.Yes Then
                    ' Perform delete action using the representative object
                    Dim representativeMinor As RepresentativeMinor
                    Dim representativeMinorManager As New RepresentativeMinorManager()

                    ' Delete the representative-minor association from the database
                    If Not isNew Then
                        ' If representative is in prexistingrepresentatives, delete it from the database
                        If preexistingRepresentatives.Contains(representative) Then
                            representativeMinor = representativeMinorManager.searchRepresentativeMinor(representative.RepresentativeID, minor.MinorID)
                            representativeMinorManager.deleteFromDB(representativeMinor)
                            If preexistingRepresentativeMinors.Contains(representativeMinor) Then
                                representativeMinors.Remove(representativeMinor)
                            End If
                        End If
                    End If
                    representatives = representatives.Where(Function(x) x.RepresentativeID <> representative.RepresentativeID).ToList()
                    representativeMinors = representativeMinors.Where(Function(x) x.RepresentativeID <> representative.RepresentativeID).ToList()

                    MessageBox.Show("Se ha eliminado correctamente la relación entre este representante legal y el menor")

                    ' Reload the DataGridView data after deletion
                    poblateDataGridView()

                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub
End Class