<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mainmenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_mainmenu))
        Me.btn_staff = New System.Windows.Forms.Button()
        Me.btn_customer = New System.Windows.Forms.Button()
        Me.btn_products = New System.Windows.Forms.Button()
        Me.btn_orderlist = New System.Windows.Forms.Button()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_backmain = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_orders = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.btn_invoice = New System.Windows.Forms.Button()
        Me.btn_make_order = New System.Windows.Forms.Button()
        Me.lbl_shopSubTitle = New System.Windows.Forms.Label()
        Me.lbl_shopTitle = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_staff
        '
        Me.btn_staff.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_staff.AutoEllipsis = True
        Me.btn_staff.BackColor = System.Drawing.Color.Goldenrod
        Me.btn_staff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_staff.Font = New System.Drawing.Font("Georgia", 7.8!)
        Me.btn_staff.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_staff.Location = New System.Drawing.Point(137, 305)
        Me.btn_staff.Name = "btn_staff"
        Me.btn_staff.Size = New System.Drawing.Size(233, 43)
        Me.btn_staff.TabIndex = 1
        Me.btn_staff.Text = "Staff"
        Me.btn_staff.UseVisualStyleBackColor = False
        '
        'btn_customer
        '
        Me.btn_customer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_customer.AutoEllipsis = True
        Me.btn_customer.BackColor = System.Drawing.Color.ForestGreen
        Me.btn_customer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_customer.Font = New System.Drawing.Font("Georgia", 7.8!)
        Me.btn_customer.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_customer.Location = New System.Drawing.Point(137, 238)
        Me.btn_customer.Name = "btn_customer"
        Me.btn_customer.Size = New System.Drawing.Size(233, 43)
        Me.btn_customer.TabIndex = 2
        Me.btn_customer.Text = "Customer"
        Me.btn_customer.UseVisualStyleBackColor = False
        '
        'btn_products
        '
        Me.btn_products.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_products.AutoEllipsis = True
        Me.btn_products.BackColor = System.Drawing.Color.RoyalBlue
        Me.btn_products.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_products.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_products.Font = New System.Drawing.Font("Georgia", 7.8!)
        Me.btn_products.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_products.Location = New System.Drawing.Point(137, 32)
        Me.btn_products.Name = "btn_products"
        Me.btn_products.Size = New System.Drawing.Size(233, 43)
        Me.btn_products.TabIndex = 3
        Me.btn_products.Text = "Products"
        Me.btn_products.UseVisualStyleBackColor = False
        '
        'btn_orderlist
        '
        Me.btn_orderlist.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_orderlist.AutoSize = True
        Me.btn_orderlist.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_orderlist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_orderlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_orderlist.Font = New System.Drawing.Font("Georgia", 7.8!)
        Me.btn_orderlist.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_orderlist.Location = New System.Drawing.Point(137, 101)
        Me.btn_orderlist.Name = "btn_orderlist"
        Me.btn_orderlist.Size = New System.Drawing.Size(233, 43)
        Me.btn_orderlist.TabIndex = 6
        Me.btn_orderlist.Text = "Order Details"
        Me.btn_orderlist.UseVisualStyleBackColor = False
        '
        'lbl_date
        '
        Me.lbl_date.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Font = New System.Drawing.Font("Georgia", 9.0!)
        Me.lbl_date.Location = New System.Drawing.Point(707, 9)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(36, 18)
        Me.lbl_date.TabIndex = 7
        Me.lbl_date.Text = "date"
        Me.lbl_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_exit
        '
        Me.btn_exit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_exit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exit.Font = New System.Drawing.Font("Georgia", 7.8!)
        Me.btn_exit.Location = New System.Drawing.Point(595, 618)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(233, 43)
        Me.btn_exit.TabIndex = 8
        Me.btn_exit.Text = "Get me outta here!"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.btn_backmain)
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Controls.Add(Me.lbl_shopSubTitle)
        Me.Panel1.Controls.Add(Me.lbl_shopTitle)
        Me.Panel1.Controls.Add(Me.btn_exit)
        Me.Panel1.Controls.Add(Me.lbl_date)
        Me.Panel1.Font = New System.Drawing.Font("Georgia", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(210, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(842, 788)
        Me.Panel1.TabIndex = 9
        '
        'btn_backmain
        '
        Me.btn_backmain.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_backmain.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_backmain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btn_backmain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_backmain.Font = New System.Drawing.Font("Georgia", 7.8!)
        Me.btn_backmain.Location = New System.Drawing.Point(18, 618)
        Me.btn_backmain.Name = "btn_backmain"
        Me.btn_backmain.Size = New System.Drawing.Size(233, 43)
        Me.btn_backmain.TabIndex = 12
        Me.btn_backmain.Text = "Back to Main Screen"
        Me.btn_backmain.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TabControl1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(164, 128)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(515, 412)
        Me.TabControl1.TabIndex = 11
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.TabPage1.Controls.Add(Me.btn_orders)
        Me.TabPage1.Controls.Add(Me.btn_staff)
        Me.TabPage1.Controls.Add(Me.btn_products)
        Me.TabPage1.Controls.Add(Me.btn_orderlist)
        Me.TabPage1.Controls.Add(Me.btn_customer)
        Me.TabPage1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TabPage1.Font = New System.Drawing.Font("Lithos Pro Regular", 12.0!)
        Me.TabPage1.Location = New System.Drawing.Point(4, 33)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(507, 375)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Views"
        '
        'btn_orders
        '
        Me.btn_orders.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_orders.BackColor = System.Drawing.Color.Purple
        Me.btn_orders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btn_orders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_orders.Font = New System.Drawing.Font("Georgia", 7.8!)
        Me.btn_orders.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_orders.Location = New System.Drawing.Point(137, 173)
        Me.btn_orders.Name = "btn_orders"
        Me.btn_orders.Size = New System.Drawing.Size(233, 43)
        Me.btn_orders.TabIndex = 14
        Me.btn_orders.Text = "Orders"
        Me.btn_orders.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Cursor = System.Windows.Forms.Cursors.Default
        Me.TabPage2.Font = New System.Drawing.Font("Lithos Pro Regular", 12.0!)
        Me.TabPage2.Location = New System.Drawing.Point(4, 33)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(507, 375)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Add"
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.AutoEllipsis = True
        Me.Button2.BackColor = System.Drawing.Color.Goldenrod
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Georgia", 7.8!)
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(137, 237)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(233, 43)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Staff"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button3.AutoEllipsis = True
        Me.Button3.BackColor = System.Drawing.Color.ForestGreen
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Georgia", 7.8!)
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(137, 145)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(233, 43)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Customer"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.AutoEllipsis = True
        Me.Button1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Georgia", 7.8!)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(137, 51)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(233, 43)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Products"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.TabPage3.Controls.Add(Me.Button5)
        Me.TabPage3.Controls.Add(Me.Button6)
        Me.TabPage3.Controls.Add(Me.Button4)
        Me.TabPage3.Font = New System.Drawing.Font("Lithos Pro Regular", 12.0!)
        Me.TabPage3.Location = New System.Drawing.Point(4, 33)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(507, 375)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Edit"
        '
        'Button5
        '
        Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button5.AutoEllipsis = True
        Me.Button5.BackColor = System.Drawing.Color.Goldenrod
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Georgia", 7.8!)
        Me.Button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button5.Location = New System.Drawing.Point(137, 242)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(233, 43)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Staff"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button6.AutoEllipsis = True
        Me.Button6.BackColor = System.Drawing.Color.ForestGreen
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Georgia", 7.8!)
        Me.Button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button6.Location = New System.Drawing.Point(137, 152)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(233, 43)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "Customer"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button4.AutoEllipsis = True
        Me.Button4.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Georgia", 7.8!)
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.Location = New System.Drawing.Point(137, 56)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(233, 43)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Products"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.DarkGray
        Me.TabPage4.Controls.Add(Me.btn_invoice)
        Me.TabPage4.Controls.Add(Me.btn_make_order)
        Me.TabPage4.Location = New System.Drawing.Point(4, 33)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(507, 375)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Make Order"
        '
        'btn_invoice
        '
        Me.btn_invoice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_invoice.BackColor = System.Drawing.Color.Blue
        Me.btn_invoice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_invoice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btn_invoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_invoice.Font = New System.Drawing.Font("Georgia", 7.8!)
        Me.btn_invoice.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_invoice.Location = New System.Drawing.Point(137, 165)
        Me.btn_invoice.Name = "btn_invoice"
        Me.btn_invoice.Size = New System.Drawing.Size(233, 43)
        Me.btn_invoice.TabIndex = 14
        Me.btn_invoice.Text = "View Invoice"
        Me.btn_invoice.UseVisualStyleBackColor = False
        '
        'btn_make_order
        '
        Me.btn_make_order.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_make_order.BackColor = System.Drawing.Color.Red
        Me.btn_make_order.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_make_order.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btn_make_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_make_order.Font = New System.Drawing.Font("Georgia", 7.8!)
        Me.btn_make_order.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_make_order.Location = New System.Drawing.Point(137, 82)
        Me.btn_make_order.Name = "btn_make_order"
        Me.btn_make_order.Size = New System.Drawing.Size(233, 43)
        Me.btn_make_order.TabIndex = 13
        Me.btn_make_order.Text = "Make Order"
        Me.btn_make_order.UseVisualStyleBackColor = False
        '
        'lbl_shopSubTitle
        '
        Me.lbl_shopSubTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_shopSubTitle.AutoSize = True
        Me.lbl_shopSubTitle.Font = New System.Drawing.Font("Georgia", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_shopSubTitle.Location = New System.Drawing.Point(229, 77)
        Me.lbl_shopSubTitle.Name = "lbl_shopSubTitle"
        Me.lbl_shopSubTitle.Size = New System.Drawing.Size(384, 24)
        Me.lbl_shopSubTitle.TabIndex = 10
        Me.lbl_shopSubTitle.Text = "Where the Crafty Creations Belongs"
        '
        'lbl_shopTitle
        '
        Me.lbl_shopTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_shopTitle.AutoSize = True
        Me.lbl_shopTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_shopTitle.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_shopTitle.Font = New System.Drawing.Font("Snap ITC", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_shopTitle.Location = New System.Drawing.Point(200, 9)
        Me.lbl_shopTitle.Name = "lbl_shopTitle"
        Me.lbl_shopTitle.Size = New System.Drawing.Size(443, 57)
        Me.lbl_shopTitle.TabIndex = 9
        Me.lbl_shopTitle.Text = "Fun Craft Store"
        '
        'Timer1
        '
        '
        'frm_mainmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_funcraftstore_a160979.My.Resources.Resources._11WhnTT
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1280, 720)
        Me.Name = "frm_mainmenu"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Main Menu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_staff As System.Windows.Forms.Button
    Friend WithEvents btn_customer As System.Windows.Forms.Button
    Friend WithEvents btn_products As System.Windows.Forms.Button
    Friend WithEvents btn_orderlist As System.Windows.Forms.Button
    Friend WithEvents lbl_date As System.Windows.Forms.Label
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbl_shopSubTitle As System.Windows.Forms.Label
    Friend WithEvents lbl_shopTitle As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_backmain As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents btn_invoice As System.Windows.Forms.Button
    Friend WithEvents btn_make_order As System.Windows.Forms.Button
    Friend WithEvents btn_orders As System.Windows.Forms.Button

End Class
