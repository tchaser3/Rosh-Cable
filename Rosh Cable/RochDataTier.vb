'Title:         Roch Data Tier
'Date:          1-2-15
'Author:        Terry Holmes

'Description:   This is the data tier class for the application

Public Class RochDataTier

    'Setting up the global variables
    Private aBJCReelIDDataSetTableAdapter As BJCReelIDDataSetTableAdapters.bjcreelidTableAdapter
    Private aBJCReelIDDataSet As BJCReelIDDataSet

    Private aCableDataSetTableAdapter As CableDataSetTableAdapters.cableTableAdapter
    Private aCableDataSet As CableDataSet

    Private aEmployeesDataSetTableAdapter As EmployeesDataSetTableAdapters.employeesTableAdapter
    Private aEmployeesDataSet As EmployeesDataSet

    Private aIDCreationDataSetTableAdapter As IDCreationDataSetTableAdapters.idcreationTableAdapter
    Private aIDCreationDataSet As IDCreationDataSet

    Private aIssueDataSetTableAdapter As IssueDataSetTableAdapters.issueTableAdapter
    Private aIssueDataSet As IssueDataSet

    Private aPartNumberDataSetTableAdapter As PartNumberDataSetTableAdapters.partnumberTableAdapter
    Private aPartNumberDataSet As PartNumberDataSet

    Private aPartNumberIDDataSetTableAdapter As PartNumberIDDataSetTableAdapters.partnumberidTableAdapter
    Private aPartNumberIDDataSet As PartNumberIDDataSet

    Private aReceiveDataSetTableAdapter As ReceiveDataSetTableAdapters.receiveTableAdapter
    Private aReceiveDataSet As ReceiveDataSet

    Private aReturnDataSetTableAdapter As ReturnDataSetTableAdapters.returncableTableAdapter
    Private aReturnDataSet As ReturnDataSet

    Public Function GetReturnInformation() As ReturnDataSet

        'Try Catch to exceptions
        Try

            'Processing data tier
            aReturnDataSet = New ReturnDataSet
            aReturnDataSetTableAdapter = New ReturnDataSetTableAdapters.returncableTableAdapter
            aReturnDataSetTableAdapter.Fill(aReturnDataSet.returncable)
            Return aReturnDataSet

        Catch ex As Exception

            'This will run if there is an exception thrown
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return aReturnDataSet

        End Try
    End Function
    Public Sub UpdateReturnDB(ByVal aReturnDataSet As ReturnDataSet)

        'Try Catch to catch exceptions
        Try
            aReturnDataSetTableAdapter.Update(aReturnDataSet.returncable)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function GetReceiveInformation() As ReceiveDataSet

        'Try Catch to exceptions
        Try

            'Processing data tier
            aReceiveDataSet = New ReceiveDataSet
            aReceiveDataSetTableAdapter = New ReceiveDataSetTableAdapters.receiveTableAdapter
            aReceiveDataSetTableAdapter.Fill(aReceiveDataSet.receive)
            Return aReceiveDataSet

        Catch ex As Exception

            'This will run if there is an exception thrown
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return aReceiveDataSet

        End Try
    End Function
    Public Sub UpdateReceiveDB(ByVal aReceiveDataSet As ReceiveDataSet)

        'Try Catch to catch exceptions
        Try
            aReceiveDataSetTableAdapter.Update(aReceiveDataSet.receive)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function GetPartNumberIDInformation() As PartNumberIDDataSet

        'Try Catch to exceptions
        Try

            'Processing data tier
            aPartNumberIDDataSet = New PartNumberIDDataSet
            aPartNumberIDDataSetTableAdapter = New PartNumberIDDataSetTableAdapters.partnumberidTableAdapter
            aPartNumberIDDataSetTableAdapter.Fill(aPartNumberIDDataSet.partnumberid)
            Return aPartNumberIDDataSet

        Catch ex As Exception

            'This will run if there is an exception thrown
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return aPartNumberIDDataSet

        End Try
    End Function
    Public Sub UpdatePartNumberIDDB(ByVal aPartNumberIDDataSet As PartNumberIDDataSet)

        'Try Catch to catch exceptions
        Try
            aPartNumberIDDataSetTableAdapter.Update(aPartNumberIDDataSet.partnumberid)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function GetPartNumberInformation() As PartNumberDataSet

        'Try Catch to exceptions
        Try

            'Processing data tier
            aPartNumberDataSet = New PartNumberDataSet
            aPartNumberDataSetTableAdapter = New PartNumberDataSetTableAdapters.partnumberTableAdapter
            aPartNumberDataSetTableAdapter.Fill(aPartNumberDataSet.partnumber)
            Return aPartNumberDataSet

        Catch ex As Exception

            'This will run if there is an exception thrown
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return aPartNumberDataSet

        End Try
    End Function
    Public Sub UpdatePartNumberDB(ByVal aPartNumberDataSet As PartNumberDataSet)

        'Try Catch to catch exceptions
        Try
            aPartNumberDataSetTableAdapter.Update(aPartNumberDataSet.partnumber)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function GetIssueInformation() As IssueDataSet

        'Try Catch to exceptions
        Try

            'Processing data tier
            aIssueDataSet = New IssueDataSet
            aIssueDataSetTableAdapter = New IssueDataSetTableAdapters.issueTableAdapter
            aIssueDataSetTableAdapter.Fill(aIssueDataSet.issue)
            Return aIssueDataSet

        Catch ex As Exception

            'This will run if there is an exception thrown
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return aIssueDataSet

        End Try
    End Function
    Public Sub UpdateIssueDB(ByVal aIssueDataSet As IssueDataSet)

        'Try Catch to catch exceptions
        Try
            aIssueDataSetTableAdapter.Update(aIssueDataSet.issue)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function GetIDCreationInformation() As IDCreationDataSet

        'Try Catch to exceptions
        Try

            'Processing data tier
            aIDCreationDataSet = New IDCreationDataSet
            aIDCreationDataSetTableAdapter = New IDCreationDataSetTableAdapters.idcreationTableAdapter
            aIDCreationDataSetTableAdapter.Fill(aIDCreationDataSet.idcreation)
            Return aIDCreationDataSet

        Catch ex As Exception

            'This will run if there is an exception thrown
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return aIDCreationDataSet

        End Try
    End Function
    Public Sub UpdateIDCreationDB(ByVal aIDCreationDataSet As IDCreationDataSet)

        'Try Catch to catch exceptions
        Try
            aIDCreationDataSetTableAdapter.Update(aIDCreationDataSet.idcreation)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function GetEmployeesInformation() As EmployeesDataSet

        'Try Catch to exceptions
        Try

            'Processing data tier
            aEmployeesDataSet = New EmployeesDataSet
            aEmployeesDataSetTableAdapter = New EmployeesDataSetTableAdapters.employeesTableAdapter
            aEmployeesDataSetTableAdapter.Fill(aEmployeesDataSet.employees)
            Return aEmployeesDataSet

        Catch ex As Exception

            'This will run if there is an exception thrown
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return aEmployeesDataSet

        End Try
    End Function
    Public Sub UpdateEmployeesDB(ByVal aEmployeesDataSet As EmployeesDataSet)

        'Try Catch to catch exceptions
        Try
            aEmployeesDataSetTableAdapter.Update(aEmployeesDataSet.employees)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function GetCableInformation() As CableDataSet

        'Try Catch to exceptions
        Try

            'Processing data tier
            aCableDataSet = New CableDataSet
            aCableDataSetTableAdapter = New CableDataSetTableAdapters.cableTableAdapter
            aCableDataSetTableAdapter.Fill(aCableDataSet.cable)
            Return aCableDataSet

        Catch ex As Exception

            'This will run if there is an exception thrown
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return aCableDataSet

        End Try
    End Function
    Public Sub UpdateCableDB(ByVal aCableDataSet As CableDataSet)

        'Try Catch to catch exceptions
        Try
            aCableDataSetTableAdapter.Update(aCableDataSet.cable)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function GetBJCReelIDInformation() As BJCReelIDDataSet

        'Try Catch to exceptions
        Try

            'Processing data tier
            aBJCReelIDDataSet = New BJCReelIDDataSet
            aBJCReelIDDataSetTableAdapter = New BJCReelIDDataSetTableAdapters.bjcreelidTableAdapter
            aBJCReelIDDataSetTableAdapter.Fill(aBJCReelIDDataSet.bjcreelid)
            Return aBJCReelIDDataSet

        Catch ex As Exception

            'This will run if there is an exception thrown
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return aBJCReelIDDataSet

        End Try
    End Function
    Public Sub UpdateBJCReelIDDB(ByVal aBJCReelIDDataSet As BJCReelIDDataSet)

        'Try Catch to catch exceptions
        Try
            aBJCReelIDDataSetTableAdapter.Update(aBJCReelIDDataSet.bjcreelid)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
