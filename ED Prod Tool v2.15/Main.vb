Imports System.Data.SqlClient


Public Class frmMain

    Private Sub ThoátToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mniExit.Click
        'hiện messagebox với 2 nút lệnh yes/no khi ấn thoát 
        Dim result As Integer = MessageBox.Show("Thoát chương trình?", "ED Smart Manager", MessageBoxButtons.YesNo)
        'chương trình đóng khi ấn Yes & quay trở lại của sổ đăng nhập nếu ấn No
        If result = DialogResult.Yes Then
            Me.Close()
            Me.Close()
            frmLogin.Close()
            frmLoading.Close()
        End If
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExit.Click
     

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lvwhistory.Items.Clear()
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = SQLControl.Sqlconstring
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM LoginHistory ORDER BY time desc"
        Dim dr As SqlDataReader = cmd.ExecuteReader()

        Do While dr.Read()
            Dim new_item As New  _
     ListViewItem(dr.Item("time").ToString)
            new_item.SubItems.Add(dr.Item("userID").ToString)
            new_item.SubItems.Add(dr.Item("username").ToString)
            new_item.SubItems.Add(dr.Item("hostname").ToString)
            new_item.SubItems.Add(dr.Item("ip").ToString)
            new_item.SubItems.Add(dr.Item("mac").ToString)
            lvwhistory.Items.Add(new_item)
        Loop
        con.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim result As Integer = MessageBox.Show("Clear History?", "ED Smart Manager", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Try
                con.ConnectionString = SQLControl.Sqlconstring
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "DELETE FROM LoginHistory"
                cmd.ExecuteNonQuery()

            Catch ex As Exception
                MessageBox.Show("Error while clear record on table..." & ex.Message, "Clear Records")
            Finally
                con.Close()
                lvwhistory.Items.Clear()
            End Try
        End If
    End Sub

    Private Sub mniHomepage_Click(sender As Object, e As EventArgs) Handles mniHomepage.Click
        Dim Home As String = "http://www.facebook.com/endlessdark94"

        Process.Start(Home)

    End Sub

    Private Sub mniAbout_Click(sender As Object, e As EventArgs) Handles mniAbout.Click
        Dim CT As String = "https://www.youtube.com/c/EndlessDarkMusique "

        Process.Start(CT)

    End Sub

    Private Sub mniReset_Click(sender As Object, e As EventArgs) Handles mniReset.Click
        frmXemKH.Show()
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles tsbExitt.Click
        'hiện messagebox với 2 nút lệnh yes/no khi ấn thoát 
        Dim result As Integer = MessageBox.Show("Thoát chương trình?", "ED SMart Manager", MessageBoxButtons.YesNo)
        'chương trình đóng khi ấn Yes & quay trở lại của sổ đăng nhập nếu ấn No
        If result = DialogResult.Yes Then
            Me.Close()
            Me.Close()
            frmLogin.Close()
            frmLoading.Close()
        End If
    End Sub

    Private Sub QuảnLýKHToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýKHToolStripMenuItem.Click
        frmQLKH.Show()
    End Sub

    Private Sub lvwhistory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwhistory.SelectedIndexChanged

    End Sub

    Private Sub mniSupp_Click(sender As Object, e As EventArgs) Handles mniSupp.Click

    End Sub

    Private Sub mniFunction_Click(sender As Object, e As EventArgs) Handles mniFunction.Click
        frmXemSP.Show()
    End Sub

    Private Sub QuảnLýSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýSảnPhẩmToolStripMenuItem.Click
        frmQLSP.Show()
    End Sub

    Private Sub XemHóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XemHóaĐơnToolStripMenuItem.Click
        frmXemHD.Show()
    End Sub

    Private Sub QuảnLíHóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLíHóaĐơnToolStripMenuItem.Click
        frmQLHD.Show()
    End Sub
End Class