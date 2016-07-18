Public Class frmLoading
    'Đồng hồ đếm giá trị để chạy Progress Bar
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLoading.Tick
        'Khi đồng hồ chạy đến giá trị 100 sẽ hiển thị form giao diện chính của phần mềm & ẩn form loading phần mềm
        prbLoading.Increment(1)
        If prbLoading.Value = 100 Then
            frmMain.Show()
            Me.Hide()
        End If
    End Sub
End Class