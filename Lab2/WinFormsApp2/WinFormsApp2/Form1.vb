Public Class Form1
    Public Sub New()
        '11var Task 2
        InitializeComponent()

        AddHandler ButtonCalculate.Click, AddressOf ButtonCalculate_Click

        LabelError.Visible = False
    End Sub

    Private Sub ButtonCalculate_Click(sender As Object, e As EventArgs)
        LabelError.Text = String.Empty
        LabelError.Visible = False

        Dim A, B, C, R As Double

        If Not Double.TryParse(TextBoxA.Text, A) OrElse A <= 0 OrElse
           Not Double.TryParse(TextBoxB.Text, B) OrElse B <= 0 OrElse
           Not Double.TryParse(TextBoxC.Text, C) OrElse C <= 0 OrElse
           Not Double.TryParse(TextBoxR.Text, R) OrElse R <= 0 Then
            ShowError("Введите корректные положительные значения для всех углов и радиуса.")
            Return
        End If

        If Math.Abs(A + B + C - 180) > 0.01 Then
            ShowError("Сумма углов должна быть равна 180 градусам.")
            Return
        End If

        Try
            Dim A_rad As Double = Math.PI * A / 180
            Dim B_rad As Double = Math.PI * B / 180
            Dim C_rad As Double = Math.PI * C / 180

            A = 2 * R * Math.Sin(A_rad)
            B = 2 * R * Math.Sin(B_rad)
            C = 2 * R * Math.Sin(C_rad)

            If Double.IsNaN(A) OrElse Double.IsNaN(B) OrElse Double.IsNaN(C) Then
                ShowError("Не удалось вычислить стороны треугольника. Проверьте введенные данные.")
                Return
            End If

            LabelResult.Text = $"Стороны треугольника: a = {A:F2}, b = {B:F2}, c = {C:F2}"
        Catch ex As Exception
            ShowError("Произошла ошибка при расчете сторон треугольника.")
        End Try
    End Sub

    Private Sub ShowError(message As String)
        LabelError.Text = message
        LabelError.Visible = True
    End Sub
End Class
