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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pnlMainScreen = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblMoves = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Location = New System.Drawing.Point(20, 15)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(50, 30)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.DarkSalmon
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Location = New System.Drawing.Point(20, 15)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(50, 30)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        Me.btnReset.Visible = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(81, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(229, 30)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Memory Card Game"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlMainScreen
        '
        Me.pnlMainScreen.Location = New System.Drawing.Point(-1, 51)
        Me.pnlMainScreen.Name = "pnlMainScreen"
        Me.pnlMainScreen.Size = New System.Drawing.Size(860, 480)
        Me.pnlMainScreen.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(552, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 30)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Time: "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(316, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 30)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Score:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(434, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 30)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Moves:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(596, 17)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(95, 25)
        Me.lblTime.TabIndex = 21
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMoves
        '
        Me.lblMoves.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblMoves.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoves.Location = New System.Drawing.Point(490, 18)
        Me.lblMoves.Name = "lblMoves"
        Me.lblMoves.Size = New System.Drawing.Size(56, 24)
        Me.lblMoves.TabIndex = 22
        Me.lblMoves.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblScore
        '
        Me.lblScore.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(368, 19)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(56, 23)
        Me.lblScore.TabIndex = 23
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 530)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblMoves)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pnlMainScreen)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnStart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents pnlMainScreen As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblMoves As Label
    Friend WithEvents lblScore As Label
End Class
