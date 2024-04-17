'Title:         Close The Program
'Date:          1-2-15
'Author:        Terry Holmes

'Description:   This close the programm

Public Class CloseProgram

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click

        'This will return to the form
        Me.Close()

    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click

        'This will close the program
        Form1.Close()
        Me.Close()

    End Sub
End Class