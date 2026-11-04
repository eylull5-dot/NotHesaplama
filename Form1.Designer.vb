<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnHesapla = New System.Windows.Forms.Button()
        Me.lblAd = New System.Windows.Forms.Label()
        Me.lblVize = New System.Windows.Forms.Label()
        Me.txtAd = New System.Windows.Forms.TextBox()
        Me.txtVize = New System.Windows.Forms.TextBox()
        Me.txtFinal = New System.Windows.Forms.TextBox()
        Me.lblFinal = New System.Windows.Forms.Label()
        Me.lblSonuc = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnHesapla
        '
        Me.btnHesapla.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnHesapla.Location = New System.Drawing.Point(39, 23)
        Me.btnHesapla.Name = "btnHesapla"
        Me.btnHesapla.Size = New System.Drawing.Size(192, 60)
        Me.btnHesapla.TabIndex = 0
        Me.btnHesapla.Text = "Not Hesapla"
        Me.btnHesapla.UseVisualStyleBackColor = True
        '
        'lblAd
        '
        Me.lblAd.AutoSize = True
        Me.lblAd.Location = New System.Drawing.Point(21, 170)
        Me.lblAd.Name = "lblAd"
        Me.lblAd.Size = New System.Drawing.Size(82, 17)
        Me.lblAd.TabIndex = 2
        Me.lblAd.Text = "Öğrenci Adı"
        '
        'lblVize
        '
        Me.lblVize.AutoSize = True
        Me.lblVize.Location = New System.Drawing.Point(34, 213)
        Me.lblVize.Name = "lblVize"
        Me.lblVize.Size = New System.Drawing.Size(69, 17)
        Me.lblVize.TabIndex = 3
        Me.lblVize.Text = "Vize Notu"
        '
        'txtAd
        '
        Me.txtAd.Location = New System.Drawing.Point(113, 165)
        Me.txtAd.Name = "txtAd"
        Me.txtAd.Size = New System.Drawing.Size(234, 22)
        Me.txtAd.TabIndex = 4
        '
        'txtVize
        '
        Me.txtVize.Location = New System.Drawing.Point(114, 210)
        Me.txtVize.Name = "txtVize"
        Me.txtVize.Size = New System.Drawing.Size(233, 22)
        Me.txtVize.TabIndex = 5
        '
        'txtFinal
        '
        Me.txtFinal.Location = New System.Drawing.Point(113, 252)
        Me.txtFinal.Name = "txtFinal"
        Me.txtFinal.Size = New System.Drawing.Size(234, 22)
        Me.txtFinal.TabIndex = 6
        '
        'lblFinal
        '
        Me.lblFinal.AutoSize = True
        Me.lblFinal.Location = New System.Drawing.Point(36, 257)
        Me.lblFinal.Name = "lblFinal"
        Me.lblFinal.Size = New System.Drawing.Size(72, 17)
        Me.lblFinal.TabIndex = 7
        Me.lblFinal.Text = "Final Notu"
        '
        'lblSonuc
        '
        Me.lblSonuc.AutoSize = True
        Me.lblSonuc.Location = New System.Drawing.Point(55, 307)
        Me.lblSonuc.Name = "lblSonuc"
        Me.lblSonuc.Size = New System.Drawing.Size(48, 17)
        Me.lblSonuc.TabIndex = 8
        Me.lblSonuc.Text = "Sonuç"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 442)
        Me.Controls.Add(Me.lblSonuc)
        Me.Controls.Add(Me.lblFinal)
        Me.Controls.Add(Me.txtFinal)
        Me.Controls.Add(Me.txtVize)
        Me.Controls.Add(Me.txtAd)
        Me.Controls.Add(Me.lblVize)
        Me.Controls.Add(Me.lblAd)
        Me.Controls.Add(Me.btnHesapla)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnHesapla As System.Windows.Forms.Button
    Friend WithEvents lblAd As System.Windows.Forms.Label
    Friend WithEvents lblVize As System.Windows.Forms.Label
    Friend WithEvents txtAd As System.Windows.Forms.TextBox
    Friend WithEvents txtVize As System.Windows.Forms.TextBox
    Friend WithEvents txtFinal As System.Windows.Forms.TextBox
    Friend WithEvents lblFinal As System.Windows.Forms.Label
    Friend WithEvents lblSonuc As System.Windows.Forms.Label

End Class
