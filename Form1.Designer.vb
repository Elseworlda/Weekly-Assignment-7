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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pctKaraoke = New System.Windows.Forms.PictureBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblSubheader = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        CType(Me.pctKaraoke, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pctKaraoke
        '
        Me.pctKaraoke.Image = CType(resources.GetObject("pctKaraoke.Image"), System.Drawing.Image)
        Me.pctKaraoke.Location = New System.Drawing.Point(2, 2)
        Me.pctKaraoke.Name = "pctKaraoke"
        Me.pctKaraoke.Size = New System.Drawing.Size(339, 445)
        Me.pctKaraoke.TabIndex = 0
        Me.pctKaraoke.TabStop = False
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.White
        Me.lblHeading.Location = New System.Drawing.Point(398, 27)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(351, 38)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Karaoke Music Night"
        '
        'ComboBox1
        '
        Me.ComboBox1.DisplayMember = "cmbPlanSelect"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Number of Songs ($2.99 per song)", "Hours in Private Karaoke Booth ($8.99 per hour)"})
        Me.ComboBox1.Location = New System.Drawing.Point(405, 94)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(352, 24)
        Me.ComboBox1.TabIndex = 2
        Me.ComboBox1.Text = "Customize your Night"
        Me.ComboBox1.ValueMember = "cmbPlanSelect"
        '
        'lblSubheader
        '
        Me.lblSubheader.AutoSize = True
        Me.lblSubheader.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubheader.ForeColor = System.Drawing.Color.White
        Me.lblSubheader.Location = New System.Drawing.Point(447, 159)
        Me.lblSubheader.Name = "lblSubheader"
        Me.lblSubheader.Size = New System.Drawing.Size(265, 20)
        Me.lblSubheader.TabIndex = 3
        Me.lblSubheader.Text = "Hourly Rental of Karaoke Room"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(552, 227)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(62, 22)
        Me.txtInput.TabIndex = 4
        '
        'btnTotal
        '
        Me.btnTotal.Location = New System.Drawing.Point(422, 280)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(99, 37)
        Me.btnTotal.TabIndex = 5
        Me.btnTotal.Text = "Total Cost"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(639, 280)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(99, 37)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.ForeColor = System.Drawing.Color.White
        Me.lblTotalCost.Location = New System.Drawing.Point(402, 349)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(0, 17)
        Me.lblTotalCost.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblSubheader)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.pctKaraoke)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pctKaraoke, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pctKaraoke As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents lblSubheader As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnTotal As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblTotalCost As Label
End Class
