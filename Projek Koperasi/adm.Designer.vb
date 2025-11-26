<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.T1 = New System.Windows.Forms.TextBox()
        Me.B1 = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.T2 = New System.Windows.Forms.TextBox()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.B2 = New System.Windows.Forms.Button()
        Me.B3 = New System.Windows.Forms.Button()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Light", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(25, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(364, 52)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "admin room's"
        '
        'T1
        '
        Me.T1.Location = New System.Drawing.Point(279, 137)
        Me.T1.Name = "T1"
        Me.T1.Size = New System.Drawing.Size(313, 20)
        Me.T1.TabIndex = 1
        '
        'B1
        '
        Me.B1.Font = New System.Drawing.Font("Copperplate Gothic Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B1.Location = New System.Drawing.Point(1110, 73)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(111, 47)
        Me.B1.TabIndex = 2
        Me.B1.Text = "simpan"
        Me.B1.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.BackgroundColor = System.Drawing.Color.Ivory
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(657, 73)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(414, 248)
        Me.dgv.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Copperplate Gothic Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(29, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 30)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "nama berjaga"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Copperplate Gothic Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(28, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 30)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "id berjaga"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Copperplate Gothic Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(28, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 30)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "absensi"
        '
        'T2
        '
        Me.T2.Location = New System.Drawing.Point(279, 193)
        Me.T2.Name = "T2"
        Me.T2.Size = New System.Drawing.Size(313, 20)
        Me.T2.TabIndex = 7
        '
        'dtp
        '
        Me.dtp.Location = New System.Drawing.Point(279, 250)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(313, 20)
        Me.dtp.TabIndex = 8
        '
        'B2
        '
        Me.B2.Font = New System.Drawing.Font("Copperplate Gothic Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B2.Location = New System.Drawing.Point(1110, 240)
        Me.B2.Name = "B2"
        Me.B2.Size = New System.Drawing.Size(111, 47)
        Me.B2.TabIndex = 9
        Me.B2.Text = "batal"
        Me.B2.UseVisualStyleBackColor = True
        '
        'B3
        '
        Me.B3.Font = New System.Drawing.Font("Copperplate Gothic Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B3.Location = New System.Drawing.Point(1110, 157)
        Me.B3.Name = "B3"
        Me.B3.Size = New System.Drawing.Size(111, 47)
        Me.B3.TabIndex = 10
        Me.B3.Text = "hapus"
        Me.B3.UseVisualStyleBackColor = True
        '
        'adm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Projek_Koperasi.My.Resources.Resources.matcha_green_laptop_wallpaper
        Me.ClientSize = New System.Drawing.Size(1257, 377)
        Me.Controls.Add(Me.B3)
        Me.Controls.Add(Me.B2)
        Me.Controls.Add(Me.dtp)
        Me.Controls.Add(Me.T2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.B1)
        Me.Controls.Add(Me.T1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "adm"
        Me.Text = "adm"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents T1 As System.Windows.Forms.TextBox
    Friend WithEvents B1 As System.Windows.Forms.Button
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents T2 As System.Windows.Forms.TextBox
    Friend WithEvents dtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents B2 As System.Windows.Forms.Button
    Friend WithEvents B3 As System.Windows.Forms.Button
End Class
