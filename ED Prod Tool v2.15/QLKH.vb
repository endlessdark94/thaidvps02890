Imports System.Data.DataTable
Imports System.Data.SqlClient
Imports iTextSharp
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.Data.Odbc
Imports System.IO


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
        Dim dataColumn_1 As New DataColumn(dgvQLKH.Columns(0).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_1)
        Dim dataColumn_2 As New DataColumn(dgvQLKH.Columns(1).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_2)
        Dim dataColumn_3 As New DataColumn(dgvQLKH.Columns(2).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_3)
        Dim dataColumn_4 As New DataColumn(dgvQLKH.Columns(3).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_4)
        Dim dataColumn_5 As New DataColumn(dgvQLKH.Columns(4).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_5)
        'Now Add some row to newly created dataTable
        Dim dataRow As DataRow
        For i As Integer = 0 To dgvQLKH.Rows.Count - 1
            dataRow = dataTable.NewRow()
            ' Important you have create New row
            dataRow(dgvQLKH.Columns(0).HeaderText.ToString()) = dgvQLKH.Rows(i).Cells(0).Value.ToString()
            dataRow(dgvQLKH.Columns(1).HeaderText.ToString()) = dgvQLKH.Rows(i).Cells(1).Value.ToString()
            dataRow(dgvQLKH.Columns(2).HeaderText.ToString()) = dgvQLKH.Rows(i).Cells(2).Value.ToString()
            dataRow(dgvQLKH.Columns(3).HeaderText.ToString()) = dgvQLKH.Rows(i).Cells(3).Value.ToString()
            dataRow(dgvQLKH.Columns(4).HeaderText.ToString()) = dgvQLKH.Rows(i).Cells(4).Value.ToString()

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
        p1 = New Phrase(New Chunk("DANH SÁCH KHÁCH HÀNG", tittle))
        doc.Add(p1)

        'Create instance of the pdf table and set the number of column in that table
        Dim PdfTable As New PdfPTable(5)
        PdfTable.TotalWidth = 490.0F
        'fix the absolute width of the table
        PdfTable.LockedWidth = True
        'relative col widths in proportions - 1,4,1,1 and 1
        Dim widths As Single() = New Single() {0.5F, 1.5F, 1.5F, 1.2F, 3.2F}
        PdfTable.SetWidths(widths)
        PdfTable.HorizontalAlignment = 1 ' 0 --> Left, 1 --> Center, 2 --> Right
        PdfTable.SpacingBefore = 2.0F

        'pdfCell Decleration
        Dim PdfPCell As PdfPCell = Nothing

        'Assigning values to each cell as phrases
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Mã KH", font12Bold)))
        'Alignment of phrase in the pdfcell
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        'Add pdfcell in pdftable
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Tên KH", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Địa Chỉ", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Số Điện Thoại", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Email", font12Bold)))
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