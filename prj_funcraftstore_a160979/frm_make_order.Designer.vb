<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_make_order
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_make_order))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_confirm = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_order = New System.Windows.Forms.Button()
        Me.list_product = New System.Windows.Forms.ListBox()
        Me.txt_sub = New System.Windows.Forms.TextBox()
        Me.order_quantity = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_sub = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.product_details = New System.Windows.Forms.GroupBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_description = New System.Windows.Forms.TextBox()
        Me.txt_type = New System.Windows.Forms.TextBox()
        Me.txt_madefrom = New System.Windows.Forms.TextBox()
        Me.txt_category = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_order_id = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.groupbox2 = New System.Windows.Forms.GroupBox()
        Me.txt_staff_tel = New System.Windows.Forms.TextBox()
        Me.txt_staff_name = New System.Windows.Forms.TextBox()
        Me.list_staff = New System.Windows.Forms.ListBox()
        Me.lbl_staff_name = New System.Windows.Forms.Label()
        Me.lbl_staff_tel = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.list_cust = New System.Windows.Forms.ListBox()
        Me.txt_cust_tel = New System.Windows.Forms.TextBox()
        Me.txt_cust_name = New System.Windows.Forms.TextBox()
        Me.lbl_cust_name = New System.Windows.Forms.Label()
        Me.lbl_cust_tel = New System.Windows.Forms.Label()
        Me.product_pic = New System.Windows.Forms.PictureBox()
        Me.grd_orders = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.order_quantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.product_details.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.groupbox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.product_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_orders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Georgia", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(536, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Make Order"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_confirm)
        Me.Panel1.Controls.Add(Me.btn_delete)
        Me.Panel1.Controls.Add(Me.btn_order)
        Me.Panel1.Controls.Add(Me.list_product)
        Me.Panel1.Controls.Add(Me.txt_sub)
        Me.Panel1.Controls.Add(Me.order_quantity)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.lbl_sub)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.product_details)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.groupbox2)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.product_pic)
        Me.Panel1.Font = New System.Drawing.Font("Georgia", 7.8!)
        Me.Panel1.Location = New System.Drawing.Point(3, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1267, 521)
        Me.Panel1.TabIndex = 1
        '
        'btn_confirm
        '
        Me.btn_confirm.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_confirm.Location = New System.Drawing.Point(1027, 460)
        Me.btn_confirm.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(174, 40)
        Me.btn_confirm.TabIndex = 132
        Me.btn_confirm.Text = "Confirm Order"
        Me.btn_confirm.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_delete.Location = New System.Drawing.Point(866, 461)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(153, 39)
        Me.btn_delete.TabIndex = 131
        Me.btn_delete.Text = "Delete Order"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_order
        '
        Me.btn_order.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_order.Location = New System.Drawing.Point(710, 460)
        Me.btn_order.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_order.Name = "btn_order"
        Me.btn_order.Size = New System.Drawing.Size(148, 40)
        Me.btn_order.TabIndex = 130
        Me.btn_order.Text = "Add Order"
        Me.btn_order.UseVisualStyleBackColor = True
        '
        'list_product
        '
        Me.list_product.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_product.FormattingEnabled = True
        Me.list_product.ItemHeight = 17
        Me.list_product.Location = New System.Drawing.Point(16, 411)
        Me.list_product.Margin = New System.Windows.Forms.Padding(4)
        Me.list_product.Name = "list_product"
        Me.list_product.Size = New System.Drawing.Size(185, 106)
        Me.list_product.TabIndex = 117
        '
        'txt_sub
        '
        Me.txt_sub.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sub.Location = New System.Drawing.Point(516, 467)
        Me.txt_sub.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_sub.Name = "txt_sub"
        Me.txt_sub.ReadOnly = True
        Me.txt_sub.Size = New System.Drawing.Size(177, 23)
        Me.txt_sub.TabIndex = 116
        '
        'order_quantity
        '
        Me.order_quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.order_quantity.Location = New System.Drawing.Point(259, 467)
        Me.order_quantity.Margin = New System.Windows.Forms.Padding(4)
        Me.order_quantity.Name = "order_quantity"
        Me.order_quantity.Size = New System.Drawing.Size(120, 23)
        Me.order_quantity.TabIndex = 113
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Georgia", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(14, 383)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(144, 24)
        Me.Label9.TabIndex = 133
        Me.Label9.Text = "Select Product:"
        '
        'lbl_sub
        '
        Me.lbl_sub.AutoSize = True
        Me.lbl_sub.Font = New System.Drawing.Font("Georgia", 12.0!)
        Me.lbl_sub.Location = New System.Drawing.Point(411, 466)
        Me.lbl_sub.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_sub.Name = "lbl_sub"
        Me.lbl_sub.Size = New System.Drawing.Size(106, 24)
        Me.lbl_sub.TabIndex = 115
        Me.lbl_sub.Text = "Sub Total: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Georgia", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(255, 439)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 24)
        Me.Label8.TabIndex = 112
        Me.Label8.Text = "Quantity:"
        '
        'product_details
        '
        Me.product_details.Controls.Add(Me.txt_price)
        Me.product_details.Controls.Add(Me.txt_description)
        Me.product_details.Controls.Add(Me.txt_type)
        Me.product_details.Controls.Add(Me.txt_madefrom)
        Me.product_details.Controls.Add(Me.txt_category)
        Me.product_details.Controls.Add(Me.txt_name)
        Me.product_details.Controls.Add(Me.Label7)
        Me.product_details.Controls.Add(Me.Label6)
        Me.product_details.Controls.Add(Me.Label5)
        Me.product_details.Controls.Add(Me.Label4)
        Me.product_details.Controls.Add(Me.Label3)
        Me.product_details.Controls.Add(Me.lbl_name)
        Me.product_details.Location = New System.Drawing.Point(410, 226)
        Me.product_details.Name = "product_details"
        Me.product_details.Size = New System.Drawing.Size(840, 208)
        Me.product_details.TabIndex = 8
        Me.product_details.TabStop = False
        Me.product_details.Text = "Product Details"
        '
        'txt_price
        '
        Me.txt_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_price.Location = New System.Drawing.Point(86, 146)
        Me.txt_price.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.ReadOnly = True
        Me.txt_price.Size = New System.Drawing.Size(113, 23)
        Me.txt_price.TabIndex = 109
        '
        'txt_description
        '
        Me.txt_description.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_description.Location = New System.Drawing.Point(468, 146)
        Me.txt_description.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_description.Multiline = True
        Me.txt_description.Name = "txt_description"
        Me.txt_description.ReadOnly = True
        Me.txt_description.Size = New System.Drawing.Size(352, 43)
        Me.txt_description.TabIndex = 107
        '
        'txt_type
        '
        Me.txt_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_type.Location = New System.Drawing.Point(86, 99)
        Me.txt_type.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_type.Name = "txt_type"
        Me.txt_type.ReadOnly = True
        Me.txt_type.Size = New System.Drawing.Size(113, 23)
        Me.txt_type.TabIndex = 103
        '
        'txt_madefrom
        '
        Me.txt_madefrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_madefrom.Location = New System.Drawing.Point(656, 99)
        Me.txt_madefrom.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_madefrom.Name = "txt_madefrom"
        Me.txt_madefrom.ReadOnly = True
        Me.txt_madefrom.Size = New System.Drawing.Size(146, 23)
        Me.txt_madefrom.TabIndex = 105
        '
        'txt_category
        '
        Me.txt_category.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_category.Location = New System.Drawing.Point(337, 99)
        Me.txt_category.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_category.Name = "txt_category"
        Me.txt_category.ReadOnly = True
        Me.txt_category.Size = New System.Drawing.Size(178, 23)
        Me.txt_category.TabIndex = 101
        '
        'txt_name
        '
        Me.txt_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(86, 32)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_name.Multiline = True
        Me.txt_name.Name = "txt_name"
        Me.txt_name.ReadOnly = True
        Me.txt_name.Size = New System.Drawing.Size(725, 46)
        Me.txt_name.TabIndex = 100
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Georgia", 11.0!)
        Me.Label7.Location = New System.Drawing.Point(16, 146)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 23)
        Me.Label7.TabIndex = 110
        Me.Label7.Text = "Price:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 11.0!)
        Me.Label6.Location = New System.Drawing.Point(333, 146)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 23)
        Me.Label6.TabIndex = 108
        Me.Label6.Text = "Description:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 11.0!)
        Me.Label5.Location = New System.Drawing.Point(523, 96)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 23)
        Me.Label5.TabIndex = 106
        Me.Label5.Text = "Made From:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 11.0!)
        Me.Label4.Location = New System.Drawing.Point(17, 99)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 23)
        Me.Label4.TabIndex = 104
        Me.Label4.Text = "Type:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 11.0!)
        Me.Label3.Location = New System.Drawing.Point(222, 96)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 23)
        Me.Label3.TabIndex = 102
        Me.Label3.Text = "Category:"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Georgia", 11.0!)
        Me.lbl_name.Location = New System.Drawing.Point(7, 32)
        Me.lbl_name.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(67, 23)
        Me.lbl_name.TabIndex = 99
        Me.lbl_name.Text = "Name:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_order_id)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(374, 81)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Order ID Generator"
        '
        'txt_order_id
        '
        Me.txt_order_id.Location = New System.Drawing.Point(123, 39)
        Me.txt_order_id.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_order_id.Name = "txt_order_id"
        Me.txt_order_id.ReadOnly = True
        Me.txt_order_id.Size = New System.Drawing.Size(139, 22)
        Me.txt_order_id.TabIndex = 126
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Order ID:"
        '
        'groupbox2
        '
        Me.groupbox2.Controls.Add(Me.txt_staff_tel)
        Me.groupbox2.Controls.Add(Me.txt_staff_name)
        Me.groupbox2.Controls.Add(Me.list_staff)
        Me.groupbox2.Controls.Add(Me.lbl_staff_name)
        Me.groupbox2.Controls.Add(Me.lbl_staff_tel)
        Me.groupbox2.Location = New System.Drawing.Point(410, 13)
        Me.groupbox2.Margin = New System.Windows.Forms.Padding(10)
        Me.groupbox2.Name = "groupbox2"
        Me.groupbox2.Size = New System.Drawing.Size(400, 200)
        Me.groupbox2.TabIndex = 5
        Me.groupbox2.TabStop = False
        Me.groupbox2.Text = "Choose Staff"
        '
        'txt_staff_tel
        '
        Me.txt_staff_tel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_staff_tel.Location = New System.Drawing.Point(166, 161)
        Me.txt_staff_tel.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_staff_tel.Name = "txt_staff_tel"
        Me.txt_staff_tel.ReadOnly = True
        Me.txt_staff_tel.Size = New System.Drawing.Size(205, 23)
        Me.txt_staff_tel.TabIndex = 128
        '
        'txt_staff_name
        '
        Me.txt_staff_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_staff_name.Location = New System.Drawing.Point(166, 110)
        Me.txt_staff_name.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_staff_name.Name = "txt_staff_name"
        Me.txt_staff_name.ReadOnly = True
        Me.txt_staff_name.Size = New System.Drawing.Size(205, 23)
        Me.txt_staff_name.TabIndex = 129
        '
        'list_staff
        '
        Me.list_staff.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_staff.FormattingEnabled = True
        Me.list_staff.ItemHeight = 17
        Me.list_staff.Location = New System.Drawing.Point(21, 22)
        Me.list_staff.Margin = New System.Windows.Forms.Padding(4)
        Me.list_staff.Name = "list_staff"
        Me.list_staff.Size = New System.Drawing.Size(358, 72)
        Me.list_staff.TabIndex = 127
        '
        'lbl_staff_name
        '
        Me.lbl_staff_name.AutoSize = True
        Me.lbl_staff_name.Font = New System.Drawing.Font("Georgia", 11.0!)
        Me.lbl_staff_name.Location = New System.Drawing.Point(17, 108)
        Me.lbl_staff_name.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_staff_name.Name = "lbl_staff_name"
        Me.lbl_staff_name.Size = New System.Drawing.Size(77, 23)
        Me.lbl_staff_name.TabIndex = 130
        Me.lbl_staff_name.Text = "Name  :"
        '
        'lbl_staff_tel
        '
        Me.lbl_staff_tel.AutoSize = True
        Me.lbl_staff_tel.Font = New System.Drawing.Font("Georgia", 11.0!)
        Me.lbl_staff_tel.Location = New System.Drawing.Point(17, 159)
        Me.lbl_staff_tel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_staff_tel.Name = "lbl_staff_tel"
        Me.lbl_staff_tel.Size = New System.Drawing.Size(143, 23)
        Me.lbl_staff_tel.TabIndex = 131
        Me.lbl_staff_tel.Text = "Telephone No. :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.list_cust)
        Me.GroupBox3.Controls.Add(Me.txt_cust_tel)
        Me.GroupBox3.Controls.Add(Me.txt_cust_name)
        Me.GroupBox3.Controls.Add(Me.lbl_cust_name)
        Me.GroupBox3.Controls.Add(Me.lbl_cust_tel)
        Me.GroupBox3.Location = New System.Drawing.Point(830, 13)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(10)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(400, 200)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Choose Customer"
        '
        'list_cust
        '
        Me.list_cust.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_cust.FormattingEnabled = True
        Me.list_cust.ItemHeight = 17
        Me.list_cust.Location = New System.Drawing.Point(13, 22)
        Me.list_cust.Margin = New System.Windows.Forms.Padding(4)
        Me.list_cust.Name = "list_cust"
        Me.list_cust.Size = New System.Drawing.Size(358, 72)
        Me.list_cust.TabIndex = 125
        '
        'txt_cust_tel
        '
        Me.txt_cust_tel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cust_tel.Location = New System.Drawing.Point(177, 160)
        Me.txt_cust_tel.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cust_tel.Name = "txt_cust_tel"
        Me.txt_cust_tel.ReadOnly = True
        Me.txt_cust_tel.Size = New System.Drawing.Size(205, 23)
        Me.txt_cust_tel.TabIndex = 123
        '
        'txt_cust_name
        '
        Me.txt_cust_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cust_name.Location = New System.Drawing.Point(177, 110)
        Me.txt_cust_name.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cust_name.Name = "txt_cust_name"
        Me.txt_cust_name.ReadOnly = True
        Me.txt_cust_name.Size = New System.Drawing.Size(205, 23)
        Me.txt_cust_name.TabIndex = 124
        '
        'lbl_cust_name
        '
        Me.lbl_cust_name.AutoSize = True
        Me.lbl_cust_name.Font = New System.Drawing.Font("Georgia", 11.0!)
        Me.lbl_cust_name.Location = New System.Drawing.Point(9, 108)
        Me.lbl_cust_name.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_cust_name.Name = "lbl_cust_name"
        Me.lbl_cust_name.Size = New System.Drawing.Size(72, 23)
        Me.lbl_cust_name.TabIndex = 121
        Me.lbl_cust_name.Text = "Name :"
        '
        'lbl_cust_tel
        '
        Me.lbl_cust_tel.AutoSize = True
        Me.lbl_cust_tel.Font = New System.Drawing.Font("Georgia", 11.0!)
        Me.lbl_cust_tel.Location = New System.Drawing.Point(9, 159)
        Me.lbl_cust_tel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_cust_tel.Name = "lbl_cust_tel"
        Me.lbl_cust_tel.Size = New System.Drawing.Size(143, 23)
        Me.lbl_cust_tel.TabIndex = 122
        Me.lbl_cust_tel.Text = "Telephone No. :"
        '
        'product_pic
        '
        Me.product_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.product_pic.Location = New System.Drawing.Point(16, 104)
        Me.product_pic.Name = "product_pic"
        Me.product_pic.Size = New System.Drawing.Size(374, 262)
        Me.product_pic.TabIndex = 7
        Me.product_pic.TabStop = False
        '
        'grd_orders
        '
        Me.grd_orders.AllowUserToAddRows = False
        Me.grd_orders.AllowUserToDeleteRows = False
        Me.grd_orders.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grd_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_orders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grd_orders.DefaultCellStyle = DataGridViewCellStyle1
        Me.grd_orders.Location = New System.Drawing.Point(3, 576)
        Me.grd_orders.Name = "grd_orders"
        Me.grd_orders.ReadOnly = True
        Me.grd_orders.RowTemplate.Height = 24
        Me.grd_orders.Size = New System.Drawing.Size(1267, 217)
        Me.grd_orders.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "PRODUCT_ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "PRODUCT_NAME"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 400
        '
        'Column3
        '
        Me.Column3.HeaderText = "PRICE"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 80
        '
        'Column4
        '
        Me.Column4.HeaderText = "QUANTITY"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 80
        '
        'Column5
        '
        Me.Column5.HeaderText = "SUB_TOTAL"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "ORDER_DATE"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 120
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Georgia", 12.0!)
        Me.lbl_total.Location = New System.Drawing.Point(960, 801)
        Me.lbl_total.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(62, 24)
        Me.lbl_total.TabIndex = 117
        Me.lbl_total.Text = "Total:"
        '
        'txt_total
        '
        Me.txt_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.Location = New System.Drawing.Point(1040, 803)
        Me.txt_total.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.ReadOnly = True
        Me.txt_total.Size = New System.Drawing.Size(213, 23)
        Me.txt_total.TabIndex = 116
        '
        'btn_back
        '
        Me.btn_back.Font = New System.Drawing.Font("Georgia", 7.8!)
        Me.btn_back.Location = New System.Drawing.Point(3, 3)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(121, 29)
        Me.btn_back.TabIndex = 118
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'frm_make_order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_funcraftstore_a160979.My.Resources.Resources._11WhnTT
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1270, 836)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.grd_orders)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_make_order"
        Me.Text = "frm_make_order"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.order_quantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.product_details.ResumeLayout(False)
        Me.product_details.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.groupbox2.ResumeLayout(False)
        Me.groupbox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.product_pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_orders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents product_details As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_price As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_description As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_madefrom As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_type As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_category As System.Windows.Forms.TextBox
    Friend WithEvents lbl_name As System.Windows.Forms.Label
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_order_id As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents groupbox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_staff_name As System.Windows.Forms.Label
    Friend WithEvents lbl_staff_tel As System.Windows.Forms.Label
    Friend WithEvents txt_staff_tel As System.Windows.Forms.TextBox
    Friend WithEvents list_staff As System.Windows.Forms.ListBox
    Friend WithEvents txt_staff_name As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents list_cust As System.Windows.Forms.ListBox
    Friend WithEvents txt_cust_tel As System.Windows.Forms.TextBox
    Friend WithEvents txt_cust_name As System.Windows.Forms.TextBox
    Friend WithEvents lbl_cust_name As System.Windows.Forms.Label
    Friend WithEvents lbl_cust_tel As System.Windows.Forms.Label
    Friend WithEvents product_pic As System.Windows.Forms.PictureBox
    Friend WithEvents btn_confirm As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_order As System.Windows.Forms.Button
    Friend WithEvents list_product As System.Windows.Forms.ListBox
    Friend WithEvents txt_sub As System.Windows.Forms.TextBox
    Friend WithEvents lbl_sub As System.Windows.Forms.Label
    Friend WithEvents order_quantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents grd_orders As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_back As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
