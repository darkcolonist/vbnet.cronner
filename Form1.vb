Imports System.Net
Imports System.IO
Imports System.Collections.Specialized

Public Class Form1

    Private consoleLimit = 100

    Private barText As String = "=========================================================================================="

    Private threads As Int16 = 0

    Private lines As List(Of UrlLine)

    Private Sub addExecutionToHistory()
        ' TODO: implement me
    End Sub

    Private Sub reloadHistoryDropdown()
        If Not My.Settings.history Is Nothing Then
            For Each line In My.Settings.history
                ' tsiHistory.DropDownItems.Add(line)
            Next
        End If

    End Sub

    Private Sub btnExecute_Click(sender As Object, e As EventArgs) Handles btnExecute.Click
        Me.lines = New List(Of UrlLine)

        ' populate the lines
        Dim tmpLines = txtInput.Lines

        Dim isValid = True

        If txtInput.Text.Trim = "" Then
            isValid = False
        End If

        For Each line In tmpLines
            If Not line.Trim = "" Then
                Dim lineArr = line.Split(New Char() {","c})
                Dim urlLine = New UrlLine()
                Dim interval As Integer

                If lineArr.ToArray.Length >= 2 _
                    And Integer.TryParse(lineArr(1), interval) Then
                    urlLine.url = lineArr(0)
                    urlLine.interval = interval
                    urlLine.stepInterval = interval

                    Me.lines.Add(urlLine)
                Else
                    isValid = False
                End If
            End If
        Next

        ' validate
        If (isValid) Then
            My.Settings.history = txtInput.Text

            txtInput.Enabled = False
            btnStop.Enabled = True
            btnExecute.Enabled = False
            dgvConsole.Rows.Clear()
            txtLastExecuted.Text = "execution started: " & getTimestamp()
            dgvConsole.Rows.Insert(0, getTimestamp(), "", "execution started")

            timIterator.Enabled = True

            Me.initializeDgvLines()

            Me.addExecutionToHistory()
        Else
            Dim errorMsg As String =
                "there's a problem with the input you have provided!" + Environment.NewLine + _
                Environment.NewLine + _
                "please try something like:" + Environment.NewLine + _
                "http://dev.loop/messaging/routine/i_run_batch,5" + Environment.NewLine + _
                "http://dev.loop/messaging/routine/i_map_operators,5" + _
                Environment.NewLine + _
                Environment.NewLine + _
                "where: <url>,<interval>"
            MessageBox.Show(errorMsg, "unable to process your request", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Function getStuff() As String
        Return "lol u mad?"
    End Function

    Function getTimestamp()
        Dim time As DateTime = DateTime.Now
        Dim format As String = "h:mm:sst"
        Return time.ToString(format)
    End Function


    Private Sub prependToConsole(ByVal console_text As String, ByVal url As String)
        Dim formattedTime = getTimestamp()

        Dim formattedConsoleText = console_text

        formattedConsoleText = formattedConsoleText.Replace(vbCr, "")

        If console_text.Length > 255 Then
            formattedConsoleText = console_text.Substring(0, 255) + " [trailing text omitted]"
        End If

        If dgvConsole.InvokeRequired Or txtLastExecuted.InvokeRequired Then
            dgvConsole.Invoke(New Action(Of String, String)(AddressOf prependToConsole), {console_text, url})
        Else
            ' txtConsole.Text = formattedTime + ": " + formattedConsoleText + Environment.NewLine + txtConsole.Text

            dgvConsole.Rows.Insert(0, formattedTime, url, formattedConsoleText)

            If dgvConsole.Rows.Count = consoleLimit + 1 Then
                dgvConsole.Rows.RemoveAt(dgvConsole.Rows.Count - 1)
            End If

            If Not url = "" Then
                formattedConsoleText = formattedTime + ": execution results for " + url + _
                    Environment.NewLine() + _
                    barText + _
                    Environment.NewLine() + _
                    console_text
            End If
            txtLastExecuted.Text = formattedConsoleText
        End If
    End Sub


    'Private Overloads Sub prependToConsole(ByVal console_text As String)
    '    prependToConsole(console_text, "")
    'End Sub

    Private Sub setLineRunningStatusInDgv(ByVal line As UrlLine)
        'Dim theCol = dgvLines.Rows.Item(line.dgvRowIndex).Cells("colIsRunning")

        'If theCol.inv Then
        If dgvLines.InvokeRequired Then
            dgvLines.Invoke(New Action(Of UrlLine)(AddressOf setLineRunningStatusInDgv), line)
        Else
            dgvLines.Rows.Item(line.dgvRowIndex).Cells("colIsRunning").Value = If(line.currentRunning, "yes", "no")
        End If
    End Sub

    Private Sub urlCall(line As UrlLine)
        Try
            line.currentRunning = True
            setLineRunningStatusInDgv(line)

            urlCallExecute(line.url)

        Catch err As System.Net.WebException
            prependToConsole("failed to call: " + line.url, line.url)
        Finally
            line.currentRunning = False
            setLineRunningStatusInDgv(line)
        End Try
    End Sub

    Private Sub urlCallExecute(url As String)
        Try
            txtStatus.Text = "current: " & url & " (threads: " & Me.threads & ")"

            Dim myReq As HttpWebRequest = WebRequest.Create(url)
            Dim theResponse As HttpWebResponse = myReq.GetResponse()
            Dim theStream As Stream = theResponse.GetResponseStream()
            Dim reader As New StreamReader(theStream)

            txtStatus.Text = "ready"

            prependToConsole(reader.ReadToEnd, url)
        Catch ex As Exception
            prependToConsole("...err?", "")
        Finally
            Me.threads -= 1
        End Try
    End Sub

    Private Sub timIterator_Tick(sender As Object, e As EventArgs) Handles timIterator.Tick
        For Each line As UrlLine In Me.lines
            If line.stepInterval = 0 Then
                Dim thr As New Threading.Thread(AddressOf urlCall)
                thr.Start(line)

                Me.threads += 1

                line.stepInterval = line.interval
                line.executions += 1
                dgvLines.Rows.Item(line.dgvRowIndex).Cells("colExecutionCount").Value = line.executions
            Else
                If line.currentRunning = False Then
                    line.stepInterval -= 1
                End If
            End If
            dgvLines.Rows.Item(line.dgvRowIndex).Cells("colTimeLeft").Value = line.stepInterval
        Next
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        dgvConsole.Rows.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        txtInput.Enabled = True
        timIterator.Enabled = False
        btnStop.Enabled = False
        btnExecute.Enabled = True
    End Sub

    Private Sub initializeDgvLines()
        dgvLines.Rows.Clear()

        For Each line As UrlLine In Me.lines
            Dim dgvIndex As Integer = dgvLines.Rows.Add()
            line.dgvRowIndex = dgvIndex
            dgvLines.Rows.Item(dgvIndex).Cells("colUrl").Value = line.url
            dgvLines.Rows.Item(dgvIndex).Cells("colTime").Value = line.stepInterval
            dgvLines.Rows.Item(dgvIndex).Cells("colExecute").Value = "run"
        Next
    End Sub

    Private Sub tsiAbout_Click(sender As Object, e As EventArgs) Handles tsiAbout.Click
        Dim version As String = "TESTING"
        If (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed) Then
            With System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion
                version = "v" & .Major & "." & .Minor & "." & .Build & " r" & .Revision
            End With
        End If

        MessageBox.Show(
            "/**" + vbNewLine + _
            " * @title: Dc.Cronner" + vbNewLine + _
            " * @author: Christian Noel Reyes <darkcolonist@gmail.com>" + vbNewLine + _
            " * @description: A program that automates WGET, kinda similar to CRONtab for " + vbNewLine + _
            " *              linux only that this is for windows." + vbNewLine + _
            " * @date: 2014-08-07" + vbNewLine + _
            " * @version: " + version + vbNewLine + _
            " */",
            "About",
        MessageBoxButtons.OK
        )
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' TODO implement stored data first
        ' Me.reloadHistoryDropdown()
        txtHover.Text = ""
        If Not My.Settings.history.Trim = "" Then
            txtInput.Text = My.Settings.history
        End If
    End Sub

    Private Sub dgvLines_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLines.CellContentClick
        If e.ColumnIndex = 5 Then
            Dim url As String
            url = Me.dgvLines.Item(0, e.RowIndex).Value()

            txtLastExecuted.Text = "executing: " + url

            Dim thr As New Threading.Thread(AddressOf urlCallExecute)
            thr.Start(url)

            Me.threads += 1
        End If
    End Sub

    Private Sub dgvLines_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLines.CellMouseEnter
        If e.RowIndex <> -1 Then
            Dim url As String
            url = Me.dgvLines.Item(0, e.RowIndex).Value()

            txtHover.Text = url
        End If
    End Sub

    Private Sub dgvLines_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLines.CellMouseLeave
        txtHover.Text = ""
    End Sub

    Private Sub txtStatus_Click(sender As Object, e As EventArgs) Handles txtStatus.Click
        MessageBox.Show("running instances: " & Me.threads)
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.threads > 0 Then
            MessageBox.Show("there are still some running instances. please try again after 5 seconds.")
            btnStop.PerformClick()
            e.Cancel = True
        End If
    End Sub
End Class

Public Class UrlLine
    Public url As String
    Public interval As Integer
    Public stepInterval As Integer
    Public executions As Integer
    Public currentRunning As Boolean
    Public dgvRowIndex As Integer

    Public Sub New()
        Me.currentRunning = False
        Me.executions = 0
        Me.currentRunning = 0
    End Sub
End Class
