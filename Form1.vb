Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnHesapla.Click
        Dim Ad As String
        Dim Vize, Final, Ortalama As Double
        Ad = txtAd.Text
        Vize = Val(txtVize.Text)
        Final = Val(txtFinal.Text)
        MessageBox.Show("Ad. " & Ad & vbCrLf &
                         "Vize." & Vize & vbCrLf &
                         "Final" & Final)
        Ortalama = (Vize * 0.4) + (Final * 0.6)
        If Ortalama >= 50 Then
            lblSonuc.Text = Ad & " - Geçti. Ortalama: " & Ortalama
        Else
            lblSonuc.Text = Ad & " - Kaldı. Ortalama: " & Ortalama
        End If

    End Sub


End Class
