<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainMenu
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbCityName = New System.Windows.Forms.Label()
        Me.lbTemp = New System.Windows.Forms.Label()
        Me.lbWind = New System.Windows.Forms.Label()
        Me.lbConditions = New System.Windows.Forms.Label()
        Me.Button3 = New WeatherApp.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New WeatherApp.Button()
        Me.Button1 = New WeatherApp.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(18, 72)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(128, 128)
        Me.Panel1.TabIndex = 3
        '
        'lbCityName
        '
        Me.lbCityName.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCityName.ForeColor = System.Drawing.Color.White
        Me.lbCityName.Location = New System.Drawing.Point(152, 72)
        Me.lbCityName.Name = "lbCityName"
        Me.lbCityName.Size = New System.Drawing.Size(330, 23)
        Me.lbCityName.TabIndex = 4
        Me.lbCityName.Text = "..."
        '
        'lbTemp
        '
        Me.lbTemp.Font = New System.Drawing.Font("Segoe UI Light", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTemp.ForeColor = System.Drawing.Color.White
        Me.lbTemp.Location = New System.Drawing.Point(149, 95)
        Me.lbTemp.Name = "lbTemp"
        Me.lbTemp.Size = New System.Drawing.Size(115, 41)
        Me.lbTemp.TabIndex = 3
        Me.lbTemp.Text = "16°C"
        '
        'lbWind
        '
        Me.lbWind.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbWind.ForeColor = System.Drawing.Color.White
        Me.lbWind.Location = New System.Drawing.Point(192, 153)
        Me.lbWind.Name = "lbWind"
        Me.lbWind.Size = New System.Drawing.Size(277, 41)
        Me.lbWind.TabIndex = 6
        Me.lbWind.Text = "South South West, 25KM/H"
        Me.lbWind.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbConditions
        '
        Me.lbConditions.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbConditions.ForeColor = System.Drawing.Color.White
        Me.lbConditions.Location = New System.Drawing.Point(270, 94)
        Me.lbConditions.Name = "lbConditions"
        Me.lbConditions.Size = New System.Drawing.Size(115, 41)
        Me.lbConditions.TabIndex = 7
        Me.lbConditions.Text = "16°C"
        Me.lbConditions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button3
        '
        Me.Button3.Image = Global.WeatherApp.My.Resources.Resources.settings2
        Me.Button3.Location = New System.Drawing.Point(18, 18)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(32, 32)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Button3"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WeatherApp.My.Resources.Resources.compass2
        Me.PictureBox2.Location = New System.Drawing.Point(156, 150)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WeatherApp.My.Resources.Resources.sunblack
        Me.PictureBox1.Location = New System.Drawing.Point(19, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Image = Global.WeatherApp.My.Resources.Resources.close
        Me.Button2.Location = New System.Drawing.Point(503, 18)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(32, 32)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        '
        'Button1
        '
        Me.Button1.Image = Global.WeatherApp.My.Resources.Resources.refresh20
        Me.Button1.Location = New System.Drawing.Point(465, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 32)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        '
        'mainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 465)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.lbConditions)
        Me.Controls.Add(Me.lbWind)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lbTemp)
        Me.Controls.Add(Me.lbCityName)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "mainMenu"
        Me.Padding = New System.Windows.Forms.Padding(15)
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbCityName As Label
    Friend WithEvents lbTemp As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lbWind As Label
    Friend WithEvents lbConditions As Label
    Friend WithEvents Button3 As Button
End Class
