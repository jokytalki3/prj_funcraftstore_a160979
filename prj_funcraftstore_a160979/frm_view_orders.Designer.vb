<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_view_orders
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_view_orders))
        Me.btn_back = New System.Windows.Forms.Button()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.list_order = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_orderID = New System.Windows.Forms.Label()
        Me.lbl_shopSubTitle = New System.Windows.Forms.Label()
        Me.lbl_shopTitle = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grd_order_record = New System.Windows.Forms.DataGridView()
        CType(Me.grd_order_record, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_back
        '
        Me.btn_back.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_back.Font = New System.Drawing.Font("Georgia", 7.8!)
        Me.btn_back.Location = New System.Drawing.Point(20, 628)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(100, 28)
        Me.btn_back.TabIndex = 27
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'txt_total
        '
        Me.txt_total.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.Location = New System.Drawing.Point(1053, 554)
        Me.txt_total.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(196, 38)
        Me.txt_total.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Georgia", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(987, 554)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 24)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Total:"
        '
        'lbl_date
        '
        Me.lbl_date.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Font = New System.Drawing.Font("Georgia", 12.0!)
        Me.lbl_date.Location = New System.Drawing.Point(1130, 156)
        Me.lbl_date.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(70, 24)
        Me.lbl_date.TabIndex = 24
        Me.lbl_date.Text = "Label9"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Georgia", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(1075, 156)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 24)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Date:"
        '
        'list_order
        '
        Me.list_order.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.list_order.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_order.FormattingEnabled = True
        Me.list_order.ItemHeight = 24
        Me.list_order.Location = New System.Drawing.Point(814, 139)
        Me.list_order.Margin = New System.Windows.Forms.Padding(4)
        Me.list_order.Name = "list_order"
        Me.list_order.Size = New System.Drawing.Size(169, 100)
        Me.list_order.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Georgia", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(669, 156)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 24)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Select Order:"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(16, 199)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 20)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Tel No: 010-9702291"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(16, 230)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(241, 20)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Email: tzesheng@hotmail.com"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(16, 168)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(204, 20)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "97000, Bintulu, Sarawak."
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(16, 139)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(258, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "No.342, Jalan Tun Hussein Onn,"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(982, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 53)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "INVOICE"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Georgia", 12.0!)
        Me.Label10.Location = New System.Drawing.Point(1037, 185)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 24)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Order ID:"
        '
        'lbl_orderID
        '
        Me.lbl_orderID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_orderID.AutoSize = True
        Me.lbl_orderID.Font = New System.Drawing.Font("Georgia", 12.0!)
        Me.lbl_orderID.Location = New System.Drawing.Point(1130, 185)
        Me.lbl_orderID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_orderID.Name = "lbl_orderID"
        Me.lbl_orderID.Size = New System.Drawing.Size(70, 24)
        Me.lbl_orderID.TabIndex = 29
        Me.lbl_orderID.Text = "Label9"
        '
        'lbl_shopSubTitle
        '
        Me.lbl_shopSubTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_shopSubTitle.AutoSize = True
        Me.lbl_shopSubTitle.Font = New System.Drawing.Font("Georgia", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl_shopSubTitle.Location = New System.Drawing.Point(24, 62)
        Me.lbl_shopSubTitle.Name = "lbl_shopSubTitle"
        Me.lbl_shopSubTitle.Size = New System.Drawing.Size(368, 23)
        Me.lbl_shopSubTitle.TabIndex = 32
        Me.lbl_shopSubTitle.Text = "Where the Crafty Creations Belongs"
        '
        'lbl_shopTitle
        '
        Me.lbl_shopTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_shopTitle.AutoSize = True
        Me.lbl_shopTitle.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_shopTitle.Font = New System.Drawing.Font("Stencil", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_shopTitle.Location = New System.Drawing.Point(20, 16)
        Me.lbl_shopTitle.Name = "lbl_shopTitle"
        Me.lbl_shopTitle.Size = New System.Drawing.Size(364, 46)
        Me.lbl_shopTitle.TabIndex = 31
        Me.lbl_shopTitle.Text = "Fun Craft Store"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(468, 603)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(327, 53)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "THANK YOU!"
        '
        'grd_order_record
        '
        Me.grd_order_record.AllowUserToAddRows = False
        Me.grd_order_record.AllowUserToDeleteRows = False
        Me.grd_order_record.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grd_order_record.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grd_order_record.BackgroundColor = System.Drawing.Color.White
        Me.grd_order_record.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.NullValue = Nothing
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grd_order_record.DefaultCellStyle = DataGridViewCellStyle1
        Me.grd_order_record.Location = New System.Drawing.Point(13, 264)
        Me.grd_order_record.Margin = New System.Windows.Forms.Padding(4)
        Me.grd_order_record.Name = "grd_order_record"
        Me.grd_order_record.ReadOnly = True
        Me.grd_order_record.Size = New System.Drawing.Size(1236, 282)
        Me.grd_order_record.TabIndex = 34
        '
        'frm_view_orders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 669)
        Me.Controls.Add(Me.grd_order_record)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_shopSubTitle)
        Me.Controls.Add(Me.lbl_shopTitle)
        Me.Controls.Add(Me.lbl_orderID)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.list_order)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_view_orders"
        Me.Text = "frm_view_orders"
        CType(Me.grd_order_record, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_back As System.Windows.Forms.Button
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbl_date As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents list_order As System.Windows.Forms.ListBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lbl_orderID As System.Windows.Forms.Label
    Friend WithEvents lbl_shopSubTitle As System.Windows.Forms.Label
    Friend WithEvents lbl_shopTitle As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grd_order_record As System.Windows.Forms.DataGridView
End Class
