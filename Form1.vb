Public Class Form1
    Private Sub BTNshow_Click(sender As Object, e As EventArgs) Handles BTNshow.Click
        Dim array(8) As Integer

        array(0) = 10
        array(1) = 100
        array(2) = 1000
        array(3) = 10000
        array(4) = 100000
        array(5) = 1000000
        array(6) = 10000000
        array(7) = 100000000
        array(8) = 1000000000

        For Each element As Integer In array
            LIBone.Items.Add(element)
        Next
    End Sub

    Private Sub BTNclear_Click(sender As Object, e As EventArgs) Handles BTNclear.Click
        LIBone.Items.Clear()
    End Sub

    Private Sub BTNexit_Click(sender As Object, e As EventArgs) Handles BTNexit.Click
        End
    End Sub
End Class
