<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_petugas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        SplitContainer1 = New SplitContainer()
        BTN_Batal = New Button()
        BTN_Hapus = New Button()
        BTN_Ubah = New Button()
        BTN_Simpan = New Button()
        GroupBox1 = New GroupBox()
        Txt_NOHP = New TextBox()
        Label6 = New Label()
        Txt_Alamat = New RichTextBox()
        Label5 = New Label()
        Cb_Agama = New ComboBox()
        Txt_Agama = New Label()
        Cb_JK = New ComboBox()
        Label4 = New Label()
        Txt_Password = New TextBox()
        Label3 = New Label()
        Txt_Nama_petugas = New TextBox()
        Label2 = New Label()
        BTN_cari = New Button()
        Txt_ID_Petugas = New TextBox()
        Label1 = New Label()
        DGV_Petugas = New DataGridView()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(DGV_Petugas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 0)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(BTN_Batal)
        SplitContainer1.Panel1.Controls.Add(BTN_Hapus)
        SplitContainer1.Panel1.Controls.Add(BTN_Ubah)
        SplitContainer1.Panel1.Controls.Add(BTN_Simpan)
        SplitContainer1.Panel1.Controls.Add(GroupBox1)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(DGV_Petugas)
        SplitContainer1.Size = New Size(2100, 848)
        SplitContainer1.SplitterDistance = 700
        SplitContainer1.TabIndex = 0
        ' 
        ' BTN_Batal
        ' 
        BTN_Batal.Location = New Point(526, 771)
        BTN_Batal.Name = "BTN_Batal"
        BTN_Batal.Size = New Size(154, 46)
        BTN_Batal.TabIndex = 4
        BTN_Batal.Text = "Batal"
        BTN_Batal.UseVisualStyleBackColor = True
        ' 
        ' BTN_Hapus
        ' 
        BTN_Hapus.Location = New Point(353, 771)
        BTN_Hapus.Name = "BTN_Hapus"
        BTN_Hapus.Size = New Size(154, 46)
        BTN_Hapus.TabIndex = 3
        BTN_Hapus.Text = "Hapus"
        BTN_Hapus.UseVisualStyleBackColor = True
        ' 
        ' BTN_Ubah
        ' 
        BTN_Ubah.Location = New Point(184, 771)
        BTN_Ubah.Name = "BTN_Ubah"
        BTN_Ubah.Size = New Size(154, 46)
        BTN_Ubah.TabIndex = 2
        BTN_Ubah.Text = "Ubah"
        BTN_Ubah.UseVisualStyleBackColor = True
        ' 
        ' BTN_Simpan
        ' 
        BTN_Simpan.Location = New Point(24, 771)
        BTN_Simpan.Name = "BTN_Simpan"
        BTN_Simpan.Size = New Size(154, 46)
        BTN_Simpan.TabIndex = 1
        BTN_Simpan.Text = "Simpan"
        BTN_Simpan.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ButtonFace
        GroupBox1.Controls.Add(Txt_NOHP)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Txt_Alamat)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Cb_Agama)
        GroupBox1.Controls.Add(Txt_Agama)
        GroupBox1.Controls.Add(Cb_JK)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Txt_Password)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Txt_Nama_petugas)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(BTN_cari)
        GroupBox1.Controls.Add(Txt_ID_Petugas)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(24, 46)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(656, 683)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Input Data Petugas"
        ' 
        ' Txt_NOHP
        ' 
        Txt_NOHP.Location = New Point(175, 605)
        Txt_NOHP.Name = "Txt_NOHP"
        Txt_NOHP.Size = New Size(458, 39)
        Txt_NOHP.TabIndex = 18
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(16, 612)
        Label6.Name = "Label6"
        Label6.Size = New Size(83, 32)
        Label6.TabIndex = 17
        Label6.Text = "No HP"
        ' 
        ' Txt_Alamat
        ' 
        Txt_Alamat.Location = New Point(175, 448)
        Txt_Alamat.Name = "Txt_Alamat"
        Txt_Alamat.Size = New Size(458, 118)
        Txt_Alamat.TabIndex = 16
        Txt_Alamat.Text = ""
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(16, 439)
        Label5.Name = "Label5"
        Label5.Size = New Size(88, 32)
        Label5.TabIndex = 15
        Label5.Text = "Alamat"
        ' 
        ' Cb_Agama
        ' 
        Cb_Agama.FormattingEnabled = True
        Cb_Agama.Items.AddRange(New Object() {"Islam", "Kristen Protestan", "Katolik", "Hindu", "Buddha"})
        Cb_Agama.Location = New Point(175, 356)
        Cb_Agama.Name = "Cb_Agama"
        Cb_Agama.Size = New Size(255, 40)
        Cb_Agama.TabIndex = 14
        ' 
        ' Txt_Agama
        ' 
        Txt_Agama.AutoSize = True
        Txt_Agama.Location = New Point(16, 364)
        Txt_Agama.Name = "Txt_Agama"
        Txt_Agama.Size = New Size(88, 32)
        Txt_Agama.TabIndex = 13
        Txt_Agama.Text = "Agama"
        ' 
        ' Cb_JK
        ' 
        Cb_JK.FormattingEnabled = True
        Cb_JK.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        Cb_JK.Location = New Point(175, 277)
        Cb_JK.Name = "Cb_JK"
        Cb_JK.Size = New Size(458, 40)
        Cb_JK.TabIndex = 12
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(16, 285)
        Label4.Name = "Label4"
        Label4.Size = New Size(159, 32)
        Label4.TabIndex = 10
        Label4.Text = "Jenis Kelamin"
        ' 
        ' Txt_Password
        ' 
        Txt_Password.Location = New Point(175, 202)
        Txt_Password.Name = "Txt_Password"
        Txt_Password.Size = New Size(458, 39)
        Txt_Password.TabIndex = 9
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(16, 209)
        Label3.Name = "Label3"
        Label3.Size = New Size(111, 32)
        Label3.TabIndex = 8
        Label3.Text = "Password"
        ' 
        ' Txt_Nama_petugas
        ' 
        Txt_Nama_petugas.Location = New Point(175, 129)
        Txt_Nama_petugas.Name = "Txt_Nama_petugas"
        Txt_Nama_petugas.Size = New Size(458, 39)
        Txt_Nama_petugas.TabIndex = 7
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(16, 136)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 32)
        Label2.TabIndex = 6
        Label2.Text = "Nama"
        ' 
        ' BTN_cari
        ' 
        BTN_cari.Location = New Point(540, 60)
        BTN_cari.Name = "BTN_cari"
        BTN_cari.Size = New Size(93, 39)
        BTN_cari.TabIndex = 5
        BTN_cari.Text = "Cari"
        BTN_cari.UseVisualStyleBackColor = True
        ' 
        ' Txt_ID_Petugas
        ' 
        Txt_ID_Petugas.Location = New Point(175, 60)
        Txt_ID_Petugas.Name = "Txt_ID_Petugas"
        Txt_ID_Petugas.Size = New Size(359, 39)
        Txt_ID_Petugas.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(16, 67)
        Label1.Name = "Label1"
        Label1.Size = New Size(127, 32)
        Label1.TabIndex = 0
        Label1.Text = "ID Petugas"
        ' 
        ' DGV_Petugas
        ' 
        DGV_Petugas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV_Petugas.Location = New Point(25, 64)
        DGV_Petugas.Name = "DGV_Petugas"
        DGV_Petugas.RowHeadersWidth = 82
        DGV_Petugas.Size = New Size(1326, 753)
        DGV_Petugas.TabIndex = 1
        ' 
        ' Form_petugas
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(2100, 848)
        Controls.Add(SplitContainer1)
        Name = "Form_petugas"
        Text = "petugas"
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DGV_Petugas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents BTN_Simpan As Button
    Friend WithEvents BTN_Batal As Button
    Friend WithEvents BTN_Hapus As Button
    Friend WithEvents BTN_Ubah As Button
    Friend WithEvents DGV_Petugas As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Cb_Agama As ComboBox
    Friend WithEvents Txt_Agama As Label
    Friend WithEvents Cb_JK As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_Password As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_Nama_petugas As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BTN_cari As Button
    Friend WithEvents Txt_ID_Petugas As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_Alamat As RichTextBox
    Friend WithEvents Txt_NOHP As TextBox
    Friend WithEvents Label6 As Label

End Class
