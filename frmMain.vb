Imports System.Net
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmMain

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim numbers As New List(Of Integer)
        Dim random As New Random()

        For i As Integer = 0 To 11
            Dim rand_number = random.Next(1, 53)
            numbers.Add(rand_number)
            numbers.Add(rand_number)
        Next

        Dim final_numbers As New List(Of Integer)

        Do While final_numbers.Count <> 24
            Dim rand_number = random.Next(numbers.Count)
            final_numbers.Add(numbers(rand_number))
            numbers.Remove(numbers(rand_number))
        Loop

        Dim stringOfNumbers As String = String.Join(",", final_numbers)

        MsgBox(stringOfNumbers)

    End Sub

    Private Sub Label_Click(sender As Object, e As EventArgs)
        Dim label As Label = CType(sender, Label)
        MessageBox.Show(label.Name & " clicked")
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        btnStart.Visible = False
        btnReset.Visible = True

        Dim x_loc, y_loc, x_size, y_size As New Integer

        y_loc = 140
        y_size = 140
        x_size = 100
        x_loc = x_size

        For i As Integer = 0 To 7
            'label.Text = "Label " & i + 5
            Dim label As New Label With {
                .Name = "Label" & i + 5,
                .Image = My.Resources.back3,
                .Location = New Point((x_loc + 5) * i + 10, 50),
                .Size = New Point(x_size, y_size),
                .Cursor = Cursors.Hand
            }

            AddHandler label.Click, AddressOf Label_Click
            Me.Controls.Add(label)
        Next
        'For i As Integer = 1 To 5
        '    Dim label As New Label()
        '    label.Name = "Label" & i
        '    label.Text = "Label " & i
        '    label.Location = New Point(10, (i - 1) * 30 + 10)
        '    AddHandler label.Click, AddressOf Label_Click
        '    Me.Controls.Add(label)
        'Next
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        btnStart.Visible = True
        btnReset.Visible = False
    End Sub

    Public Sub Display_On_MainScreen(frm As Form)
        pnlMainScreen.Controls.Clear()
        frm.TopLevel = False
        pnlMainScreen.Controls.Add(frm)
        frm.Show()
    End Sub
End Class
