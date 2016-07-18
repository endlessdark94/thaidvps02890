Imports System.Data.DataTable
Imports System.Data.SqlClient
Imports iTextSharp
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.Data.Odbc
Imports System.IO
Public Class frmQLHD
    Dim db As New DataTable
    Private Sub QLHD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As SqlConnection = New SqlConnection(SQLControl.Sqlconstring)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select KHACHHANG.MAKH, KHACHHANG.TENKH, SANPHAM.MASP ,SANPHAM.TENSP, CHITIETHOADON.SOHD, CHITIETHOADON.MAHD, CHITIETHOADON.SL, CHITIETHOADON.DONGIA, CHITIETHOADON.SL * CHITIETHOADON.DONGIA as THANHTIEN from HOADON inner join KHACHHANG on HOADON.MAKH = KHACHHANG.MAKH INNER JOIN SANPHAM on HOADON.MASP = SANPHAM.MASP INNER JOIN CHITIETHOADON on HOADON.MAHD = CHITIETHOADON.MAHD", conn)

        conn.Open()
        load.Fill(db)
        dgvQLHD.DataSource = db.DefaultView
        conn.Close()
    End Sub

    Private Sub dgvQLSP_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvQLHD.CellContentClick
        Dim click As Integer = dgvQLHD.CurrentRow.Index
        txtMAKH.Text = dgvQLHD.Item(0, click).Value
        txtMASP.Text = dgvQLHD.Item(2, click).Value
        txtSOHD.Text = dgvQLHD.Item(4, click).Value
        txtMAHD.Text = dgvQLHD.Item(5, click).Value
        txtSL.Text = dgvQLHD.Item(6, click).Value
        txtDONGIA.Text = dgvQLHD.Item(7, click).Value
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnRefresh2_Click(sender As Object, e As EventArgs) Handles btnRefresh2.Click
        db.Clear()
        dgvQLHD.DataSource = db
        dgvQLHD.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(SQLControl.Sqlconstring)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select KHACHHANG.MAKH, KHACHHANG.TENKH, SANPHAM.MASP ,SANPHAM.TENSP, CHITIETHOADON.SOHD, CHITIETHOADON.MAHD, CHITIETHOADON.SL, CHITIETHOADON.DONGIA, CHITIETHOADON.SL * CHITIETHOADON.DONGIA as THANHTIEN from HOADON inner join KHACHHANG on HOADON.MAKH = KHACHHANG.MAKH INNER JOIN SANPHAM on HOADON.MASP = SANPHAM.MASP INNER JOIN CHITIETHOADON on HOADON.MAHD = CHITIETHOADON.MAHD", conn)

        conn.Open()
        load.Fill(db)
        dgvQLHD.DataSource = db.DefaultView
        conn.Close()
    End Sub

    Private Sub txtADD2_Click(sender As Object, e As EventArgs) Handles txtADD2.Click
        Dim result As Integer = MessageBox.Show("Xác nhận thêm hóa đơn?", "ED Smart Manager", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Dim conn As SqlConnection = New SqlConnection(SQLControl.Sqlconstring)
            Dim query As String = "insert into HOADON values(@MAKH,@MASP,@MAHD) insert into CHITIETHOADON values(@SOHD,@MAHD,@SL,@DONGIA)"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            Try
                txtMAKH.Focus()
                If txtMAKH.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtMASP.Focus()
                    If txtMASP.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtMAHD.Focus()
                        If txtMAHD.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập mã hóa đơn", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            txtSOHD.Focus()
                            If txtSOHD.Text = "" Then
                                MessageBox.Show("Bạn chưa nhập số hóa đơn", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else
                                txtSL.Focus()
                                If txtSL.Text = "" Then
                                    MessageBox.Show("Bạn chưa nhập số lượng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                                Else
                                    txtDONGIA.Focus()
                                    If txtDONGIA.Text = "" Then
                                        MessageBox.Show("Bạn chưa nhập đơn giá", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                                    Else
                                        save.Parameters.AddWithValue("@MAKH", txtMAKH.Text)
                                        save.Parameters.AddWithValue("@MASP", txtMASP.Text)
                                        save.Parameters.AddWithValue("@MAHD", txtMAHD.Text)
                                        save.Parameters.AddWithValue("@SOHD", txtSOHD.Text)
                                        save.Parameters.AddWithValue("@SL", txtSL.Text)
                                        save.Parameters.AddWithValue("@DONGIA", txtDONGIA.Text)
                                        save.ExecuteNonQuery()
                                        MessageBox.Show("Lưu thành công")
                                        'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                                        txtMASP.Text = Nothing
                                        txtMAKH.Text = Nothing
                                        txtMAHD.Text = Nothing
                                        txtSOHD.Text = Nothing
                                        txtSL.Text = Nothing
                                        txtDONGIA.Text = Nothing
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Catch ex As Exception  'Ngược lại báo lỗi
                MessageBox.Show("Không được trùng mã hóa đơn", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            End Try
        End If
        db.Clear()
        dgvQLHD.DataSource = db
        dgvQLHD.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnEDIT2_Click(sender As Object, e As EventArgs) Handles btnEDIT2.Click
        Dim result As Integer = MessageBox.Show("Xác nhận sửa hóa đơn?", "ED Smart Manager", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Dim conn As SqlConnection = New SqlConnection(SQLControl.Sqlconstring)
            Dim updatequery As String = "update HOADON set MAKH=@MAKH, MASP=@MASP, MAHD=@MAHD where MAHD=@MAHD update CHITIETHOADON set SOHD=@SOHD, MAHD=@MAHD, SL=@SL, DONGIA=@DONGIA where SOHD=@SOHD"
            Dim addupdate As SqlCommand = New SqlCommand(updatequery, conn)
            conn.Open()
            Try
                txtMAKH.Focus()
                If txtMAKH.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtMASP.Focus()
                    If txtMASP.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtMAHD.Focus()
                        If txtMAHD.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập mã hóa đơn", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            txtSOHD.Focus()
                            If txtSOHD.Text = "" Then
                                MessageBox.Show("Bạn chưa nhập số hóa đơn", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else
                                txtSL.Focus()
                                If txtSL.Text = "" Then
                                    MessageBox.Show("Bạn chưa nhập số lượng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                                Else
                                    txtDONGIA.Focus()
                                    If txtDONGIA.Text = "" Then
                                        MessageBox.Show("Bạn chưa nhập đơn giá", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                                    Else
                                        addupdate.Parameters.AddWithValue("@MAKH", txtMAKH.Text)
                                        addupdate.Parameters.AddWithValue("@MASP", txtMASP.Text)
                                        addupdate.Parameters.AddWithValue("@MAHD", txtMAHD.Text)
                                        addupdate.Parameters.AddWithValue("@SOHD", txtSOHD.Text)
                                        addupdate.Parameters.AddWithValue("@SL", txtSL.Text)
                                        addupdate.Parameters.AddWithValue("@DONGIA", txtDONGIA.Text)
                                        addupdate.ExecuteNonQuery()
                                        conn.Close() 'đóng kết nối
                                        MessageBox.Show("Cập nhật thành công")
                                        txtMASP.Text = Nothing
                                        txtMAKH.Text = Nothing
                                        txtMAHD.Text = Nothing
                                        txtSOHD.Text = Nothing
                                        txtSL.Text = Nothing
                                        txtDONGIA.Text = Nothing
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            End Try
        End If
        'Sau khi cập nhật xong sẽ tự làm mới lại bảng
        db.Clear()
        dgvQLHD.DataSource = db
        dgvQLHD.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnDEL2_Click(sender As Object, e As EventArgs) Handles btnDEL2.Click
        Dim conn As SqlConnection = New SqlConnection(SQLControl.Sqlconstring)
        Dim delquery As String = "delete from CHITIETHOADON where SOHD=@MAHD delete from HOADON where MAHD=@MAHD"
        Dim delete As SqlCommand = New SqlCommand(delquery, conn)
        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        conn.Open()
        Try
            If txtMASP.Text = "" Then
                MessageBox.Show("Bạn cần nhập số hóa đơn", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                txtMASP.Focus()
            Else
                If resulft = Windows.Forms.DialogResult.Yes Then
                    delete.Parameters.AddWithValue("@MASP", txtMASP.Text)
                    delete.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Xóa thành công")
                    'Sau khi xóa thành công, tự động làm mới các khung textbox
                    txtMASP.Text = Nothing
                    txtMAKH.Text = Nothing
                    txtMAHD.Text = Nothing
                    txtSOHD.Text = Nothing
                    txtSL.Text = Nothing
                    txtDONGIA.Text = Nothing
                    txtMAKH.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Nhập đúng số hóa đơn cần xóa", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'làm mới bảng
        db.Clear()
        dgvQLHD.DataSource = db
        dgvQLHD.DataSource = Nothing
        LoadData()
    End Sub

    Private Function GetDataTable() As DataTable
        Dim dataTable As New DataTable("MyDataTable")
        'Create another DataColumn Name
        Dim dataColumn_1 As New DataColumn(dgvQLHD.Columns(0).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_1)
        Dim dataColumn_2 As New DataColumn(dgvQLHD.Columns(1).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_2)
        Dim dataColumn_3 As New DataColumn(dgvQLHD.Columns(2).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_3)
        Dim dataColumn_4 As New DataColumn(dgvQLHD.Columns(3).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_4)
        Dim dataColumn_5 As New DataColumn(dgvQLHD.Columns(4).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_5)
        Dim dataColumn_6 As New DataColumn(dgvQLHD.Columns(5).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_6)
        Dim dataColumn_7 As New DataColumn(dgvQLHD.Columns(6).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_7)
        Dim dataColumn_8 As New DataColumn(dgvQLHD.Columns(7).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_8)
        
        'Now Add some row to newly created dataTable
        Dim dataRow As DataRow
        For i As Integer = 0 To dgvQLHD.Rows.Count - 1
            dataRow = dataTable.NewRow()
            ' Important you have create New row
            dataRow(dgvQLHD.Columns(0).HeaderText.ToString()) = dgvQLHD.Rows(i).Cells(0).Value.ToString()
            dataRow(dgvQLHD.Columns(1).HeaderText.ToString()) = dgvQLHD.Rows(i).Cells(1).Value.ToString()
            dataRow(dgvQLHD.Columns(2).HeaderText.ToString()) = dgvQLHD.Rows(i).Cells(2).Value.ToString()
            dataRow(dgvQLHD.Columns(3).HeaderText.ToString()) = dgvQLHD.Rows(i).Cells(3).Value.ToString()
            dataRow(dgvQLHD.Columns(4).HeaderText.ToString()) = dgvQLHD.Rows(i).Cells(4).Value.ToString()
            dataRow(dgvQLHD.Columns(5).HeaderText.ToString()) = dgvQLHD.Rows(i).Cells(5).Value.ToString()
            dataRow(dgvQLHD.Columns(6).HeaderText.ToString()) = dgvQLHD.Rows(i).Cells(6).Value.ToString()
            dataRow(dgvQLHD.Columns(7).HeaderText.ToString()) = dgvQLHD.Rows(i).Cells(7).Value.ToString()


            dataTable.Rows.Add(dataRow)
        Next
        dataTable.AcceptChanges()
        Return dataTable
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        SaveFileDialog1.ShowDialog()
        If SaveFileDialog1.FileName = "" Then
            MsgBox("Enter Filename to create PDF")
            Exit Sub
        Else
            ExportDataToPDFTable()
            MsgBox("PDF Created Successfully")
        End If
    End Sub
    Private Sub ExportDataToPDFTable()
        Dim arial As BaseFont = BaseFont.CreateFont(
    "c:\windows\fonts\ARIAL.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED)

        Dim tittle As New Font(arial, 16, FontStyle.Bold, BaseColor.RED)
        Dim font12Bold As New Font(arial, 12, FontStyle.Bold, BaseColor.BLACK)
        Dim font12Normal As New Font(arial, 12, FontStyle.Regular, BaseColor.BLACK)

        Dim paragraph As New Paragraph
        Dim doc As New Document(iTextSharp.text.PageSize.LETTER.Rotate(), 25, 25, 30, 30)
        Dim wri As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(SaveFileDialog1.FileName + ".pdf", FileMode.Create))
        doc.Open()


        Dim p1 As New Phrase
        p1 = New Phrase(New Chunk("DANH SÁCH HÓA ĐƠN", tittle))
        doc.Add(p1)

        'Create instance of the pdf table and set the number of column in that table
        Dim PdfTable As New PdfPTable(8)
        PdfTable.TotalWidth = 600.0F
        'fix the absolute width of the table
        PdfTable.LockedWidth = True
        'relative col widths in proportions - 1,4,1,1 and 1
        Dim widths As Single() = New Single() {5.0F, 1.0F, 5.0F, 1.0F, 1.0F, 1.0F, 4.5F, 1.0F}
        PdfTable.SetWidths(widths)
        PdfTable.HorizontalAlignment = 1 ' 0 --> Left, 1 --> Center, 2 --> Right
        PdfTable.SpacingBefore = 3.0F

        'pdfCell Decleration
        Dim PdfPCell As PdfPCell = Nothing

        'Assigning values to each cell as phrases
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Tên KH", font12Bold)))
        'Alignment of phrase in the pdfcell
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        'Add pdfcell in pdftable
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Mã SP", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Tên SP", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Mã HD", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Số HD", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("SL", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("ĐG", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
       
        Dim dt As DataTable = GetDataTable()
        If dt IsNot Nothing Then
            'Now add the data from datatable to pdf table
            For rows As Integer = 0 To dt.Rows.Count - 1
                For column As Integer = 0 To dt.Columns.Count - 1
                    PdfPCell = New PdfPCell(New Phrase(dt.Rows(rows)(column).ToString(), font12Normal))
                    If column = 0 Or column = 1 Then
                        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    Else
                        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                    End If
                    PdfTable.AddCell(PdfPCell)
                Next
            Next
            'Adding pdftable to the pdfdocument
            doc.Add(PdfTable)
        End If
        doc.Close()
    End Sub
End Class