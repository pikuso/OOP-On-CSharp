Public Class Form1
    Public Sub New()
        ' 9 VARIANT TASK 1
        InitializeComponent()

        AddHandler ButtonCalculate.Click, AddressOf ButtonCalculate_Click
    End Sub

    Private Sub ButtonCalculate_Click(sender As Object, e As EventArgs)
        LabelError.Text = String.Empty
        Dim R1, R2, R3, R4 As Double

        If Not Double.TryParse(TextBoxR1.Text, R1) OrElse R1 <= 0 OrElse
           Not Double.TryParse(TextBoxR2.Text, R2) OrElse R2 <= 0 OrElse
           Not Double.TryParse(TextBoxR3.Text, R3) OrElse R3 <= 0 OrElse
           Not Double.TryParse(TextBoxR4.Text, R4) OrElse R4 <= 0 Then
            LabelError.Text = "Введите корректные положительные значения для всех резисторов."
            Return
        End If

        Dim Rtotal As Double
        If RadioButtonSeries.Checked Then
            Rtotal = R1 + R2 + R3 + R4
        ElseIf RadioButtonParallel.Checked Then
            Rtotal = 1 / (1 / R1 + 1 / R2 + 1 / R3 + 1 / R4)
        Else
            LabelError.Text = "Выберите тип соединения."
            Return
        End If

        LabelResult.Text = $"Общее сопротивление: {Rtotal:F2} Ом"
    End Sub
End Class
