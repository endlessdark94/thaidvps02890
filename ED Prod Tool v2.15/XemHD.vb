Imports System.Data.SqlClient
Public Class frmXemHD
    Sub XemHD()
        lvwXemHD.Items.Clear()
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = SQLControl.Sqlconstring
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "select KHACHHANG.MAKH, KHACHHANG.TENKH, SANPHAM.MASP ,SANPHAM.TENSP, CHITIETHOADON.SOHD, CHITIETHOADON.MAHD, CHITIETHOADON.SL, CHITIETHOADON.DONGIA, CHITIETHOADON.SL * CHITIETHOADON.DONGIA as THANHTIEN from HOADON inner join KHACHHANG on HOADON.MAKH = KHACHHANG.MAKH INNER JOIN SANPHAM on HOADON.MASP = SANPHAM.MASP INNER JOIN CHITIETHOADON on HOADON.MAHD = CHITIETHOADON.MAHD"
        Dim dr As SqlDataReader = cmd.ExecuteReader()

        Do While dr.Read()
            Dim new_item As New  _
     ListViewItem(dr.Item("MAKH").ToString)
            new_item.SubItems.Add(dr.Item("TENKH").ToString)
            new_item.SubItems.Add(dr.Item("MASP").ToString)
            new_item.SubItems.Add(dr.Item("TENSP").ToString)
            new_item.SubItems.Add(dr.Item("SOHD").ToString)
            new_item.SubItems.Add(dr.Item("MAHD").ToString)
            new_item.SubItems.Add(dr.Item("SL").ToString)
            new_item.SubItems.Add(dr.Item("DONGIA").ToString)
            new_item.SubItems.Add(dr.Item("THANHTIEN").ToString)
            lvwXemHD.Items.Add(new_item)
        Loop
        con.Close()

    End Sub

    Private Sub lvwXemHD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwXemHD.SelectedIndexChanged

    End Sub

    Private Sub frmXemHD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        XemHD()
    End Sub

    Private Sub btnSearch2_Click(sender As Object, e As EventArgs) Handles btnSearch2.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = SQLControl.Sqlconstring
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "select KHACHHANG.MAKH, KHACHHANG.TENKH, SANPHAM.MASP ,SANPHAM.TENSP, CHITIETHOADON.SOHD, CHITIETHOADON.MAHD, CHITIETHOADON.SL, CHITIETHOADON.DONGIA, CHITIETHOADON.SL * CHITIETHOADON.DONGIA as THANHTIEN from HOADON inner join KHACHHANG on HOADON.MAKH = KHACHHANG.MAKH INNER JOIN SANPHAM on HOADON.MASP = SANPHAM.MASP INNER JOIN CHITIETHOADON on HOADON.MAHD = CHITIETHOADON.MAHD where HOADON.MAHD like '" & txtSearch2.Text & "' or KHACHHANG.TENKH like '%" & txtSearch2.Text & "%' "
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        Try
            If txtSearch2.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã SP", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

            Else

                If dr.HasRows Then
                    lvwXemHD.Items.Clear()

                    Do While dr.Read()
                        Dim new_item As New  _
                 ListViewItem(dr.Item("MAKH").ToString)
                        new_item.SubItems.Add(dr.Item("TENKH").ToString)
                        new_item.SubItems.Add(dr.Item("MASP").ToString)
                        new_item.SubItems.Add(dr.Item("TENSP").ToString)
                        new_item.SubItems.Add(dr.Item("SOHD").ToString)
                        new_item.SubItems.Add(dr.Item("MAHD").ToString)
                        new_item.SubItems.Add(dr.Item("SL").ToString)
                        new_item.SubItems.Add(dr.Item("DONGIA").ToString)
                        new_item.SubItems.Add(dr.Item("THANHTIEN").ToString)
                        lvwXemHD.Items.Add(new_item)
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
End Class