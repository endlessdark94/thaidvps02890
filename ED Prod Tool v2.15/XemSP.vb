Imports System.Data.SqlClient
Public Class frmXemSP

    Private Sub frmXemSP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        XemSP()
       
    End Sub

    Sub XemSP()
        lvwXemSP.Items.Clear()
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = SQLControl.Sqlconstring
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "select SANPHAM.MASP ,SANPHAM.TENSP, LOAISANPHAM.MALOAI, LOAISANPHAM.TENLOAI, SANPHAM.SOLUONG from SANPHAM inner join LOAISANPHAM on SANPHAM.MASP = LOAISANPHAM.MASP"
        Dim dr As SqlDataReader = cmd.ExecuteReader()

        Do While dr.Read()
            Dim new_item As New  _
     ListViewItem(dr.Item("MASP").ToString)
            new_item.SubItems.Add(dr.Item("TENSP").ToString)
            new_item.SubItems.Add(dr.Item("MALOAI").ToString)
            new_item.SubItems.Add(dr.Item("TENLOAI").ToString)
            new_item.SubItems.Add(dr.Item("SOLUONG").ToString)

            lvwXemSP.Items.Add(new_item)
        Loop
        con.Close()
        txtSearch2.Focus()
    End Sub

    Private Sub btnSearch2_Click(sender As Object, e As EventArgs) Handles btnSearch2.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = SQLControl.Sqlconstring
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "select SANPHAM.MASP ,SANPHAM.TENSP, LOAISANPHAM.MALOAI, LOAISANPHAM.TENLOAI, SANPHAM.SOLUONG from SANPHAM inner join LOAISANPHAM on SANPHAM.MASP = LOAISANPHAM.MASP where SANPHAM.MASP like '" & txtSearch2.Text & "' or TENSP like '%" & txtSearch2.Text & "%' "
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        Try
            If txtSearch2.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã SP", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

            Else

                If dr.HasRows Then
                    lvwXemSP.Items.Clear()

                    Do While dr.Read()
                        Dim new_item As New  _
                 ListViewItem(dr.Item("MASP").ToString)
                        new_item.SubItems.Add(dr.Item("TENSP").ToString)
                        new_item.SubItems.Add(dr.Item("MALOAI").ToString)
                        new_item.SubItems.Add(dr.Item("TENLOAI").ToString)
                        new_item.SubItems.Add(dr.Item("SOLUONG").ToString)

                        lvwXemSP.Items.Add(new_item)
                    Loop


                Else
                    MessageBox.Show("Không tìm thấy")
                    txtSearch2.Text = Nothing
                End If
            End If
            con.Close()
        Catch ex As Exception
        End Try
        txtSearch2.Focus()
    End Sub

    Private Sub txtSearch2_TextChanged(sender As Object, e As EventArgs) Handles txtSearch2.TextChanged
        If txtSearch2.Text = "" Then
            XemSP()
        End If
    End Sub
End Class