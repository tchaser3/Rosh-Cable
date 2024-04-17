'Title:         Create BJC Reel ID
'Date:          1-2-15
'Author:        Terry Holmes

'Description:   This will create a BJC ID for Roch Cable

Option Strict On

Public Class CreateBJCReelID

    'Setting up global data variables
    Private TheBJCReelIDDataSet As BJCReelIDDataSet
    Private TheBJCReelIDDataTier As RochDataTier
    Private WithEvents TheBJCReelIDBindingSource As BindingSource

    'Setting up global variables
    Private addingBoolean As Boolean = False
    Private editingBoolean As Boolean = False
    Private previousSelectedIndex As Integer

    Private Sub SetComboBoxBindings()

        'Setting up the binding for the combo box
        With cboTransactionID
            If (addingBoolean Or editingBoolean) Then
                .DataBindings!text.DataSourceUpdateMode = DataSourceUpdateMode.OnValidation
                .DropDownStyle = ComboBoxStyle.Simple
            Else
                .DataBindings!text.DataSourceUpdateMode = DataSourceUpdateMode.Never
                .DropDownStyle = ComboBoxStyle.DropDownList
            End If
        End With
    End Sub

    Private Sub CreateBJCReelID_Load(sender As Object, e As EventArgs) Handles Me.Load

        'This will load when the form is loaded
        'Try Catch to catch exceptions
        Try

            'Setting up the data set
            TheBJCReelIDDataTier = New RochDataTier
            TheBJCReelIDDataSet = TheBJCReelIDDataTier.GetBJCReelIDInformation
            TheBJCReelIDBindingSource = New BindingSource

            'Setting up the binding source
            With TheBJCReelIDBindingSource
                .DataSource = TheBJCReelIDDataSet
                .DataMember = "bjcreelid"
                .MoveFirst()
                .MoveLast()
            End With

            'Setting up the combo box
            With cboTransactionID
                .DataSource = TheBJCReelIDBindingSource
                .DisplayMember = "TransactionID"
                .DataBindings.Add("text", TheBJCReelIDBindingSource, "TransactionID", False, DataSourceUpdateMode.Never)
            End With

            'Setting up the rest of the controls
            txtBJCReelID.DataBindings.Add("Text", TheBJCReelIDBindingSource, "BJCReelID")
            txtPartID.DataBindings.Add("Text", TheBJCReelIDBindingSource, "PartID")

            FindandUpdateID()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FindandUpdateID()

        'Setting up local variables
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim intPartIDForSearch As Integer
        Dim intPartIDFromTable As Integer
        Dim intSelectedIndex As Integer
        Dim blnItemNotFound As Boolean = True
        Dim intNewReelID As Integer

        'Loading up for find the part id
        intNumberOfRecords = cboTransactionID.Items.Count - 1
        intPartIDForSearch = Form1.mintPartID

        'Beginning the loop
        For intCounter = 0 To intNumberOfRecords

            'Incrementing the combo box
            cboTransactionID.SelectedIndex = intCounter

            'Getting ID from table
            intPartIDFromTable = CInt(txtPartID.Text)

            'Comparing Part IDs
            If intPartIDForSearch = intPartIDFromTable Then

                'Setting up the index of the combo box
                intSelectedIndex = intCounter

                'Setting the boolean modify
                blnItemNotFound = False
            End If
        Next

        'Saving the information
        If blnItemNotFound = True Then

            'Setting the binding source for adding records
            With TheBJCReelIDBindingSource
                .EndEdit()
                .AddNew()
            End With

            'Setting up the variables
            addingBoolean = True
            SetComboBoxBindings()

            'Setting up the controls
            cboTransactionID.Text = CStr(intNumberOfRecords + 101)
            txtPartID.Text = CStr(intPartIDForSearch)
            txtBJCReelID.Text = "1"
        Else

            'This will run if the record is found
            editingBoolean = True
            cboTransactionID.SelectedIndex = intSelectedIndex

            'Getting the reel id
            intNewReelID = CInt(txtBJCReelID.Text)
            intNewReelID = intNewReelID + 1
            txtBJCReelID.Text = CStr(intNewReelID)

        End If

        'Try Catch to save the record
        Try
            TheBJCReelIDBindingSource.EndEdit()
            TheBJCReelIDDataTier.UpdateBJCReelIDDB(TheBJCReelIDDataSet)
            editingBoolean = False
            addingBoolean = False
            SetComboBoxBindings()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class