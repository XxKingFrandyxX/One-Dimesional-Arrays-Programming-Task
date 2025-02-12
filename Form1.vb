''' <>
''' Author: King_Frandy
''' Date: 13/02/25
''' Title: One Dimesional Array
''' <>
Public Class Form1
    Private Sub BTNshow_Click(sender As Object, e As EventArgs) Handles BTNshow.Click
        'Making a variable 

        Dim array(8) As Integer

        'Assigning values to variables
        array(0) = 10
        array(1) = 100
        array(2) = 1000
        array(3) = 10000
        array(4) = 100000
        array(5) = 1000000
        array(6) = 10000000
        array(7) = 100000000
        array(8) = 1000000000

        'Other Way to Do it 
        'Dim array() As Integer = {55, 907, 1039, 79797, 19382183, 19291, 128812, 128121, 19389282, 83}

        'For loop indivisaling all the objects in vaiable array
        For Each element As Integer In array
            'Displaying objects on ListBox
            LIBone.Items.Add(element)
        Next ' Going to next item
    End Sub

    Private Sub BTNclear_Click(sender As Object, e As EventArgs) Handles BTNclear.Click
        LIBone.Items.Clear() 'Clears all Items in ListBox
    End Sub

    Private Sub BTNexit_Click(sender As Object, e As EventArgs) Handles BTNexit.Click
        End 'Ends the app
    End Sub
End Class
