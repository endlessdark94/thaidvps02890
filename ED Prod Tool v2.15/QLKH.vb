Imports System.Data.DataTable
Imports System.Data.SqlClient

Public Class frmQLKH
    Dim db As New DataTable
    Private Sub frmQLKH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As SqlConnection = New SqlConnection(SQLControl.Sqlconstring)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select MAKH as 'Mã KH' ,TENKH as 'Tên Khách Hàng', DIACHI as 'Địa chỉ', SDT as 'SĐT', EMAIL from KHACHHANG", conn)

        conn.Open()
        load.Fill(db)
        dgvQLKH.DataSource = db.DefaultView
        conn.Close()
    End Sub

    Private Sub dgvQLKH_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvQLKH.CellContentClick
        Dim click As Integer = dgvQLKH.CurrentRow.Index
        txtMAKH.Text = dgvQLKH.Item(0, click).Value
        txtTENKH.Text = dgvQLKH.Item(1, click).Value
        txtDIACHI.Text = dgvQLKH.Item(2, click).Value
        txtSDT.Text = dgvQLKH.Item(3, click).Value
        txtEMAIL.Text = dgvQLKH.Item(4, click).Value

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        db.Clear()
        dgvQLKH.DataSource = db
        dgvQLKH.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(SQLControl.Sqlconstring)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select MAKH as 'Mã KH' ,TENKH as 'Tên Khách Hàng', DIACHI as 'Địa chỉ', SDT as 'SĐT', EMAIL from KHACHHANG", conn)

        conn.Open()
        load.Fill(db)
        dgvQLKH.DataSource = db.DefaultView
        conn.Close()
    End Sub

    Private Sub txtADD_Click(sender As Object, e As EventArgs) Handles txtADD.Click
        Dim result As Integer = MessageBox.Show("Xác nhận thêm tài khoản?", "ED Smart Manager", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Dim conn As SqlConnection = New SqlConnection(SQLControl.Sqlconstring)
            Dim query As String = "insert into KHACHHANG values(@MAKH,@TENKH,@DIACHI,@SDT,@EMAIL)"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            Try
                txtMAKH.Focus()
                If txtMAKH.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập Mã Khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtMAKH.Focus()
                    If txtTENKH.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập tên khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

                    Else
                        If txtDIACHI.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập địa chỉ", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            txtSDT.Focus()
                            If txtSDT.Text = "" Then
                                MessageBox.Show("Bạn chưa nhập số điện thoại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else
                                txtEMAIL.Focus()
                                If txtEMAIL.Text = "" Then
                                    MessageBox.Show("Bạn chưa nhập email", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                                    txtEMAIL.Focus()
                                Else
                                    save.Parameters.AddWithValue("@MAKH", txtMAKH.Text)
                                    save.Parameters.AddWithValue("@TENKH", txtTENKH.Text)
                                    save.Parameters.AddWithValue("@DIACHI", txtDIACHI.Text)
                                    save.Parameters.AddWithValue("@SDT", txtSDT.Text)
                                    save.Parameters.AddWithValue("@EMAIL", txtEMAIL.Text)
                                    save.ExecuteNonQuery()
                                    MessageBox.Show("Lưu thành công")
                                    'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                                    txtMAKH.Text = Nothing
                                    txtTENKH.Text = Nothing
                                    txtDIACHI.Text = Nothing
                                    txtSDT.Text = Nothing
                                    txtEMAIL.Text = Nothing
                                End If
                            End If
                        End If
                    End If
                End If
            Catch ex As Exception  'Ngược lại báo lỗi
                MessageBox.Show("Không được trùng mã khách hàng", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            End Try
        End If
        db.Clear()
        dgvQLKH.DataSource = db
        dgvQLKH.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnEDIT_Click(sender As Object, e As EventArgs) Handles btnEDIT.Click
        Dim result As Integer = MessageBox.Show("Mã khách hàng (PR) không thể thay đổi, Xác nhận sửa tài khoản?", "ED Smart Manager", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then

            Dim conn As SqlConnection = New SqlConnection(SQLControl.Sqlconstring)
            Dim updatequery As String = "update KHACHHANG set MAKH=@MAKH, TENKH=@TENKH, DIACHI=@DIACHI, SDT=@SDT, EMAIL=@EMAIL where MAKH=@MAKH"
            Dim addupdate As SqlCommand = New SqlCommand(updatequery, conn)
            conn.Open()

            txtMAKH.Focus()
            If txtMAKH.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMAKH.Focus()
                If txtTENKH.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtTENKH.Focus()
                    If txtDIACHI.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập địa chỉ khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtDIACHI.Focus()
                        If txtSDT.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập số điện thoại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            txtSDT.Focus()
                            If txtEMAIL.Text = "" Then
                                MessageBox.Show("Bạn chưa nhập email", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else


                                addupdate.Parameters.AddWithValue("@MAKH", txtMAKH.Text)
                                addupdate.Parameters.AddWithValue("@TENKH", txtTENKH.Text)
                                addupdate.Parameters.AddWithValue("@DIACHI", txtDIACHI.Text)
                                addupdate.Parameters.AddWithValue("@SDT", txtSDT.Text)
                                addupdate.Parameters.AddWithValue("@EMAIL", txtEMAIL.Text)
                                addupdate.ExecuteNonQuery()
                                conn.Close() 'đóng kết nối
                                MessageBox.Show("Cập nhật thành công")
                                txtMAKH.Focus()

                                txtMAKH.Text = Nothing
                                txtTENKH.Text = Nothing
                                txtDIACHI.Text = Nothing
                                txtSDT.Text = Nothing
                                txtEMAIL.Text = Nothing
                                End If
                        End If
                    End If
                End If
            End If

            conn.Close()
            'Sau khi cập nhật xong sẽ tự làm mới lại bảng
            db.Clear()
            dgvQLKH.DataSource = db
            dgvQLKH.DataSource = Nothing
            LoadData()
        End If
    End Sub

    Private Sub btnDEL_Click(sender As Object, e As EventArgs) Handles btnDEL.Click
        Dim conn As SqlConnection = New SqlConnection(SQLControl.Sqlconstring)
        Dim delquery As String = "delete from KHACHHANG where MAKH=@MAKH"
        Dim delete As SqlCommand = New SqlCommand(delquery, conn)
        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        conn.Open()
        Try
            If txtMAKH.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                txtMAKH.Focus()
            Else
                If resulft = Windows.Forms.DialogResult.Yes Then
                    delete.Parameters.AddWithValue("@MAKH", txtMAKH.Text)
                    delete.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Xóa thành công")
                    'Sau khi xóa thành công, tự động làm mới các khung textbox, combox và date....
                    txtMAKH.Text = Nothing
                    txtTENKH.Text = Nothing
                    txtDIACHI.Text = Nothing
                    txtSDT.Text = Nothing
                    txtEMAIL.Text = Nothing
                    txtMAKH.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Nhập đúng mã khách hàng cần xóa", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'làm mới bảng
        db.Clear()
        dgvQLKH.DataSource = db
        dgvQLKH.DataSource = Nothing
        LoadData()
    End Sub
End Class