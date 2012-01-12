Imports System.Xml

Public Class mainForm

    Structure AddressInfo
        Dim Address As String
        Dim City As String
        Dim State As String
        Dim Zip As String
        Dim GoogleFound As Boolean
        Dim GoogleLL As String
        Dim YahooFound As Boolean
        Dim YahooLL As String
    End Structure

    Dim myAddresses As AddressInfo
    Dim numAddresses As Integer = 0


    Private Sub btnGetIt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetIt.Click
        myAddresses.Address = tboxAddr.Text
        myAddresses.City = tboxCity.Text
        myAddresses.State = tboxState.Text
        myAddresses.Zip = tboxZip.Text
        GetGoogleLL(myAddresses)
        tboxgLL.Text = myAddresses.GoogleLL
        GetYahooLL(myAddresses)
        tboxyLL.Text = myAddresses.YahooLL
    End Sub

    Public Sub GetGoogleLL(ByRef addr As AddressInfo)
        Dim Url As String
        'Construct an URL
        Url = "http://maps.google.com/maps/geo?q=" & addr.Address & " " & addr.City & " " & _
        addr.State & " " & addr.Zip & "&output=xml&oe=utf8&sensor=false"
        Dim gLL As String = ""
        ' Retrieve XML document
        Dim reader As XmlTextReader = New XmlTextReader(Url)
        ' Skip non-significant whitespace
        reader.WhitespaceHandling = WhitespaceHandling.Significant
        ' Read nodes one at a time
        Try
            While reader.Read()
                If reader.Name = "code" Then
                    If reader.ReadElementString("code") <> "200" Then
                        gLL = ""
                        Exit While
                    End If
                End If
                If reader.Name = "coordinates" Then
                    gLL = reader.ReadElementString("coordinates")
                    Exit While
                End If
            End While
            'Get Latitude and Longitude from the CoOrdinates returned
            If gLL <> "" Then
                Dim cLat(12), cLon(12) As Char
                Dim j As Short = 0
                Dim c1 As Boolean = 0
                For i As Short = 0 To gLL.Length - 1
                    If gLL(i) <> "," Then
                        If Not c1 Then
                            cLon(j) = gLL(i)
                        Else
                            cLat(j) = gLL(i)
                        End If
                        j += 1
                    Else
                        If Not c1 Then
                            c1 = 1
                            j = 0
                        Else
                            Exit For
                        End If
                    End If
                Next
                Dim dLat, dLon As Double
                dLat = CDbl(CStr(cLat))
                dLon = CDbl(CStr(cLon))
                gLL = dLat & "," & dLon
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        addr.GoogleLL = gLL
        If gLL = "" Then
            addr.GoogleFound = 0
        Else
            addr.GoogleFound = 1
        End If
    End Sub

    Public Sub GetYahooLL(ByRef addr As AddressInfo)
        Dim Url As String
        Dim yLL As String = ""
        'Construct an URL

        ''Deprecated
        ''Url = "http://local.yahooapis.com/MapsService/V1/geocode?appid=UprhOKrV34HQsNw5LLrUpbq383E533rdAAIH._7WEAzdXyGSvHC6ylUdocvkrLjPku8CyoabUDY-&street=" _
        ''& addr.Address & "&city=" & addr.City & "&state=" & addr.State & "&zip=" & addr.Zip

        'Yahoo! PlaceFinder
        Url = "http://where.yahooapis.com/geocode?appid=UprhOKrV34HQsNw5LLrUpbq383E533rdAAIH._7WEAzdXyGSvHC6ylUdocvkrLjPku8CyoabUDY-&location=" _
        & addr.Address & ", " & addr.City & ", " & addr.State & ", " & addr.Zip

        ' Retrieve XML document
        Dim reader As XmlTextReader = New XmlTextReader(Url)
        ' Skip non-significant whitespace
        reader.WhitespaceHandling = WhitespaceHandling.Significant
        ' Read nodes one at a time
        Try
            While reader.Read()

                If reader.Name = "latitude" Then
                    yLL = reader.ReadElementString("latitude")
                End If

                If reader.Name = "longitude" Then
                    yLL = yLL & "," & reader.ReadElementString("longitude")
                    Exit While
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        addr.YahooLL = yLL
        If yLL = "" Then
            addr.YahooFound = 0
        Else
            addr.YahooFound = 1
        End If
    End Sub

End Class
