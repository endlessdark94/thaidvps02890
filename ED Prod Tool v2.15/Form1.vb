Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports System.Net.NetworkInformation

Public Class frmLogin


    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        ConnectToSQL()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'hiện messagebox với 2 nút lệnh yes/no khi ấn thoát 
        Dim result As Integer = MessageBox.Show("Thoát chương trình?", "ED Smart Manager", MessageBoxButtons.YesNo)
        'chương trình đóng khi ấn Yes & quay trở lại của sổ đăng nhập nếu ấn No
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub


    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ConnectToSQL()

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim Password As String
        Dim Password2 As String
        Dim userName As String

        Try

            'change the data source and initial catalog according to your sql server engine and data base
            con.ConnectionString = SQLControl.Sqlconstring
            con.Open()

            cmd.Connection = con
            'change the data fields names and table according to your database
            cmd.CommandText = " SELECT  userID, userPWD FROM   Admin WHERE   (userID = '" & txtUsername.Text & "' ) AND (userPWD = '" & txtPassword.Text & "')"

            Dim lrd As SqlDataReader = cmd.ExecuteReader()
            If lrd.HasRows Then
                While lrd.Read()

                    'Do something here
                    Password = lrd("userID").ToString()
                    userName = lrd("userPWD").ToString()

                    Password2 = txtPassword.Text()

                    If Password = Password2 And userName = txtUsername.Text Then

                        MessageBox.Show("Logged in successfully as " & userName, "", MessageBoxButtons.OK, MessageBoxIcon.Information
                                        )
                        Savelog()
                        frmLoading.Show()
                        Me.Hide()

                        'Clear all fields
                        txtPassword.Text = ""
                        txtUsername.Text = ""

                    End If

                End While

            Else
                MessageBox.Show("Username and Password do not match..", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'Clear all fields
                txtPassword.Text = ""
                txtUsername.Text = ""
            End If



        Catch ex As Exception
            MessageBox.Show("Error while connecting to SQL Server." & ex.Message)

        Finally
            con.Close() 'Whether there is error or not. Close the connection.

        End Try

    End Sub



    Private Sub lblSpp_Click(sender As Object, e As EventArgs) Handles lblSpp.Click

    End Sub

    Sub Savelog() 'lưu lịch sử đăng nhập
        Dim hostname As String
        Dim ip As String
        Dim MAC As String
        Dim user As String = txtUsername.Text
        hostname = System.Net.Dns.GetHostName()
        ip = MyIP_WinHTTP()
        MAC = getMacAddress()

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Try
            con.ConnectionString = SQLControl.Sqlconstring
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO LoginHistory (time, userID, username, hostname, ip, mac) values ('" + DateTime.Now.ToString + "','" + txtUsername.Text + "','" + user + "','" + hostname + "','" + ip + "','" + MAC + "')"
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Error while saving Login History Log..." & ex.Message, "Insert Records")
        
        End Try

  
    End Sub

    Function MyIP_WinHTTP() 'API check IP Adress
        Dim objHTTP, strURL
        MyIP_WinHTTP = "0.0.0.0"
        strURL = "http://tools.feron.it/php/ip.php"
        objHTTP = CreateObject("WinHttp.WinHttpRequest.5.1")
        objHTTP.Open("GET", strURL)
        objHTTP.Send()
        If objHTTP.Status = 200 Then MyIP_WinHTTP = objHTTP.ResponseText
        objHTTP = Nothing
    End Function

    Function getMacAddress() 'Hàm check MAC Adress
        Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces()
        Return nics(0).GetPhysicalAddress.ToString
    End Function





End Class
