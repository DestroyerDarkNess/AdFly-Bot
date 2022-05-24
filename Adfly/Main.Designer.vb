<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Me.ProcesorMonitor = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DevSkin1 = New Adfly.DevSkin()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.DevLabel8 = New Adfly.DevLabel()
        Me.DevButton4 = New Adfly.DevButton()
        Me.DevNumeric1 = New Adfly.DevNumeric()
        Me.DevLabel7 = New Adfly.DevLabel()
        Me.AdFlyNET1 = New Adfly.AdFlyNET()
        Me.DevButton3 = New Adfly.DevButton()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DevLabel5 = New Adfly.DevLabel()
        Me.DevLabel6 = New Adfly.DevLabel()
        Me.ErrorLabel = New Adfly.DevLabel()
        Me.VisitNumbLabel = New Adfly.DevLabel()
        Me.LogTextBox = New System.Windows.Forms.TextBox()
        Me.UrlTextBox = New Adfly.DevTextBox()
        Me.DevLabel1 = New Adfly.DevLabel()
        Me.DevButton1 = New Adfly.DevButton()
        Me.DevControlBox1 = New Adfly.DevControlBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DelimiterTex = New System.Windows.Forms.TextBox()
        Me.DevLabel3 = New Adfly.DevLabel()
        Me.DevButton2 = New Adfly.DevButton()
        Me.DevLabel4 = New Adfly.DevLabel()
        Me.ProxieLabel = New Adfly.DevLabel()
        Me.DevLabel2 = New Adfly.DevLabel()
        Me.DevSkin1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProcesorMonitor
        '
        Me.ProcesorMonitor.Interval = 1
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'DevSkin1
        '
        Me.DevSkin1.Controls.Add(Me.ComboBox2)
        Me.DevSkin1.Controls.Add(Me.DevLabel8)
        Me.DevSkin1.Controls.Add(Me.DevButton4)
        Me.DevSkin1.Controls.Add(Me.DevNumeric1)
        Me.DevSkin1.Controls.Add(Me.DevLabel7)
        Me.DevSkin1.Controls.Add(Me.AdFlyNET1)
        Me.DevSkin1.Controls.Add(Me.DevButton3)
        Me.DevSkin1.Controls.Add(Me.ComboBox1)
        Me.DevSkin1.Controls.Add(Me.DevLabel5)
        Me.DevSkin1.Controls.Add(Me.DevLabel6)
        Me.DevSkin1.Controls.Add(Me.ErrorLabel)
        Me.DevSkin1.Controls.Add(Me.VisitNumbLabel)
        Me.DevSkin1.Controls.Add(Me.LogTextBox)
        Me.DevSkin1.Controls.Add(Me.UrlTextBox)
        Me.DevSkin1.Controls.Add(Me.DevLabel1)
        Me.DevSkin1.Controls.Add(Me.DevButton1)
        Me.DevSkin1.Controls.Add(Me.DevControlBox1)
        Me.DevSkin1.Controls.Add(Me.Panel1)
        Me.DevSkin1.Controls.Add(Me.DevLabel2)
        Me.DevSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DevSkin1.HeaderLogo = Nothing
        Me.DevSkin1.Location = New System.Drawing.Point(0, 0)
        Me.DevSkin1.Name = "DevSkin1"
        Me.DevSkin1.Size = New System.Drawing.Size(773, 510)
        Me.DevSkin1.TabIndex = 0
        Me.DevSkin1.Text = "AdFly Bot v1.0"
        '
        'ComboBox2
        '
        Me.ComboBox2.DisplayMember = "0"
        Me.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Image", "Button"})
        Me.ComboBox2.Location = New System.Drawing.Point(378, 106)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(71, 21)
        Me.ComboBox2.TabIndex = 27
        '
        'DevLabel8
        '
        Me.DevLabel8.AutoSize = True
        Me.DevLabel8.BackColor = System.Drawing.Color.Transparent
        Me.DevLabel8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DevLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.DevLabel8.Location = New System.Drawing.Point(317, 108)
        Me.DevLabel8.Name = "DevLabel8"
        Me.DevLabel8.Size = New System.Drawing.Size(55, 15)
        Me.DevLabel8.TabIndex = 26
        Me.DevLabel8.Text = "Method :"
        '
        'DevButton4
        '
        Me.DevButton4.ButtonColor = Adfly.DevButton.xButtonColor.Blue
        Me.DevButton4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.DevButton4.Location = New System.Drawing.Point(689, 108)
        Me.DevButton4.Name = "DevButton4"
        Me.DevButton4.Size = New System.Drawing.Size(72, 27)
        Me.DevButton4.TabIndex = 25
        Me.DevButton4.Text = "Stop"
        '
        'DevNumeric1
        '
        Me.DevNumeric1.Location = New System.Drawing.Point(518, 102)
        Me.DevNumeric1.MaxValue = 50
        Me.DevNumeric1.MinValue = 10
        Me.DevNumeric1.Name = "DevNumeric1"
        Me.DevNumeric1.Size = New System.Drawing.Size(70, 30)
        Me.DevNumeric1.TabIndex = 24
        Me.DevNumeric1.Text = "DevNumeric1"
        Me.DevNumeric1.Value = 10
        '
        'DevLabel7
        '
        Me.DevLabel7.AutoSize = True
        Me.DevLabel7.BackColor = System.Drawing.Color.Transparent
        Me.DevLabel7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DevLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.DevLabel7.Location = New System.Drawing.Point(455, 108)
        Me.DevLabel7.Name = "DevLabel7"
        Me.DevLabel7.Size = New System.Drawing.Size(57, 15)
        Me.DevLabel7.TabIndex = 23
        Me.DevLabel7.Text = "Seconds :"
        '
        'AdFlyNET1
        '
        Me.AdFlyNET1.Location = New System.Drawing.Point(15, 147)
        Me.AdFlyNET1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.AdFlyNET1.Name = "AdFlyNET1"
        Me.AdFlyNET1.ScriptErrorsSuppressed = True
        Me.AdFlyNET1.Size = New System.Drawing.Size(746, 360)
        Me.AdFlyNET1.TabIndex = 22
        '
        'DevButton3
        '
        Me.DevButton3.ButtonColor = Adfly.DevButton.xButtonColor.Blue
        Me.DevButton3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.DevButton3.Location = New System.Drawing.Point(609, 108)
        Me.DevButton3.Name = "DevButton3"
        Me.DevButton3.Size = New System.Drawing.Size(74, 27)
        Me.DevButton3.TabIndex = 20
        Me.DevButton3.Text = "Force Next"
        '
        'ComboBox1
        '
        Me.ComboBox1.DisplayMember = "0"
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Mobile", "PC"})
        Me.ComboBox1.Location = New System.Drawing.Point(242, 106)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(69, 21)
        Me.ComboBox1.TabIndex = 19
        '
        'DevLabel5
        '
        Me.DevLabel5.AutoSize = True
        Me.DevLabel5.BackColor = System.Drawing.Color.Transparent
        Me.DevLabel5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DevLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.DevLabel5.Location = New System.Drawing.Point(165, 108)
        Me.DevLabel5.Name = "DevLabel5"
        Me.DevLabel5.Size = New System.Drawing.Size(71, 15)
        Me.DevLabel5.TabIndex = 18
        Me.DevLabel5.Text = "User Agent :"
        '
        'DevLabel6
        '
        Me.DevLabel6.AutoSize = True
        Me.DevLabel6.BackColor = System.Drawing.Color.Transparent
        Me.DevLabel6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DevLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.DevLabel6.Location = New System.Drawing.Point(85, 108)
        Me.DevLabel6.Name = "DevLabel6"
        Me.DevLabel6.Size = New System.Drawing.Size(40, 15)
        Me.DevLabel6.TabIndex = 17
        Me.DevLabel6.Text = "Errors:"
        '
        'ErrorLabel
        '
        Me.ErrorLabel.AutoSize = True
        Me.ErrorLabel.BackColor = System.Drawing.Color.Transparent
        Me.ErrorLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ErrorLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.ErrorLabel.Location = New System.Drawing.Point(131, 108)
        Me.ErrorLabel.Name = "ErrorLabel"
        Me.ErrorLabel.Size = New System.Drawing.Size(13, 15)
        Me.ErrorLabel.TabIndex = 16
        Me.ErrorLabel.Text = "0"
        '
        'VisitNumbLabel
        '
        Me.VisitNumbLabel.AutoSize = True
        Me.VisitNumbLabel.BackColor = System.Drawing.Color.Transparent
        Me.VisitNumbLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.VisitNumbLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.VisitNumbLabel.Location = New System.Drawing.Point(55, 108)
        Me.VisitNumbLabel.Name = "VisitNumbLabel"
        Me.VisitNumbLabel.Size = New System.Drawing.Size(13, 15)
        Me.VisitNumbLabel.TabIndex = 15
        Me.VisitNumbLabel.Text = "0"
        '
        'LogTextBox
        '
        Me.LogTextBox.BackColor = System.Drawing.Color.Black
        Me.LogTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LogTextBox.ForeColor = System.Drawing.Color.Lime
        Me.LogTextBox.Location = New System.Drawing.Point(12, 247)
        Me.LogTextBox.Multiline = True
        Me.LogTextBox.Name = "LogTextBox"
        Me.LogTextBox.ReadOnly = True
        Me.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.LogTextBox.Size = New System.Drawing.Size(749, 251)
        Me.LogTextBox.TabIndex = 10
        '
        'UrlTextBox
        '
        Me.UrlTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.UrlTextBox.Location = New System.Drawing.Point(80, 68)
        Me.UrlTextBox.MaxLength = 32767
        Me.UrlTextBox.MultiLine = False
        Me.UrlTextBox.Name = "UrlTextBox"
        Me.UrlTextBox.ReadOnly = False
        Me.UrlTextBox.Size = New System.Drawing.Size(509, 24)
        Me.UrlTextBox.TabIndex = 6
        Me.UrlTextBox.Text = "http://j.gs/BpsF"
        Me.UrlTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.UrlTextBox.UseSystemPasswordChar = False
        '
        'DevLabel1
        '
        Me.DevLabel1.AutoSize = True
        Me.DevLabel1.BackColor = System.Drawing.Color.Transparent
        Me.DevLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DevLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.DevLabel1.Location = New System.Drawing.Point(12, 68)
        Me.DevLabel1.Name = "DevLabel1"
        Me.DevLabel1.Size = New System.Drawing.Size(62, 15)
        Me.DevLabel1.TabIndex = 3
        Me.DevLabel1.Text = "Adf.ly Url :"
        '
        'DevButton1
        '
        Me.DevButton1.ButtonColor = Adfly.DevButton.xButtonColor.Blue
        Me.DevButton1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.DevButton1.Location = New System.Drawing.Point(609, 57)
        Me.DevButton1.Name = "DevButton1"
        Me.DevButton1.Size = New System.Drawing.Size(152, 50)
        Me.DevButton1.TabIndex = 2
        Me.DevButton1.Text = "Start"
        '
        'DevControlBox1
        '
        Me.DevControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DevControlBox1.BoxType = Adfly.DevControlBox.xBoxType.Close
        Me.DevControlBox1.Location = New System.Drawing.Point(729, 0)
        Me.DevControlBox1.Name = "DevControlBox1"
        Me.DevControlBox1.Size = New System.Drawing.Size(44, 27)
        Me.DevControlBox1.TabIndex = 1
        Me.DevControlBox1.Text = "DevControlBox1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.DelimiterTex)
        Me.Panel1.Controls.Add(Me.DevLabel3)
        Me.Panel1.Controls.Add(Me.DevButton2)
        Me.Panel1.Controls.Add(Me.DevLabel4)
        Me.Panel1.Controls.Add(Me.ProxieLabel)
        Me.Panel1.Location = New System.Drawing.Point(389, 82)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(41, 10)
        Me.Panel1.TabIndex = 13
        Me.Panel1.Visible = False
        '
        'DelimiterTex
        '
        Me.DelimiterTex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DelimiterTex.Location = New System.Drawing.Point(252, 4)
        Me.DelimiterTex.MaxLength = 1
        Me.DelimiterTex.Name = "DelimiterTex"
        Me.DelimiterTex.Size = New System.Drawing.Size(29, 20)
        Me.DelimiterTex.TabIndex = 13
        Me.DelimiterTex.Text = ":"
        Me.DelimiterTex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DevLabel3
        '
        Me.DevLabel3.AutoSize = True
        Me.DevLabel3.BackColor = System.Drawing.Color.Transparent
        Me.DevLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DevLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.DevLabel3.Location = New System.Drawing.Point(3, 5)
        Me.DevLabel3.Name = "DevLabel3"
        Me.DevLabel3.Size = New System.Drawing.Size(48, 15)
        Me.DevLabel3.TabIndex = 7
        Me.DevLabel3.Text = "Proxys :"
        '
        'DevButton2
        '
        Me.DevButton2.ButtonColor = Adfly.DevButton.xButtonColor.Blue
        Me.DevButton2.Dock = System.Windows.Forms.DockStyle.Right
        Me.DevButton2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.DevButton2.Location = New System.Drawing.Point(-65, 0)
        Me.DevButton2.Name = "DevButton2"
        Me.DevButton2.Size = New System.Drawing.Size(104, 8)
        Me.DevButton2.TabIndex = 11
        Me.DevButton2.Text = "Load List"
        '
        'DevLabel4
        '
        Me.DevLabel4.AutoSize = True
        Me.DevLabel4.BackColor = System.Drawing.Color.Transparent
        Me.DevLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DevLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.DevLabel4.Location = New System.Drawing.Point(141, 5)
        Me.DevLabel4.Name = "DevLabel4"
        Me.DevLabel4.Size = New System.Drawing.Size(97, 15)
        Me.DevLabel4.TabIndex = 12
        Me.DevLabel4.Text = "Proxie Delimiter :"
        '
        'ProxieLabel
        '
        Me.ProxieLabel.AutoSize = True
        Me.ProxieLabel.BackColor = System.Drawing.Color.Transparent
        Me.ProxieLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ProxieLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.ProxieLabel.Location = New System.Drawing.Point(56, 5)
        Me.ProxieLabel.Name = "ProxieLabel"
        Me.ProxieLabel.Size = New System.Drawing.Size(13, 15)
        Me.ProxieLabel.TabIndex = 8
        Me.ProxieLabel.Text = "0"
        '
        'DevLabel2
        '
        Me.DevLabel2.AutoSize = True
        Me.DevLabel2.BackColor = System.Drawing.Color.Transparent
        Me.DevLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DevLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.DevLabel2.Location = New System.Drawing.Point(12, 108)
        Me.DevLabel2.Name = "DevLabel2"
        Me.DevLabel2.Size = New System.Drawing.Size(37, 15)
        Me.DevLabel2.TabIndex = 14
        Me.DevLabel2.Text = "Visits:"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 510)
        Me.Controls.Add(Me.DevSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.DevSkin1.ResumeLayout(False)
        Me.DevSkin1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DevSkin1 As Adfly.DevSkin
    Friend WithEvents UrlTextBox As Adfly.DevTextBox
    Friend WithEvents DevLabel1 As Adfly.DevLabel
    Friend WithEvents DevButton1 As Adfly.DevButton
    Friend WithEvents DevControlBox1 As Adfly.DevControlBox
    Friend WithEvents ProxieLabel As Adfly.DevLabel
    Friend WithEvents DevLabel3 As Adfly.DevLabel
    Friend WithEvents LogTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DevButton2 As Adfly.DevButton
    Friend WithEvents ProcesorMonitor As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DelimiterTex As System.Windows.Forms.TextBox
    Friend WithEvents DevLabel4 As Adfly.DevLabel
    Friend WithEvents VisitNumbLabel As Adfly.DevLabel
    Friend WithEvents DevLabel2 As Adfly.DevLabel
    Friend WithEvents DevLabel6 As Adfly.DevLabel
    Friend WithEvents ErrorLabel As Adfly.DevLabel
    Friend WithEvents DevLabel5 As Adfly.DevLabel
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DevButton3 As Adfly.DevButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents AdFlyNET1 As Adfly.AdFlyNET
    Friend WithEvents DevNumeric1 As Adfly.DevNumeric
    Friend WithEvents DevLabel7 As Adfly.DevLabel
    Friend WithEvents DevButton4 As Adfly.DevButton
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents DevLabel8 As Adfly.DevLabel
End Class
