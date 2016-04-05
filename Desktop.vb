Imports System.Runtime.InteropServices
Imports System.Globalization

Public Class Desktop

    Public Sub New(user As String)
        InitializeComponent()


    End Sub




    Private Sub Desktop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized

        Dim o = New OSAppBase("AirOSAppTest")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time.Text = DateTime.Now.ToShortTimeString ' DateTime.Now.Hour.ToString + ":" + DateTime.Now.Minute.ToString
        pm.Text = DateTime.Now.ToString("tt", CultureInfo.InvariantCulture)
    End Sub

    Public RunningApps As New List(Of OSAppBase)


    Public Shared Function GetDesktopHandle() As Desktop
        Return CType(Application.OpenForms("Desktop"), Desktop)
    End Function

    Private Sub Desktop_Activated(sender As Object, e As EventArgs) Handles Me.Activated
    End Sub


    Private Sub Desktop_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        'For i = 0 To RunningApps.Count - 1
        '    RunningApps(i).SendMessage("hide")
        'Next
    End Sub


    Private Sub Desktop_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        For i = 0 To RunningApps.Count - 1
            RunningApps(i).Dispose()
        Next
    End Sub

    Private Sub Desktop_Shown(sender As Object, e As EventArgs) Handles Me.Shown

    End Sub

    Public Sub StartApp(appname As String)
        Dim a As New OSAppBase(appname)
        RunningApps.Add(a)
    End Sub


    <DllImport("user32.dll")> _
    Private Shared Function SetParent(hWndChild As IntPtr, hWndNewParent As IntPtr) As IntPtr
    End Function

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs)
        Form1.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs)
        menudrop.Show(Control.MousePosition)
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Form1.Show()
    End Sub

    Private Sub PictureBox1_Click_1(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
    End Sub
End Class