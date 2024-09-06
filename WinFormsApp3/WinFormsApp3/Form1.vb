Public Class Form1
    'Var 3 Task3'
    Private Sub buttonShowGreeting_Click(sender As Object, e As EventArgs) Handles buttonShowGreeting.Click
        Dim name As String = textBoxName.Text

        If String.IsNullOrWhiteSpace(name) Then
            MessageBox.Show("Введите ваше имя, чтобы получить поздравление.")
            Return
        End If

        Dim greeting As String = $"Дорогий(а) {name}!" & vbCrLf & vbCrLf &
                                  "Щиро вітаю вас з днем народження!" & vbCrLf &
                                  "Бажаю вам здоров'я, щастя та успіхів!" & vbCrLf & vbCrLf &
                                  "З повагою," & vbCrLf &
                                  "Президент країни"

        labelGreeting.Text = greeting

        pictureBoxSignature.Visible = True
        PicSign.Visible = True

    End Sub
End Class
