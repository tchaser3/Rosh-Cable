'Title:         Receive Cable
'Date:          1-6-15
'Author:        Terry Holmes

'Description:   This form will receive the Cable

Option Strict On

Public Class ReceiveCable

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        'This will close the program
        CloseProgram.ShowDialog()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'This will show the main menu
        Form1.Show()
        Me.Close()

    End Sub
    Private Sub SetControlsReadOnly(ByVal valueBoolean As Boolean)

        'This will make the controls read only
        txtBJCReelID.ReadOnly = valueBoolean
        txtCurrentFootage.ReadOnly = valueBoolean
        txtRochReelID.ReadOnly = valueBoolean

    End Sub
    Private Sub SetCableControlsVisible(ByVal valueBoolean As Boolean)

        'Makes the controls visible
        cboReelID.Visible = valueBoolean
        txtBJCReelID.Visible = valueBoolean
        txtCurrentFootage.Visible = valueBoolean
        txtPartID.Visible = valueBoolean
        txtRochReelID.Visible = valueBoolean
        txtStatus.Visible = valueBoolean

    End Sub
End Class