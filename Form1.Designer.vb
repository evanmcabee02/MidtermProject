<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuildingPlansConversion
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
        Me.txtConversion = New System.Windows.Forms.TextBox()
        Me.grpConvertMeasurement = New System.Windows.Forms.GroupBox()
        Me.radMetersToInches = New System.Windows.Forms.RadioButton()
        Me.radInchesToMeters = New System.Windows.Forms.RadioButton()
        Me.picBuilding = New System.Windows.Forms.PictureBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblConverted = New System.Windows.Forms.Label()
        Me.lblConverterApp = New System.Windows.Forms.Label()
        Me.lblEnterValue = New System.Windows.Forms.Label()
        Me.grpConvertMeasurement.SuspendLayout()
        CType(Me.picBuilding, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtConversion
        '
        Me.txtConversion.BackColor = System.Drawing.Color.DarkMagenta
        Me.txtConversion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConversion.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtConversion.Location = New System.Drawing.Point(621, 95)
        Me.txtConversion.Multiline = True
        Me.txtConversion.Name = "txtConversion"
        Me.txtConversion.Size = New System.Drawing.Size(89, 32)
        Me.txtConversion.TabIndex = 0
        Me.txtConversion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpConvertMeasurement
        '
        Me.grpConvertMeasurement.BackColor = System.Drawing.Color.DarkMagenta
        Me.grpConvertMeasurement.Controls.Add(Me.radMetersToInches)
        Me.grpConvertMeasurement.Controls.Add(Me.radInchesToMeters)
        Me.grpConvertMeasurement.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpConvertMeasurement.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grpConvertMeasurement.Location = New System.Drawing.Point(446, 173)
        Me.grpConvertMeasurement.Name = "grpConvertMeasurement"
        Me.grpConvertMeasurement.Size = New System.Drawing.Size(299, 100)
        Me.grpConvertMeasurement.TabIndex = 1
        Me.grpConvertMeasurement.TabStop = False
        Me.grpConvertMeasurement.Text = "Convert Measurement"
        '
        'radMetersToInches
        '
        Me.radMetersToInches.AutoSize = True
        Me.radMetersToInches.Location = New System.Drawing.Point(7, 57)
        Me.radMetersToInches.Name = "radMetersToInches"
        Me.radMetersToInches.Size = New System.Drawing.Size(197, 29)
        Me.radMetersToInches.TabIndex = 1
        Me.radMetersToInches.TabStop = True
        Me.radMetersToInches.Text = "Meters to Inches"
        Me.radMetersToInches.UseVisualStyleBackColor = True
        '
        'radInchesToMeters
        '
        Me.radInchesToMeters.AutoSize = True
        Me.radInchesToMeters.Location = New System.Drawing.Point(7, 26)
        Me.radInchesToMeters.Name = "radInchesToMeters"
        Me.radInchesToMeters.Size = New System.Drawing.Size(197, 29)
        Me.radInchesToMeters.TabIndex = 0
        Me.radInchesToMeters.TabStop = True
        Me.radInchesToMeters.Text = "Inches to Meters"
        Me.radInchesToMeters.UseVisualStyleBackColor = True
        '
        'picBuilding
        '
        Me.picBuilding.Image = Global.MidtermProject.My.Resources.Resources.building
        Me.picBuilding.Location = New System.Drawing.Point(12, 12)
        Me.picBuilding.Name = "picBuilding"
        Me.picBuilding.Size = New System.Drawing.Size(284, 216)
        Me.picBuilding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBuilding.TabIndex = 2
        Me.picBuilding.TabStop = False
        '
        'btnConvert
        '
        Me.btnConvert.BackColor = System.Drawing.Color.MediumPurple
        Me.btnConvert.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.Location = New System.Drawing.Point(27, 367)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(235, 55)
        Me.btnConvert.TabIndex = 3
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.MediumPurple
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(277, 367)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(235, 55)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.MediumPurple
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(531, 367)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(235, 55)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblConverted
        '
        Me.lblConverted.AutoSize = True
        Me.lblConverted.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConverted.Location = New System.Drawing.Point(441, 307)
        Me.lblConverted.Name = "lblConverted"
        Me.lblConverted.Size = New System.Drawing.Size(343, 29)
        Me.lblConverted.TabIndex = 6
        Me.lblConverted.Text = "10 meters is 123.456 inches."
        '
        'lblConverterApp
        '
        Me.lblConverterApp.AutoSize = True
        Me.lblConverterApp.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConverterApp.Location = New System.Drawing.Point(314, 31)
        Me.lblConverterApp.Name = "lblConverterApp"
        Me.lblConverterApp.Size = New System.Drawing.Size(262, 40)
        Me.lblConverterApp.TabIndex = 7
        Me.lblConverterApp.Text = "Converter App"
        '
        'lblEnterValue
        '
        Me.lblEnterValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterValue.Location = New System.Drawing.Point(342, 82)
        Me.lblEnterValue.Name = "lblEnterValue"
        Me.lblEnterValue.Size = New System.Drawing.Size(234, 68)
        Me.lblEnterValue.TabIndex = 8
        Me.lblEnterValue.Text = "Enter a value and choose conversion"
        '
        'frmBuildingPlansConversion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumPurple
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblEnterValue)
        Me.Controls.Add(Me.lblConverterApp)
        Me.Controls.Add(Me.lblConverted)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.picBuilding)
        Me.Controls.Add(Me.grpConvertMeasurement)
        Me.Controls.Add(Me.txtConversion)
        Me.Name = "frmBuildingPlansConversion"
        Me.Text = "Building Plans Conversion"
        Me.grpConvertMeasurement.ResumeLayout(False)
        Me.grpConvertMeasurement.PerformLayout()
        CType(Me.picBuilding, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtConversion As TextBox
    Friend WithEvents grpConvertMeasurement As GroupBox
    Friend WithEvents radMetersToInches As RadioButton
    Friend WithEvents radInchesToMeters As RadioButton
    Friend WithEvents picBuilding As PictureBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblConverted As Label
    Friend WithEvents lblConverterApp As Label
    Friend WithEvents lblEnterValue As Label
End Class
