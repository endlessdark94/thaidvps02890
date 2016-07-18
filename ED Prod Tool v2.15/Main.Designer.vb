<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.stsMain = New System.Windows.Forms.StatusStrip()
        Me.tslmain = New System.Windows.Forms.ToolStripStatusLabel()
        Me.mniHethong = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniReset = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýKHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniSupp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniFunction = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýSảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniProm = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniHomepage = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsMain = New System.Windows.Forms.MenuStrip()
        Me.HóaĐơnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XemHóaĐơnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tosMain = New System.Windows.Forms.ToolStrip()
        Me.tsbAbout = New System.Windows.Forms.ToolStripButton()
        Me.tsbMinimize = New System.Windows.Forms.ToolStripButton()
        Me.tsbExit = New System.Windows.Forms.ToolStripButton()
        Me.lvwhistory = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnClear = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbExitt = New System.Windows.Forms.ToolStripButton()
        Me.QuảnLíHóaĐơnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.stsMain.SuspendLayout()
        Me.mnsMain.SuspendLayout()
        Me.tosMain.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'stsMain
        '
        Me.stsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslmain})
        Me.stsMain.Location = New System.Drawing.Point(0, 346)
        Me.stsMain.Name = "stsMain"
        Me.stsMain.Size = New System.Drawing.Size(712, 22)
        Me.stsMain.TabIndex = 1
        Me.stsMain.Text = "stsMain"
        '
        'tslmain
        '
        Me.tslmain.Name = "tslmain"
        Me.tslmain.Size = New System.Drawing.Size(247, 17)
        Me.tslmain.Text = "Powered by EndlessDark™. All rights reserved."
        '
        'mniHethong
        '
        Me.mniHethong.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniReset, Me.QuảnLýKHToolStripMenuItem, Me.mniExit})
        Me.mniHethong.Name = "mniHethong"
        Me.mniHethong.Size = New System.Drawing.Size(84, 20)
        Me.mniHethong.Text = "Khách Hàng"
        '
        'mniReset
        '
        Me.mniReset.Name = "mniReset"
        Me.mniReset.Size = New System.Drawing.Size(166, 22)
        Me.mniReset.Text = "Xem Khách Hàng"
        '
        'QuảnLýKHToolStripMenuItem
        '
        Me.QuảnLýKHToolStripMenuItem.Name = "QuảnLýKHToolStripMenuItem"
        Me.QuảnLýKHToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.QuảnLýKHToolStripMenuItem.Text = "Quản Lý KH"
        '
        'mniExit
        '
        Me.mniExit.Name = "mniExit"
        Me.mniExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.mniExit.Size = New System.Drawing.Size(166, 22)
        Me.mniExit.Text = "Thoát"
        '
        'mniSupp
        '
        Me.mniSupp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniFunction, Me.QuảnLýSảnPhẩmToolStripMenuItem})
        Me.mniSupp.Name = "mniSupp"
        Me.mniSupp.Size = New System.Drawing.Size(73, 20)
        Me.mniSupp.Text = "Sản Phẩm"
        '
        'mniFunction
        '
        Me.mniFunction.Name = "mniFunction"
        Me.mniFunction.Size = New System.Drawing.Size(175, 22)
        Me.mniFunction.Text = "Xem Sản Phẩm"
        '
        'QuảnLýSảnPhẩmToolStripMenuItem
        '
        Me.QuảnLýSảnPhẩmToolStripMenuItem.Name = "QuảnLýSảnPhẩmToolStripMenuItem"
        Me.QuảnLýSảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.QuảnLýSảnPhẩmToolStripMenuItem.Text = "Quản Lý Sản Phẩm"
        '
        'mniProm
        '
        Me.mniProm.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniHomepage, Me.mniAbout})
        Me.mniProm.Name = "mniProm"
        Me.mniProm.Size = New System.Drawing.Size(70, 20)
        Me.mniProm.Text = "Giới thiệu"
        '
        'mniHomepage
        '
        Me.mniHomepage.Name = "mniHomepage"
        Me.mniHomepage.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.mniHomepage.Size = New System.Drawing.Size(169, 22)
        Me.mniHomepage.Text = "Trang chủ"
        '
        'mniAbout
        '
        Me.mniAbout.Name = "mniAbout"
        Me.mniAbout.Size = New System.Drawing.Size(169, 22)
        Me.mniAbout.Text = "Về chúng tôi"
        '
        'mnsMain
        '
        Me.mnsMain.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniHethong, Me.mniSupp, Me.HóaĐơnToolStripMenuItem, Me.mniProm})
        Me.mnsMain.Location = New System.Drawing.Point(0, 0)
        Me.mnsMain.Name = "mnsMain"
        Me.mnsMain.Size = New System.Drawing.Size(712, 24)
        Me.mnsMain.TabIndex = 0
        Me.mnsMain.Text = "mnsMain"
        '
        'HóaĐơnToolStripMenuItem
        '
        Me.HóaĐơnToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.XemHóaĐơnToolStripMenuItem, Me.QuảnLíHóaĐơnToolStripMenuItem})
        Me.HóaĐơnToolStripMenuItem.Name = "HóaĐơnToolStripMenuItem"
        Me.HóaĐơnToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.HóaĐơnToolStripMenuItem.Text = "Hóa Đơn"
        '
        'XemHóaĐơnToolStripMenuItem
        '
        Me.XemHóaĐơnToolStripMenuItem.Name = "XemHóaĐơnToolStripMenuItem"
        Me.XemHóaĐơnToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.XemHóaĐơnToolStripMenuItem.Text = "Xem Hóa Đơn"
        '
        'tosMain
        '
        Me.tosMain.Dock = System.Windows.Forms.DockStyle.None
        Me.tosMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAbout, Me.tsbMinimize, Me.tsbExit})
        Me.tosMain.Location = New System.Drawing.Point(1183, 0)
        Me.tosMain.Name = "tosMain"
        Me.tosMain.Size = New System.Drawing.Size(81, 25)
        Me.tosMain.TabIndex = 4
        Me.tosMain.Text = "tosMain"
        '
        'tsbAbout
        '
        Me.tsbAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAbout.Image = Global.ED_Prod_Tool_v2._15.My.Resources.Resources.sign_computer_icon_symbol_signs_info_information
        Me.tsbAbout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAbout.Name = "tsbAbout"
        Me.tsbAbout.Size = New System.Drawing.Size(23, 22)
        '
        'tsbMinimize
        '
        Me.tsbMinimize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbMinimize.Image = Global.ED_Prod_Tool_v2._15.My.Resources.Resources.minimize_box_blue
        Me.tsbMinimize.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbMinimize.Name = "tsbMinimize"
        Me.tsbMinimize.Size = New System.Drawing.Size(23, 22)
        Me.tsbMinimize.Text = "Thu nhỏ"
        '
        'tsbExit
        '
        Me.tsbExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbExit.Image = Global.ED_Prod_Tool_v2._15.My.Resources.Resources.Button_Close_icon
        Me.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExit.Name = "tsbExit"
        Me.tsbExit.Size = New System.Drawing.Size(23, 22)
        Me.tsbExit.Text = "Thoát"
        '
        'lvwhistory
        '
        Me.lvwhistory.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lvwhistory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lvwhistory.Cursor = System.Windows.Forms.Cursors.Default
        Me.lvwhistory.FullRowSelect = True
        Me.lvwhistory.GridLines = True
        Me.lvwhistory.HideSelection = False
        Me.lvwhistory.Location = New System.Drawing.Point(27, 107)
        Me.lvwhistory.MultiSelect = False
        Me.lvwhistory.Name = "lvwhistory"
        Me.lvwhistory.Size = New System.Drawing.Size(665, 223)
        Me.lvwhistory.TabIndex = 5
        Me.lvwhistory.UseCompatibleStateImageBehavior = False
        Me.lvwhistory.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Time"
        Me.ColumnHeader1.Width = 127
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "UserID"
        Me.ColumnHeader2.Width = 71
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "UserName"
        Me.ColumnHeader3.Width = 74
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "PC-Name"
        Me.ColumnHeader4.Width = 93
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "IP Adress"
        Me.ColumnHeader5.Width = 118
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "MAC Adress"
        Me.ColumnHeader6.Width = 147
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(574, 72)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(118, 27)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear History"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(27, 66)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(152, 28)
        Me.TextBox1.TabIndex = 8
        Me.TextBox1.Text = "Login History"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbExitt})
        Me.ToolStrip1.Location = New System.Drawing.Point(681, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(35, 25)
        Me.ToolStrip1.TabIndex = 9
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbExitt
        '
        Me.tsbExitt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbExitt.Image = Global.ED_Prod_Tool_v2._15.My.Resources.Resources.Button_Close_icon
        Me.tsbExitt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExitt.Name = "tsbExitt"
        Me.tsbExitt.Size = New System.Drawing.Size(23, 22)
        Me.tsbExitt.Text = "Exit"
        '
        'QuảnLíHóaĐơnToolStripMenuItem
        '
        Me.QuảnLíHóaĐơnToolStripMenuItem.Name = "QuảnLíHóaĐơnToolStripMenuItem"
        Me.QuảnLíHóaĐơnToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.QuảnLíHóaĐơnToolStripMenuItem.Text = "Quản Lí Hóa Đơn"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ED_Prod_Tool_v2._15.My.Resources.Resources.maxresdefault
        Me.ClientSize = New System.Drawing.Size(712, 368)
        Me.ControlBox = False
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lvwhistory)
        Me.Controls.Add(Me.tosMain)
        Me.Controls.Add(Me.stsMain)
        Me.Controls.Add(Me.mnsMain)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnsMain
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ED SMART MANAGER BY Thaidvps02890@fpt.edu.vn"
        Me.stsMain.ResumeLayout(False)
        Me.stsMain.PerformLayout()
        Me.mnsMain.ResumeLayout(False)
        Me.mnsMain.PerformLayout()
        Me.tosMain.ResumeLayout(False)
        Me.tosMain.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents stsMain As System.Windows.Forms.StatusStrip
    Friend WithEvents tslmain As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents mniHethong As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniReset As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniSupp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniFunction As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniProm As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniHomepage As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnsMain As System.Windows.Forms.MenuStrip
    Friend WithEvents tosMain As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbMinimize As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbAbout As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents lvwhistory As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents QuảnLýKHToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbExitt As System.Windows.Forms.ToolStripButton
    Friend WithEvents QuảnLýSảnPhẩmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HóaĐơnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XemHóaĐơnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuảnLíHóaĐơnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
