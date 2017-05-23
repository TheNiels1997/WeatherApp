<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Search_Locations
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
        Me.CityList1 = New WeatherApp.CityList()
        Me.Button2 = New WeatherApp.Button()
        Me.SuspendLayout()
        '
        'CityList1
        '
        Me.CityList1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CityList1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CityList1.FormattingEnabled = True
        Me.CityList1.IntegralHeight = False
        Me.CityList1.ItemHeight = 30
        Me.CityList1.Location = New System.Drawing.Point(18, 56)
        Me.CityList1.Name = "CityList1"
        Me.CityList1.Size = New System.Drawing.Size(464, 361)
        Me.CityList1.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Image = Global.WeatherApp.My.Resources.Resources.close
        Me.Button2.Location = New System.Drawing.Point(450, 18)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(32, 32)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Button2"
        '
        'Search_Locations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 435)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CityList1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Search_Locations"
        Me.Padding = New System.Windows.Forms.Padding(15)
        Me.Text = "Search_Locations"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CityList1 As CityList
    Friend WithEvents Button2 As Button
End Class
