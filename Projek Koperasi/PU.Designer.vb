<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PU
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataSet1 = New System.Data.DataSet()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CB4 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.B3 = New System.Windows.Forms.Button()
        Me.CB3 = New System.Windows.Forms.ComboBox()
        Me.CB2 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.T3 = New System.Windows.Forms.TextBox()
        Me.CB1 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.T5 = New System.Windows.Forms.TextBox()
        Me.B1 = New System.Windows.Forms.Button()
        Me.T4 = New System.Windows.Forms.TextBox()
        Me.T2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.T1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Pink
        Me.Panel1.BackgroundImage = Global.Projek_Koperasi.My.Resources.Resources.blue_aura_wallpaper
        Me.Panel1.Controls.Add(Me.CB4)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.dgv)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.B3)
        Me.Panel1.Controls.Add(Me.CB3)
        Me.Panel1.Controls.Add(Me.CB2)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.T3)
        Me.Panel1.Controls.Add(Me.CB1)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.T5)
        Me.Panel1.Controls.Add(Me.B1)
        Me.Panel1.Controls.Add(Me.T4)
        Me.Panel1.Controls.Add(Me.T2)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.dtp)
        Me.Panel1.Controls.Add(Me.T1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-1, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(969, 693)
        Me.Panel1.TabIndex = 0
        '
        'CB4
        '
        Me.CB4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB4.FormattingEnabled = True
        Me.CB4.Items.AddRange(New Object() {"Harian = 5,3%", "Mingguan  = 8,5%", "Bulanan = 13,4%", "Tahunana = 17%"})
        Me.CB4.Location = New System.Drawing.Point(588, 311)
        Me.CB4.Name = "CB4"
        Me.CB4.Size = New System.Drawing.Size(350, 21)
        Me.CB4.TabIndex = 29
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Copperplate Gothic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label11.Location = New System.Drawing.Point(488, 311)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 21)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "DENDA:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(69, 426)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(840, 186)
        Me.dgv.TabIndex = 27
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Button1.Location = New System.Drawing.Point(571, 628)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 42)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "AKTIFKAN" & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button1.UseVisualStyleBackColor = False
        '
        'B3
        '
        Me.B3.BackColor = System.Drawing.Color.Transparent
        Me.B3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.B3.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B3.ForeColor = System.Drawing.Color.SteelBlue
        Me.B3.Location = New System.Drawing.Point(690, 628)
        Me.B3.Name = "B3"
        Me.B3.Size = New System.Drawing.Size(109, 42)
        Me.B3.TabIndex = 24
        Me.B3.Text = "HAPUS" & Global.Microsoft.VisualBasic.ChrW(10)
        Me.B3.UseVisualStyleBackColor = False
        '
        'CB3
        '
        Me.CB3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB3.FormattingEnabled = True
        Me.CB3.Items.AddRange(New Object() {"100.000,00", "300.000,00", "500.000,00", "700.000,00", "1.000,000,00", "Di Tentukan Di Kantor"})
        Me.CB3.Location = New System.Drawing.Point(612, 250)
        Me.CB3.Name = "CB3"
        Me.CB3.Size = New System.Drawing.Size(326, 21)
        Me.CB3.TabIndex = 23
        '
        'CB2
        '
        Me.CB2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB2.FormattingEnabled = True
        Me.CB2.Items.AddRange(New Object() {"Sertifikat", "Kendaraan", "Barang Elektronik", "KTP", "Di Tentukan DI Kantor"})
        Me.CB2.Location = New System.Drawing.Point(170, 375)
        Me.CB2.Name = "CB2"
        Me.CB2.Size = New System.Drawing.Size(286, 21)
        Me.CB2.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Copperplate Gothic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label10.Location = New System.Drawing.Point(34, 375)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 21)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "JAMINAN:"
        '
        'T3
        '
        Me.T3.Location = New System.Drawing.Point(206, 314)
        Me.T3.Name = "T3"
        Me.T3.Size = New System.Drawing.Size(250, 20)
        Me.T3.TabIndex = 20
        '
        'CB1
        '
        Me.CB1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB1.FormattingEnabled = True
        Me.CB1.Items.AddRange(New Object() {"Male", "Female", "Ketoprak"})
        Me.CB1.Location = New System.Drawing.Point(226, 250)
        Me.CB1.Name = "CB1"
        Me.CB1.Size = New System.Drawing.Size(230, 21)
        Me.CB1.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Copperplate Gothic Bold", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label9.Location = New System.Drawing.Point(140, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(699, 41)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "REGISTRASI PEMINJAMAN UANG"
        '
        'T5
        '
        Me.T5.Location = New System.Drawing.Point(642, 187)
        Me.T5.Name = "T5"
        Me.T5.Size = New System.Drawing.Size(296, 20)
        Me.T5.TabIndex = 16
        '
        'B1
        '
        Me.B1.BackColor = System.Drawing.Color.Transparent
        Me.B1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.B1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B1.ForeColor = System.Drawing.Color.SteelBlue
        Me.B1.Location = New System.Drawing.Point(794, 628)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(103, 42)
        Me.B1.TabIndex = 5
        Me.B1.Text = "BATAL"
        Me.B1.UseVisualStyleBackColor = False
        '
        'T4
        '
        Me.T4.Location = New System.Drawing.Point(600, 122)
        Me.T4.Name = "T4"
        Me.T4.Size = New System.Drawing.Size(338, 20)
        Me.T4.TabIndex = 14
        '
        'T2
        '
        Me.T2.Location = New System.Drawing.Point(297, 188)
        Me.T2.Name = "T2"
        Me.T2.Size = New System.Drawing.Size(159, 20)
        Me.T2.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Copperplate Gothic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label8.Location = New System.Drawing.Point(34, 314)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(166, 21)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "NOMOR AKTIF:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Copperplate Gothic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label7.Location = New System.Drawing.Point(489, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(147, 21)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "PEKERJAAN:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Copperplate Gothic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label6.Location = New System.Drawing.Point(34, 250)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(181, 21)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "JENIS KELAMIN:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Copperplate Gothic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label5.Location = New System.Drawing.Point(488, 250)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 21)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "NOMINAL:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Copperplate Gothic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label4.Location = New System.Drawing.Point(34, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "NAMA PEMINJAM:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Copperplate Gothic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(489, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "ALAMAT:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Copperplate Gothic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label2.Location = New System.Drawing.Point(34, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(257, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "NIK KARTU KELUARGA:"
        '
        'dtp
        '
        Me.dtp.Location = New System.Drawing.Point(636, 372)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(302, 20)
        Me.dtp.TabIndex = 4
        '
        'T1
        '
        Me.T1.Location = New System.Drawing.Point(240, 130)
        Me.T1.Name = "T1"
        Me.T1.Size = New System.Drawing.Size(216, 20)
        Me.T1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(488, 372)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "JANJI TEMU:"
        '
        'PU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(963, 688)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "PU"
        Me.Text = "Form1"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents T1 As System.Windows.Forms.TextBox
    Friend WithEvents dtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents T2 As System.Windows.Forms.TextBox
    Friend WithEvents T4 As System.Windows.Forms.TextBox
    Friend WithEvents B1 As System.Windows.Forms.Button
    Friend WithEvents T5 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CB1 As System.Windows.Forms.ComboBox
    Friend WithEvents CB3 As System.Windows.Forms.ComboBox
    Friend WithEvents CB2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents T3 As System.Windows.Forms.TextBox
    Friend WithEvents B3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents CB4 As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
