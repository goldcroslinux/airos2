﻿Imports System.IO
Public Class Booter

    Private Sub Booting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Me.Size = My.Computer.Screen.Bounds.Size
        Me.BringToFront()
        '      My.Settings.Console.Clear()
        My.Settings.Save()
    End Sub

    Dim destcolor As Color = ColorTranslator.FromHtml("#2196F3")
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Refresh()
        If Me.BackColor <> ColorTranslator.FromHtml("#2196F3") Then
            Dim upr As Integer = 0
            Dim upg As Integer = 0
            Dim upb As Integer = 0

            If BackColor.R < destcolor.R Then
                upr = 1
            End If
            If BackColor.G < destcolor.G Then
                upg = 1
            End If
            If BackColor.B < destcolor.B Then
                upb = 1
            End If
            Me.BackColor = Color.FromArgb(Me.BackColor.R + upr, Me.BackColor.G + upg, Me.BackColor.B + upb)
            If ProgressBar1.Value < ProgressBar1.Maximum Then
                ProgressBar1.Value += 1
            Else
                If Me.BackColor.R = ColorTranslator.FromHtml("#2196F3").R And Me.BackColor.G = ColorTranslator.FromHtml("#2196F3").G And Me.BackColor.B = ColorTranslator.FromHtml("#2196F3").B Then
                End If
            End If

            Console.WriteLine("Boot started...")
            Console.WriteLine("Checking file directories...")
            Console.WriteLine("Loading apps and settings...")

            If ProgressBar1.Value <= 33 Then
                Label1.Text = "Loading OS... - " + Math.Truncate((ProgressBar1.Value)).ToString + "%"

                If Not Directory.Exists(AirOS.OSDataPath + "\users") Then
                    Directory.CreateDirectory(AirOS.OSDataPath + "\users")
                End If

                If Not Directory.Exists(AirOS.OSDataPath + "\users\admin") Then
                    Directory.CreateDirectory(AirOS.OSDataPath + "\users\admin")
                    File.WriteAllText(AirOS.OSDataPath + "\users\admin\pw.txt", Functions.Encrypt(""))
                    File.WriteAllText(AirOS.OSDataPath + "\users\admin\name.txt", "Administrator")

                    File.WriteAllText(AirOS.OSDataPath + "\users\admin\settings.txt", "")

                    'MAKE SURE TO ADD SETTINGS

                    My.Resources.person.Save(AirOS.OSDataPath + "\users\admin\img.png", Imaging.ImageFormat.Png)
                End If
            ElseIf ProgressBar1.Value <= 66 Then
                Label1.Text = "Loading components and files... - " + Math.Truncate((ProgressBar1.Value)).ToString + "%"
                Refresh()

                If Not IO.Directory.Exists(AirOS.OSDataPath + "\files") Then
                    IO.Directory.CreateDirectory(AirOS.OSDataPath + "\files")
                End If
                If IO.Directory.GetDirectories(AirOS.OSDataPath + "\files").Length < 5 Then
                    If Not IO.Directory.Exists(AirOS.OSDataPath + "\files\docs") Then
                        Label1.Text = "Copying documents..."
                        IO.Directory.CreateDirectory(AirOS.OSDataPath + "\files\docs")
                        Dim files As String() = IO.Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments))
                        For i = 0 To files.Length - 1 Step 1
                            File.Copy(files(i), AirOS.OSDataPath + "\files\docs\" + files(i).Substring(files(i).LastIndexOf("\") + 1), True)
                        Next
                    End If
                    If Not IO.Directory.Exists(AirOS.OSDataPath + "\files\tunes") Then
                        Label1.Text = "Copying music..."
                        IO.Directory.CreateDirectory(AirOS.OSDataPath + "\files\tunes")
                        Dim files As String() = IO.Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic))
                        For i = 0 To files.Length - 1 Step 1
                            File.Copy(files(i), AirOS.OSDataPath + "\files\tunes\" + files(i).Substring(files(i).LastIndexOf("\") + 1), True)
                        Next
                    End If
                    If Not IO.Directory.Exists(AirOS.OSDataPath + "\files\photos") Then
                        Label1.Text = "Copying photos..."
                        IO.Directory.CreateDirectory(AirOS.OSDataPath + "\files\photos")
                        Dim files As String() = IO.Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures))
                        For i = 0 To files.Length - 1 Step 1
                            File.Copy(files(i), AirOS.OSDataPath + "\files\photos\" + files(i).Substring(files(i).LastIndexOf("\") + 1), True)
                        Next
                    End If
                    If Not IO.Directory.Exists(AirOS.OSDataPath + "\files\downloads") Then
                        IO.Directory.CreateDirectory(AirOS.OSDataPath + "\files\downloads")
                    End If
                    If Not IO.Directory.Exists(AirOS.OSDataPath + "\files\films") Then
                        Label1.Text = "Copying media..."
                        IO.Directory.CreateDirectory(AirOS.OSDataPath + "\files\films")
                        Dim files As String() = IO.Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos))
                        For i = 0 To files.Length - 1 Step 1
                            File.Copy(files(i), AirOS.OSDataPath + "\files\films\" + files(i).Substring(files(i).LastIndexOf("\") + 1), True)
                        Next
                    End If
                End If

            Else
                Label1.Text = "Loading apps and settings... - " + Math.Truncate((ProgressBar1.Value)).ToString + "%"
            End If
        Else
            Console.WriteLine("Booting complete...")
            Console.WriteLine("Showing login screen...")
            Timer2.Enabled = True
        End If
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Dim l As New Login
        l.Show()
        l.BringToFront()
        Timer3.Enabled = True
    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
        Timer1.Enabled = False
        Timer2.Enabled = False
    End Sub
End Class
