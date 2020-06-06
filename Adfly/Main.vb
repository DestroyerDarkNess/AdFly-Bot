Imports System.Threading
Imports System.IO
Imports Microsoft.Win32
Public Class Main

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
    End Sub

    Dim VisitNumb As Integer = 0
    Dim VitErrors As Integer = 0
    Dim attemp As Integer = 1

    Private Sub DevButton1_Click(sender As Object, e As EventArgs) Handles DevButton1.Click
        ResetC()
        Procexxor()
    End Sub

    Public Sub ResetC()
        VisitNumb = 0
        VitErrors = 0
        attemp = 1
    End Sub


    Public Sub Procexxor()

        LogTextBox.Text += ">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Attemp = " & attemp & vbNewLine
        LogTextBox.Text += ">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Loading ... | Please wait." & vbNewLine
        LogTextBox.Select(LogTextBox.Text.Length, 0)
        LogTextBox.ScrollToCaret()

        Dim ClickMethod As AdFlyNET.CleckerType = AdFlyNET.CleckerType.Image 'Defaul Method

        Dim UAgent As AdFlyNET.AgentType = AdFlyNET.AgentType.Mobile 'Defaul User Agent

        Select Case ComboBox2.SelectedIndex
            Case 0
                ClickMethod = AdFlyNET.CleckerType.Image
            Case 1
                ClickMethod = AdFlyNET.CleckerType.Button
        End Select

        Select Case ComboBox1.SelectedIndex
            Case 0
                UAgent = AdFlyNET.AgentType.Mobile
            Case 1
                UAgent = AdFlyNET.AgentType.PC
        End Select

        AdFlyNET1.Start(UrlTextBox.Text, ClickMethod, UAgent, DevNumeric1.Value)

        ProcesorMonitor.Enabled = True

    End Sub

    Private Sub ProcesorMonitor_Tick(sender As Object, e As EventArgs) Handles ProcesorMonitor.Tick

        If AdFlyNET1.ClickerResult = AdFlyNET.ResultType.IError Then
            VitErrors += 1
            attemp += 1
            LogTextBox.Text += AdFlyNET1.LogResult & vbNewLine
            Procexxor()
        ElseIf AdFlyNET1.ClickerResult = AdFlyNET.ResultType.Successful Then
            VisitNumb += 1
            attemp += 1
            LogTextBox.Text += AdFlyNET1.LogResult & vbNewLine
            Procexxor()
        End If

        ErrorLabel.Text = VitErrors
        VisitNumbLabel.Text = VisitNumb

    End Sub

    Private Sub DevButton3_Click(sender As Object, e As EventArgs) Handles DevButton3.Click
        AdFlyNET1.ForceStop()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        For i As Integer = 0 To Application.OpenForms.Count - 1
            Dim form As Form = Application.OpenForms(i)
            If Not form.Name = Me.Name Then
                MsgBox(form.Name)
                form.DialogResult = Windows.Forms.DialogResult.OK
                i -= 1
            End If
        Next
    End Sub

    Private Sub DevButton4_Click(sender As Object, e As EventArgs) Handles DevButton4.Click
        ProcesorMonitor.Enabled = False
        AdFlyNET1.ForceStop()
    End Sub

End Class