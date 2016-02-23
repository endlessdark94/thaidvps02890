Imports System.Data.DataTable
Imports System.Data.SqlClient
Imports iTextSharp
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.Data.Odbc
Imports System.IO
Public Class frmQLSP
    Dim db As New DataTable
    Private Sub frmQLSP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As SqlConnection = New SqlConnection(SQLControl.Sqlconstring)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select SANPHAM.MASP ,SANPHAM.TENSP, LOAISANPHAM.MALOAI, LOAISANPHAM.TENLOAI, SANPHAM.SOLUONG from SANPHAM inner join LOAISANPHAM on SANPHAM.MASP = LOAISANPHAM.MASP", conn)

        conn.Open()
        load.Fill(db)
        dgvQLSP.DataSource = db.DefaultView
        conn.Close()
    End Sub

    Private Sub dgvQLSP_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvQLSP.CellContentClick
        Dim click As Integer = dgvQLSP.CurrentRow.Index
        txtMASP.Text = dgvQLSP.Item(0, click).Value
        txtTENSP.Text = dgvQLSP.Item(1, click).Value
        txtMALOAI.Text = dgvQLSP.Item(2, click).Value
        txtTENLOAI.Text = dgvQLSP.Item(3, click).Value
        txtSOLUONG.Text = dgvQLSP.Item(4, click).Value
    End Sub

    Private Sub btnRefresh2_Click(sender As Object, e As EventArgs) Handles btnRefresh2.Click
        db.Clear()
        dgvQLSP.DataSource = db
        dgvQLSP.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(SQLControl.Sqlconstring)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select SANPHAM.MASP ,SANPHAM.TENSP, LOAISANPHAM.MALOAI, LOAISANPHAM.TENLOAI, SANPHAM.SOLUONG from SANPHAM inner join LOAISANPHAM on SANPHAM.MASP = LOAISANPHAM.MASP", conn)

        conn.Open()
        load.Fill(db)
        dgvQLSP.DataSource = db.DefaultView
        conn.Close()
    End Sub

    Private Sub txtADD2_Click(sender As Object, e As EventArgs) Handles txtADD2.Click
        Dim result As Integer = MessageBox.Show("Xác nhận thêm sản phẩm?", "ED Smart Manager", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Dim conn As SqlConnection = New SqlConnection(SQLControl.Sqlconstring)
            Dim query As String = "insert into SANPHAM values(@MASP,@TENSP,@SOLUONG) insert into LOAISANPHAM values(@MALOAI,@MASP,@TENLOAI)"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            Try
                txtMASP.Focus()
                If txtMASP.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtMASP.Focus()
                    If txtTENSP.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtTENSP.Focus()
                        If txtMALOAI.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập mã loại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            txtMALOAI.Focus()
                            If txtSOLUONG.Text = "" Then
                                MessageBox.Show("Bạn chưa nhập số lượng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else
                                save.Parameters.AddWithValue("@MASP", txtMASP.Text)
                                save.Parameters.AddWithValue("@TENSP", txtTENSP.Text)
                                save.Parameters.AddWithValue("@MALOAI", txtMALOAI.Text)
                                save.Parameters.AddWithValue("@TENLOAI", txtTENLOAI.Text)
                                save.Parameters.AddWithValue("@SOLUONG", txtSOLUONG.Text)
                                save.ExecuteNonQuery()
                                MessageBox.Show("Lưu thành công")
                                'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                                txtMASP.Text = Nothing
                                txtMALOAI.Text = Nothing
                                txtSOLUONG.Text = Nothing
                                txtTENSP.Text = Nothing
                                txtTENLOAI.Text = Nothing

                            End If
                        End If
                    End If
                End If
            Catch ex As Exception  'Ngược lại báo lỗi
                MessageBox.Show("Không được trùng mã sản phẩm", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            End Try
        End If
db.Clear()
        dgvQLSP.DataSource = db
        dgvQLSP.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnEDIT2_Click(sender As Object, e As EventArgs) Handles btnEDIT2.Click
        Dim result As Integer = MessageBox.Show("Mã SP & Mã loại (PR) không thể thay đổi, Xác nhận sửa tài khoản?", "ED Smart Manager", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Dim conn As SqlConnection = New SqlConnection(SQLControl.Sqlconstring)
            Dim updatequery As String = "update SANPHAM set MASP=@MASP, TENSP=@TENSP, SOLUONG=@SOLUONG where MASP=@MASP update LOAISANPHAM set MALOAI=@MALOAI, MASP=@MASP, TENLOAI=@TENLOAI where MASP=@MASP"
            Dim addupdate As SqlCommand = New SqlCommand(updatequery, conn)
            conn.Open()
            Try
                txtMASP.Focus()
                If txtMASP.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtMASP.Focus()
                    If txtTENSP.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtTENSP.Focus()
                        If txtMALOAI.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập mã loại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            txtMALOAI.Focus()
                            If txtSOLUONG.Text = "" Then
                                MessageBox.Show("Bạn chưa nhập số lượng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else
                                addupdate.Parameters.AddWithValue("@MASP", txtMASP.Text)
                                addupdate.Parameters.AddWithValue("@TENSP", txtTENSP.Text)
                                addupdate.Parameters.AddWithValue("@MALOAI", txtMALOAI.Text)
                                addupdate.Parameters.AddWithValue("@TENLOAI", txtTENLOAI.Text)
                                addupdate.Parameters.AddWithValue("@SOLUONG", txtSOLUONG.Text)
                                addupdate.ExecuteNonQuery()
                                conn.Close() 'đóng kết nối
                                MessageBox.Show("Cập nhật thành công")
                                txtMASP.Text = Nothing
                                txtTENSP.Text = Nothing
                                txtMALOAI.Text = Nothing
                                txtTENLOAI.Text = Nothing
                                txtSOLUONG.Text = Nothing
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
        dgvQLSP.DataSource = db
        dgvQLSP.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnDEL2_Click(sender As Object, e As EventArgs) Handles btnDEL2.Click
        Dim conn As SqlConnection = New SqlConnection(SQLControl.Sqlconstring)
        Dim delquery As String = "delete from LOAISANPHAM where MASP=@MASP delete from SANPHAM where MASP=@MASP"
        Dim delete As SqlCommand = New SqlCommand(delquery, conn)
        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        conn.Open()
        Try
            If txtMASP.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                txtMASP.Focus()
            Else
                If resulft = Windows.Forms.DialogResult.Yes Then
                    delete.Parameters.AddWithValue("@MASP", txtMASP.Text)
                    delete.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Xóa thành công")
                    'Sau khi xóa thành công, tự động làm mới các khung textbox
                    txtMASP.Text = Nothing
                    txtTENSP.Text = Nothing
                    txtMALOAI.Text = Nothing
                    txtTENLOAI.Text = Nothing
                    txtSOLUONG.Text = Nothing
                    txtMASP.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Nhập đúng mã sản phẩm cần xóa", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'làm mới bảng
        db.Clear()
        dgvQLSP.DataSource = db
        dgvQLSP.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SaveFileDialog1.ShowDialog()
        If SaveFileDialog1.FileName = "" Then
            MsgBox("Enter Filename to create PDF")
            Exit Sub
        Else
            ExportDataToPDFTable()
            MsgBox("PDF Created Successfully")
        End If
    End Sub

    Private Function GetDataTable() As DataTable
        Dim dataTable As New DataTable("MyDataTable")
        'Create another DataColumn Name
        Dim dataColumn_1 As New DataColumn(dgvQLSP.Columns(0).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_1)
        Dim dataColumn_2 As New DataColumn(dgvQLSP.Columns(1).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_2)
        Dim dataColumn_3 As New DataColumn(dgvQLSP.Columns(2).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_3)
        Dim dataColumn_4 As New DataColumn(dgvQLSP.Columns(3).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_4)
        Dim dataColumn_5 As New DataColumn(dgvQLSP.Columns(4).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_5)
        'Now Add some row to newly created dataTable
        Dim dataRow As DataRow
        For i As Integer = 0 To dgvQLSP.Rows.Count - 1
            dataRow = dataTable.NewRow()
            ' Important you have create New row
            dataRow(dgvQLSP.Columns(0).HeaderText.ToString()) = dgvQLSP.Rows(i).Cells(0).Value.ToString()
            dataRow(dgvQLSP.Columns(1).HeaderText.ToString()) = dgvQLSP.Rows(i).Cells(1).Value.ToString()
            dataRow(dgvQLSP.Columns(2).HeaderText.ToString()) = dgvQLSP.Rows(i).Cells(2).Value.ToString()
            dataRow(dgvQLSP.Columns(3).HeaderText.ToString()) = dgvQLSP.Rows(i).Cells(3).Value.ToString()
            dataRow(dgvQLSP.Columns(4).HeaderText.ToString()) = dgvQLSP.Rows(i).Cells(4).Value.ToString()

            dataTable.Rows.Add(dataRow)
        Next
        dataTable.AcceptChanges()
        Return dataTable
    End Function

    Private Sub ExportDataToPDFTable()
        Dim arial As BaseFont = BaseFont.CreateFont(
    "c:\windows\fonts\ARIAL.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED)

        Dim tittle As New Font(arial, 16, FontStyle.Bold, BaseColor.RED)
        Dim font12Bold As New Font(arial, 12, FontStyle.Bold, BaseColor.BLACK)
        Dim font12Normal As New Font(arial, 12, FontStyle.Regular, BaseColor.BLACK)

        Dim paragraph As New Paragraph
        Dim doc As New Document(iTextSharp.text.PageSize.A4, 40, 40, 40, 10)
        Dim wri As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(SaveFileDialog1.FileName + ".pdf", FileMode.Create))
        doc.Open()


        Dim p1 As New Phrase
        p1 = New Phrase(New Chunk("DANH SÁCH SẢN PHẨM", tittle))
        doc.Add(p1)

        'Create instance of the pdf table and set the number of column in that table
        Dim PdfTable As New PdfPTable(5)
        PdfTable.TotalWidth = 490.0F
        'fix the absolute width of the table
        PdfTable.LockedWidth = True
        'relative col widths in proportions - 1,4,1,1 and 1
        Dim widths As Single() = New Single() {1.0F, 2.5F, 1.0F, 2.5F, 1.0F}
        PdfTable.SetWidths(widths)
        PdfTable.HorizontalAlignment = 1 ' 0 --> Left, 1 --> Center, 2 --> Right
        PdfTable.SpacingBefore = 2.0F

        'pdfCell Decleration
        Dim PdfPCell As PdfPCell = Nothing

        'Assigning values to each cell as phrases
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Mã SP", font12Bold)))
        'Alignment of phrase in the pdfcell
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        'Add pdfcell in pdftable
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Tên SP", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Mã Loại", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Tên Loại", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Số Lượng", font12Bold)))
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