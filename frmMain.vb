Imports System.Net
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmMain
    Public WithEvents timer As New Timer()
    Public stopwatch As New Stopwatch()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timer.Interval = 1000



        'MsgBox(stringOfNumbers)

    End Sub

    Public Sub timer_tick(sender As Object, e As EventArgs) Handles timer.Tick
        lblTime.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        btnStart.Visible = False
        btnReset.Visible = True

        frmDisplay.Close()
        Display_On_MainScreen(frmDisplay)
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        btnStart.Visible = True
        btnReset.Visible = False
        timer.Stop()
        stopwatch.Reset()
        lblMoves.Text = ""
        lblScore.Text = ""
        lblTime.Text = ""
        frmDisplay.Close()
    End Sub

    Public Sub Display_On_MainScreen(frm As Form)
        pnlMainScreen.Controls.Clear()
        frm.TopLevel = False
        pnlMainScreen.Controls.Add(frm)
        frm.Show()
    End Sub
End Class
