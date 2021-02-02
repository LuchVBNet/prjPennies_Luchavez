<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblApp = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPennies = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPenniesLeft = New System.Windows.Forms.TextBox()
        Me.lblPennies = New System.Windows.Forms.Label()
        Me.txtNickels = New System.Windows.Forms.TextBox()
        Me.lblNickels = New System.Windows.Forms.Label()
        Me.txtDimes = New System.Windows.Forms.TextBox()
        Me.lblDimes = New System.Windows.Forms.Label()
        Me.txtQuarters = New System.Windows.Forms.TextBox()
        Me.lblQuarters = New System.Windows.Forms.Label()
        Me.txtDollars = New System.Windows.Forms.TextBox()
        Me.lblDollars = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.prjPennies_Luchavez.My.Resources.Resources.piggybank
        Me.PictureBox1.Location = New System.Drawing.Point(71, 15)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 123)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblApp
        '
        Me.lblApp.AutoSize = True
        Me.lblApp.BackColor = System.Drawing.Color.Goldenrod
        Me.lblApp.Font = New System.Drawing.Font("Lucida Calligraphy", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApp.Location = New System.Drawing.Point(13, 142)
        Me.lblApp.Name = "lblApp"
        Me.lblApp.Size = New System.Drawing.Size(252, 36)
        Me.lblApp.TabIndex = 1
        Me.lblApp.Text = "Pennies Solution"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 225)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "# of Pennies"
        '
        'txtPennies
        '
        Me.txtPennies.Location = New System.Drawing.Point(111, 223)
        Me.txtPennies.Name = "txtPennies"
        Me.txtPennies.Size = New System.Drawing.Size(154, 22)
        Me.txtPennies.TabIndex = 3
        Me.txtPennies.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.LightGreen
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculate.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(84, 267)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(110, 30)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "&CALCULATE"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPenniesLeft)
        Me.GroupBox1.Controls.Add(Me.lblPennies)
        Me.GroupBox1.Controls.Add(Me.txtNickels)
        Me.GroupBox1.Controls.Add(Me.lblNickels)
        Me.GroupBox1.Controls.Add(Me.txtDimes)
        Me.GroupBox1.Controls.Add(Me.lblDimes)
        Me.GroupBox1.Controls.Add(Me.txtQuarters)
        Me.GroupBox1.Controls.Add(Me.lblQuarters)
        Me.GroupBox1.Controls.Add(Me.txtDollars)
        Me.GroupBox1.Controls.Add(Me.lblDollars)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 313)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(252, 184)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Result"
        '
        'txtPenniesLeft
        '
        Me.txtPenniesLeft.BackColor = System.Drawing.Color.Bisque
        Me.txtPenniesLeft.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPenniesLeft.Location = New System.Drawing.Point(104, 148)
        Me.txtPenniesLeft.Name = "txtPenniesLeft"
        Me.txtPenniesLeft.ReadOnly = True
        Me.txtPenniesLeft.Size = New System.Drawing.Size(142, 22)
        Me.txtPenniesLeft.TabIndex = 15
        Me.txtPenniesLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPennies
        '
        Me.lblPennies.AutoSize = True
        Me.lblPennies.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPennies.Location = New System.Drawing.Point(6, 150)
        Me.lblPennies.Name = "lblPennies"
        Me.lblPennies.Size = New System.Drawing.Size(89, 17)
        Me.lblPennies.TabIndex = 14
        Me.lblPennies.Text = "# of Pennies"
        '
        'txtNickels
        '
        Me.txtNickels.BackColor = System.Drawing.Color.Bisque
        Me.txtNickels.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNickels.Location = New System.Drawing.Point(104, 120)
        Me.txtNickels.Name = "txtNickels"
        Me.txtNickels.ReadOnly = True
        Me.txtNickels.Size = New System.Drawing.Size(142, 22)
        Me.txtNickels.TabIndex = 13
        Me.txtNickels.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNickels
        '
        Me.lblNickels.AutoSize = True
        Me.lblNickels.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNickels.Location = New System.Drawing.Point(6, 122)
        Me.lblNickels.Name = "lblNickels"
        Me.lblNickels.Size = New System.Drawing.Size(83, 17)
        Me.lblNickels.TabIndex = 12
        Me.lblNickels.Text = "# of Nickels"
        '
        'txtDimes
        '
        Me.txtDimes.BackColor = System.Drawing.Color.Bisque
        Me.txtDimes.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDimes.Location = New System.Drawing.Point(104, 92)
        Me.txtDimes.Name = "txtDimes"
        Me.txtDimes.ReadOnly = True
        Me.txtDimes.Size = New System.Drawing.Size(142, 22)
        Me.txtDimes.TabIndex = 11
        Me.txtDimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDimes
        '
        Me.lblDimes.AutoSize = True
        Me.lblDimes.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDimes.Location = New System.Drawing.Point(6, 94)
        Me.lblDimes.Name = "lblDimes"
        Me.lblDimes.Size = New System.Drawing.Size(79, 17)
        Me.lblDimes.TabIndex = 10
        Me.lblDimes.Text = "# of Dimes"
        '
        'txtQuarters
        '
        Me.txtQuarters.BackColor = System.Drawing.Color.Bisque
        Me.txtQuarters.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuarters.Location = New System.Drawing.Point(104, 64)
        Me.txtQuarters.Name = "txtQuarters"
        Me.txtQuarters.ReadOnly = True
        Me.txtQuarters.Size = New System.Drawing.Size(142, 22)
        Me.txtQuarters.TabIndex = 9
        Me.txtQuarters.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblQuarters
        '
        Me.lblQuarters.AutoSize = True
        Me.lblQuarters.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuarters.Location = New System.Drawing.Point(6, 66)
        Me.lblQuarters.Name = "lblQuarters"
        Me.lblQuarters.Size = New System.Drawing.Size(94, 17)
        Me.lblQuarters.TabIndex = 8
        Me.lblQuarters.Text = "# of Quarters"
        '
        'txtDollars
        '
        Me.txtDollars.BackColor = System.Drawing.Color.Bisque
        Me.txtDollars.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDollars.Location = New System.Drawing.Point(104, 36)
        Me.txtDollars.Name = "txtDollars"
        Me.txtDollars.ReadOnly = True
        Me.txtDollars.Size = New System.Drawing.Size(142, 22)
        Me.txtDollars.TabIndex = 7
        Me.txtDollars.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDollars
        '
        Me.lblDollars.AutoSize = True
        Me.lblDollars.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDollars.Location = New System.Drawing.Point(6, 38)
        Me.lblDollars.Name = "lblDollars"
        Me.lblDollars.Size = New System.Drawing.Size(82, 17)
        Me.lblDollars.TabIndex = 6
        Me.lblDollars.Text = "# of Dollars"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Tomato
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(138, 503)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(60, 30)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Cl&ear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.OrangeRed
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(204, 503)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(60, 30)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 541)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtPennies)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblApp)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pennies Solution"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblApp As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPennies As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtPenniesLeft As TextBox
    Friend WithEvents lblPennies As Label
    Friend WithEvents txtNickels As TextBox
    Friend WithEvents lblNickels As Label
    Friend WithEvents txtDimes As TextBox
    Friend WithEvents lblDimes As Label
    Friend WithEvents txtQuarters As TextBox
    Friend WithEvents lblQuarters As Label
    Friend WithEvents txtDollars As TextBox
    Friend WithEvents lblDollars As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
