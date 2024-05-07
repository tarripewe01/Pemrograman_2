Public Class Form_petugas
    Dim sql As String
    Dim proses As New koneksi
    Dim petugas As DataTable

    Sub kosong()
        Txt_ID_Petugas.Clear()
        Txt_Nama_petugas.Clear()
        Txt_Password.Clear()
        Txt_Alamat.Clear()
        Txt_NOHP.Clear()
        Cb_JK.Text = ""
        Cb_Agama.Text = ""
        BTN_Simpan.Enabled = True
        BTN_Ubah.Enabled = False
        BTN_Hapus.Enabled = False
        Txt_ID_Petugas.Focus()
    End Sub

    Sub Tampildata()
        petugas = proses.executequery("select * from petugas order by 
    ID_petugas asc")
        DGV_Petugas.DataSource = petugas
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kosong()
        Tampildata()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTN_Simpan.Click
        If Txt_ID_Petugas.Text = "" Or Txt_Nama_petugas.Text = "" Or
Txt_Password.Text = "" Or Txt_Alamat.Text = "" Or Txt_NOHP.Text = "" Or
Cb_Agama.Text = "" Or Cb_JK.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub
        Else
            petugas = proses.executequery("select * from petugas where 
id_Petugas='" & Txt_ID_Petugas.Text & "'")
            If petugas.Rows.Count = 0 Then
                sql = "insert into petugas values('" &
               Txt_ID_Petugas.Text & "','" & Txt_Nama_petugas.Text & "','" &
               Txt_Password.Text & "','" & Cb_JK.Text & "','" & Cb_Agama.Text & "','" &
               Txt_Alamat.Text & "','" & Txt_NOHP.Text & "')"
                proses.executenonquery(sql)
                MessageBox.Show("data telah disimpan..!!", "penyimpanan 
sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        Tampildata()
        kosong()
    End Sub

    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Petugas.CellContentClick

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Txt_Alamat_TextChanged(sender As Object, e As EventArgs) Handles Txt_Alamat.TextChanged

    End Sub

    Private Sub BTN_Ubah_Click(sender As Object, e As EventArgs) Handles BTN_Ubah.Click
        If Txt_ID_Petugas.Text = "" Or Txt_Nama_petugas.Text = "" Or
Txt_Password.Text = "" Or Txt_Alamat.Text = "" Or Txt_NOHP.Text = "" Or
Cb_Agama.Text = "" Or Cb_JK.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub
        Else
            sql = "update petugas set nama_petugas='" &
           Txt_Nama_petugas.Text & "',password='" & Txt_Password.Text &
           "',jenis_kelamin='" & Cb_JK.Text & "',agama='" & Cb_Agama.Text &
           "',alamat='" & Txt_Alamat.Text & "',no_hp='" & Txt_NOHP.Text & "' where 
ID_Petugas='" & Txt_ID_Petugas.Text & "'"
            proses.executenonquery(sql)
            MessageBox.Show("data telah diubah..!!", "penyimpanan 
sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Tampildata()
        kosong()
    End Sub

    Private Sub BTN_Hapus_Click(sender As Object, e As EventArgs) Handles BTN_Hapus.Click
        If MsgBox("apakah anda yakin mau menghapus data?",
MsgBoxStyle.YesNo, "kompirmasi") = MsgBoxResult.Yes Then
            sql = "delete from petugas where id_petugas='" &
           Txt_ID_Petugas.Text & "'"
            proses.executenonquery(sql)
            MessageBox.Show("data telah dihapus..!!", "penghapusan 
sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Tampildata()
        Else
            MessageBox.Show("silahkan HAPUS data yang lain..!!",
           "pesan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        kosong()
    End Sub

    Private Sub BTN_cari_Click(sender As Object, e As EventArgs) Handles BTN_cari.Click
        petugas = proses.executequery("select*from petugas where 
id_petugas='" & Txt_ID_Petugas.Text & "'")
        If petugas.Rows.Count = 0 Then
            MessageBox.Show("data tidak ada dalam database,silahkan 
inputkan data..!!", "informasi", MessageBoxButtons.OK,
           MessageBoxIcon.Information)
            Txt_ID_Petugas.Focus()
        Else
            With petugas.Rows(0)
                Txt_Nama_petugas.Text = .Item("nama_petugas")
                Txt_Password.Text = .Item("password")
                Txt_Alamat.Text = .Item("alamat")
                Txt_NOHP.Text = .Item("no_hp")
                Cb_JK.Text = .Item("jenis_kelamin")
                Cb_Agama.Text = .Item("agama")
                BTN_Simpan.Enabled = False
                BTN_Ubah.Enabled = True
                BTN_Hapus.Enabled = True
            End With
        End If
    End Sub

    Private Sub BTN_Batal_Click(sender As Object, e As EventArgs) Handles BTN_Batal.Click
        kosong()
    End Sub
End Class
