Imports System

Public Delegate Sub SwipeDetectedEventHandler(ByVal sender As Object, ByVal e As SwipeDetectedEventArgs)
Public Class SwipeDetectedEventArgs
    Inherits EventArgs
    Public Property SwipeDirection As String
    Public Property TouchY As Integer
    Public Sub New(direction As String)
        SwipeDirection = direction
    End Sub
    Public Sub New(pointy As Integer)
        TouchY = pointy
    End Sub
End Class

Public Class Touch_function

    Implements IMessageFilter

    Public Event SwipeDetected As SwipeDetectedEventHandler
    Public Event TouchPointY As SwipeDetectedEventHandler

    Private Const WM_LBUTTONDOWN As Integer = &H201 ' Maus-Linksklick-Nachricht
    Private Const WM_LBUTTONUP As Integer = &H202   ' Maus-Linksklicklos-Nachricht
    Dim startposy As Integer
    Dim endposy As Integer
    Dim startposx As Integer
    Dim endposx As Integer
    Public Function PreFilterMessage(ByRef m As Message) As Boolean Implements IMessageFilter.PreFilterMessage
        If m.Msg = WM_LBUTTONDOWN Then
            Dim mouse As Point = Cursor.Position
            startposy = mouse.Y
            startposx = mouse.X
        ElseIf m.Msg = WM_LBUTTONUP Then
            Dim mouse As Point = Cursor.Position
            endposy = mouse.Y
            endposx = mouse.X
            Dim diffy As Integer = endposy - startposy
            Dim diffx As Integer = endposx - startposx
            RaiseEvent TouchPointY(Me, New SwipeDetectedEventArgs(startposy))
            If diffy > 500 Then
                RaiseEvent SwipeDetected(Me, New SwipeDetectedEventArgs("Swipe Down Large"))
            ElseIf diffy > 300 Then
                RaiseEvent SwipeDetected(Me, New SwipeDetectedEventArgs("Swipe Down"))
            ElseIf diffy < -300 Then
                RaiseEvent SwipeDetected(Me, New SwipeDetectedEventArgs("Swipe Up"))
            ElseIf diffy < -500 Then
                RaiseEvent SwipeDetected(Me, New SwipeDetectedEventArgs("Swipe Up Tiny"))
            ElseIf diffx > 150 Then
                RaiseEvent SwipeDetected(Me, New SwipeDetectedEventArgs("Swipe Right"))
            ElseIf diffx < -200 Then
                RaiseEvent SwipeDetected(Me, New SwipeDetectedEventArgs("Swipe Left"))
            End If

        End If
        Return False
    End Function
End Class