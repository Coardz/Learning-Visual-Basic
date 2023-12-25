<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registryform
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.readkeyBox = New System.Windows.Forms.TextBox()
        Me.readValueBox = New System.Windows.Forms.TextBox()
        Me.readBtn = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.readclrbtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.readdataHolder = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.editdataBox = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.editdataholder = New System.Windows.Forms.Label()
        Me.editvalueBox = New System.Windows.Forms.TextBox()
        Me.editbtn = New System.Windows.Forms.Button()
        Me.editkeyBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(6, 34)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 81)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Read Value"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(9, 121)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 76)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Change Value"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.YellowGreen
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Font = New System.Drawing.Font("Nirmala UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(19, 19)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(113, 209)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Examples"
        '
        'readkeyBox
        '
        Me.readkeyBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.readkeyBox.Location = New System.Drawing.Point(29, 51)
        Me.readkeyBox.Multiline = True
        Me.readkeyBox.Name = "readkeyBox"
        Me.readkeyBox.Size = New System.Drawing.Size(250, 49)
        Me.readkeyBox.TabIndex = 3
        '
        'readValueBox
        '
        Me.readValueBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.readValueBox.Location = New System.Drawing.Point(29, 119)
        Me.readValueBox.Multiline = True
        Me.readValueBox.Name = "readValueBox"
        Me.readValueBox.Size = New System.Drawing.Size(250, 39)
        Me.readValueBox.TabIndex = 4
        '
        'readBtn
        '
        Me.readBtn.Location = New System.Drawing.Point(29, 179)
        Me.readBtn.Name = "readBtn"
        Me.readBtn.Size = New System.Drawing.Size(250, 23)
        Me.readBtn.TabIndex = 5
        Me.readBtn.Text = "Read"
        Me.readBtn.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.readclrbtn)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.readdataHolder)
        Me.GroupBox2.Controls.Add(Me.readValueBox)
        Me.GroupBox2.Controls.Add(Me.readBtn)
        Me.GroupBox2.Controls.Add(Me.readkeyBox)
        Me.GroupBox2.Location = New System.Drawing.Point(154, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(316, 294)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Read Value Project 1"
        '
        'readclrbtn
        '
        Me.readclrbtn.Location = New System.Drawing.Point(29, 208)
        Me.readclrbtn.Name = "readclrbtn"
        Me.readclrbtn.Size = New System.Drawing.Size(250, 23)
        Me.readclrbtn.TabIndex = 9
        Me.readclrbtn.Text = "Clear"
        Me.readclrbtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Insert Key Path"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Insert Value Name"
        '
        'readdataHolder
        '
        Me.readdataHolder.AutoSize = True
        Me.readdataHolder.Font = New System.Drawing.Font("Nirmala UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.readdataHolder.Location = New System.Drawing.Point(24, 244)
        Me.readdataHolder.Name = "readdataHolder"
        Me.readdataHolder.Size = New System.Drawing.Size(70, 30)
        Me.readdataHolder.TabIndex = 6
        Me.readdataHolder.Text = "Data: "
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.editdataBox)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.editdataholder)
        Me.GroupBox3.Controls.Add(Me.editvalueBox)
        Me.GroupBox3.Controls.Add(Me.editbtn)
        Me.GroupBox3.Controls.Add(Me.editkeyBox)
        Me.GroupBox3.Location = New System.Drawing.Point(488, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(316, 379)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Edit Value Project 2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Insert Data"
        '
        'editdataBox
        '
        Me.editdataBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editdataBox.Location = New System.Drawing.Point(29, 179)
        Me.editdataBox.Multiline = True
        Me.editdataBox.Name = "editdataBox"
        Me.editdataBox.Size = New System.Drawing.Size(250, 39)
        Me.editdataBox.TabIndex = 10
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(29, 271)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(250, 23)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Clear"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Insert Key Path"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Insert Value Name"
        '
        'editdataholder
        '
        Me.editdataholder.AutoSize = True
        Me.editdataholder.Font = New System.Drawing.Font("Nirmala UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editdataholder.Location = New System.Drawing.Point(24, 309)
        Me.editdataholder.Name = "editdataholder"
        Me.editdataholder.Size = New System.Drawing.Size(186, 30)
        Me.editdataholder.TabIndex = 6
        Me.editdataholder.Text = "You set the value:"
        '
        'editvalueBox
        '
        Me.editvalueBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editvalueBox.Location = New System.Drawing.Point(29, 119)
        Me.editvalueBox.Multiline = True
        Me.editvalueBox.Name = "editvalueBox"
        Me.editvalueBox.Size = New System.Drawing.Size(250, 39)
        Me.editvalueBox.TabIndex = 4
        '
        'editbtn
        '
        Me.editbtn.Location = New System.Drawing.Point(29, 242)
        Me.editbtn.Name = "editbtn"
        Me.editbtn.Size = New System.Drawing.Size(250, 23)
        Me.editbtn.TabIndex = 5
        Me.editbtn.Text = "Edit"
        Me.editbtn.UseVisualStyleBackColor = True
        '
        'editkeyBox
        '
        Me.editkeyBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editkeyBox.Location = New System.Drawing.Point(29, 51)
        Me.editkeyBox.Multiline = True
        Me.editkeyBox.Name = "editkeyBox"
        Me.editkeyBox.Size = New System.Drawing.Size(250, 49)
        Me.editkeyBox.TabIndex = 3
        '
        'registryform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 430)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "registryform"
        Me.Text = "RegistryProxy"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents readkeyBox As System.Windows.Forms.TextBox
    Friend WithEvents readValueBox As System.Windows.Forms.TextBox
    Friend WithEvents readBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents readdataHolder As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents readclrbtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents editdataBox As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents editdataholder As System.Windows.Forms.Label
    Friend WithEvents editvalueBox As System.Windows.Forms.TextBox
    Friend WithEvents editbtn As System.Windows.Forms.Button
    Friend WithEvents editkeyBox As System.Windows.Forms.TextBox

End Class
