<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Transaksi
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbkode = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbtotal = New System.Windows.Forms.TextBox()
        Me.tbMail = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbclas = New System.Windows.Forms.ComboBox()
        Me.tbphone = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbharga = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbjmlah = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbcard = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.datatiket = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataTRANSAKSI = New System.Windows.Forms.DataGridView()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnDelet = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.datatiket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataTRANSAKSI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Image = Global.THE_1975.My.Resources.Resources.REBAHANn
        Me.Label4.Location = New System.Drawing.Point(9, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tticket Code"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.THE_1975.My.Resources.Resources.ALBUM
        Me.GroupBox1.Controls.Add(Me.tbkode)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tbtotal)
        Me.GroupBox1.Controls.Add(Me.tbMail)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cmbclas)
        Me.GroupBox1.Controls.Add(Me.tbphone)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.tbharga)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.tbjmlah)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tbcard)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbname)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 345)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TRANSACTION"
        '
        'tbkode
        '
        Me.tbkode.FormattingEnabled = True
        Me.tbkode.Items.AddRange(New Object() {"PVG-SB", "GSV-BP", "SVP-GB", "BVP-SG", "VPG-BS", "XAS-PV", "PLG-BX", "VSG-BS", "SAF-LP", "ABS-VP", "PLV-AS"})
        Me.tbkode.Location = New System.Drawing.Point(95, 39)
        Me.tbkode.Name = "tbkode"
        Me.tbkode.Size = New System.Drawing.Size(97, 21)
        Me.tbkode.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Image = Global.THE_1975.My.Resources.Resources.REBAHANn
        Me.Label2.Location = New System.Drawing.Point(9, 305)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 15)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Total Payment"
        '
        'tbtotal
        '
        Me.tbtotal.Location = New System.Drawing.Point(95, 302)
        Me.tbtotal.Name = "tbtotal"
        Me.tbtotal.Size = New System.Drawing.Size(143, 20)
        Me.tbtotal.TabIndex = 14
        '
        'tbMail
        '
        Me.tbMail.Location = New System.Drawing.Point(95, 210)
        Me.tbMail.Name = "tbMail"
        Me.tbMail.Size = New System.Drawing.Size(143, 20)
        Me.tbMail.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Image = Global.THE_1975.My.Resources.Resources.REBAHANn
        Me.Label11.Location = New System.Drawing.Point(9, 213)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 15)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "E-Mail"
        '
        'cmbclas
        '
        Me.cmbclas.FormattingEnabled = True
        Me.cmbclas.Location = New System.Drawing.Point(95, 125)
        Me.cmbclas.Name = "cmbclas"
        Me.cmbclas.Size = New System.Drawing.Size(97, 21)
        Me.cmbclas.TabIndex = 18
        '
        'tbphone
        '
        Me.tbphone.Location = New System.Drawing.Point(95, 237)
        Me.tbphone.Name = "tbphone"
        Me.tbphone.Size = New System.Drawing.Size(143, 20)
        Me.tbphone.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Image = Global.THE_1975.My.Resources.Resources.REBAHANn
        Me.Label9.Location = New System.Drawing.Point(9, 244)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 15)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Phone"
        '
        'tbharga
        '
        Me.tbharga.Location = New System.Drawing.Point(95, 184)
        Me.tbharga.Name = "tbharga"
        Me.tbharga.Size = New System.Drawing.Size(143, 20)
        Me.tbharga.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Image = Global.THE_1975.My.Resources.Resources.REBAHANn
        Me.Label8.Location = New System.Drawing.Point(9, 187)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 15)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Price"
        '
        'tbjmlah
        '
        Me.tbjmlah.Location = New System.Drawing.Point(95, 265)
        Me.tbjmlah.Name = "tbjmlah"
        Me.tbjmlah.Size = New System.Drawing.Size(143, 20)
        Me.tbjmlah.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Nirmala UI", 9.25!)
        Me.Label7.Image = Global.THE_1975.My.Resources.Resources.REBAHANn
        Me.Label7.Location = New System.Drawing.Point(9, 272)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Amount"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Image = Global.THE_1975.My.Resources.Resources.REBAHANn
        Me.Label5.Location = New System.Drawing.Point(9, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Tticket Class"
        '
        'tbcard
        '
        Me.tbcard.Location = New System.Drawing.Point(95, 66)
        Me.tbcard.Name = "tbcard"
        Me.tbcard.Size = New System.Drawing.Size(143, 20)
        Me.tbcard.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Image = Global.THE_1975.My.Resources.Resources.REBAHANn
        Me.Label3.Location = New System.Drawing.Point(9, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "ID Card"
        '
        'tbname
        '
        Me.tbname.Location = New System.Drawing.Point(95, 96)
        Me.tbname.Name = "tbname"
        Me.tbname.Size = New System.Drawing.Size(143, 20)
        Me.tbname.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Image = Global.THE_1975.My.Resources.Resources.REBAHANn
        Me.Label1.Location = New System.Drawing.Point(9, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = Global.THE_1975.My.Resources.Resources.REBAHANn
        Me.GroupBox2.Controls.Add(Me.datatiket)
        Me.GroupBox2.Location = New System.Drawing.Point(281, 221)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(466, 198)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "BUYER"
        '
        'datatiket
        '
        Me.datatiket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datatiket.Location = New System.Drawing.Point(6, 19)
        Me.datatiket.Name = "datatiket"
        Me.datatiket.Size = New System.Drawing.Size(454, 172)
        Me.datatiket.TabIndex = 4
        '
        'GroupBox3
        '
        Me.GroupBox3.BackgroundImage = Global.THE_1975.My.Resources.Resources.REBAHANn
        Me.GroupBox3.Controls.Add(Me.DataTRANSAKSI)
        Me.GroupBox3.Location = New System.Drawing.Point(281, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(466, 199)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "TRANSACTION"
        '
        'DataTRANSAKSI
        '
        Me.DataTRANSAKSI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataTRANSAKSI.Location = New System.Drawing.Point(6, 19)
        Me.DataTRANSAKSI.Name = "DataTRANSAKSI"
        Me.DataTRANSAKSI.Size = New System.Drawing.Size(454, 174)
        Me.DataTRANSAKSI.TabIndex = 5
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.LightYellow
        Me.btnsave.Font = New System.Drawing.Font("Sitka Small", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(88, 369)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(116, 37)
        Me.btnsave.TabIndex = 8
        Me.btnsave.Text = "PRINT / SAVE"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnDelet
        '
        Me.btnDelet.BackColor = System.Drawing.Color.LightYellow
        Me.btnDelet.Font = New System.Drawing.Font("Sitka Small", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelet.Location = New System.Drawing.Point(191, 412)
        Me.btnDelet.Name = "btnDelet"
        Me.btnDelet.Size = New System.Drawing.Size(72, 36)
        Me.btnDelet.TabIndex = 8
        Me.btnDelet.Text = "DELETE"
        Me.btnDelet.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightYellow
        Me.Button3.Font = New System.Drawing.Font("Sitka Small", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(107, 412)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(72, 36)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "CANCEL"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightYellow
        Me.Button1.Font = New System.Drawing.Font("Sitka Small", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 412)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 36)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "CLEAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoEllipsis = True
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Gainsboro
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.CausesValidation = False
        Me.Label14.Font = New System.Drawing.Font("Nirmala UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Gray
        Me.Label14.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label14.Location = New System.Drawing.Point(620, 461)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(131, 47)
        Me.Label14.TabIndex = 57
        Me.Label14.Text = "NOACF" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Yellow
        Me.Label6.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Image = Global.THE_1975.My.Resources.Resources.REBAHANn
        Me.Label6.Location = New System.Drawing.Point(228, 489)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(311, 15)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "© 2020 THE 1975 OFFICIAL STORE. ALL RIGHTS RESERVED"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Red
        Me.LinkLabel1.Location = New System.Drawing.Point(45, 481)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(61, 15)
        Me.LinkLabel1.TabIndex = 59
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Register"
        '
        'Transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.THE_1975.My.Resources.Resources.REBAHANn
        Me.ClientSize = New System.Drawing.Size(756, 511)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnDelet)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Name = "Transaksi"
        Me.Text = "Transaksi"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.datatiket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataTRANSAKSI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tbphone As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbharga As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbjmlah As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbcard As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbMail As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents datatiket As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents tbtotal As TextBox
    Friend WithEvents btnsave As Button
    Friend WithEvents btnDelet As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents cmbclas As ComboBox
    Friend WithEvents tbkode As ComboBox
    Friend WithEvents DataTRANSAKSI As DataGridView
    Friend WithEvents Label14 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
