Option Strict On

Public Class Form1

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim Ast, Bst, Cst, Dst As String
        Dim A, B, C, D As Double

        ' Read the input from the user
        Ast = txtA.Text
        Bst = txtB.Text
        Cst = txtC.Text
        Dst = txtD.Text

        ' All input must be numbers
        If Not (IsNumeric(Ast) And IsNumeric(Bst) And IsNumeric(Cst) _
                And IsNumeric(Dst)) Then
            MessageBox.Show("Please enter valid numbers", "Error!")
            Return
        End If

        ' Convert to double
        A = CDbl(Ast)
        B = CDbl(Bst)
        C = CDbl(Cst)
        D = CDbl(Dst)

        If B < A Or D < C Then
            MessageBox.Show("Please enter valid numbers.", "Error!")
        End If

        txtResult.Text = FindIntersection(A, B, C, D)


    End Sub

    Function FindIntersection(a As Double, b As Double, c As Double, d As Double) As String
        ' Please write your code here...
        Dim result As String
        If b < c Or d < a Then
            result = "No Intersection"

        Else

            Dim first As Double = Math.Max(a, c)
            Dim Second As Double = Math.Min(b, d)
            result = "Intersection from " & CStr(first) & " to " & CStr(Second)

        End If
        Return result
    End Function

End Class
