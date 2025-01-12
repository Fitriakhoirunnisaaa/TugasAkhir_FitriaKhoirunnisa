Public Class Form1
    ' Variabel untuk menyimpan hasil IMT
    Dim imt As Double

    ' Array untuk kategori, keterangan, dan gambar
    Dim kategori() As String = {"Kurus", "Normal", "Gemuk", "Obesitas"}
    Dim keterangan() As String = {
        "Jangan lupa banyak makan makanan yang mengandung protein" & vbCrLf & "Karbohidrat, lemak, vitamin dan mineral ya!",
        "Kondisi tubuh kamu ideal!" & vbCrLf & "Pastikan kamu tetap menjaga pola makan sehat" & vbCrLf & "dan rutin berolahraga ya!",
        "Kamu harus perhatikan pola makan kamu dan rutin berolahraga ya!.",
        "Konsultasikan dengan dokter atau ahli gizi" & vbCrLf & "Bangun semangat untuk mengatur gaya hidup sehat dan berolahraga!"
    }
    Dim gambar() As String = {
        "Resources\kurus.png",
        "Resources\normal.png",
        "Resources\overweight.png",
        "Resources\obese.png"
    }

    ' Fungsi untuk menghitung IMT
    Private Sub ButtonHitung_Click(sender As Object, e As EventArgs) Handles ButtonHitung.Click
        ' Validasi input berat dan tinggi badan
        If Not Double.TryParse(TextBoxBerat.Text, imt) OrElse Not Double.TryParse(TextBoxTinggi.Text, imt) Then
            Labelkategori.Text = "Masukkan data yang benar"
            LabelKeterangan.Text = ""
            PictureBoxIMT.Image = Nothing
            Return
        End If

        ' Konversi tinggi badan ke meter
        Dim tinggiMeter As Double = Double.Parse(TextBoxTinggi.Text) / 100

        ' Hitung IMT
        imt = Double.Parse(TextBoxBerat.Text) / (tinggiMeter * tinggiMeter)

        ' Tampilkan hasil IMT di label
        LabelIMT.Text = "IMT: " & imt.ToString("F2")

        ' Tentukan kategori IMT, tampilkan gambar dan keterangan
        Dim index As Integer

        If imt < 18.5 Then
            index = 0 ' Kurus
        ElseIf imt >= 18.5 AndAlso imt <= 24.9 Then
            index = 1 ' Normal
        ElseIf imt >= 25 AndAlso imt <= 29.9 Then
            index = 2 ' Gemuk
        Else
            index = 3 ' Obesitas
        End If

        ' Set kategori, keterangan, dan gambar berdasarkan index
        Labelkategori.Text = kategori(index)
        LabelKeterangan.Text = keterangan(index)
        PictureBoxIMT.Image = Image.FromFile(gambar(index))

        ' Sesuaikan gambar dengan ukuran PictureBox
        PictureBoxIMT.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    ' Fungsi untuk mereset form
    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        ' Reset semua kontrol
        TextBoxBerat.Clear()
        TextBoxTinggi.Clear()
        LabelIMT.Text = "IMT:"
        Labelkategori.Text = ""
        LabelKeterangan.Text = ""
        PictureBoxIMT.Image = Nothing
    End Sub
End Class