<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Label2 = New Label()
        TextBoxTinggi = New TextBox()
        TextBoxBerat = New TextBox()
        ButtonHitung = New Button()
        PictureBoxIMT = New PictureBox()
        Labelkategori = New Label()
        LabelIMT = New Label()
        ButtonReset = New Button()
        LabelKeterangan = New Label()
        CType(PictureBoxIMT, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(34, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(253, 23)
        Label1.TabIndex = 0
        Label1.Text = "Tinggi Badan (dalam cm)"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(34, 103)
        Label2.Name = "Label2"
        Label2.Size = New Size(243, 23)
        Label2.TabIndex = 1
        Label2.Text = "Berat badan (dalam Kg)"
        ' 
        ' TextBoxTinggi
        ' 
        TextBoxTinggi.Location = New Point(310, 31)
        TextBoxTinggi.Name = "TextBoxTinggi"
        TextBoxTinggi.Size = New Size(469, 31)
        TextBoxTinggi.TabIndex = 2
        ' 
        ' TextBoxBerat
        ' 
        TextBoxBerat.Cursor = Cursors.IBeam
        TextBoxBerat.Location = New Point(310, 103)
        TextBoxBerat.Name = "TextBoxBerat"
        TextBoxBerat.Size = New Size(469, 31)
        TextBoxBerat.TabIndex = 3
        ' 
        ' ButtonHitung
        ' 
        ButtonHitung.Font = New Font("Arial Rounded MT Bold", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonHitung.Location = New Point(310, 175)
        ButtonHitung.Name = "ButtonHitung"
        ButtonHitung.Size = New Size(469, 34)
        ButtonHitung.TabIndex = 4
        ButtonHitung.Text = "Hitung "
        ButtonHitung.UseVisualStyleBackColor = True
        ' 
        ' PictureBoxIMT
        ' 
        PictureBoxIMT.BackColor = Color.Transparent
        PictureBoxIMT.Location = New Point(660, 234)
        PictureBoxIMT.Name = "PictureBoxIMT"
        PictureBoxIMT.Size = New Size(340, 271)
        PictureBoxIMT.TabIndex = 5
        PictureBoxIMT.TabStop = False
        ' 
        ' Labelkategori
        ' 
        Labelkategori.AutoSize = True
        Labelkategori.Font = New Font("Arial Rounded MT Bold", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Labelkategori.ForeColor = SystemColors.ButtonHighlight
        Labelkategori.Location = New Point(21, 242)
        Labelkategori.Name = "Labelkategori"
        Labelkategori.Size = New Size(95, 23)
        Labelkategori.TabIndex = 6
        Labelkategori.Text = "Kategori"
        ' 
        ' LabelIMT
        ' 
        LabelIMT.AutoSize = True
        LabelIMT.BackColor = Color.Transparent
        LabelIMT.Font = New Font("Arial Rounded MT Bold", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelIMT.ForeColor = SystemColors.ButtonHighlight
        LabelIMT.Location = New Point(410, 242)
        LabelIMT.Name = "LabelIMT"
        LabelIMT.Size = New Size(58, 23)
        LabelIMT.TabIndex = 7
        LabelIMT.Text = "Hasil"
        ' 
        ' ButtonReset
        ' 
        ButtonReset.Font = New Font("Arial Rounded MT Bold", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonReset.Location = New Point(852, 62)
        ButtonReset.Name = "ButtonReset"
        ButtonReset.Size = New Size(112, 34)
        ButtonReset.TabIndex = 8
        ButtonReset.Text = "Reset"
        ButtonReset.UseVisualStyleBackColor = True
        ' 
        ' LabelKeterangan
        ' 
        LabelKeterangan.AutoSize = True
        LabelKeterangan.Font = New Font("Arial Rounded MT Bold", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelKeterangan.ForeColor = SystemColors.ButtonHighlight
        LabelKeterangan.Location = New Point(44, 315)
        LabelKeterangan.Name = "LabelKeterangan"
        LabelKeterangan.Size = New Size(0, 21)
        LabelKeterangan.TabIndex = 9
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.RosyBrown
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1021, 517)
        Controls.Add(LabelKeterangan)
        Controls.Add(ButtonReset)
        Controls.Add(LabelIMT)
        Controls.Add(Labelkategori)
        Controls.Add(PictureBoxIMT)
        Controls.Add(ButtonHitung)
        Controls.Add(TextBoxBerat)
        Controls.Add(TextBoxTinggi)
        Controls.Add(Label2)
        Controls.Add(Label1)
        DoubleBuffered = True
        Name = "Form1"
        Text = "Index Masa Tubuh"
        CType(PictureBoxIMT, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxTinggi As TextBox
    Friend WithEvents TextBoxBerat As TextBox
    Friend WithEvents ButtonHitung As Button
    Friend WithEvents PictureBoxIMT As PictureBox
    Friend WithEvents Labelkategori As Label
    Friend WithEvents LabelIMT As Label
    Friend WithEvents ButtonReset As Button
    Friend WithEvents LabelKeterangan As Label

End Class
