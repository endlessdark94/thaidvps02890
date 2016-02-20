Imports System.Data.SqlClient
Public Class frmXemKH

    Private Sub XemKH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSearch.Select()
        XemKH()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = SQLControl.Sqlconstring
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "select * from KHACHHANG where MAKH='" & txtSearch.Text & "'"
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        Try
            If txtSearch.Text = "" Then
                MessageBox.Show("Bạn cần nhập MAKH", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

            Else

                If dr.HasRows Then
                    lvwXemKH.Items.Clear()

                    Do While dr.Read()
                        Dim new_item As New  _
                 ListViewItem(dr.Item("MAKH").ToString)
                        new_item.SubItems.Add(dr.Item("TENKH").ToString)
                        new_item.SubItems.Add(dr.Item("DIACHI").ToString)
                        new_item.SubItems.Add(dr.Item("SDT").ToString)
                        new_item.SubItems.Add(dr.Item("EMAIL").ToString)

                        lvwXemKH.Items.Add(new_item)
                    Loop


                Else
                    MessageBox.Show("Không tìm thấy")
                    txtSearch.Text = Nothing
                End If
            End If
            con.Close()
        Catch ex As Exception
        End Try

    End Sub


    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text = "" Then
            XemKH()
        End If
    End Sub

    Sub XemKH()
        lvwXemKH.Items.Clear()
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = SQLControl.Sqlconstring
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM KHACHHANG ORDER BY MAKH"
        Dim dr As SqlDataReader = cmd.ExecuteReader()

        Do While dr.Read()
            Dim new_item As New  _
     ListViewItem(dr.Item("MAKH").ToString)
            new_item.SubItems.Add(dr.Item("TENKH").ToString)
            new_item.SubItems.Add(dr.Item("DIACHI").ToString)
            new_item.SubItems.Add(dr.Item("SDT").ToString)
            new_item.SubItems.Add(dr.Item("EMAIL").ToString)

            lvwXemKH.Items.Add(new_item)
        Loop
        con.Close()
        txtSearch.Focus()
    End Sub

    Private Sub lvwXemKH_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwXemKH.SelectedIndexChanged

    End Sub
End Class