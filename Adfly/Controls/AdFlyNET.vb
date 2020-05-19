Imports System.Runtime.InteropServices
Imports Microsoft.Win32
Imports System.Threading
Imports System.Text.RegularExpressions
Imports System.Text

<ComVisible(False)>
Public Class AdFlyNET
    Inherits WebBrowser

#Region " Properties "

    Dim _ClickerResult As ResultType = ResultType.Indeterminate
    Public ReadOnly Property ClickerResult As ResultType
        Get
            Return _ClickerResult
        End Get
    End Property

    Dim _LogResult As String = String.Empty
    Public ReadOnly Property LogResult As String
        Get
            Return _LogResult
        End Get
    End Property

#End Region

#Region " Types "

    Public Enum AgentType
        Mobile
        PC
    End Enum

    Public Enum CleckerType
        Image = 0
        Button = 1
    End Enum

    Public Enum ResultType
        Successful = 0
        IError = 1
        Indeterminate = 2
        No_Element = 3
    End Enum

#End Region

#Region " Private Methods "

    Private Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function

    Private Function Get_UserAgent(ByVal Type As AgentType) As String
        Dim UserAgent As New List(Of String)
        If Type = AgentType.Mobile Then

            UserAgent.AddRange({"User-Agent:Mozilla/5.0 (Linux; Android 4.0.1; Galaxy Nexus Build/IMM70B) AppleWebKit/535.19 (KHTML, like Gecko) Chrome/18.0.1025.133 Mobile Safari/" & GetRandom(0, 999) & "." & GetRandom(0, 99), _
                            "User-Agent:Mozilla/5.0 (Linux; Android 4.4; Galaxy Nexus Build/IMM79B) AppleWebKit/535.19 (KHTML, like Gecko) Chrome/18.0.1025.133 Mobile Safari/" & GetRandom(0, 999) & "." & GetRandom(0, 99), _
                            "User-Agent:Mozilla/5.0 (Linux; Android 4.0.2; Galaxy Nexus Build/IMM73B) AppleWebKit/535.19 (KHTML, like Gecko) Chrome/18.0.1025.133 Mobile Safari/" & GetRandom(0, 999) & "." & GetRandom(0, 99), _
                            "User-Agent:Mozilla/5.0 (Linux; Android 4.0.4; Galaxy Nexus Build/IMM74B) AppleWebKit/535.19 (KHTML, like Gecko) Chrome/18.0.1025.133 Mobile Safari/" & GetRandom(0, 999) & "." & GetRandom(0, 99), _
                            "User-Agent:Mozilla/5.0 (Linux; Android 4.0.4; Galaxy Nexus Build/IMM75B) AppleWebKit/535.19 (KHTML, like Gecko) Chrome/18.0.1025.133 Mobile Safari/" & GetRandom(0, 999) & "." & GetRandom(0, 99), _
                            "User-Agent:Mozilla/5.0 (Linux; Android 8.1.0; POCOPHONE F1 Build/OPM1.171019.012) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/68.0.3440.91 Mobile Safari/" & GetRandom(0, 999) & "." & GetRandom(0, 99), _
                            "User-Agent:Mozilla/5.0 (Linux; Android 4.2.2; HUAWEI P6-U07 Build/HuaweiP6-U06) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/33.0.1750.170 Mobile Safari/" & GetRandom(0, 999) & "." & GetRandom(0, 99), _
                            "User-Agent:Mozilla/5.0 (Linux; Android 4.4.2; SAMSUNG SM-G901F Build/KOT49H) AppleWebKit/537.36 (KHTML, like Gecko) Version/1.6 Chrome/28.0.1500.94 Mobile Safari/" & GetRandom(0, 999) & "." & GetRandom(0, 99), _
                            "User-Agent:Mozilla/5.0 (Linux; Android 4.3; SAMSUNG GT-I9505 Build/JSS15J) AppleWebKit/537.36 (KHTML, like Gecko) Version/1.5 Chrome/28.0.1500.94 Mobile Safari/" & GetRandom(0, 999) & "." & GetRandom(0, 99), _
                            "User-Agent:Mozilla/5.0 (Linux; Android 6.0.; SM-G925F Build/LMY48X; wv) AppleWebKit/537.36 (KHTML, like Gecko) Version/4.0 Chrome/47.0.2526.100 Mobile Safari/" & GetRandom(0, 999) & "." & GetRandom(0, 99), _
                            "User-Agent:Mozilla/5.0 (iPhone; CPU iPhone OS 9_2_1 like Mac OS X) AppleWebKit/601.1.46 (KHTML, like Gecko) Version/9.0 Mobile/13D16 Safari/" & GetRandom(0, 999) & "." & GetRandom(0, 9), _
                            "User-Agent:Mozilla/5.0 (iPhone; CPU iPhone OS 8_3 like Mac OS X) AppleWebKit/600.1.4 (KHTML, like Gecko) Version/8.0 Mobile/12F71 Safari/" & GetRandom(0, 999) & "." & GetRandom(0, 9) & "." & GetRandom(0, 9), _
                            "User-Agent:Mozilla/5.0 (iPhone; CPU iPhone OS 8_1 like Mac OS X) AppleWebKit/600.1.4 (KHTML, like Gecko) Version/8.0 Mobile/12B412 Safari/" & GetRandom(0, 999) & "." & GetRandom(0, 9) & "." & GetRandom(0, 9) & " (compatible; YandexMobileBot/3.0; +http://yandex.com/bots)", _
                            "User-Agent:Mozilla/5.0 (Linux; Android 4.4.2; SM-G900V Build/KOT49H) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/36.0.1985.135 Mobile Safari/" & GetRandom(0, 999) & "." & GetRandom(0, 99), _
                            "User-Agent:Mozilla/5.0 (Linux; Android 4.0.4; Galaxy Nexus Build/IMM75B) AppleWebKit/535.19 (KHTML, like Gecko) Chrome/18.0.1025.133 Mobile Safari/" & GetRandom(0, 999) & "." & GetRandom(0, 99), _
                            "User-Agent:Mozilla/5.0 (Linux; Android 4.0.4; Galaxy Nexus Build/IMM74B) AppleWebKit/535.19 (KHTML, like Gecko) Chrome/18.0.1025.133 Mobile Safari/" & GetRandom(0, 999) & "." & GetRandom(0, 99), _
                            "User-Agent:Mozilla/5.0 (iPhone; CPU iPhone OS 11_4_1 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Mobile/15G77", _
                            "User-Agent:Mozilla/5.0 (Linux; Android 4.0.4; Galaxy Nexus Build/IMM76B) AppleWebKit/535.19 (KHTML, like Gecko) Chrome/18.0.1025.133 Mobile Safari/" & GetRandom(0, 999) & "." & GetRandom(0, 99), _
                            "User-Agent:Mozilla/5.0 (Linux; Android 4.0.4; Galaxy Nexus Build/IMM77B) AppleWebKit/535.19 (KHTML, like Gecko) Chrome/18.0.1025.133 Mobile Safari/" & GetRandom(0, 999) & "." & GetRandom(0, 99), _
                            "User-Agent:Mozilla/5.0 (Linux; Android " & GetRandom(0, 9) & "." & GetRandom(0, 9) & "; Galaxy Nexus Build/IMM79B) AppleWebKit/535.19 (KHTML, like Gecko) Chrome/18.0.1025.133 Mobile Safari/" & GetRandom(0, 999) & "." & GetRandom(0, 99)})

            Return UserAgent(GetRandom(0, UserAgent.Count))

        ElseIf Type = AgentType.PC Then

            UserAgent.AddRange({"User-Agent: Mozilla / " & GetRandom(0, 9) & "." & GetRandom(0, 9) & " (Windows NT 6.1) AppleWebKit / " & GetRandom(0, 999) & "." & GetRandom(0, 99) & " (KHTML, como Gecko) Chrome / 28.0.1468.0 Safari / " & GetRandom(0, 999) & "." & GetRandom(0, 99)})

            Return UserAgent(GetRandom(0, UserAgent.Count))
        End If
    End Function

#End Region

#Region " Execution Time "

    ' [ Code Execution Time ]
    '
    ' Examples :
    ' Execution_Start() : Threading.Thread.Sleep(500) : Execution_End()

    Dim Execution_Watcher As New Stopwatch

    Private Sub Execution_Start()
        If Execution_Watcher.IsRunning Then Execution_Watcher.Restart()
        Execution_Watcher.Start()
    End Sub

    Private Sub Execution_End()
        If Execution_Watcher.IsRunning Then
            _LogResult += vbNewLine
            _LogResult += "          +Elapsed Time: " & Execution_Watcher.Elapsed.Hours & "h" & _
                            ":" & Execution_Watcher.Elapsed.Minutes & "m" & _
                            ":" & Execution_Watcher.Elapsed.Seconds & "s" & _
                            ":" & Execution_Watcher.Elapsed.Milliseconds & "ms" & vbNewLine & vbNewLine
            Execution_Watcher.Reset()
        Else


        End If
    End Sub

#End Region

    Private Function GetLang() As String
        Dim theUsecCulture As String = System.Globalization.CultureInfo.CurrentCulture.ToString
        Dim SepareLang As String() = theUsecCulture.Split("-")
        Return SepareLang(0)
    End Function

    Private Function GetIEDialogButtom(ByVal SystemLang As String) As String
        Dim IEButtonString As String = String.Empty
        If SystemLang = "es" Then
            IEButtonString = "&Permanecer en esta página"
        ElseIf SystemLang = "en" Then
            IEButtonString = "&Stay on this page"
        End If
        Return IEButtonString
    End Function

    Private tmrElapse As System.Windows.Forms.Timer = New System.Windows.Forms.Timer()

    Private tmrFormMonitor As System.Windows.Forms.Timer = New System.Windows.Forms.Timer()

    Private TypeC As CleckerType = CleckerType.Image

    Private LimitedSeconds As Integer = 0

    Public Sub Start(ByVal URL As String, ByVal ClickType As CleckerType, ByVal UserAgentType As AgentType, Optional ByVal SecondsLimit As Integer = 30)
        Try
            Execution_Start()
            TypeC = ClickType
            LimitedSeconds = SecondsLimit
            _LogResult = String.Empty
            _ClickerResult = ResultType.Indeterminate
            Me.Url = New Uri(URL)

            Dim UserAgentT As String = Get_UserAgent(UserAgentType)

            Me.Navigate(URL, False, Nothing, UserAgentT)
            _LogResult += "-----------------------------------------------------------------------------------------------------------" & vbNewLine
            _LogResult += "          +Start process for the Address: " & URL & vbNewLine
            _LogResult += "          +User-Agent Type: " & vbNewLine
            _LogResult += "# " & UserAgentT & vbNewLine & vbNewLine
            AddHandler Me.DocumentCompleted, AddressOf OnDocumentLoaded
        Catch ex As Exception
            ForceStop()
        End Try
    End Sub

    Public Sub ForceStop()
        Execution_End()
        _LogResult += "                   -Forcing Stop. " & vbNewLine
        _LogResult += "-----------------------------------------------------------------------------------------------------------" & vbNewLine
        _ClickerResult = ResultType.IError
    End Sub

    Private tStart As Thread
    Private tmr As System.Windows.Forms.Timer = New System.Windows.Forms.Timer()

    Public Sub New()
        '  Dim key As RegistryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", True)
        Dim name As String = AppDomain.CurrentDomain.FriendlyName

        '  If CObj(key.GetValue(name)) Is Nothing Then
        ' key.SetValue(name, 11001, RegistryValueKind.DWord)
        ' End If

        Dim RegKeyWrite As RegistryKey = Registry.CurrentUser
        RegKeyWrite = RegKeyWrite.CreateSubKey("Software\Microsoft\Internet Explorer\Styles")
        RegKeyWrite.SetValue("MaxScriptStatements", 0) '1000000000
        RegKeyWrite.Close()

        Dim RegKeyWrit As RegistryKey = Registry.CurrentUser
        RegKeyWrit = RegKeyWrit.CreateSubKey("Software\Microsoft\Internet Explorer\Styles")
        RegKeyWrit.SetValue("Use My Stylesheet", 0)
        RegKeyWrit.Close()

        'Dim RegKeyRead As RegistryKey = Registry.CurrentUser
        'RegKeyRead = RegKeyRead.OpenSubKey("Software\Microsoft\Internet Explorer\Styles")
        'Dim regSuccessful As [Object] = RegKeyRead.GetValue("MaxScriptStatements")
        'RegKeyRead.Close()

        Me.ScriptErrorsSuppressed = True
        AddHandler tmr.Tick, New System.EventHandler(AddressOf tmr_Tick)
        tmr.Interval = 100
        AddHandler tmrElapse.Tick, New System.EventHandler(AddressOf tmrElapse_Tick)
        tmrElapse.Interval = 100
        tmrElapse.Enabled = True
        AddHandler tmrFormMonitor.Tick, New System.EventHandler(AddressOf tmrFormMonitor_Tick)
        tmrFormMonitor.Interval = 100
        tmrFormMonitor.Enabled = True
    End Sub

    Private Const BM_CLICK As Integer = &HF5
    Private Const WM_ACTIVATE As Integer = &H6
    Private Const WA_ACTIVE As Integer = 1
    Private Const WM_LBUTTONDOWN As Integer = &H201
    Private Const WM_LBUTTONUP As Integer = &H202

    Private Sub tmrFormMonitor_Tick(ByVal sender As Object, ByVal e As EventArgs)
        Dim hwnd = FindWindow("#32770", "Windows Internet Explorer")
        If hwnd <> IntPtr.Zero Then
            GetChildWindows(hwnd)
            For i = 0 To children.Count - 1

                If children(i).ClassName = "Button" AndAlso children(i).Text = GetIEDialogButtom(GetLang) Then

                    SendMessage(children(i).hWnd, WM_ACTIVATE, WA_ACTIVE, 0)

                    SendMessage(children(i).hWnd, BM_CLICK, 0, 0)

                End If
            Next

        End If

        Dim hwndNew = FindWindow("#32770", "Explorador web")
        If hwndNew <> IntPtr.Zero Then
            GetChildWindows(hwndNew)
            For i = 0 To children.Count - 1

                If children(i).ClassName = "Button" AndAlso children(i).Text = "Cancel" Then

                    SendMessage(children(i).hWnd, WM_ACTIVATE, WA_ACTIVE, 0)

                    SendMessage(children(i).hWnd, BM_CLICK, 0, 0)

                End If
            Next

        End If
    End Sub

    Private Sub tmrElapse_Tick(ByVal sender As Object, ByVal e As EventArgs)
        If Not LimitedSeconds = 0 Then
            Dim TimeSecondElapse As Integer = Execution_Watcher.Elapsed.Seconds
            If TimeSecondElapse > LimitedSeconds Then
                Execution_End()
                _LogResult += "                   -Waiting Time Elapsed, Canceling Process. " & vbNewLine
                _LogResult += "-----------------------------------------------------------------------------------------------------------" & vbNewLine
                _ClickerResult = ResultType.IError
            End If
        End If
    End Sub

    Public Sub WebBrowser_NewWindow(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.NewWindow
        e.Cancel = True
    End Sub

    Public Sub OnDocumentLoaded(ByVal sender As Object, ByVal e As WebBrowserDocumentCompletedEventArgs)
        Try
            InjectAlertBlocker()
            tStart = New Thread(New ThreadStart(AddressOf OnCheckerLoad))
            tStart.Start()
        Catch __unusedException1__ As Exception
            tStart.Start()
        End Try
    End Sub

    Protected Overridable Sub OnCheckerLoad()
        On Error Resume Next
        Application.DoEvents()
        Thread.Sleep(100)
        Me.BeginInvoke(New MethodInvoker(Sub()
                                             tmr.Enabled = True
                                         End Sub))
    End Sub

    Private StartChecker As Boolean = False

    Private Sub tmr_Tick(ByVal sender As Object, ByVal e As EventArgs)
        On Error Resume Next
        Dim CountStatus As String = Me.Document.GetElementById("countdown").GetAttribute("innerText")
        Dim CountParse As Integer = Num(CountStatus)

        Dim CfErrorCode As String = Me.Document.GetElementById("cf-error-code").GetAttribute("innerText")

        Dim CfErrorType As String = Me.Document.GetElementById("cf-error-code").GetAttribute("innerText")

        If Not CfErrorCode = "" Then
            Execution_End()
            _LogResult += "                   -Access denied. | Error Code : " & CfErrorCode & vbNewLine
            _LogResult += "-----------------------------------------------------------------------------------------------------------" & vbNewLine
            _ClickerResult = ResultType.IError
        ElseIf CfErrorType = "Error" Then
            Execution_End()
            _LogResult += "                   -Access denied. " & vbNewLine
            _LogResult += "-----------------------------------------------------------------------------------------------------------" & vbNewLine
            _ClickerResult = ResultType.IError
        End If

        If CountParse = 5 Then
            StartChecker = True
        End If

        If StartChecker = True Then
            If CountParse = 0 Then
                _LogResult += "                   -Detecting AdFly Timeout in 0 seconds." & vbNewLine
                _LogResult += "                   -Starting the Click Engine = " & GetObject(TypeC).ToString & vbNewLine
                Dim ObjectsForClick As Integer = 0
                If TypeC = CleckerType.Image Then
                    Dim col As HtmlElementCollection
                    Dim ele As HtmlElement

                    col = Me.Document.GetElementsByTagName("img")

                    For Each ele In col
                        If ele.GetAttribute("alt") = "Skip Ad" Then
                            ele.InvokeMember("click")
                            ObjectsForClick += 1
                            StartChecker = False
                        End If
                    Next
                ElseIf TypeC = CleckerType.Button Then
                    For Each hem As HtmlElement In Me.Document.All
                        If hem.GetAttribute("id").Contains("skip_bu2tton") Then
                            hem.InvokeMember("Click")
                            ObjectsForClick += 1
                            StartChecker = False
                        End If
                    Next
                End If
                If ObjectsForClick = 0 Then
                    Execution_End()
                    _LogResult += "                   -No Objects Found." & vbNewLine
                    _LogResult += "-----------------------------------------------------------------------------------------------------------" & vbNewLine
                    _ClickerResult = ResultType.IError
                Else
                    Execution_End()
                    _LogResult += "                   -Finished Processes, Detected Objects: = " & ObjectsForClick & vbNewLine
                    _LogResult += "                   -Clicked Correctly." & vbNewLine
                    _LogResult += "-----------------------------------------------------------------------------------------------------------" & vbNewLine
                    ObjectsForClick = 0
                    _ClickerResult = ResultType.Successful
                End If
            End If
        End If

    End Sub

    Private Sub InjectAlertBlocker()
        Dim head As HtmlElement = Me.Document.GetElementsByTagName("head")(0)
        Dim scriptEl As HtmlElement = Me.Document.CreateElement("script")
        Dim element As mshtml.IHTMLScriptElement = CType(scriptEl.DomElement, mshtml.IHTMLScriptElement)
        Dim alertBlocker As String = "window.alert = function () { }"
        element.text = alertBlocker
        head.AppendChild(scriptEl)
    End Sub

    Private Function Num(ByVal value As String) As Integer
        Dim returnVal As String = String.Empty
        Dim collection As MatchCollection = Regex.Matches(value, "\d+")
        For Each m As Match In collection
            returnVal += m.ToString()
        Next
        Return Convert.ToInt32(returnVal)
    End Function

End Class

Module ModChildren
    Public Class ChldInfo
        Public hWnd As IntPtr
        Public ClassName As String
        Public Text As String
        Public Sub New(hwnd As IntPtr, clsname As String, text As String)
            Me.hWnd = hwnd
            Me.ClassName = clsname
            Me.Text = text
        End Sub
    End Class
    Public children As List(Of ChldInfo)

    Public Sub GetChildWindows(ByVal hwnd As IntPtr)
        children = New List(Of ChldInfo)
        EnumChildWindows(hwnd, AddressOf EnumProc, Nothing)
    End Sub

    Public Const BM_CLICK As Integer = &HF5
    Public Const WM_ACTIVATE As Integer = &H6
    Public Const WA_ACTIVE As Integer = 1

    <DllImport("user32.dll", CharSet:=CharSet.Auto, EntryPoint:="FindWindow")> _
    Public Function FindWindow(ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr
    End Function

    <DllImport("user32.dll", EntryPoint:="SendMessage")> _
    Public Function SendMessage(hwnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer) As IntPtr
    End Function

    ' private...
    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Private Sub GetClassName(ByVal hWnd As System.IntPtr, ByVal lpClassName As StringBuilder, ByVal nMaxCount As Integer)
    End Sub

    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
    Private Function GetWindowText(ByVal hwnd As IntPtr, ByVal lpString As StringBuilder, ByVal cch As Integer) As Integer
    End Function

    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
    Private Function GetWindowTextLength(ByVal hwnd As IntPtr) As Integer
    End Function

    Private Delegate Function EnumCallBackDelegate(ByVal hwnd As IntPtr, ByVal lParam As IntPtr) As Integer
    Private Declare Function EnumChildWindows Lib "user32" (ByVal hWndParent As IntPtr, ByVal lpEnumFunc As EnumCallBackDelegate, ByVal lParam As IntPtr) As IntPtr

    Private Function EnumProc(ByVal hwnd As IntPtr, ByVal lParam As IntPtr) As Int32
        If hwnd <> IntPtr.Zero Then
            children.Add(New ChldInfo(hwnd, Get_ClassName(hwnd), GetText(hwnd)))
        End If
        Return 1
    End Function

    Private Function Get_ClassName(ByVal hWnd As IntPtr) As String
        Dim sbClassName As New StringBuilder("", 256)
        Call GetClassName(hWnd, sbClassName, 256)
        Return sbClassName.ToString
    End Function

    Private Function GetText(ByVal hWnd As IntPtr) As String
        Dim length As Integer = GetWindowTextLength(hWnd)
        If length = 0 Then Return ""
        Dim sb As New StringBuilder("", length + 1)
        GetWindowText(hWnd, sb, sb.Capacity)
        Return sb.ToString()
    End Function

End Module
