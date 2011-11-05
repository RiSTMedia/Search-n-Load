Imports System.Net
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.ComponentModel
Imports System.Threading
Imports System.Runtime.InteropServices
Imports Google.GData.YouTube
Imports Google.YouTube
Imports Google.GData.Client
Imports System.Windows.Forms
Imports System.Windows.Forms.Cursor
Imports System.Runtime.Remoting.Messaging
Imports System

Namespace searchnload

    Class MainWindow

        Private Sub Window_Loaded(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded
            TextBox2.Text = Environment.GetEnvironmentVariable("UserProfile") & "\Downloads"
            ComboBox2.SelectedIndex = 0
        End Sub

        Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles Button1.Click
            ListView1.Items.Clear()
            Dim del As New search(AddressOf yt_search)
            del.BeginInvoke(TextBox1.Text, Nothing, Nothing)

        End Sub
        Delegate Function search(ByVal searchcontent As String) As List(Of Video)
        Public Function yt_search(ByVal searchcontent As String) As List(Of Video)

            Dim request As New YouTubeRequest(New YouTubeRequestSettings("Search n Load", "AI39si5N4KkOUgwxmcqMnTWteyz66exNwblcvGM675ENeo8aITXG8KgeFCMUpSEbINKIUFjyHyX3xwi7PFdeMAFqj116NdSUNA"))
            Dim query As YouTubeQuery
            Dim results As Integer
            Dim islist As Boolean = False
            Dim del As New _addvideos(AddressOf addvideos)

            If searchcontent.Contains("www.youtube") Then
                If searchcontent.Contains("list=") Then
                    query = New YouTubeQuery("https://gdata.youtube.com/feeds/api/playlists/" & searchcontent.Substring(searchcontent.IndexOf("list=") + 7, 16))
                    islist = True
                Else
                    query = New YouTubeQuery("http://gdata.youtube.com/feeds/api/videos/" & searchcontent.Substring(searchcontent.IndexOf("v=") + 2, 11))
                End If


            Else
                query = New YouTubeQuery(YouTubeQuery.DefaultVideoUri)
                query.OrderBy = "relevance"

                query.Query = searchcontent.Replace(" ", "+")
                query.SafeSearch = YouTubeQuery.SafeSearchValues.None
            End If
            If Not searchcontent.Contains("watch?v=") Then
                query.NumberToRetrieve = 10
            End If

            Dim video_feed As Feed(Of Video) = request.Get(Of Video)(query)
            results = video_feed.TotalResults
            Dim videolist As List(Of Video) = New List(Of Video)


            ListView1.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.SystemIdle, del, video_feed)
            Dim loaded As Integer = video_feed.Entries.Count

            If Not islist Then
                results = 100
            End If

            While loaded < results
                query.StartIndex = loaded + 1

                video_feed = request.Get(Of Video)(query)

                ListView1.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.SystemIdle, del, video_feed)

                loaded += 10

            End While

            'query.StartIndex = loaded + 1
            'video_feed = request.Get(Of Video)(query)

            'ListView1.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.SystemIdle, del, video_feed)




            Return videolist


        End Function
        Delegate Sub _addvideos(ByVal list As Feed(Of Video))
        Sub addvideos(ByVal list As Feed(Of Video))

            For Each vid In list.Entries
                ListView1.Items.Add(vid)
            Next

        End Sub

        Private Sub itemclick(ByVal sender As System.Object, ByVal e As System.Windows.Input.MouseButtonEventArgs)
            MsgBox(DirectCast(ListView1.SelectedItem, Video).Description)
        End Sub

        Private Sub itemdl(ByVal sender As System.Object, ByVal e As System.Windows.Input.MouseButtonEventArgs)

            Dim FFmpeg As Process
            Dim name As String = DirectCast(ListView1.SelectedItem, Video).Title.Replace("*", "").Replace("/", "").Replace(":", "").Replace("\", "").Replace("?", "").Replace("<", "").Replace(">", "").Replace("|", "").Replace("&quot;", "").Replace("&#39;", "'").Replace(vbLf, "").Replace(Chr(34), "")




            FFmpeg = New Process
            'FFmpeg.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            FFmpeg.StartInfo.FileName = "ffmpeg\ffmpeg.exe"

            If ComboBox2.SelectedIndex = 0 Then
                FFmpeg.StartInfo.Arguments = "-i " & Chr(34) & dl_links(DirectCast(ListView1.SelectedItem, Video).VideoId) & Chr(34) & " -f mp3" & " -ab 128000 " & Chr(34) & TextBox2.Text & "\" & name & ".mp3" & Chr(34)
            ElseIf ComboBox2.SelectedIndex = 1 Then
                FFmpeg.StartInfo.Arguments = "-i " & Chr(34) & dl_links(DirectCast(ListView1.SelectedItem, Video).VideoId) & Chr(34) & " -sameq" & " -acodec libmp3lame" & " -ab 128000 " & Chr(34) & TextBox2.Text & "\" & name & ".mp4" & Chr(34)
            End If


            FFmpeg.Start()




        End Sub
        Private Function dl_links(ByVal vidid As String) As String
            Dim httpURL As New System.Uri("http://www.youtube.com/watch?v=" & vidid)
            Dim request As HttpWebRequest = HttpWebRequest.Create(httpURL)
            request.Method = WebRequestMethods.Http.Get
            Dim response As HttpWebResponse = request.GetResponse
            Dim reader As New StreamReader(response.GetResponseStream)

            Dim code As String
            code = reader.ReadToEnd
            link_filter(code)
            For Each url In link_filter(code)
                Dim format As String = url.Substring(url.IndexOf("type=") + 13)
                Dim DL_URL As String = url.Substring(url.IndexOf("url=") + 4)
                format = format.Remove(format.IndexOf("&"))
                DL_URL = Unescape(DL_URL.Remove(DL_URL.IndexOf("&")))
                If format.Contains("webm") Then
                    Continue For
                End If
                Return DL_URL


            Next
            Return Nothing
        End Function
        Private Function link_filter(ByVal code As String) As String()
            Dim link_begin1 As Integer = InStr(code, "flashvars")
            Dim link_begin2 As Integer = InStr(link_begin1, code, "url_encoded_fmt_stream_map") + 27
            Dim ende_stelle_des_video_downloads_1 As Integer = InStr(link_begin2 + 5, code, "&")
            Dim Laenge_des_downloads_1 As Integer = ende_stelle_des_video_downloads_1 - link_begin2

            Dim url_map As String = Mid(code, link_begin2, Laenge_des_downloads_1)
            url_map = Unescape(url_map)
            Return url_map.Split(",")

        End Function
        Public Function Unescape(ByVal Enc As String) As String
            Return System.Uri.UnescapeDataString(Enc)
        End Function

        Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles Button2.Click
            Dim dialog As New System.Windows.Forms.FolderBrowserDialog
            dialog.ShowDialog()
            TextBox2.Text = dialog.SelectedPath
        End Sub

        Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles Button3.Click
            MediaElement1.Source = New Uri(dl_links(DirectCast(ListView1.SelectedItem, Video).VideoId))
        End Sub
    End Class




End Namespace