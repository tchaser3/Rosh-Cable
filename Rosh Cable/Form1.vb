'Title:         Main Menu - Form 1
'Date:          1-2-15
'Author:        Terry Holmes

'Description:   This is the main menu for the program

Option Strict On

Public Class Form1

    'Creating global variables
    Friend mintCreatedID As Integer
    Friend mintPartID As Integer
    Friend mintEmployeeID As Integer
    Friend mstrErrorMessage As String

    Dim TheModuleUnderDevelopment As New ModuleUnderDevelopment

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        'This will call the Close Program form
        CloseProgram.ShowDialog()

    End Sub

    Private Sub btnReceiveCable_Click(sender As Object, e As EventArgs) Handles btnReceiveCable.Click

        'This will load the Receive Cable
        ReceiveCable.Show()
        Me.Hide()

    End Sub

    Private Sub btnIssueCable_Click(sender As Object, e As EventArgs) Handles btnIssueCable.Click
        TheModuleUnderDevelopment.UnderDevelopment()
    End Sub

    Private Sub btnReturnCable_Click(sender As Object, e As EventArgs) Handles btnReturnCable.Click
        TheModuleUnderDevelopment.UnderDevelopment()
    End Sub

    Private Sub btnAddPartNumber_Click(sender As Object, e As EventArgs) Handles btnAddPartNumber.Click

        'This will open the Add Part Number
        AddPartNumber.Show()
        Me.Hide()

    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        TheModuleUnderDevelopment.UnderDevelopment()
    End Sub

    Private Sub btnCableAvailability_Click(sender As Object, e As EventArgs) Handles btnCableAvailability.Click
        TheModuleUnderDevelopment.UnderDevelopment()
    End Sub

    Private Sub btnCableUsage_Click(sender As Object, e As EventArgs) Handles btnCableUsage.Click
        TheModuleUnderDevelopment.UnderDevelopment()
    End Sub

    Private Sub btnCableInTheField_Click(sender As Object, e As EventArgs) Handles btnCableInTheField.Click
        TheModuleUnderDevelopment.UnderDevelopment()
    End Sub
End Class
