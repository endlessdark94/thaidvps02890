<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLHD
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
        Me.dgvQLHD = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtADD2 = New System.Windows.Forms.Button()
        Me.btnEDIT2 = New System.Windows.Forms.Button()
        Me.btnDEL2 = New System.Windows.Forms.Button()
        Me.btnRefresh2 = New System.Windows.Forms.Button()
        Me.txtMAKH = New System.Windows.Forms.TextBox()
        Me.txtMASP = New System.Windows.Forms.TextBox()
        Me.txtSOHD = New System.Windows.Forms.TextBox()
        Me.txtMAHD = New System.Windows.Forms.TextBox()
        Me.txtSL = New System.Windows.Forms.TextBox()
        Me.txtDONGIA = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.dgvQLHD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvQLHD
        '
        Me.dgvQLHD.AllowUserToAddRows = False
        Me.dgvQLHD.AllowUserToDeleteRows = False
        Me.dgvQLHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvQLHD.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvQLHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvQLHD.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvQLHD.Location = New System.Drawing.Point(12, 193)
        Me.dgvQLHD.Name = "dgvQLHD"
        Me.dgvQLHD.ReadOnly = True
        Me.dgvQLHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvQLHD.Size = New System.Drawing.Size(686, 164)
        Me.dgvQLHD.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Mã KH"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Mã SP"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(322, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Số HD"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(322, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 16)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Mã HD"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(322, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 16)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Số lượng"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(322, 108)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 16)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Đơn giá"
        '
        'txtADD2
        '
        Me.txtADD2.Location = New System.Drawing.Point(47, 148)
        Me.txtADD2.Name = "txtADD2"
        Me.txtADD2.Size = New System.Drawing.Size(75, 23)
        Me.txtADD2.TabIndex = 43
        Me.txtADD2.Text = "Thêm"
        Me.txtADD2.UseVisualStyleBackColor = True
        '
        'btnEDIT2
        '
        Me.btnEDIT2.Location = New System.Drawing.Point(179, 148)
        Me.btnEDIT2.Name = "btnEDIT2"
        Me.btnEDIT2.Size = New System.Drawing.Size(75, 23)
        Me.btnEDIT2.TabIndex = 44
        Me.btnEDIT2.Text = "Sửa"
        Me.btnEDIT2.UseVisualStyleBackColor = True
        '
        'btnDEL2
        '
        Me.btnDEL2.Location = New System.Drawing.Point(308, 148)
        Me.btnDEL2.Name = "btnDEL2"
        Me.btnDEL2.Size = New System.Drawing.Size(75, 23)
        Me.btnDEL2.TabIndex = 45
        Me.btnDEL2.Text = "Xóa"
        Me.btnDEL2.UseVisualStyleBackColor = True
        '
        'btnRefresh2
        '
        Me.btnRefresh2.Location = New System.Drawing.Point(440, 148)
        Me.btnRefresh2.Name = "btnRefresh2"
        Me.btnRefresh2.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh2.TabIndex = 46
        Me.btnRefresh2.Text = "Refresh"
        Me.btnRefresh2.UseVisualStyleBackColor = True
        '
        'txtMAKH
        '
        Me.txtMAKH.Location = New System.Drawing.Point(103, 8)
        Me.txtMAKH.Name = "txtMAKH"
        Me.txtMAKH.Size = New System.Drawing.Size(179, 20)
        Me.txtMAKH.TabIndex = 47
        '
        'txtMASP
        '
        Me.txtMASP.Location = New System.Drawing.Point(103, 40)
        Me.txtMASP.Name = "txtMASP"
        Me.txtMASP.Size = New System.Drawing.Size(179, 20)
        Me.txtMASP.TabIndex = 48
        '
        'txtSOHD
        '
        Me.txtSOHD.Location = New System.Drawing.Point(404, 5)
        Me.txtSOHD.Name = "txtSOHD"
        Me.txtSOHD.Size = New System.Drawing.Size(179, 20)
        Me.txtSOHD.TabIndex = 49
        '
        'txtMAHD
        '
        Me.txtMAHD.Location = New System.Drawing.Point(404, 40)
        Me.txtMAHD.Name = "txtMAHD"
        Me.txtMAHD.Size = New System.Drawing.Size(179, 20)
        Me.txtMAHD.TabIndex = 50
        '
        'txtSL
        '
        Me.txtSL.Location = New System.Drawing.Point(404, 75)
        Me.txtSL.Name = "txtSL"
        Me.txtSL.Size = New System.Drawing.Size(179, 20)
        Me.txtSL.TabIndex = 51
        '
        'txtDONGIA
        '
        Me.txtDONGIA.Location = New System.Drawing.Point(404, 107)
        Me.txtDONGIA.Name = "txtDONGIA"
        Me.txtDONGIA.Size = New System.Drawing.Size(179, 20)
        Me.txtDONGIA.TabIndex = 52
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(577, 144)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 30)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "Export to PDF"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmQLHD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 366)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtDONGIA)
        Me.Controls.Add(Me.txtSL)
        Me.Controls.Add(Me.txtMAHD)
        Me.Controls.Add(Me.txtSOHD)
        Me.Controls.Add(Me.txtMASP)
        Me.Controls.Add(Me.txtMAKH)
        Me.Controls.Add(Me.btnRefresh2)
        Me.Controls.Add(Me.btnDEL2)
        Me.Controls.Add(Me.btnEDIT2)
        Me.Controls.Add(Me.txtADD2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvQLHD)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmQLHD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QLHD"
        CType(Me.dgvQLHD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvQLHD As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtADD2 As System.Windows.Forms.Button
    Friend WithEvents btnEDIT2 As System.Windows.Forms.Button
    Friend WithEvents btnDEL2 As System.Windows.Forms.Button
    Friend WithEvents btnRefresh2 As System.Windows.Forms.Button
    Friend WithEvents txtMAKH As System.Windows.Forms.TextBox
    Friend WithEvents txtMASP As System.Windows.Forms.TextBox
    Friend WithEvents txtSOHD As System.Windows.Forms.TextBox
    Friend WithEvents txtMAHD As System.Windows.Forms.TextBox
    Friend WithEvents txtSL As System.Windows.Forms.TextBox
    Friend WithEvents txtDONGIA As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
