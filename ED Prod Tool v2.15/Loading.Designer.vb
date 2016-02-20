<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoading
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoading))
        Me.lblDescriptloading = New System.Windows.Forms.Label()
        Me.prbLoading = New System.Windows.Forms.ProgressBar()
        Me.tmrLoading = New System.Windows.Forms.Timer(Me.components)
        Me.lblAdloading = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblDescriptloading
        '
        Me.lblDescriptloading.AutoSize = True
        Me.lblDescriptloading.BackColor = System.Drawing.Color.Transparent
        Me.lblDescriptloading.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescriptloading.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblDescriptloading.Location = New System.Drawing.Point(676, 217)
        Me.lblDescriptloading.Name = "lblDescriptloading"
        Me.lblDescriptloading.Size = New System.Drawing.Size(202, 63)
        Me.lblDescriptloading.TabIndex = 4
        Me.lblDescriptloading.Text = "ED Smart Manager" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Author: EndlessDark" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "endlessdark94@gmail.com "
        '
        'prbLoading
        '
        Me.prbLoading.BackColor = System.Drawing.SystemColors.Control
        Me.prbLoading.ForeColor = System.Drawing.Color.Transparent
        Me.prbLoading.Location = New System.Drawing.Point(28, 285)
        Me.prbLoading.Name = "prbLoading"
        Me.prbLoading.Size = New System.Drawing.Size(840, 10)
        Me.prbLoading.TabIndex = 5
        Me.prbLoading.Value = 1
        '
        'tmrLoading
        '
        Me.tmrLoading.Enabled = True
        Me.tmrLoading.Interval = 40
        '
        'lblAdloading
        '
        Me.lblAdloading.AutoSize = True
        Me.lblAdloading.BackColor = System.Drawing.Color.Transparent
        Me.lblAdloading.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdloading.ForeColor = System.Drawing.Color.Navy
        Me.lblAdloading.Location = New System.Drawing.Point(113, 245)
        Me.lblAdloading.Name = "lblAdloading"
        Me.lblAdloading.Size = New System.Drawing.Size(554, 30)
        Me.lblAdloading.TabIndex = 6
        Me.lblAdloading.Text = "PHẦN MỀM QUẢN LÝ KHÁCH HÀNG CHUYÊN NGHIỆP"
        '
        'frmLoading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ED_Prod_Tool_v2._15.My.Resources.Resources.calculating_hands
        Me.ClientSize = New System.Drawing.Size(900, 300)
        Me.Controls.Add(Me.lblAdloading)
        Me.Controls.Add(Me.prbLoading)
        Me.Controls.Add(Me.lblDescriptloading)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLoading"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loading"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDescriptloading As System.Windows.Forms.Label
    Friend WithEvents prbLoading As System.Windows.Forms.ProgressBar
    Friend WithEvents tmrLoading As System.Windows.Forms.Timer
    Friend WithEvents lblAdloading As System.Windows.Forms.Label
End Class
