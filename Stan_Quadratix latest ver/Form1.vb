
Public Class Stan_Quadratix

    'Variable declarations
    Dim a, b, c, d As Double
    Dim stanswer, ndanswer As Single

    Private Sub TextBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Click
        If TextBox1.Text = "a" Then
            TextBox1.Clear()
        Else
            TextBox1.Text = a
        End If
    End Sub

    Private Sub TextBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.Click
        If TextBox2.Text = "b" Then
            TextBox2.Clear()
        Else
            TextBox2.Text = b
        End If
    End Sub

    Private Sub TextBox3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.Click
        If TextBox3.Text = "c" Then
            TextBox3.Clear()
        Else
            TextBox3.Text = c
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        About.Show()
    End Sub

    'WHEN CHARACTERS INSTEAD OF NUMBERS ARE INPUTTED
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
            MsgBox("HEY BOSS!...That Was An Invalid Input...Please Input Numbers Only!", MessageBoxIcon.Exclamation, "ALERT!")
        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
            MsgBox("HEY BOSS!...That Was An Invalid Input...Please Input Numbers Only!", MessageBoxIcon.Exclamation, "ALERT!")
        End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
            MsgBox("HEY BOSS!...That Was An Invalid Input...Please Input Numbers Only!", MessageBoxIcon.Exclamation, "ALERT!")
        End If
    End Sub

    Private Sub TextBox6_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox6.Click
        MsgBox("HEY BOSS!...That's An Answer Box...Wait For Your Answers Here!", MessageBoxIcon.Exclamation, "ALERT!")
    End Sub

    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) = False Or True And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
            MsgBox("HEY BOSS!...That's An Answer Box...Wait For Your Answers Here!", MessageBoxIcon.Exclamation, "ALERT!")
        End If

    End Sub

    'CALCULATE BUTTON CLICKED
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'if the values of a, b or c are missing

        If TextBox1.Text = "a" Or TextBox2.Text = "b" Or TextBox3.Text = "c" Or TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("HEY BOSS!...Please fill in all the values of a, b and c.", MessageBoxIcon.Exclamation, "ALERT!")
            TextBox4.Text = ""
            TextBox6.Text = ""
        Else
            a = TextBox1.Text
            b = TextBox2.Text
            c = TextBox3.Text

            If a = 0 Then
                Beep()
                stanswer = ("Error")
                ndanswer = ("Error")
                MsgBox("HEY BOSS!..The Leading Coefficient 'a' Of Your Equation Must Be Any Value Besides Zero (0)..!", MessageBoxIcon.Information, "NOTICE!")
            End If

            'The quadratic formula
            d = ((b * b) - (4 * a * c))
            If d >= 0 Then
                stanswer = ((-b) + (d) ^ (1 / 2)) / (2 * a)
                ndanswer = ((-b) - (d) ^ (1 / 2)) / (2 * a)
                TextBox4.Text = stanswer
                TextBox6.Text = ndanswer

                'In case the values of x are equal
                If stanswer = ndanswer Then
                    Beep()
                    MessageBox.Show("HEY BOSS!...Please note that the possible values of x are the same, so the answer may be read as " & stanswer & " twice.", "NOTICE!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                'if the value of the determinant is negative
            ElseIf d < 0 Then
                TextBox4.Text = ("#ERROR!")
                TextBox6.Text = ("#ERROR!")
                MessageBox.Show("HEY BOSS!...This Quadratic equation has no real roots since the discriminant, 'b^2-4ac' is negative. It is impossible to find the square root of a negative value. Please try another one...", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        'when refresh button is clicked
        TextBox1.Text = "a"
        TextBox2.Text = "b"
        TextBox3.Text = "c"
        TextBox4.Text = ""
        TextBox6.Text = ""
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        'when EXIT button is clicked
        Beep()
        If MessageBox.Show("HEY BOSS!...Are you leaving so fast?", "EXIT!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class

