Imports System.Net
Imports System.Net.Sockets

Public Class CAn

    Dim sockets As New Socket(AddressFamily.InterNetwork, SocketType.Raw, ProtocolType.IP)
    Dim bytedata(4096) As Byte
    Dim ip As IPAddress
    Dim started As Boolean = True
    Dim diff As Size
    Dim loaded As Boolean = False
    Dim FilterIPAddress As New IPAddress(0)
    Dim FilterIP As Boolean
    Dim computerconnections() As Net.NetworkInformation.NetworkInterface

    Dim dates As String
    Dim strings As String = ""
    Dim types As String = ""
    Dim ipsource As IPAddress
    Dim ipdestination As IPAddress
    Dim destinationport As UInteger
    Dim sourceport As UInteger

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        diff.Height = Me.Height - DGV.Height
        diff.Width = Me.Width - DGV.Width
        loaded = True
        computerconnections = Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces
        For i = 0 To computerconnections.Length - 1
            ComboBox1.Items.Add(computerconnections(i).Name)
        Next
    End Sub
    Private Sub OnReceive(ByVal asyncresult As IAsyncResult)
        If started = True Then

            dates = Now

            Dim readlength As UInteger = BitConverter.ToUInt16(Byteswap(bytedata, 2), 0)
            sourceport = BitConverter.ToUInt16(Byteswap(bytedata, 22), 0)
            destinationport = BitConverter.ToUInt16(Byteswap(bytedata, 24), 0)

            If bytedata(9) = 6 Then
                types = "TCP"
            ElseIf bytedata(9) = 17 Then
                types = "UDP"
            Else
                types = "OTHER"
            End If

            ipsource = New IPAddress(BitConverter.ToUInt32(bytedata, 12))
            ipdestination = New IPAddress(BitConverter.ToUInt32(bytedata, 16))

            If (ipsource.Equals(ip) = True Or ipdestination.Equals(ip) = True) And ipdestination.Equals(ipsource) = False Then
                If FilterIP = False Or (FilterIP = True And (FilterIPAddress.Equals(ipsource) Or FilterIPAddress.Equals(ipdestination))) Then

                    strings = ""
                    For i = 26 To readlength - 1
                        If Char.IsLetterOrDigit(Chr(bytedata(i))) = True Then
                            strings = strings & Chr(bytedata(i))
                        Else
                            strings = strings & "."
                        End If
                    Next

                    DGV.Invoke(New MethodInvoker(AddressOf DGVUpdate))
                End If
            End If
        End If

        sockets.BeginReceive(bytedata, 0, bytedata.Length, SocketFlags.None, New AsyncCallback(AddressOf OnReceive), Nothing)
    End Sub
    Private Sub DGVUpdate()
        If DGV.Rows.Count > 1000 Then
            DGV.Rows.RemoveAt(0)
        End If
        DGV.Rows.Add()
        DGV.Rows(DGV.Rows.Count - 1).Cells(0).Value = dates.ToString
        DGV.Rows(DGV.Rows.Count - 1).Cells(1).Value = ipsource.ToString & ":" & sourceport
        DGV.Rows(DGV.Rows.Count - 1).Cells(2).Value = ipdestination.ToString & ":" & destinationport
        DGV.Rows(DGV.Rows.Count - 1).Cells(3).Value = types
        DGV.Rows(DGV.Rows.Count - 1).Cells(4).Value = strings
    End Sub
    Private Function Byteswap(ByVal byt() As Byte, ByVal index As UInteger)
        Dim result(1) As Byte
        result(0) = byt(index + 1)
        result(1) = byt(index)
        Return result
    End Function

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If loaded = True Then
            DGV.Size = Me.Size - diff
        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        For i = 0 To computerconnections(ComboBox1.SelectedIndex).GetIPProperties.UnicastAddresses.Count - 1
            If computerconnections(ComboBox1.SelectedIndex).GetIPProperties.UnicastAddresses(i).Address.AddressFamily = Net.Sockets.AddressFamily.InterNetwork Then
                ip = computerconnections(ComboBox1.SelectedIndex).GetIPProperties.UnicastAddresses(i).Address
                BindSocket()
            End If
        Next
    End Sub
    Private Sub BindSocket()
        Try
            sockets.Bind(New IPEndPoint(ip, 0))
            sockets.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.HeaderIncluded, True)
            Dim bytrue() As Byte = {1, 0, 0, 0}
            Dim byout() As Byte = {1, 0, 0, 0}
            sockets.IOControl(IOControlCode.ReceiveAll, bytrue, byout)
            sockets.Blocking = False
            ReDim bytedata(sockets.ReceiveBufferSize)
            sockets.BeginReceive(bytedata, 0, bytedata.Length, SocketFlags.None, New AsyncCallback(AddressOf OnReceive), Nothing)
            ComboBox1.Enabled = False
            MsgBox("If you selected the correct network interface card, click Ok to continue. If not, restart the application.")
        Catch ex As Exception
            ComboBox1.BackColor = Color.Gray
        End Try
    End Sub

    Private Sub Stopbtn_Click(sender As Object, e As EventArgs) Handles Stopbtn.Click
        If started = True Then
            Stopbtn.Text = "start"
            started = False
        Else
            Stopbtn.Text = "stop"
            started = True
        End If
    End Sub

    Private Sub Snapbtn_Click(sender As Object, e As EventArgs) Handles Snapbtn.Click
        Dim headers = (From header As DataGridViewColumn In DGV.Columns.Cast(Of DataGridViewColumn)()
                       Select header.HeaderText).ToArray
        Dim rows = From row As DataGridViewRow In DGV.Rows.Cast(Of DataGridViewRow)()
                   Where Not row.IsNewRow
                   Select Array.ConvertAll(row.Cells.Cast(Of DataGridViewCell).ToArray, Function(c) If(c.Value IsNot Nothing, c.Value.ToString, ""))
        Using sw As New IO.StreamWriter("CAn Snapshot" + ".txt")
            sw.WriteLine(String.Join(" , ", headers))
            For Each r In rows
                sw.WriteLine(String.Join(" , ", r))
            Next
        End Using
        Process.Start("CAn Snapshot" + ".txt")
    End Sub

    Private Sub Aboubtn_Click(sender As Object, e As EventArgs) Handles Aboubtn.Click
        MsgBox("CAn 2.0.1. © Copyright 2016 EMG Future Technologies Inc. All trademarks and registered trademarks are the property of their respective owners.")
    End Sub

    Private Sub Exitbtn_Click(sender As Object, e As EventArgs) Handles Exitbtn.Click
        Close()
    End Sub

End Class