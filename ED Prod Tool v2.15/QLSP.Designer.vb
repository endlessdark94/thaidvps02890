<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLSP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQLSP))
        Me.txtSOLUONG = New System.Windows.Forms.TextBox()
        Me.txtTENLOAI = New System.Windows.Forms.TextBox()
        Me.txtMALOAI = New System.Windows.Forms.TextBox()
        Me.txtTENSP = New System.Windows.Forms.TextBox()
        Me.txtMASP = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRefresh2 = New System.Windows.Forms.Button()
        Me.btnDEL2 = New System.Windows.Forms.Button()
        Me.btnEDIT2 = New System.Windows.Forms.Button()
        Me.txtADD2 = New System.Windows.Forms.Button()
        Me.dgvQLSP = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.dgvQLSP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSOLUONG
        '
        Me.txtSOLUONG.Location = New System.Drawing.Point(151, 112)
        Me.txtSOLUONG.Name = "txtSOLUONG"
        Me.txtSOLUONG.Size = New System.Drawing.Size(179, 20)
        Me.txtSOLUONG.TabIndex = 20
        '
        'txtTENLOAI
        '
        Me.txtTENLOAI.Location = New System.Drawing.Point(151, 86)
        Me.txtTENLOAI.Name = "txtTENLOAI"
        Me.txtTENLOAI.Size = New System.Drawing.Size(179, 20)
        Me.txtTENLOAI.TabIndex = 19
        '
        'txtMALOAI
        '
        Me.txtMALOAI.Location = New System.Drawing.Point(151, 60)
        Me.txtMALOAI.Name = "txtMALOAI"
        Me.txtMALOAI.Size = New System.Drawing.Size(179, 20)
        Me.txtMALOAI.TabIndex = 18
        '
        'txtTENSP
        '
        Me.txtTENSP.Location = New System.Drawing.Point(151, 34)
        Me.txtTENSP.Name = "txtTENSP"
        Me.txtTENSP.Size = New System.Drawing.Size(179, 20)
        Me.txtTENSP.TabIndex = 17
        '
        'txtMASP
        '
        Me.txtMASP.Location = New System.Drawing.Point(151, 9)
        Me.txtMASP.Name = "txtMASP"
        Me.txtMASP.Size = New System.Drawing.Size(179, 20)
        Me.txtMASP.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 16)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Số lượng"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 16)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Mã loại"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Tên loại"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Tên sản phẩm"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Mã sản phẩm"
        '
        'btnRefresh2
        '
        Me.btnRefresh2.Location = New System.Drawing.Point(292, 146)
        Me.btnRefresh2.Name = "btnRefresh2"
        Me.btnRefresh2.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh2.TabIndex = 24
        Me.btnRefresh2.Text = "Refresh"
        Me.btnRefresh2.UseVisualStyleBackColor = True
        '
        'btnDEL2
        '
        Me.btnDEL2.Location = New System.Drawing.Point(195, 146)
        Me.btnDEL2.Name = "btnDEL2"
        Me.btnDEL2.Size = New System.Drawing.Size(75, 23)
        Me.btnDEL2.TabIndex = 23
        Me.btnDEL2.Text = "Xóa"
        Me.btnDEL2.UseVisualStyleBackColor = True
        '
        'btnEDIT2
        '
        Me.btnEDIT2.Location = New System.Drawing.Point(105, 146)
        Me.btnEDIT2.Name = "btnEDIT2"
        Me.btnEDIT2.Size = New System.Drawing.Size(75, 23)
        Me.btnEDIT2.TabIndex = 22
        Me.btnEDIT2.Text = "Sửa"
        Me.btnEDIT2.UseVisualStyleBackColor = True
        '
        'txtADD2
        '
        Me.txtADD2.Location = New System.Drawing.Point(13, 146)
        Me.txtADD2.Name = "txtADD2"
        Me.txtADD2.Size = New System.Drawing.Size(75, 23)
        Me.txtADD2.TabIndex = 21
        Me.txtADD2.Text = "Thêm"
        Me.txtADD2.UseVisualStyleBackColor = True
        '
        'dgvQLSP
        '
        Me.dgvQLSP.AllowUserToAddRows = False
        Me.dgvQLSP.AllowUserToDeleteRows = False
        Me.dgvQLSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvQLSP.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvQLSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvQLSP.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvQLSP.Location = New System.Drawing.Point(12, 192)
        Me.dgvQLSP.Name = "dgvQLSP"
        Me.dgvQLSP.ReadOnly = True
        Me.dgvQLSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvQLSP.Size = New System.Drawing.Size(494, 207)
        Me.dgvQLSP.TabIndex = 25
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(378, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 30)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Export to PDF"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmQLSP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 405)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgvQLSP)
        Me.Controls.Add(Me.btnRefresh2)
        Me.Controls.Add(Me.btnDEL2)
        Me.Controls.Add(Me.btnEDIT2)
        Me.Controls.Add(Me.txtADD2)
        Me.Controls.Add(Me.txtSOLUONG)
        Me.Controls.Add(Me.txtTENLOAI)
        Me.Controls.Add(Me.txtMALOAI)
        Me.Controls.Add(Me.txtTENSP)
        Me.Controls.Add(Me.txtMASP)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmQLSP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QLSP"
        CType(Me.dgvQLSP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSOLUONG As System.Windows.Forms.TextBox
    Friend WithEvents txtTENLOAI As System.Windows.Forms.TextBox
    Friend WithEvents txtMALOAI As System.Windows.Forms.TextBox
    Friend WithEvents txtTENSP As System.Windows.Forms.TextBox
    Friend WithEvents txtMASP As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnRefresh2 As System.Windows.Forms.Button
    Friend WithEvents btnDEL2 As System.Windows.Forms.Button
    Friend WithEvents btnEDIT2 As System.Windows.Forms.Button
    Friend WithEvents txtADD2 As System.Windows.Forms.Button
    Friend WithEvents dgvQLSP As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
