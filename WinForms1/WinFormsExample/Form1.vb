Public Class Form1
    '19 Variant Task 1'
    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Try
            Dim angleA As Double
            Dim angleB As Double
            Dim sideC As Double

            If Not Double.TryParse(textBoxA.Text, angleA) Then
                MessageBox.Show("Угол A должен быть числом.")
                Return
            End If

            If Not Double.TryParse(textBoxB.Text, angleB) Then
                MessageBox.Show("Угол B должен быть числом.")
                Return
            End If

            If Not Double.TryParse(textBoxC.Text, sideC) Then
                MessageBox.Show("Сторона c должна быть числом.")
                Return
            End If

            If angleA <= 0 Then
                MessageBox.Show("Угол A должен быть положительным числом.")
                Return
            End If

            If angleB <= 0 Then
                MessageBox.Show("Угол B должен быть положительным числом.")
                Return
            End If

            If angleA + angleB >= 180 Then
                MessageBox.Show("Сумма углов A и B должна быть меньше 180°.")
                Return
            End If

            If sideC <= 0 Then
                MessageBox.Show("Сторона c должна быть положительным числом.")
                Return
            End If

            Dim angleC As Double = 180 - angleA - angleB

            Dim angleARad As Double = angleA * Math.PI / 180
            Dim angleBRad As Double = angleB * Math.PI / 180
            Dim angleCRad As Double = angleC * Math.PI / 180

            Dim sideA As Double = (sideC * Math.Sin(angleARad)) / Math.Sin(angleCRad)
            Dim sideB As Double = (sideC * Math.Sin(angleBRad)) / Math.Sin(angleCRad)

            textBoxResultAngleC.Text = angleC.ToString()
            textBoxResultSideA.Text = sideA.ToString()
            textBoxResultSideB.Text = sideB.ToString()

        Catch ex As Exception
            MessageBox.Show("Ошибка: " & ex.Message)
        End Try
    End Sub
End Class
