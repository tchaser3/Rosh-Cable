'Title:         Create Part Number ID
'Date:          1-4-15
'Author:        Terry Holmes

'Description:   This form is used to create a part number

Option Strict On

Public Class CreatePartNumberID

    'Setting the Global data Variables
    Private ThePartNumberIDDataSet As PartNumberIDDataSet
    Private ThePartNumberIDDataTier As RochDataTier
    Private WithEvents ThePartNumberIDBindingSource As BindingSource

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


    Private Sub CreatePartNumberID_Load(sender As Object, e As EventArgs) Handles Me.Load

        'This will load when the form is launched
        'Try catch for exceptions
        Try

            'Setting up the data sources
            ThePartNumberIDDataTier = New RochDataTier
            ThePartNumberIDDataSet = ThePartNumberIDDataTier.GetPartNumberIDInformation
            ThePartNumberIDBindingSource = New BindingSource

            'Setting up the Binding Source
            With ThePartNumberIDBindingSource
                .DataSource = ThePartNumberIDDataSet
                .DataMember = "partnumberid"
                .MoveFirst()
                .MoveLast()
            End With

            'Setting up the combo box
            With cboPrimaryKey
                .DataSource = ThePartNumberIDBindingSource
                .DisplayMember = "TransactionID"
                .DataBindings.Add("text", ThePartNumberIDBindingSource, "TransactionID", False, DataSourceUpdateMode.Never)
            End With

            'Setting up the final control
            txtCreatedTransactionID.DataBindings.Add("text", ThePartNumberIDBindingSource, "CurrentTransactionID")

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
            ThePartNumberIDBindingSource.EndEdit()
            ThePartNumberIDDataTier.UpdatePartNumberIDDB(ThePartNumberIDDataSet)
            editingBoolean = False
            SetComboBoxBindings()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub
End Class