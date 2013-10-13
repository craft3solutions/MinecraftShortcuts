Public Class Form1
    Dim Type As Integer
    Dim FormAction As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim IsSelected As Boolean = Me.RadioButton1.Checked Or Me.RadioButton2.Checked

        If IsSelected Then
            Me.Button1.Enabled = True

            If Me.RadioButton1.Checked = True Then
                Type = 1
            ElseIf Me.RadioButton2.Checked = True Then
                Type = 2
            End If
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Dim IsSelected As Boolean = Me.RadioButton1.Checked
        Type = 1
        If IsSelected Then
            Me.Button1.Enabled = True
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Dim IsSelected As Boolean = Me.RadioButton2.Checked
        Type = 2
        If IsSelected Then
            Me.Button1.Enabled = True
        End If
    End Sub

    Private Sub RadioButton2_Click(sender As Object, e As EventArgs) Handles RadioButton2.Click
        
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If Me.CheckBox1.Checked = True Then
            Me.RadioButton1.Enabled = False
            Me.RadioButton2.Enabled = False

            Me.RadioButton3.Enabled = True
            Me.RadioButton4.Enabled = True
            Me.RadioButton5.Enabled = True
        Else
            Me.RadioButton1.Enabled = True
            Me.RadioButton2.Enabled = True

            Me.RadioButton3.Enabled = False
            Me.RadioButton4.Enabled = False
            Me.RadioButton5.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Button1.Text = "Launching..."
        Dim LoadedAll As Boolean = Me.CheckBox1.Checked
        Dim title As String = "Starting Minecraft"

        If LoadedAll = True Then
            Dim msg As String = "Starting Modules"
            MsgBox(msg, MsgBoxStyle.Information, title)

            If FormAction = Nothing Then
                System.Diagnostics.Process.Start("C:\Minecraft_1_5.exe")
                System.Diagnostics.Process.Start("C:\Minecraft.exe")
            ElseIf FormAction = "FstToLst" Then
                System.Diagnostics.Process.Start("C:\Minecraft_1_5.exe")
                System.Diagnostics.Process.Start("C:\Minecraft.exe")
            ElseIf FormAction = "Rndm" Then
                Dim rand As Random = New Random
                Dim r As Integer
                r = rand.Next(200)

                If r < 101 Then
                    System.Diagnostics.Process.Start("C:\Minecraft.exe")
                ElseIf r > 100 Then
                    System.Diagnostics.Process.Start("C:\Minecraft_1_5.exe")
                End If

            ElseIf FormAction = "LstToFst" Then
                System.Diagnostics.Process.Start("C:\Minecraft_1_5.exe")
                System.Diagnostics.Process.Start("C:\Minecraft.exe")
            End If

        End If

        If Type = 1 And LoadedAll = False Then
            Dim msg As String = "Starting " + Me.RadioButton1.Text
            MsgBox(msg, MsgBoxStyle.Information, title)
            System.Diagnostics.Process.Start("C:\Minecraft_1_5.exe")
        ElseIf Type = 2 And LoadedAll = False Then
            Dim msg As String = "Starting " + Me.RadioButton2.Text
            MsgBox(msg, MsgBoxStyle.Information, title)
            System.Diagnostics.Process.Start("C:\Minecraft.exe")
        End If

        Me.Close()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        FormAction = "FstToLst"
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        FormAction = "Rndm"
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        FormAction = "LstToFst"
    End Sub
End Class
