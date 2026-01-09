Imports System.Management
Imports System.Net
Imports System.Reflection.Emit
Imports System.Runtime.InteropServices
Imports Touch_Gesture_Recognition_System

'AlwaysOn Form missing for Fintou, will be added shortly

Public Class MainScreen

    ' Windows API Funktionen
    <DllImport("user32.dll")>
    Private Shared Function SendMessage(hWnd As IntPtr, Msg As UInteger, wParam As IntPtr, lParam As IntPtr) As IntPtr
    End Function

    Private Const WM_SYSCOMMAND As UInteger = &H112
    Private Shared ReadOnly SC_MONITORPOWER As IntPtr = CType(&HF170, IntPtr)

    ' Bildschirm ausschalten
    Private Sub TurnOffScreen()
        SendMessage(Me.Handle, WM_SYSCOMMAND, SC_MONITORPOWER, CType(2, IntPtr))
    End Sub

    ' Bildschirm einschalten
    Private Sub TurnOnScreen()
        SendMessage(Me.Handle, WM_SYSCOMMAND, SC_MONITORPOWER, CType(-1, IntPtr))
    End Sub

    Private watcher As ManagementEventWatcher

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As New WqlEventQuery("SELECT * FROM Win32_PowerManagementEvent")
        watcher = New ManagementEventWatcher(query)
        AddHandler watcher.EventArrived, AddressOf PowerEventArrived
        watcher.Start()
    End Sub
    Private Sub PowerEventArrived(sender As Object, e As EventArrivedEventArgs)
        ' EventType 10 = Power Button pressed
        Dim eventType As Integer = Convert.ToInt32(e.NewEvent.Properties("EventType").Value)
        If eventType = 10 Then
            MessageBox.Show("Powerbutton wurde gedrückt!")
        End If
    End Sub

    <DllImport("user32.dll")>
    Private Shared Function FindWindow(lpClassName As String, lpWindowName As String) As IntPtr
    End Function
    <DllImport("user32.dll")>
    Private Shared Function ShowWindow(hWnd As IntPtr, nCmdShow As Integer) As Boolean
    End Function
    Const SW_SHOW = 5

    Private mouseFilter As Touch_function
    Dim TouchPoint As Boolean
    Dim EndPoint As Boolean
    Dim isdraging As Boolean
    Dim ChargingStatus As Boolean = True
    Dim LowStatus As Boolean = False
    Dim ChargingStart As Boolean

    Private Sub SwipeDetectedHandler(ByVal sender As Object, ByVal e As SwipeDetectedEventArgs)
        If e.SwipeDirection = "Swipe Up" Then
            If TouchPoint And EndPoint Then
                My.Computer.Audio.Play("C:\KAVN\Resources\media.arc\UI\ve_poppingcolours_unlock.wav")
                Me.Hide()
            End If
        End If
    End Sub

    Public ClockCount As Integer = 0
    Dim CurrentPointerX As Integer
    Dim CurrentPointerY As Integer

    Private Sub System_Timer_Tick(sender As Object, e As EventArgs) Handles System_Timer.Tick
        ClockCount = ClockCount + 1
        Clock_Hours.Text = DateAndTime.Now.ToString("HH")
        Clock_Minutes.Text = DateAndTime.Now.ToString("mm")
        Clock_Date.Text = DateAndTime.Now.ToString("dd. MMMM")
        'AlwaysOn.Clock_Hours.Text = DateAndTime.Now.ToString("HH")
        'AlwaysOn.Clock_Minutes.Text = DateAndTime.Now.ToString("mm")
        'AlwaysOn.Date_Today.Text = DateAndTime.Now.ToString("dd. MMMM")
        If ClockCount > 60 Then
            'AlwaysOn.Clock_Hours.Visible = False
            'AlwaysOn.Clock_Minutes.Visible = False
            'AlwaysOn.Date_Today.Visible = False
            'AlwaysOn.Device_Name.Visible = False
            'AlwaysOn.Opacity = 0
            Me.Show()
            ClockCount = 0
            TurnOffScreen()
        ElseIf ClockCount > 40 Then
            'AlwaysOn.Clock_Hours.Visible = True
            'AlwaysOn.Clock_Minutes.Visible = True
            'AlwaysOn.Date_Today.Visible = True
            'AlwaysOn.Device_Name.Visible = True
            'Do Until AlwaysOn.Opacity = 1
            'AlwaysOn.Opacity += 0.1
            'AlwaysOn.Refresh()
            'System.Threading.Thread.Sleep(10)
            'Loop
        ElseIf ClockCount > 30 Then
            'AlwaysOn.Clock_Hours.Visible = False
            'AlwaysOn.Clock_Minutes.Visible = False
            'AlwaysOn.Date_Today.Visible = False
            'AlwaysOn.Device_Name.Visible = False
            'AlwaysOn.Show()
            'AlwaysOn.TopMost = True
            'Do Until AlwaysOn.Opacity = 0.6
            'AlwaysOn.Opacity += 0.05
            'AlwaysOn.Refresh()
            'System.Threading.Thread.Sleep(10)
            'Loop
            'AlwaysOn.Pointer.Start()
        End If
    End Sub

    Private Sub Pointer_Tick(sender As Object, e As EventArgs) Handles Pointer.Tick
        If Not CurrentPointerX = MousePosition.X Or Not CurrentPointerY = MousePosition.Y Then
            ClockCount = 0
            TurnOnScreen()
        End If
        CurrentPointerX = MousePosition.X
        CurrentPointerY = MousePosition.Y
    End Sub

    Private Sub Lockscreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.WindowState = FormWindowState.Normal
        Me.FormBorderStyle = FormBorderStyle.None

        mouseFilter = New Touch_function()
        Application.AddMessageFilter(mouseFilter)
        AddHandler mouseFilter.SwipeDetected, AddressOf SwipeDetectedHandler
        Me.TopMost = True

        Dim hwnd As IntPtr = FindWindow(Nothing, "") ' Fenster-Titel
        If hwnd <> IntPtr.Zero Then

        Else
            Try
                'Process.Start("C:\XDesk Touch\XDesk Touch\bin\Debug\net9.0-windows\XDesk Touch.exe")
                'Replace 
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub SwipeHandler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = My.Computer.Screen.Bounds.Width
        Me.Height = My.Computer.Screen.Bounds.Height
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point(0, 0)

        AddHandler Me.MouseDown, AddressOf Form_MouseDown
        AddHandler Me.MouseUp, AddressOf Form_MouseUp
        AddHandler Me.MouseMove, AddressOf Form_MouseMove
        For Each ctrl As Control In GetAllControls(Me)
            AddHandler ctrl.MouseDown, AddressOf Form_MouseDown
            AddHandler ctrl.MouseUp, AddressOf Form_MouseUp
            AddHandler ctrl.MouseMove, AddressOf Form_MouseMove
        Next
    End Sub

    Private Function GetAllControls(ByVal parent As Control) As IEnumerable(Of Control)
        Dim controls As New List(Of Control)
        For Each ctrl As Control In parent.Controls
            controls.Add(ctrl)
            controls.AddRange(GetAllControls(ctrl))
        Next
        Return controls
    End Function

    Private Sub Form_MouseDown(sender As Object, e As MouseEventArgs)
        Dim y As Integer = Cursor.Position.Y
        If y > My.Computer.Screen.Bounds.Height - 200 Then
            TouchPoint = True
            If Not isdraging Then
                My.Computer.Audio.Play("C:\KAVN\Resources\media.arc\UI\ve_poppingcolours_tap.wav")
            End If
            isdraging = True
        Else
            TouchPoint = False
        End If
    End Sub

    Private Sub Form_MouseUp(sender As Object, e As MouseEventArgs)
        Dim y As Integer = Cursor.Position.Y
        EndPoint = True
        isdraging = False
    End Sub

    Private Sub Form_MouseMove(sender As Object, e As MouseEventArgs)
        Dim y As Integer = Cursor.Position.Y
        If isdraging Then
            Me.Top = y - Me.Height + 50
        Else
            Me.Top = 0
        End If
    End Sub

    Private Sub Battery_Status_Tick(sender As Object, e As EventArgs) Handles Battery_Status.Tick
        UpdateOpacityBasedOnPosition()
        Dim powerStatus As PowerStatus = SystemInformation.PowerStatus
        Dim batteryLifePercent As Single = powerStatus.BatteryLifePercent * 100
        Dim batteryLifePercentRounded As Integer = Math.Round(batteryLifePercent)
        Dim chargingStatus As PowerLineStatus = powerStatus.PowerLineStatus
        Dim batteryLifeRemaining As Integer = powerStatus.BatteryLifeRemaining

        If chargingStatus = PowerLineStatus.Online Then
            Dim remainingPercent As Integer = 100 - batteryLifePercentRounded
            LowStatus = False
            If Not ChargingStart Then
                My.Computer.Audio.Play("C:\KAVN\Resources\media.arc\UI\ChargerPluggedIn.wav")
                ChargingStart = True
            End If
            If batteryLifeRemaining > 0 And remainingPercent > 0 Then
                Dim remainingTime As Integer = (batteryLifeRemaining * remainingPercent) / batteryLifePercentRounded
                Dim minutes As Integer = remainingTime \ 60
                Dim seconds As Integer = remainingTime Mod 60
                Battery_Percent.Text = String.Format("Charging {0}%, {1} hour(s) and {2} minute(s)", batteryLifePercentRounded, minutes, seconds)
            Else
                Battery_Percent.Text = String.Format("Charging {0}%", batteryLifePercentRounded)
            End If
        ElseIf chargingStatus = PowerLineStatus.Offline Then
            If chargingStatus Then
                chargingStatus = False
            End If
            ChargingStart = False
            Battery_Percent.Text = String.Format("{0}%", batteryLifePercentRounded)
            If batteryLifePercentRounded <= 20 Then
                If Not LowStatus Then
                    My.Computer.Audio.Play("C:\KAVN\Resources\media.arc\UI\LowBattery.wav")
                End If
                LowStatus = True
            End If
        End If

    End Sub
    Private Sub Lockscreen_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        TouchPoint = False
        EndPoint = False
        isdraging = False
        If Me.Visible = False Then
            Dim hwnd As IntPtr = FindWindow(Nothing, "") ' Fenster-Titel - Correction missing
            If hwnd <> IntPtr.Zero Then

            Else
                Try
                    'Process.Start("C:\XDesk Touch\XDesk Touch\bin\Debug\net9.0-windows\XDesk Touch.exe")
                    'Replacing with Fintou variant of the UI
                    'Missing CDM
                Catch ex As Exception

                End Try
            End If
            Me.Width = My.Computer.Screen.Bounds.Width
            Me.Height = My.Computer.Screen.Bounds.Height
            Me.StartPosition = FormStartPosition.Manual
            Me.Location = New Point(0, 0)
            Me.TopMost = True
        End If
    End Sub

    Private Sub UpdateOpacityBasedOnPosition()
        Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        ' Y-Position der Maus relativ zum Bildschirm
        Dim cursorY As Integer = Cursor.Position.Y
        ' Verhältnis berechnen (0 = ganz oben, 1 = ganz unten)
        Dim ratio As Double = cursorY / screenHeight
        ' Begrenzen zwischen 0.0 und 1.0
        ratio = Math.Max(0.0, Math.Min(1.0, ratio))
        ' Sichtbarkeit setzen
        If isdraging Then
            Me.Opacity = Math.Max(0.25, ratio)
        Else
            Me.Opacity = 1
        End If
    End Sub
End Class
