Option Strict On

Public Class Form1

    Private Sub btnFirstName_Click(sender As System.Object, e As System.EventArgs) Handles btnFirstName.Click
        Dim fullname As String = txtFullName.Text
        'Read the input from the user
        fullname = txtFullName.Text

        'Make sure full name is trimmed, this is how
        Dim fullnameTrimmed As String
        fullnameTrimmed = fullname.Trim()

        'Find the index of first space
        Dim idxSpace As Integer
        idxSpace = fullnameTrimmed.IndexOf(" ")

        'Extract the first name
        Dim firstName As String
        firstName = fullnameTrimmed.Substring(0, idxSpace)

        'Display tge results to the user
        TextBox1.Text = firstName
    End Sub
End Class
