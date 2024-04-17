'Title:         Add Part Number
'Data:          1-5-14
'Author:        Terry Holmes

'Description:   This form is used to add a part number and description

Option Strict On

Public Class AddPartNumber

    'Setting global data variables
    Private ThePartNumberDataSet As PartNumberDataSet
    Private ThePartNumberDataTier As RochDataTier
    Private WithEvents ThePartNumberBindingSource As BindingSource

    'Setting global variables
    Private addingBoolean As Boolean = False
    Private editingBoolean As Boolean = False
    Private previousSelectedIndex As Integer

    'Calling the Data Validation Class
    Dim TheInputDateValidation As New InputDataValidation

    'Setting up array
    Dim mintCounter As Integer
    Dim mintSelectedIndex(10000) As Integer
    Dim mintUpperLimit As Integer

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        'This will close the program
        CloseProgram.ShowDialog()

    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click

        'This will show the main menu
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub AddPartNumber_Load(sender As Object, e As EventArgs) Handles Me.Load

        'This will load up when the form is launched
        Try

            'Loading up the global data variables
            ThePartNumberDataTier = New RochDataTier
            ThePartNumberDataSet = ThePartNumberDataTier.GetPartNumberInformation
            ThePartNumberBindingSource = New BindingSource

            'setting up the binding source
            With ThePartNumberBindingSource
                .DataSource = ThePartNumberDataSet
                .DataMember = "partnumber"
                .MoveFirst()
                .MoveLast()
            End With

            'Setting up the combo box
            With cboPartID
                .DataSource = ThePartNumberBindingSource
                .DisplayMember = "PartID"
                .DataBindings.Add("text", ThePartNumberBindingSource, "PartID", False, DataSourceUpdateMode.Never)
            End With

            'binding the rest of the controls
            txtDescription.DataBindings.Add("text", ThePartNumberBindingSource, "Description")

            SetNavigationButtons()

        Catch ex As Exception

            'Output to user
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
    Private Sub SetNavigationButtons()

        'This sub routine will set up the buttons to function correctly
        'Setting local variables
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer

        'Setting initial conditions of the buttons
        btnNext.Enabled = False
        btnBack.Enabled = False

        'Getting count from combo box
        intNumberOfRecords = cboPartID.Items.Count - 1

        'Beginning loop to set the counter
        For intCounter = 0 To intNumberOfRecords

            'setting up the selected index array
            mintSelectedIndex(intCounter) = intCounter

        Next

        'Setting up global variables
        mintUpperLimit = intNumberOfRecords
        mintCounter = 0
        cboPartID.SelectedIndex = mintSelectedIndex(0)

        'Setting up the navigation butons
        If mintUpperLimit > 0 Then
            btnNext.Enabled = True
        End If

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        'This will increment the combo box
        mintCounter += 1

        'Setting the Combo box
        cboPartID.SelectedIndex = mintSelectedIndex(mintCounter)

        'Setting navigation button state
        btnBack.Enabled = True

        'Checking to see if the button can be disabled
        If mintCounter = mintUpperLimit Then
            btnNext.Enabled = False
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        'This will decrement the combo box
        mintCounter -= 1

        'Setting the Combo box
        cboPartID.SelectedIndex = mintSelectedIndex(mintCounter)

        'Setting navigation button state
        btnNext.Enabled = True

        'Checking to see if the button can be disabled
        If mintCounter = 0 Then
            btnBack.Enabled = False
        End If

    End Sub

    Private Sub SetComboBoxBindings()

        'Setting up the binding for the combo box
        With cboPartID
            If (addingBoolean Or editingBoolean) Then
                .DataBindings!text.DataSourceUpdateMode = DataSourceUpdateMode.OnValidation
                .DropDownStyle = ComboBoxStyle.Simple
            Else
                .DataBindings!text.DataSourceUpdateMode = DataSourceUpdateMode.Never
                .DropDownStyle = ComboBoxStyle.DropDownList
            End If
        End With
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        'Setting up local variables
        Dim strValueForValidation As String
        Dim blnFatalError As Boolean

        'This will add a new part number for Roch
        If btnAdd.Text = "Add" Then

            'Setting up the combo box
            With ThePartNumberBindingSource
                .EndEdit()
                .AddNew()
            End With

            'Setting up variables
            addingBoolean = True
            SetComboBoxBindings()

            CreatePartNumberID.Show()
            cboPartID.Text = CStr(Form1.mintCreatedID)
            txtDescription.ReadOnly = False
            btnAdd.Text = "Save"

        Else

            'Setting up for data validation
            strValueForValidation = txtDescription.Text
            blnFatalError = TheInputDateValidation.VerifyTextData(strValueForValidation)

            'Output for data validation
            If blnFatalError = True Then
                MessageBox.Show(Form1.mstrErrorMessage, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            'Saving the record
            Try
                ThePartNumberBindingSource.EndEdit()
                ThePartNumberDataTier.UpdatePartNumberDB(ThePartNumberDataSet)
                editingBoolean = False
                addingBoolean = False
                SetComboBoxBindings()
                txtDescription.ReadOnly = True
                SetNavigationButtons()

            Catch ex As Exception

                'Output for an exception
                MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try

        End If
    End Sub
End Class