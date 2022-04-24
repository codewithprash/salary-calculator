Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id As Single
        Dim nam As String
        Dim base As Double
        Dim tax As Single

        Dim gross As Double

        id = Val(TextBox2.Text)
        nam = TextBox4.Text
        base = Val(TextBox5.Text)

        If CheckBox1.CheckState = CheckState.Checked Then
            gross = gross + base * NumericUpDown1.Value / 100
        End If

        If CheckBox2.CheckState = CheckState.Checked Then
            gross = gross + base * NumericUpDown2.Value / 100
        End If

        If CheckBox3.CheckState = CheckState.Checked Then
            gross = gross + base * NumericUpDown3.Value / 100
        End If

        If CheckBox4.CheckState = CheckState.Checked Then
            tax = tax + base * NumericUpDown4.Value / 100
        End If

        If CheckBox5.CheckState = CheckState.Checked Then
            tax = tax + base * NumericUpDown5.Value / 100
        End If

        If CheckBox6.CheckState = CheckState.Checked Then
            tax = tax + Val(TextBox6.Text)
        End If


        TextBox1.AppendText(id & vbTab)
        TextBox1.AppendText(base & vbTab)
        TextBox1.AppendText(gross + base & vbTab)
        TextBox1.AppendText((base + gross) - tax & vbTab)
        TextBox1.AppendText(vbCrLf)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.AppendText("Emp ID" & vbTab & "BASIC" & vbTab & "GROSS" & vbTab & "NET PAY" & vbCrLf)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = Nothing
        TextBox2.Text = Nothing
        TextBox6.Text = Nothing
        TextBox4.Text = Nothing
        TextBox5.Text = Nothing
        NumericUpDown1.Value = 0
        NumericUpDown2.Value = 0
        NumericUpDown3.Value = 0
        NumericUpDown4.Value = 0
        NumericUpDown5.Value = 0
        CheckBox1.CheckState = CheckState.Unchecked
        CheckBox2.CheckState = CheckState.Unchecked
        CheckBox3.CheckState = CheckState.Unchecked
        CheckBox4.CheckState = CheckState.Unchecked
        CheckBox5.CheckState = CheckState.Unchecked
        TextBox1.AppendText("Emp ID" & vbTab & "BASIC" & vbTab & "GROSS" & vbTab & "NET PAY" & vbCrLf)
    End Sub
End Class
