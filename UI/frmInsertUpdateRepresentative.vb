Imports DOM
Imports BL
Public Class frmInsertUpdateRepresentative

    Private representative As Representative
    Private isNew As Boolean
    Private parent As frmRepresentativeList

    Public Sub New(representative As Representative)

        ' This call is required by the designer.
        InitializeComponent()

        Me.representative = representative
        Me.isNew = False

    End Sub

    Public Sub New(representative As Representative, parent As frmRepresentativeList)

        ' This call is required by the designer.
        InitializeComponent()

        Me.representative = representative
        Me.isNew = False
        Me.parent = parent

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        Me.representative = New Representative()
        Me.isNew = True

    End Sub

    Private Sub frmNewRepresentative_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboxGender.DataSource = [Enum].GetValues(GetType(Representative.GenderEnum))
        cboxMaritalStatus.DataSource = [Enum].GetValues(GetType(Representative.MaritalStatusEnum))

        If Not isNew Then
            tbIDCard.Text = representative.RepresentativeID
            tbName.Text = representative.Name
            tbMail.Text = representative.Mail
            tbPhone.Text = representative.Phone
            cboxMaritalStatus.SelectedItem = representative.MaritalStatus
            tbWorkPlace.Text = representative.WorkPlace
            tbOccupation.Text = representative.Occupation
            tbResidency.Text = representative.Residency
            Dim gender As Representative.GenderEnum = [Enum].Parse(GetType(Representative.GenderEnum), representative.Gender)
            cboxGender.SelectedItem = gender
            tbIDCard.Enabled = False

            Me.Text = "Editar representante"
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim repManager As New RepresentativeManager()
            representative.Name = tbName.Text
            representative.Mail = tbMail.Text
            representative.Phone = tbPhone.Text
            representative.MaritalStatus = cboxMaritalStatus.SelectedItem.ToString()
            representative.RepresentativeID = tbIDCard.Text
            representative.WorkPlace = tbWorkPlace.Text
            representative.Occupation = tbOccupation.Text
            representative.Gender = cboxGender.SelectedItem.ToString()
            representative.Residency = tbResidency.Text
            representative.ValidateAll()
            If isNew Then
                repManager.saveToDB(representative)
            Else
                repManager.updateToDB(representative)
                parent.refreshDataGridView()
            End If
            MessageBox.Show("Representante guardado con éxito")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub
End Class