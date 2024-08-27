Public Class Form1
    Private operador As String
    Private valor1, valor2 As Double
    Private operacionPendiente As Boolean = False

    Private Sub btnNumero_Click(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click
        Dim boton As Button = CType(sender, Button)
        If txtDisplay.Text = "" OrElse operacionPendiente Then
            txtDisplay.Text = boton.Text
            operacionPendiente = False
        Else
            txtDisplay.Text &= boton.Text
        End If
    End Sub

    Private Sub btnOperador_Click(sender As Object, e As EventArgs) Handles btnSumar.Click, btnRestar.Click, btnMultiplicar.Click, btnDividir.Click
        Dim boton As Button = CType(sender, Button)
        operador = boton.Text
        valor1 = CDbl(txtDisplay.Text)
        operacionPendiente = True
    End Sub

    Private Sub btnResult_Click(sender As Object, e As EventArgs) Handles btnResult.Click
        valor2 = CDbl(txtDisplay.Text)
        Select Case operador
            Case "+"
                txtDisplay.Text = (valor1 + valor2).ToString()
            Case "-"
                txtDisplay.Text = (valor1 - valor2).ToString()
            Case "X"
                txtDisplay.Text = (valor1 * valor2).ToString()
            Case "/"
                If valor2 <> 0 Then
                    txtDisplay.Text = (valor1 / valor2).ToString()
                Else
                    MessageBox.Show("Error: División por cero.")
                    txtDisplay.Text = ""
                End If
        End Select
        operacionPendiente = True
    End Sub

    Private Sub C_Click(sender As Object, e As EventArgs) Handles C.Click
        txtDisplay.Text = ""
        valor1 = 0
        valor2 = 0
        operador = ""
        operacionPendiente = False
    End Sub
End Class

