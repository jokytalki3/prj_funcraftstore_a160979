<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_product_views
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_product_views))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_shopSubTitle = New System.Windows.Forms.Label()
        Me.lbl_shopTitle = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.btn_backtomain = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_description = New System.Windows.Forms.Label()
        Me.lbl_madefrom = New System.Windows.Forms.Label()
        Me.lbl_type = New System.Windows.Forms.Label()
        Me.lbl_category = New System.Windows.Forms.Label()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.product_pic = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.product_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(601, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome! User!"
        '
        'lbl_shopSubTitle
        '
        Me.lbl_shopSubTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_shopSubTitle.AutoSize = True
        Me.lbl_shopSubTitle.Font = New System.Drawing.Font("Georgia", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl_shopSubTitle.Location = New System.Drawing.Point(503, 68)
        Me.lbl_shopSubTitle.Name = "lbl_shopSubTitle"
        Me.lbl_shopSubTitle.Size = New System.Drawing.Size(384, 24)
        Me.lbl_shopSubTitle.TabIndex = 12
        Me.lbl_shopSubTitle.Text = "Where the Crafty Creations Belongs"
        '
        'lbl_shopTitle
        '
        Me.lbl_shopTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_shopTitle.AutoSize = True
        Me.lbl_shopTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_shopTitle.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_shopTitle.Font = New System.Drawing.Font("Snap ITC", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_shopTitle.Location = New System.Drawing.Point(474, 0)
        Me.lbl_shopTitle.Name = "lbl_shopTitle"
        Me.lbl_shopTitle.Size = New System.Drawing.Size(443, 57)
        Me.lbl_shopTitle.TabIndex = 11
        Me.lbl_shopTitle.Text = "Fun Craft Store"
        '
        'Timer1
        '
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 184)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1387, 657)
        Me.FlowLayoutPanel1.TabIndex = 14
        '
        'panel1
        '
        Me.panel1.BackgroundImage = Global.prj_funcraftstore_a160979.My.Resources.Resources._11WhnTT
        Me.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel1.Controls.Add(Me.btn_backtomain)
        Me.panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.panel1.Controls.Add(Me.lbl_shopSubTitle)
        Me.panel1.Controls.Add(Me.lbl_shopTitle)
        Me.panel1.Controls.Add(Me.Label1)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(1390, 853)
        Me.panel1.TabIndex = 15
        '
        'btn_backtomain
        '
        Me.btn_backtomain.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_backtomain.Location = New System.Drawing.Point(41, 35)
        Me.btn_backtomain.Name = "btn_backtomain"
        Me.btn_backtomain.Size = New System.Drawing.Size(252, 59)
        Me.btn_backtomain.TabIndex = 15
        Me.btn_backtomain.Text = "<<    Back to Main"
        Me.btn_backtomain.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.lbl_description)
        Me.Panel2.Controls.Add(Me.lbl_madefrom)
        Me.Panel2.Controls.Add(Me.lbl_type)
        Me.Panel2.Controls.Add(Me.lbl_category)
        Me.Panel2.Controls.Add(Me.lbl_price)
        Me.Panel2.Controls.Add(Me.lbl_name)
        Me.Panel2.Controls.Add(Me.lbl_id)
        Me.Panel2.Controls.Add(Me.btn_back)
        Me.Panel2.Controls.Add(Me.product_pic)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1390, 853)
        Me.Panel2.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(725, 504)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(229, 32)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Description     :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(719, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 32)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Name    :"
        '
        'lbl_description
        '
        Me.lbl_description.AutoSize = True
        Me.lbl_description.Font = New System.Drawing.Font("Georgia", 16.2!, System.Drawing.FontStyle.Bold)
        Me.lbl_description.Location = New System.Drawing.Point(725, 470)
        Me.lbl_description.Name = "lbl_description"
        Me.lbl_description.Size = New System.Drawing.Size(194, 32)
        Me.lbl_description.TabIndex = 30
        Me.lbl_description.Text = "Description:"
        '
        'lbl_madefrom
        '
        Me.lbl_madefrom.AutoSize = True
        Me.lbl_madefrom.Font = New System.Drawing.Font("Georgia", 16.2!, System.Drawing.FontStyle.Bold)
        Me.lbl_madefrom.Location = New System.Drawing.Point(723, 420)
        Me.lbl_madefrom.Name = "lbl_madefrom"
        Me.lbl_madefrom.Size = New System.Drawing.Size(193, 32)
        Me.lbl_madefrom.TabIndex = 29
        Me.lbl_madefrom.Text = "Made From:"
        '
        'lbl_type
        '
        Me.lbl_type.AutoSize = True
        Me.lbl_type.Font = New System.Drawing.Font("Georgia", 16.2!, System.Drawing.FontStyle.Bold)
        Me.lbl_type.Location = New System.Drawing.Point(725, 367)
        Me.lbl_type.Name = "lbl_type"
        Me.lbl_type.Size = New System.Drawing.Size(94, 32)
        Me.lbl_type.TabIndex = 28
        Me.lbl_type.Text = "Type:"
        '
        'lbl_category
        '
        Me.lbl_category.AutoSize = True
        Me.lbl_category.Font = New System.Drawing.Font("Georgia", 16.2!, System.Drawing.FontStyle.Bold)
        Me.lbl_category.Location = New System.Drawing.Point(725, 320)
        Me.lbl_category.Name = "lbl_category"
        Me.lbl_category.Size = New System.Drawing.Size(154, 32)
        Me.lbl_category.TabIndex = 27
        Me.lbl_category.Text = "Category:"
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.Font = New System.Drawing.Font("Georgia", 16.2!, System.Drawing.FontStyle.Bold)
        Me.lbl_price.ForeColor = System.Drawing.Color.Red
        Me.lbl_price.Location = New System.Drawing.Point(725, 273)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(101, 32)
        Me.lbl_price.TabIndex = 26
        Me.lbl_price.Text = "Price:"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Georgia", 16.2!, System.Drawing.FontStyle.Bold)
        Me.lbl_name.Location = New System.Drawing.Point(725, 168)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(110, 32)
        Me.lbl_name.TabIndex = 25
        Me.lbl_name.Text = "Name:"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Georgia", 16.2!, System.Drawing.FontStyle.Bold)
        Me.lbl_id.Location = New System.Drawing.Point(725, 113)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(179, 32)
        Me.lbl_id.TabIndex = 24
        Me.lbl_id.Text = "product_id"
        '
        'btn_back
        '
        Me.btn_back.Font = New System.Drawing.Font("Georgia", 7.8!)
        Me.btn_back.Location = New System.Drawing.Point(31, 28)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(107, 53)
        Me.btn_back.TabIndex = 16
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'product_pic
        '
        Me.product_pic.Location = New System.Drawing.Point(68, 113)
        Me.product_pic.Name = "product_pic"
        Me.product_pic.Size = New System.Drawing.Size(587, 398)
        Me.product_pic.TabIndex = 15
        Me.product_pic.TabStop = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label3.Location = New System.Drawing.Point(482, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(384, 24)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Where the Crafty Creations Belongs"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label4.Font = New System.Drawing.Font("Snap ITC", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(474, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(443, 57)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Fun Craft Store"
        '
        'frm_product_views
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1390, 853)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_product_views"
        Me.Text = "frm_product_views"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.product_pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_shopSubTitle As System.Windows.Forms.Label
    Friend WithEvents lbl_shopTitle As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn_back As System.Windows.Forms.Button
    Friend WithEvents product_pic As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_madefrom As System.Windows.Forms.Label
    Friend WithEvents lbl_type As System.Windows.Forms.Label
    Friend WithEvents lbl_category As System.Windows.Forms.Label
    Friend WithEvents lbl_price As System.Windows.Forms.Label
    Friend WithEvents lbl_name As System.Windows.Forms.Label
    Friend WithEvents lbl_id As System.Windows.Forms.Label
    Friend WithEvents lbl_description As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_backtomain As System.Windows.Forms.Button
End Class
