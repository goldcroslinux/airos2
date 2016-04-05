Imports System.Runtime.InteropServices

Public Class OSAppBase
    'Base of interaction between OS and App.

    Public MyServer As air_os.PipeServer
    Public MyClient As air_os.PipeClient
    Public MyProcess As Process
    Public MyName As String = ""
    Public WithEvents MyTimer As New Timer
    Public MyTBItem As TaskbarItem

    Public Sub New(path As String)

    End Sub


    <DllImport("user32.dll")> _
    Private Shared Function SetParent(hWndChild As IntPtr, hWndNewParent As IntPtr) As IntPtr
    End Function

    Public Sub Dispose()

        'If MyProcess.Responding Then
        '    MyProcess.CloseMainWindow()
        'Else
        MyProcess.Kill()
        'End If
        MyProcess.Kill()
        SendMessage("close")
        MyProcess.Dispose()
        MyServer.Close()

        MyTBItem.Dispose()
        MyTimer.Dispose()
    End Sub

    Public Sub SendMessage(message As String)
        MyClient.Send(message, "airos_to_app_" + MyName, 2000)
    End Sub

    Public Sub RecievedMessage(message As String)

        Dim command As String = message.Split("|")(0)
        Dim arg As String() = "".Split("")
        Try
            arg = message.Split("|")(1).Split("^")
        Catch ex As Exception : End Try
        Desktop.GetDesktopHandle.BeginInvoke(Sub(comm, args)
                                                 ExecuteCommand(comm, arg)
                                             End Sub, command, arg)
    End Sub

    Public Delegate Sub ExecuteCommandDel(comm As String, args As String())
    Public MyExecuteCommDel = New ExecuteCommandDel(AddressOf ExecuteCommand)

    Public Sub ExecuteCommand(comm As String, args As String())
        MsgBox(comm)
        ' MsgBox("Message : " + comm)
        Select Case comm.ToLower
            Case "close"
                Desktop.GetDesktopHandle.BeginInvoke(Sub()
                                                         Dispose()
                                                     End Sub)

            Case "restart"
                RestartApp()
            Case "putindt"
                SetParent(MyProcess.MainWindowHandle, Desktop.GetDesktopHandle.Handle)

        End Select
    End Sub

    Private Sub MyTimer_Tick(sender As Object, e As EventArgs) Handles MyTimer.Tick
        If Not MyProcess.Responding Then


        End If
        If MyProcess.HasExited Then
            MyProcess.Dispose()
            MyServer.Close()
            MyTBItem.Dispose()
            MyTimer.Dispose()
        End If
    End Sub

    Public Sub RestartApp()
        If MyProcess.Responding Then
            MyProcess.CloseMainWindow()
        Else
            MyProcess.Kill()
        End If
        Threading.Thread.Sleep(100)
        MyProcess = Process.Start(AirOS.OSDataPath + "\apps\" + MyName + "\" + MyName + ".exe", "airos")
    End Sub
End Class
