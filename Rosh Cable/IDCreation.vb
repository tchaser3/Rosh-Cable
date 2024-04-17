'Title:         The ID Creation Form
'Date:          1-2-15
'Author:        Terry Holmes

'Description:   This form is used to create the id

Option Strict On

Public Class IDCreation

    'Setting up the global variables
    Private TheIDCreationDataSet As IDCreationDataSet
    Private TheIDCreationDataTier As RochDataTier
    Private WithEvents TheIDCreationBindingSource As BindingSource

    'Setting up the global variables
    Private addingBoolean As Boolean = False
    Private editingBoolean As Boolean = False
    Private previousSelectedIndex As Integer

    Private Sub SetComboBoxBindings()

        'Setting up the binding for the combo box
        With cboPrimaryKey
            If (addingBoolean Or editingBoolean) Then
                .DataBindings!text.DataSourceUpdateMode = DataSourceUpdateMode.OnValidation
                .DropDownStyle = ComboBoxStyle.Simple
            Else
                .DataBindings!text.DataSourceUpdateMode = DataSourceUpdateMode.Never
                .DropDownStyle = ComboBoxStyle.DropDownList
            End If
        End With
    End Sub

    Private Sub IDCreation_Load(sender As Object, e As EventArgs) Handles Me.Load

        'This will load when the form is launched
        'Try catch for exceptions
        Try

            'Setting up the data sources
            TheIDCreationDataTier = New RochDataTier
            TheIDCreationDataSet = TheIDCreationDataTier.GetIDCreationInformation
            TheIDCreationBindingSource = New BindingSource

            'Setting up the Binding Source
            With TheIDCreationBindingSource
                .DataSource = TheIDCreationDataSet
                .DataMember = "idcreation"
                .MoveFirst()
                .MoveLast()
            End With

            'Setting up the combo box
            With cboPrimaryKey
                .DataSource = TheIDCreationBindingSource
                .DisplayMember = "PrimaryKey"
                .DataBindings.Add("text", TheIDCreationBindingSource, "PrimaryKey", False, DataSourceUpdateMode.Never)
            End With

            'Setting up the final control
            txtCreatedTransactionID.DataBindings.Add("text", TheIDCreationBindingSource, "CurrentTransactionID")

            CreateNewID()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub CreateNewID()

        'This sub routine will create a new id

        'Setting Local variables
        Dim intCurrentID As Integer

        'Setting the variable
        intCurrentID = CInt(txtCreatedTransactionID.Text)
        editingBoolean = True

        'Getting new id
        intCurrentID = intCurrentID + 1

        'Setting the control
        txtCreatedTransactionID.Text = CStr(intCurrentID)
        Form1.mintCreatedID = intCurrentID

        'Saving the transaction id
        Try
            TheIDCreationBindingSource.EndEdit()
            TheIDCreationDataTier.UpdateIDCreationDB(TheIDCreationDataSet)
            editingBoolean = False
            SetComboBoxBindings()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub
End Class