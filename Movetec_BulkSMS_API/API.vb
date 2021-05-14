Imports System.IO
Imports System.Net
Imports System.Data
Imports DB_Layer.DB_Layer
Imports System.Threading.Tasks
Imports System.Net.Http
'Disclaimer
'    Copyright (c) 2021 Denis Asiema 

'Permission Is hereby granted, free of charge, to any person
'obtaining a copy Of this software And associated documentation
'files (the "Software"), to deal in the Software without
'restriction, including without limitation the rights to use,
'copy, modify, merge, publish, distribute, sublicense, And/Or sell
'copies of the Software, And to permit persons to whom the
'Software Is furnished to do so, subject to the following
'conditions:

'The above copyright notice And this permission notice shall be
'included in all copies Or substantial portions of the Software.

'THE SOFTWARE Is PROVIDED "AS IS", WITHOUT WARRANTY Of ANY KIND,
'EXPRESS Or IMPLIED, INCLUDING BUT Not LIMITED TO THE WARRANTIES
'OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE And
'NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS Or COPYRIGHT
'HOLDERS BE LIABLE For ANY CLAIM, DAMAGES Or OTHER LIABILITY,
'WHETHER IN AN ACTION OF CONTRACT, TORT Or OTHERWISE, ARISING
'FROM, OUT OF Or IN CONNECTION WITH THE SOFTWARE Or THE USE Or
'OTHER DEALINGS In THE SOFTWARE.
Public Class API
    Function SendSMS(ByVal _SMSApi As API_Parameters_Model) As String
        'get SMS SPI params       
        Dim url As String = _SMSApi.base_url & "?username=" & _SMSApi.username & "&api_key=" & _SMSApi.key & "&sender=" & _SMSApi.sender & "&to=" & _SMSApi.phone & "&message=" & _SMSApi.message & "&msgtype=" & _SMSApi.msgtype & "&dlr=" & _SMSApi.dlr

        Dim x As Object = StartTask(url), y As String
        y = x.result

        Return y
    End Function

    Public Async Function GetRequest(ByVal url As String) As Task(Of String)
        Dim client As New HttpClient
        Using client
            Dim response As HttpResponseMessage = client.GetAsync(url).Result
            Using response
                Dim content As HttpContent = response.Content
                Using content
                    Dim mycontent As String = content.ReadAsStringAsync().Result
                    Return mycontent
                End Using
            End Using
        End Using
    End Function
    Private Function StartTask(ByVal url As String)
        Try
            Dim t As Task(Of String) = GetRequest(url)
            t.Wait()

            Return t
        Catch ex As Exception
            'send the error via email
            Return ex.ToString
        End Try

    End Function
End Class
