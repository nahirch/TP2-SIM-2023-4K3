Imports System.Runtime.CompilerServices

Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub
    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click

        Form1.Show()
        Me.Hide()
    End Sub
End Class