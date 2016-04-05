Public Class Settings

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Public Sub LoadSettings() Handles Me.Load
        Select Case My.Settings.SearchEngine
            Case "https://www.google.com/search?q="
                segoogle.Checked = True
            Case "http://www.bing.com/search?q="
                sebing.Checked = True
            Case "https://search.yahoo.com/search?p="
                seyahoo.Checked = True
            Case "https://www.youtube.com/results?search_query="
                seyoutube.Checked = True
            Case Else
                segoogle.Checked = True
        End Select

        If My.Settings.DownloadsPath = "" Then
            My.Settings.DownloadsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\Downloads"
            My.Settings.Save()
        End If

        TextBox1.Text = My.Settings.Homepage
        TextBox2.Text = My.Settings.DownloadsPath
        CheckBox1.Checked = My.Settings.AskDownload


    End Sub

    Public Sub SaveSettings() Handles Me.FormClosed
        My.Settings.Homepage = TextBox1.Text
        My.Settings.AskDownload = CheckBox1.Checked
        My.Settings.DownloadsPath = TextBox2.Text

        My.Settings.Save()
    End Sub

    Private Sub segoogle_CheckedChanged(sender As Object, e As EventArgs) Handles segoogle.CheckedChanged
        If segoogle.Checked Then
            My.Settings.SearchEngine = "https://www.google.com/search?q=" 'search engine set to google
        End If
    End Sub

    Private Sub seyahoo_CheckedChanged(sender As Object, e As EventArgs) Handles seyahoo.CheckedChanged
        If seyahoo.Checked Then
            My.Settings.SearchEngine = "https://search.yahoo.com/search?p=" 'search engine set to yahoo
        End If
    End Sub

    Private Sub sebing_CheckedChanged(sender As Object, e As EventArgs) Handles sebing.CheckedChanged
        If sebing.Checked Then
            My.Settings.SearchEngine = "http://www.bing.com/search?q=" 'search engine set to bing
        End If
    End Sub

    Private Sub seyoutube_CheckedChanged(sender As Object, e As EventArgs) Handles seyoutube.CheckedChanged
        If seyoutube.Checked Then
            My.Settings.SearchEngine = "https://www.youtube.com/results?search_query=" 'search engine set to youtube
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim f As New FolderBrowserDialog
        f.ShowNewFolderButton = True
        If f.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            TextBox2.Text = f.SelectedPath 'browses for folder as download path
        End If
    End Sub
End Class