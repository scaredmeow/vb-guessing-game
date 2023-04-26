Imports System.Threading
Public Class frmDisplay
    Public lbl_dynamic As New List(Of Label)
    Public prev_val As Integer = 0
    Public next_val As Integer = 0
    Public prev_idx, next_idx, moves, score, counter As New Integer
    Public cards As Integer = 0
    Public final_numbers As New List(Of Integer)
    Private Sub frmDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x_loc, y_loc, x_size, y_size, k, l, m As New Integer
        Dim back_cards() As String = {"back1", "back2", "back3", "back4", "back5", "back6"}
        Dim random As New Random()
        Dim back_card = back_cards(random.Next(back_cards.Length))
        Dim numbers As New List(Of Integer)


        counter = 0
        moves = 0
        score = 0
        frmMain.lblMoves.Text = moves.ToString
        frmMain.lblScore.Text = score.ToString

        frmMain.stopwatch.Start()

        frmMain.timer.Start()

        For i As Integer = 0 To 11
            Dim rand_number = random.Next(1, 53)
            numbers.Add(rand_number)
            numbers.Add(rand_number)
        Next

        Do While final_numbers.Count <> 24
            Dim rand_number = random.Next(numbers.Count)
            final_numbers.Add(numbers(rand_number))
            numbers.Remove(numbers(rand_number))
        Loop

        Dim stringOfNumbers As String = String.Join(",", final_numbers)


        y_size = 140
        x_size = 100
        x_loc = x_size
        y_loc = y_size
        l = 1
        m = 8
        For i As Integer = 1 To 3
            k = l
            l = m * i
            Dim counter As Integer = 0
            For j As Integer = k To l

                Dim label As New Label With {
                    .Name = "back" & j,
                    .Text = final_numbers(j - 1),
                    .ForeColor = Color.Transparent,
                    .Image = CType(My.Resources.ResourceManager.GetObject(back_card), Bitmap),
                    .Location = New Point((x_loc + 5) * counter + 10, (y_loc + 5) * (i - 1) + 25),
                    .Size = New Point(x_size, y_size),
                    .Cursor = Cursors.Hand,
                    .Font = New Font("Arial", 3)
                }

                AddHandler label.Click, AddressOf Label_Click
                Controls.Add(label)
                lbl_dynamic.Add(label)
                counter += 1
            Next
            l += 1
        Next

        l = 1
        m = 8
        For i As Integer = 1 To 3
            k = l
            l = m * i
            Dim counter As Integer = 0
            For j As Integer = k To l
                Dim label As New Label With {
                    .Name = "front" & j,
                    .Text = final_numbers(j - 1),
                    .ForeColor = Color.Transparent,
                    .Image = CType(My.Resources.ResourceManager.GetObject(final_numbers(j - 1).ToString), Bitmap),
                    .Location = New Point((x_loc + 5) * counter + 10, (y_loc + 5) * (i - 1) + 25),
                    .Size = New Point(x_size, y_size),
                    .Cursor = Cursors.Hand,
                    .Font = New Font("Arial", 3)
                }

                AddHandler label.Click, AddressOf Label_Click
                Controls.Add(label)
                lbl_dynamic.Add(label)
                counter += 1
            Next
            l += 1
        Next

    End Sub

    Private Sub Label_Click(sender As Object, e As EventArgs)
        Dim label As Label = CType(sender, Label)

        If Not label.Name.Contains("front") Then
            label.Visible = False
            cards += 1
            frmMain.lblMoves.Text += 1
            If cards = 1 Then
                prev_val = label.Text
                prev_idx = lbl_dynamic.IndexOf(label)
            ElseIf cards = 2 Then
                next_val = label.Text
                next_idx = lbl_dynamic.IndexOf(label)
                If counter = 22 Then
                    Select Case CInt(frmMain.lblMoves.Text)
                        Case < 15
                            frmMain.lblScore.Text += 100
                        Case < 25
                            frmMain.lblScore.Text += 50
                        Case < 50
                            frmMain.lblScore.Text += 25
                        Case < 100
                            frmMain.lblScore.Text += 10
                        Case Else
                            frmMain.lblScore.Text += 1
                    End Select
                    counter += 2
                End If

            Else
                If prev_val <> next_val Then
                    lbl_dynamic(prev_idx).Visible = True
                    lbl_dynamic(next_idx).Visible = True
                Else
                    Select Case CInt(frmMain.lblMoves.Text)
                        Case < 15
                            frmMain.lblScore.Text += 100
                        Case < 25
                            frmMain.lblScore.Text += 50
                        Case < 50
                            frmMain.lblScore.Text += 25
                        Case < 100
                            frmMain.lblScore.Text += 10
                        Case Else
                            frmMain.lblScore.Text += 1
                    End Select
                    counter += 2
                End If
                prev_val = label.Text
                prev_idx = lbl_dynamic.IndexOf(label)
                next_idx = Nothing
                next_val = Nothing
                cards = 1
                Thread.Sleep(200)
            End If
        End If
    End Sub
End Class