Option Strict On

Public Class Form1

    Private Sub btnFirstName_Click(sender As System.Object, e As System.EventArgs) Handles btnFirstName.Click
        Dim fullname As String

        'read the input from the user
        fullname = txtFullName.Text

        Dim fullnameTrimmed As String

        'Find the index of first space
        Dim idxspace As Integer
        idxspace = fullname.IndexOf(" ")
        'Extract the first name
        Dim firstName As String
        firstName = fullnameTrimmed.Substring(0, idxspace)
        'display the result to the user
        txtfirstname.Text = firstName

    End Sub
End Class
