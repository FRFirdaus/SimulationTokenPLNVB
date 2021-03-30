Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrLUAR.Tick
        grpLUAR.Left = grpLUAR.Left - 14
        If grpLUAR.Left = 0 Then
            tmrLUAR.Enabled = False
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        tmrLUAR.Enabled = True
        grpISI.Hide()
    End Sub

    Private Sub tmrRUMAH_Tick(sender As Object, e As EventArgs) Handles tmrRUMAH.Tick
        grpLUAR.Left = grpLUAR.Left + 14
        If grpLUAR.Left = 1400 Then
            tmrRUMAH.Enabled = False
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        tmrRUMAH.Enabled = True
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Dim a, b As String
        If tmrAC.Enabled = False Then
            a = MessageBox.Show("Apakah anda ingin menyalakan ac?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If a = vbYes Then
                If lblISISALDO.Text > 0 Then
                    pctARUSAC.Show()
                    tmrAC.Enabled = True
                Else
                    MessageBox.Show("Anda Tidak Mempunyai Saldo, Silahkan Isi ulang token anda!", "CAUTION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        ElseIf tmrAC.Enabled = True Then
            b = MessageBox.Show("Apakah anda ingin mematikan ac?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If b = vbYes Then
                tmrAC.Enabled = False
                pctARUSAC.Hide()
            End If
        End If

    End Sub

    Private Sub tmrAC_Tick(sender As Object, e As EventArgs) Handles tmrAC.Tick
        Dim a, tot As Integer
        tot = lblANGKAUAC.Text
        tot = 0
        a = lblISISALDO.Text
        pctARUSAC.Top = pctARUSAC.Top + 2
        If pctARUSAC.Top = 170 Then
            lblISISALDO.Text = lblISISALDO.Text - 300
            lblANGKAUAC.Text = lblANGKAUAC.Text + 300
            pctARUSAC.Top = 140
            If lblISISALDO.Text <= 0 Then
                lblISISALDO.Text = 0
                pctTV.BackColor = Color.Black
                tmrTONE.Enabled = False
                tmrAC.Enabled = False
                tmrTV.Enabled = False
                pctARUSAC.Hide()
                pctTONE1.Hide()
                pctGSUARA.Hide()
                pctM1.Hide()
                pctM2.Hide()
                pctM3.Hide()
                lblmonster.Hide()
                MessageBox.Show("Saldo Token anda Telah Habis!")
                btnSTAT.Enabled = True
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnCLOSEINDO.Enabled = False
        pctARUSAC.Hide()
        cmbSALDO.Enabled = False
        lblKODE.Text = ""
        lblWELCOME.Text = ""
        lblnotoken.Text = ""
        lblISISALDO.Text = 5000
        pctTONE1.Hide()
        pctGSUARA.Hide()
        grpPEMAKAIAN.Hide()
        lblANGKAUAC.Hide()
        lblANGKAURAD.Hide()
        lblANGKAUTV.Hide()
        btngoac.Hide()
        btngotv.Hide()
        btngorad.Hide()
        pctM1.Hide()
        pctM2.Hide()
        pctM3.Hide()
        lblmonster.Hide()
        btnSTAT.Enabled = False
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles pctTV.Click
        Dim a, b As String
        If tmrTV.Enabled = False Then
            a = MessageBox.Show("Apakah anda ingin menyalakan TV?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If a = vbYes Then
                If lblISISALDO.Text > 0 Then
                    tmrTV.Enabled = True
                Else
                    MessageBox.Show("Anda Tidak Mempunyai Saldo, Silahkan Isi ulang token anda!", "CAUTION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        ElseIf tmrTV.Enabled = True Then
            b = MessageBox.Show("Apakah anda ingin mematikan TV?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If b = vbYes Then
                tmrTV.Enabled = False
                pctM1.Hide()
                pctM2.Hide()
                pctM3.Hide()
                lblmonster.Hide()
                pctTV.BackColor = Color.Black

            End If
        End If


    End Sub

    Private Sub tmrTV_Tick(sender As Object, e As EventArgs) Handles tmrTV.Tick
        Dim a As Integer
        a = lblANGKAUAC.Text
        Select Case pctTV.BackColor
            Case Color.Black
                pctM1.Show()
                pctM1.BackColor = Color.Red
                pctTV.BackColor = Color.Red
            Case Color.Red
                pctTV.BackColor = Color.Blue
                pctM1.BackColor = Color.Blue
            Case Color.Blue
                pctM2.Show()
                pctM1.Hide()
                pctTV.BackColor = Color.Green
                pctM2.BackColor = Color.Green
            Case Color.Green
                pctTV.BackColor = Color.Gold
                pctM2.BackColor = Color.Gold
            Case Color.Gold
                pctM3.Show()
                pctM2.Hide()
                pctTV.BackColor = Color.Lavender
                pctM3.BackColor = Color.Lavender
            Case Color.Lavender
                pctTV.BackColor = Color.Yellow
                pctM3.BackColor = Color.Yellow
            Case Color.Yellow
                lblmonster.Show()
                pctM3.Hide()
                pctTV.BackColor = Color.White
            Case Color.White
                lblmonster.Hide()
                pctTV.BackColor = Color.Black
                lblISISALDO.Text = lblISISALDO.Text - 150
                lblANGKAUTV.Text = lblANGKAUTV.Text + 150
                If lblISISALDO.Text <= 0 Then
                    lblISISALDO.Text = 0
                    pctTV.BackColor = Color.Black
                    pctTONE1.Hide()
                    pctGSUARA.Hide()
                    pctARUSAC.Hide()
                    pctM1.Hide()
                    pctM2.Hide()
                    pctM3.Hide()
                    lblmonster.Hide()
                    tmrTV.Enabled = False
                    tmrTONE.Enabled = False
                    tmrAC.Enabled = False
                    MessageBox.Show("Saldo Token anda Telah Habis!")
                    btnSTAT.Enabled = True
                End If
        End Select
    End Sub

    Private Sub tmrWELCOME_Tick(sender As Object, e As EventArgs) Handles tmrMASUKINDO.Tick
        grpTOKEN.Top = grpTOKEN.Top - 8
        If grpTOKEN.Top = 242 Then
            tmrMASUKINDO.Enabled = False
            tmrmbakindo.Enabled = True
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        tmrMASUKINDO.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCLOSEINDO.Click
        tmrKELUARINDO.Enabled = True
        txtNOMOR.Clear()
        cmbSALDO.Text = ""
        txtKODE.Clear()
    End Sub

    Private Sub tmrKELUARINDO_Tick(sender As Object, e As EventArgs) Handles tmrKELUARINDO.Tick
        tmrKELUARINDO.Interval = 100
        btnCLOSEINDO.Enabled = False
        lblnotoken.Text = ""
        Select Case lblWELCOME.Text
            Case "Selamat Datang Di Indomaret,"
                lblWELCOME.Text = "T"
            Case "T"
                lblWELCOME.Text = "Te"
            Case "Te"
                lblWELCOME.Text = "Ter"
            Case "Ter"
                lblWELCOME.Text = "Teri"
            Case "Teri"
                lblWELCOME.Text = "Terim"
            Case "Terim"
                lblWELCOME.Text = "Terima"
            Case "Terima"
                lblWELCOME.Text = "Terima K"
            Case "Terima K"
                lblWELCOME.Text = "Terima Ka"
            Case "Terima Ka"
                lblWELCOME.Text = "Terima Kas"
            Case "Terima Kas"
                lblWELCOME.Text = "Terima Kasi"
            Case "Terima Kasi"
                lblWELCOME.Text = "Terima Kasih"
            Case "Terima Kasih"
                lblWELCOME.Text = "Terima Kasih."
            Case "Terima Kasih."
                lblWELCOME.Text = "Terima Kasih.."
            Case "Terima Kasih.."
                tmrKELUARINDO.Interval = 10
                grpTOKEN.Top = grpTOKEN.Top + 8
                If grpTOKEN.Top = 730 Then
                    tmrKELUARINDO.Enabled = False
                    lblWELCOME.Text = ""
                End If
        End Select

    End Sub

    Private Sub tmrmbakindo_Tick(sender As Object, e As EventArgs) Handles tmrmbakindo.Tick
        Select Case lblWELCOME.Text
            Case ""
                lblWELCOME.Text = "S"
            Case "S"
                lblWELCOME.Text = "Se"
            Case "Se"
                lblWELCOME.Text = "Sel"
            Case "Sel"
                lblWELCOME.Text = "Sela"
            Case "Sela"
                lblWELCOME.Text = "Selam"
            Case "Selam"
                lblWELCOME.Text = "Selama"
            Case "Selama"
                lblWELCOME.Text = "Selamat"
            Case "Selamat"
                lblWELCOME.Text = "Selamat D"
            Case "Selamat D"
                lblWELCOME.Text = "Selamat Da"
            Case "Selamat Da"
                lblWELCOME.Text = "Selamat Dat"
            Case "Selamat Dat"
                lblWELCOME.Text = "Selamat Data"
            Case "Selamat Data"
                lblWELCOME.Text = "Selamat Datan"
            Case "Selamat Datan"
                lblWELCOME.Text = "Selamat Datang "
            Case "Selamat Datang "
                lblWELCOME.Text = "Selamat Datang D"
            Case "Selamat Datang D"
                lblWELCOME.Text = "Selamat Datang Di"
            Case "Selamat Datang Di"
                lblWELCOME.Text = "Selamat Datang Di I"
            Case "Selamat Datang Di I"
                lblWELCOME.Text = "Selamat Datang Di In"
            Case "Selamat Datang Di In"
                lblWELCOME.Text = "Selamat Datang Di Ind"
            Case "Selamat Datang Di Ind"
                lblWELCOME.Text = "Selamat Datang Di Indo"
            Case "Selamat Datang Di Indo"
                lblWELCOME.Text = "Selamat Datang Di Indom"
            Case "Selamat Datang Di Indom"
                lblWELCOME.Text = "Selamat Datang Di Indoma"
            Case "Selamat Datang Di Indoma"
                lblWELCOME.Text = "Selamat Datang Di Indomar"
            Case "Selamat Datang Di Indomar"
                lblWELCOME.Text = "Selamat Datang Di Indomare"
            Case "Selamat Datang Di Indomare"
                lblWELCOME.Text = "Selamat Datang Di Indomaret,"
            Case "Selamat Datang Di Indomaret,"
                Select Case lblnotoken.Text
                    Case ""
                        lblnotoken.Text = "M"
                    Case "M"
                        lblnotoken.Text = "Ma"
                    Case "Ma"
                        lblnotoken.Text = "Mas"
                    Case "Mas"
                        lblnotoken.Text = "Masu"
                    Case "Masu"
                        lblnotoken.Text = "Masuk"
                    Case "Masuk"
                        lblnotoken.Text = "Masukk"
                    Case "Masukk"
                        lblnotoken.Text = "Masukka"
                    Case "Masukka"
                        lblnotoken.Text = "Masukkan"
                    Case "Masukkan"
                        lblnotoken.Text = "Masukkan N"
                    Case "Masukkan N"
                        lblnotoken.Text = "Masukkan No"
                    Case "Masukkan No"
                        lblnotoken.Text = "Masukkan Nom"
                    Case "Masukkan Nom"
                        lblnotoken.Text = "Masukkan Nomo"
                    Case "Masukkan Nomo"
                        lblnotoken.Text = "Masukkan Nomor"
                    Case "Masukkan Nomor"
                        lblnotoken.Text = "Masukkan Nomor T"
                    Case "Masukkan Nomor T"
                        lblnotoken.Text = "Masukkan Nomor To"
                    Case "Masukkan Nomor To"
                        lblnotoken.Text = "Masukkan Nomor Tok"
                    Case "Masukkan Nomor Tok"
                        lblnotoken.Text = "Masukkan Nomor Toke"
                    Case "Masukkan Nomor Toke"
                        lblnotoken.Text = "Masukkan Nomor Token"
                    Case "Masukkan Nomor Token"
                        lblnotoken.Text = "Masukkan Nomor Token A"
                    Case "Masukkan Nomor Token A"
                        lblnotoken.Text = "Masukkan Nomor Token An"
                    Case "Masukkan Nomor Token An"
                        lblnotoken.Text = "Masukkan Nomor Token And"
                    Case "Masukkan Nomor Token And"
                        lblnotoken.Text = "Masukkan Nomor Token Anda"
                    Case "Masukkan Nomor Token Anda"
                        lblnotoken.Text = "Masukkan Nomor Token Anda!"
                        tmrmbakindo.Enabled = False
                        btnCLOSEINDO.Enabled = True
                End Select

        End Select
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNOMOR.TextChanged

    End Sub

    Private Sub cmbSALDO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSALDO.SelectedIndexChanged
        Dim a As String
        a = cmbSALDO.Items(cmbSALDO.SelectedIndex).ToString
        Select Case a
            Case "Rp 5000"
                txtKODE.Clear()
                txtKODE.Text = "123456"
            Case "Rp 10.000"
                txtKODE.Clear()
                txtKODE.Text = "654321"
            Case "Rp 20.000"
                txtKODE.Clear()
                txtKODE.Text = "567890"
            Case "Rp 25.000"
                txtKODE.Clear()
                txtKODE.Text = "098765"
            Case "Rp 50.000"
                txtKODE.Clear()
                txtKODE.Text = "135791"
        End Select
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If txtNOMOR.Text = "554347" Then
            MessageBox.Show("Nomer Pin Anda Benar, Silahkan Pilih Nominal Token!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmbSALDO.Enabled = True
        Else
            MessageBox.Show("Nomor Token anda salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        grpISI.Show()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs)
        grpISI.Hide()
    End Sub

    Private Sub tmrISI_Tick(sender As Object, e As EventArgs) Handles tmrISIIN.Tick
        grpISI.Left = grpISI.Left - 6
        If grpISI.Left = 832 Then
            tmrISIIN.Enabled = False
        End If
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        tmrISIIN.Enabled = True
        grpISI.Show()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        tmrISIOUT.Enabled = True
    End Sub

    Private Sub tmrISIOUT_Tick(sender As Object, e As EventArgs) Handles tmrISIOUT.Tick
        grpISI.Left = grpISI.Left + 6
        If grpISI.Left = 1114 Then
            tmrISIOUT.Enabled = False
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If txtKODE.Text = "" Then
            MessageBox.Show("Tidak ada nomor aktivasi", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Nomor Berhasil Disimpan", "BERHASIL", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lblKODE.Text = txtKODE.Text
            txtNOMOR.Text = ""
            cmbSALDO.Text = ""
            txtKODE.Text = ""
        End If
    End Sub


    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        txtMETERAN.Text = txtMETERAN.Text + "1"
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        txtMETERAN.Text = txtMETERAN.Text + "2"
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        txtMETERAN.Text = txtMETERAN.Text + "3"
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        txtMETERAN.Text = txtMETERAN.Text + "4"
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        txtMETERAN.Text = txtMETERAN.Text + "5"
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        txtMETERAN.Text = txtMETERAN.Text + "6"
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        txtMETERAN.Text = txtMETERAN.Text + "7"
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        txtMETERAN.Text = txtMETERAN.Text + "8"
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        txtMETERAN.Text = txtMETERAN.Text + "9"
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        txtMETERAN.Text = txtMETERAN.Text + "0"
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        txtMETERAN.Text = ""
    End Sub
    Public nominal As Integer
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim a As Integer
        a = lblISISALDO.Text
        If txtMETERAN.Text = lblKODE.Text Then

            If txtMETERAN.Text = "123456" Then
                MessageBox.Show("Anda berhasil Aktivasi Kode!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtMETERAN.Text = ""
                lblKODE.Text = ""
                lblISISALDO.Text = lblISISALDO.Text + 5000 '* 0.00066)
                lblANGKAUAC.Text = 0
                lblANGKAURAD.Text = 0
                lblANGKAUTV.Text = 0
                lblpersentv.Text = 0
                lblpersenac.Text = 0
                lblpersenrad.Text = 0
                lblANGKAUTV.Hide()
                lblANGKAURAD.Hide()
                lblANGKAUAC.Hide()
                btngorad.Hide()
                btngoac.Hide()
                btngotv.Hide()
                btnSTAT.Enabled = False
            ElseIf txtMETERAN.Text = "654321" Then
                MessageBox.Show("Anda berhasil Aktivasi Kode!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtMETERAN.Text = ""
                lblKODE.Text = ""
                lblISISALDO.Text = lblISISALDO.Text + 10000 '* 0.00066)
                lblANGKAUAC.Text = 0
                lblANGKAURAD.Text = 0
                lblpersenac.Text = 0
                lblpersenrad.Text = 0
                lblANGKAUTV.Text = 0
                lblpersentv.Text = 0
                lblANGKAUTV.Hide()
                lblANGKAURAD.Hide()
                lblANGKAUAC.Hide()
                btngorad.Hide()
                btngoac.Hide()
                btngotv.Hide()
                btnSTAT.Enabled = False
            ElseIf txtMETERAN.Text = "567890" Then
                MessageBox.Show("Anda berhasil Aktivasi Kode!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtMETERAN.Text = ""
                lblKODE.Text = ""
                lblISISALDO.Text = lblISISALDO.Text + (20000 * 0.00066)
                lblANGKAUAC.Text = 0
                lblANGKAURAD.Text = 0
                lblpersenac.Text = 0
                lblpersenrad.Text = 0
                lblANGKAUTV.Text = 0
                lblpersentv.Text = 0
                lblANGKAUTV.Hide()
                lblANGKAURAD.Hide()
                lblANGKAUAC.Hide()
                btngorad.Hide()
                btngoac.Hide()
                btngotv.Hide()
                btnSTAT.Enabled = False
            ElseIf txtMETERAN.Text = "098765" Then
                MessageBox.Show("Anda berhasil Aktivasi Kode!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtMETERAN.Text = ""
                lblKODE.Text = ""
                lblISISALDO.Text = lblISISALDO.Text + 25000 '* 0.00066)
                lblANGKAUAC.Text = 0
                lblANGKAURAD.Text = 0
                lblpersenac.Text = 0
                lblpersenrad.Text = 0
                lblANGKAUTV.Text = 0
                lblpersentv.Text = 0
                lblANGKAUTV.Hide()
                lblANGKAURAD.Hide()
                lblANGKAUAC.Hide()
                btngorad.Hide()
                btngoac.Hide()
                btngotv.Hide()
                btnSTAT.Enabled = False
            ElseIf txtMETERAN.Text = "135791" Then
                MessageBox.Show("Anda berhasil Aktivasi Kode!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtMETERAN.Text = ""
                lblKODE.Text = ""
                lblISISALDO.Text = lblISISALDO.Text + 50000 '* 0.00066)
                lblANGKAUAC.Text = 0
                lblANGKAURAD.Text = 0
                lblpersenac.Text = 0
                lblpersenrad.Text = 0
                lblANGKAUTV.Text = 0
                lblpersentv.Text = 0
                lblANGKAUTV.Hide()
                lblANGKAURAD.Hide()
                lblANGKAUAC.Hide()
                btngorad.Hide()
                btngoac.Hide()
                btngotv.Hide()
                btnSTAT.Enabled = False
            End If
        Else
            MessageBox.Show("Anda Salah Memasukkan Kode!", "REJECTED", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles pctRADI.Click
        Dim a, b As String
        If tmrTONE.Enabled = False Then
            a = MessageBox.Show("Apakah anda ingin menyalakan Radio?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If a = vbYes Then
                If lblISISALDO.Text > 0 Then
                    pctTONE1.Show()
                    tmrTONE.Enabled = True
                Else
                    MessageBox.Show("Anda Tidak Mempunyai Saldo, Silahkan Isi ulang token anda!", "CAUTION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        ElseIf tmrTONE.Enabled = True Then
            b = MessageBox.Show("Apakah anda ingin mematikan Radio?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If b = vbYes Then
                tmrTONE.Enabled = False
                pctTONE1.Hide()
                pctGSUARA.Hide()
            End If
        End If
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles pctTONE1.Click

    End Sub

    Private Sub tmrTONE_Tick(sender As Object, e As EventArgs) Handles tmrTONE.Tick
        Dim a, tot, uac, urad, persen As Integer
        uac = lblANGKAUAC.Text
        urad = lblANGKAURAD.Text
        tot = lblANGKAURAD.Text
        tot = 0
        a = lblISISALDO.Text
        pctTONE1.Top = pctTONE1.Top - 2
        If pctTONE1.Top = 444 Then
            pctGSUARA.Show()
        ElseIf pctTONE1.Top = 438 Then
            pctGSUARA.Hide()
        ElseIf pctTONE1.Top = 432 Then
            pctGSUARA.Show()
        ElseIf pctTONE1.Top = 426 Then
            pctGSUARA.Hide()
        ElseIf pctTONE1.Top = 420 Then
            lblISISALDO.Text = lblISISALDO.Text - 50
            lblANGKAURAD.Text = lblANGKAURAD.Text + 50
            pctTONE1.Top = 450
            If lblISISALDO.Text <= 0 Then
                lblISISALDO.Text = 0
                pctTV.BackColor = Color.Black
                tmrTONE.Enabled = False
                tmrAC.Enabled = False
                tmrTV.Enabled = False
                pctTONE1.Hide()
                pctGSUARA.Hide()
                pctARUSAC.Hide()
                pctM1.Hide()
                pctM2.Hide()
                pctM3.Hide()
                lblmonster.Hide()
                MessageBox.Show("Saldo Token anda Telah Habis!")
                btnSTAT.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnSTAT_Click(sender As Object, e As EventArgs) Handles btnSTAT.Click
        Dim persenac, persenrad, persentv, utv, uac, urad As Integer
        btngotv.Show()
        btngorad.Show()
        btngoac.Show()
        uac = lblANGKAUAC.Text
        urad = lblANGKAURAD.Text
        utv = lblANGKAUTV.Text
        persentv = utv / (urad + uac + utv) * 100
        persenrad = urad / (urad + uac + utv) * 100
        persenac = uac / (uac + urad + utv) * 100
        lblpersenac.Text = persenac
        lblpersenrad.Text = persenrad
        lblpersentv.Text = persentv
        dotYELLOW.Height = 5
        dotYELLOW.Top = 192
        dotGold.Height = 5
        dotGold.Top = 192
        dotRED.Height = 5
        dotRED.Top = 192
        LABELG1.Text = 0
        LABELG2.Text = 0
        LABELG3.Text = 0
        led1.Enabled = True
        led2.Enabled = True
        led3.Enabled = True
        tmrGRAFIK.Enabled = True

    End Sub

    Private Sub btnSHOW_Click(sender As Object, e As EventArgs) Handles btnSHOW.Click
        If btnSHOW.Text = "Show" Then
            grpPEMAKAIAN.Show()
            btnSHOW.Text = "Hide"
            dotYELLOW.Height = 5
            dotYELLOW.Top = 192
            dotGold.Height = 5
            dotGold.Top = 192
            dotRED.Height = 5
            dotRED.Top = 192
            LABELG1.Text = 0
            LABELG2.Text = 0
            LABELG3.Text = 0
        ElseIf btnSHOW.Text = "Hide" Then
            grpPEMAKAIAN.Hide()
            btnSHOW.Text = "Show"
            tmrGRAFIK.Enabled = False
            lblGRAFIK.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btngoac.Click
        lblANGKAUAC.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btngorad.Click
        lblANGKAURAD.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btngotv.Click
        lblANGKAUTV.Show()
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs)


    End Sub

    Private Sub led1_Tick(sender As Object, e As EventArgs) Handles led1.Tick
        If lblpersenac.Text > 0 Then
            dotRED.Height = dotRED.Height + 2
            dotRED.Top = dotRED.Top - 2
            LABELG1.Text = LABELG1.Text + 1
            If dotRED.Height = 5 + (CInt(lblpersenac.Text) * 2) Then
                led1.Enabled = False
            End If

        Else
            led1.Enabled = False
        End If
       
    End Sub

    Private Sub led2_Tick(sender As Object, e As EventArgs) Handles led2.Tick
        If lblpersenrad.Text > 0 Then
            dotGold.Height = dotGold.Height + 2
            dotGold.Top = dotGold.Top - 2
            LABELG2.Text = LABELG2.Text + 1
            If dotGold.Height = 5 + (CInt(lblpersenrad.Text) * 2) Then
                led2.Enabled = False
            End If

        Else
            led2.Enabled = False
        End If
    End Sub

    Private Sub led3_Tick(sender As Object, e As EventArgs) Handles led3.Tick
        If lblpersentv.Text > 0 Then
            dotYELLOW.Height = dotYELLOW.Height + 2
            dotYELLOW.Top = dotYELLOW.Top - 2
            LABELG3.Text = LABELG3.Text + 1
            If dotYELLOW.Height = 5 + (CInt(lblpersentv.Text) * 2) Then
                led3.Enabled = False
            End If

        Else
            led3.Enabled = False
        End If
    End Sub

    Private Sub tmrGRAFIK_Tick(sender As Object, e As EventArgs) Handles tmrGRAFIK.Tick
        Select Case lblGRAFIK.ForeColor
            Case Color.Black
                lblGRAFIK.ForeColor = Color.Red
            Case Color.Red
                lblGRAFIK.ForeColor = Color.Green
            Case Color.Green
                lblGRAFIK.ForeColor = Color.Orange
            Case Color.Orange
                lblGRAFIK.ForeColor = Color.Maroon
            Case Color.Maroon
                lblGRAFIK.ForeColor = Color.Black
        End Select
    End Sub

    Private Sub TToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TToolStripMenuItem.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub lblpersenac_Click(sender As Object, e As EventArgs) Handles lblpersenac.Click

    End Sub
End Class
