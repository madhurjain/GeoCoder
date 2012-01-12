<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm))
        Me.lblAddr = New System.Windows.Forms.Label
        Me.lblCity = New System.Windows.Forms.Label
        Me.lblState = New System.Windows.Forms.Label
        Me.lblZip = New System.Windows.Forms.Label
        Me.tboxAddr = New System.Windows.Forms.TextBox
        Me.tboxCity = New System.Windows.Forms.TextBox
        Me.tboxState = New System.Windows.Forms.TextBox
        Me.tboxZip = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnGetIt = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.tboxyLL = New System.Windows.Forms.TextBox
        Me.tboxgLL = New System.Windows.Forms.TextBox
        Me.lblyLL = New System.Windows.Forms.Label
        Me.lblgLL = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAddr
        '
        Me.lblAddr.AutoSize = True
        Me.lblAddr.Location = New System.Drawing.Point(25, 31)
        Me.lblAddr.Name = "lblAddr"
        Me.lblAddr.Size = New System.Drawing.Size(51, 13)
        Me.lblAddr.TabIndex = 0
        Me.lblAddr.Text = "Address :"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(25, 62)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(30, 13)
        Me.lblCity.TabIndex = 1
        Me.lblCity.Text = "City :"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(25, 98)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(38, 13)
        Me.lblState.TabIndex = 2
        Me.lblState.Text = "State :"
        '
        'lblZip
        '
        Me.lblZip.AutoSize = True
        Me.lblZip.Location = New System.Drawing.Point(25, 135)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(56, 13)
        Me.lblZip.TabIndex = 3
        Me.lblZip.Text = "Zip Code :"
        '
        'tboxAddr
        '
        Me.tboxAddr.Location = New System.Drawing.Point(92, 28)
        Me.tboxAddr.Name = "tboxAddr"
        Me.tboxAddr.Size = New System.Drawing.Size(261, 20)
        Me.tboxAddr.TabIndex = 4
        '
        'tboxCity
        '
        Me.tboxCity.Location = New System.Drawing.Point(92, 59)
        Me.tboxCity.Name = "tboxCity"
        Me.tboxCity.Size = New System.Drawing.Size(191, 20)
        Me.tboxCity.TabIndex = 5
        '
        'tboxState
        '
        Me.tboxState.Location = New System.Drawing.Point(92, 95)
        Me.tboxState.Name = "tboxState"
        Me.tboxState.Size = New System.Drawing.Size(150, 20)
        Me.tboxState.TabIndex = 6
        '
        'tboxZip
        '
        Me.tboxZip.Location = New System.Drawing.Point(92, 132)
        Me.tboxZip.Name = "tboxZip"
        Me.tboxZip.Size = New System.Drawing.Size(116, 20)
        Me.tboxZip.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tboxCity)
        Me.GroupBox1.Controls.Add(Me.tboxZip)
        Me.GroupBox1.Controls.Add(Me.lblAddr)
        Me.GroupBox1.Controls.Add(Me.tboxState)
        Me.GroupBox1.Controls.Add(Me.lblCity)
        Me.GroupBox1.Controls.Add(Me.lblState)
        Me.GroupBox1.Controls.Add(Me.tboxAddr)
        Me.GroupBox1.Controls.Add(Me.lblZip)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(473, 188)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter Details"
        '
        'btnGetIt
        '
        Me.btnGetIt.Location = New System.Drawing.Point(219, 206)
        Me.btnGetIt.Name = "btnGetIt"
        Me.btnGetIt.Size = New System.Drawing.Size(76, 21)
        Me.btnGetIt.TabIndex = 9
        Me.btnGetIt.Text = "Get it !"
        Me.btnGetIt.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tboxyLL)
        Me.GroupBox2.Controls.Add(Me.tboxgLL)
        Me.GroupBox2.Controls.Add(Me.lblyLL)
        Me.GroupBox2.Controls.Add(Me.lblgLL)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 233)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(469, 43)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Output"
        '
        'tboxyLL
        '
        Me.tboxyLL.Location = New System.Drawing.Point(305, 16)
        Me.tboxyLL.Name = "tboxyLL"
        Me.tboxyLL.Size = New System.Drawing.Size(152, 20)
        Me.tboxyLL.TabIndex = 3
        '
        'tboxgLL
        '
        Me.tboxgLL.Location = New System.Drawing.Point(82, 16)
        Me.tboxgLL.Name = "tboxgLL"
        Me.tboxgLL.Size = New System.Drawing.Size(152, 20)
        Me.tboxgLL.TabIndex = 2
        '
        'lblyLL
        '
        Me.lblyLL.AutoSize = True
        Me.lblyLL.Location = New System.Drawing.Point(240, 19)
        Me.lblyLL.Name = "lblyLL"
        Me.lblyLL.Size = New System.Drawing.Size(59, 13)
        Me.lblyLL.TabIndex = 1
        Me.lblyLL.Text = "Yahoo LL :"
        '
        'lblgLL
        '
        Me.lblgLL.AutoSize = True
        Me.lblgLL.Location = New System.Drawing.Point(14, 19)
        Me.lblgLL.Name = "lblgLL"
        Me.lblgLL.Size = New System.Drawing.Size(62, 13)
        Me.lblgLL.TabIndex = 0
        Me.lblgLL.Text = "Google LL :"
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 288)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnGetIt)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "mainForm"
        Me.Text = "GeoCoder"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblAddr As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents lblZip As System.Windows.Forms.Label
    Friend WithEvents tboxAddr As System.Windows.Forms.TextBox
    Friend WithEvents tboxCity As System.Windows.Forms.TextBox
    Friend WithEvents tboxState As System.Windows.Forms.TextBox
    Friend WithEvents tboxZip As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnGetIt As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblyLL As System.Windows.Forms.Label
    Friend WithEvents lblgLL As System.Windows.Forms.Label
    Friend WithEvents tboxgLL As System.Windows.Forms.TextBox
    Friend WithEvents tboxyLL As System.Windows.Forms.TextBox

End Class
