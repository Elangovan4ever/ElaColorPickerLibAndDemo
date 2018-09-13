Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''ColorPicker1.Color = Color.Green
        colorPicker1.Color = My.Settings.selected_color
    End Sub

    Private Sub colorPicker1_ColorChanged_1(sender As Object, e As EventArgs) Handles colorPicker1.ColorChanged
        My.Settings.selected_color = colorPicker1.Color
    End Sub
End Class
