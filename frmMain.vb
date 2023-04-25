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

        'For i As Integer = 1 To 5
        '    'label.Text = "Label " & i + 5
        '    Dim label As New Label With {
        '        .Name = "Label" & i + 5,
        '        .Image = My.Resources.back3,
        '        .Location = New Point(10, (i - 1) * y_size + 30),
        '        .Size = New Point(100, y_size)
        '    }

        '    AddHandler label.Click, AddressOf Label_Click
        '    Me.Controls.Add(label)
        'Next
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
End Class
