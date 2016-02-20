<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLKH
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQLKH))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMAKH = New System.Windows.Forms.TextBox()
        Me.txtTENKH = New System.Windows.Forms.TextBox()
        Me.txtDIACHI = New System.Windows.Forms.TextBox()
        Me.txtSDT = New System.Windows.Forms.TextBox()
        Me.txtEMAIL = New System.Windows.Forms.TextBox()
        Me.txtADD = New System.Windows.Forms.Button()
        Me.btnEDIT = New System.Windows.Forms.Button()
        Me.btnDEL = New System.Windows.Forms.Button()
        Me.dgvQLKH = New System.Windows.Forms.DataGridView()
        Me.btnRefresh = New System.Windows.Forms.Button()
        CType(Me.dgvQLKH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã khách hàng"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên khách hàng"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Số điện thoại"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Địa chỉ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Email"
        '
        'txtMAKH
        '
        Me.txtMAKH.Location = New System.Drawing.Point(151, 21)
        Me.txtMAKH.Name = "txtMAKH"
        Me.txtMAKH.Size = New System.Drawing.Size(179, 20)
        Me.txtMAKH.TabIndex = 6
        '
        'txtTENKH
        '
        Me.txtTENKH.Location = New System.Drawing.Point(151, 46)
        Me.txtTENKH.Name = "txtTENKH"
        Me.txtTENKH.Size = New System.Drawing.Size(179, 20)
        Me.txtTENKH.TabIndex = 7
        '
        'txtDIACHI
        '
        Me.txtDIACHI.Location = New System.Drawing.Point(151, 72)
        Me.txtDIACHI.Name = "txtDIACHI"
        Me.txtDIACHI.Size = New System.Drawing.Size(179, 20)
        Me.txtDIACHI.TabIndex = 8
        '
        'txtSDT
        '
        Me.txtSDT.Location = New System.Drawing.Point(151, 98)
        Me.txtSDT.Name = "txtSDT"
        Me.txtSDT.Size = New System.Drawing.Size(179, 20)
        Me.txtSDT.TabIndex = 9
        '
        'txtEMAIL
        '
        Me.txtEMAIL.Location = New System.Drawing.Point(151, 124)
        Me.txtEMAIL.Name = "txtEMAIL"
        Me.txtEMAIL.Size = New System.Drawing.Size(179, 20)
        Me.txtEMAIL.TabIndex = 10
        '
        'txtADD
        '
        Me.txtADD.Location = New System.Drawing.Point(13, 155)
        Me.txtADD.Name = "txtADD"
        Me.txtADD.Size = New System.Drawing.Size(75, 23)
        Me.txtADD.TabIndex = 11
        Me.txtADD.Text = "Thêm"
        Me.txtADD.UseVisualStyleBackColor = True
        '
        'btnEDIT
        '
        Me.btnEDIT.Location = New System.Drawing.Point(105, 155)
        Me.btnEDIT.Name = "btnEDIT"
        Me.btnEDIT.Size = New System.Drawing.Size(75, 23)
        Me.btnEDIT.TabIndex = 12
        Me.btnEDIT.Text = "Sửa"
        Me.btnEDIT.UseVisualStyleBackColor = True
        '
        'btnDEL
        '
        Me.btnDEL.Location = New System.Drawing.Point(195, 155)
        Me.btnDEL.Name = "btnDEL"
        Me.btnDEL.Size = New System.Drawing.Size(75, 23)
        Me.btnDEL.TabIndex = 13
        Me.btnDEL.Text = "Xóa"
        Me.btnDEL.UseVisualStyleBackColor = True
        '
        'dgvQLKH
        '
        Me.dgvQLKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvQLKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvQLKH.GridColor = System.Drawing.SystemColors.Window
        Me.dgvQLKH.Location = New System.Drawing.Point(13, 194)
        Me.dgvQLKH.Name = "dgvQLKH"
        Me.dgvQLKH.ReadOnly = True
        Me.dgvQLKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvQLKH.Size = New System.Drawing.Size(494, 207)
        Me.dgvQLKH.TabIndex = 14
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(292, 155)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 15
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'frmQLKH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 406)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.dgvQLKH)
        Me.Controls.Add(Me.btnDEL)
        Me.Controls.Add(Me.btnEDIT)
        Me.Controls.Add(Me.txtADD)
        Me.Controls.Add(Me.txtEMAIL)
        Me.Controls.Add(Me.txtSDT)
        Me.Controls.Add(Me.txtDIACHI)
        Me.Controls.Add(Me.txtTENKH)
        Me.Controls.Add(Me.txtMAKH)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmQLKH"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QLKH"
        CType(Me.dgvQLKH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMAKH As System.Windows.Forms.TextBox
    Friend WithEvents txtTENKH As System.Windows.Forms.TextBox
    Friend WithEvents txtDIACHI As System.Windows.Forms.TextBox
    Friend WithEvents txtSDT As System.Windows.Forms.TextBox
    Friend WithEvents txtEMAIL As System.Windows.Forms.TextBox
    Friend WithEvents txtADD As System.Windows.Forms.Button
    Friend WithEvents btnEDIT As System.Windows.Forms.Button
    Friend WithEvents btnDEL As System.Windows.Forms.Button
    Friend WithEvents dgvQLKH As System.Windows.Forms.DataGridView
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
End Class
