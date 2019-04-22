<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_insert_customer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_insert_customer))
        Me.note = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_exit1 = New System.Windows.Forms.Button()
        Me.lbl_shopTitle = New System.Windows.Forms.Label()
        Me.lbl_shopSubTitle = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_toinsert = New System.Windows.Forms.Button()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.txt_phone = New System.Windows.Forms.TextBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.grd_product = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'note
        '
        Me.note.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.note.AutoSize = True
        Me.note.Font = New System.Drawing.Font("Georgia", 7.8!)
        Me.note.Location = New System.Drawing.Point(216, 644)
        Me.note.Name = "note"
        Me.note.Size = New System.Drawing.Size(265, 17)
        Me.note.TabIndex = 11
        Me.note.Text = "Note: Resize the window for a better view"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Georgia", 7.8!)
        Me.Button2.Location = New System.Drawing.Point(18, 630)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(192, 43)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Main Menu"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btn_exit1
        '
        Me.btn_exit1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_exit1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_exit1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btn_exit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exit1.Font = New System.Drawing.Font("Georgia", 7.8!)
        Me.btn_exit1.Location = New System.Drawing.Point(585, 630)
        Me.btn_exit1.Name = "btn_exit1"
        Me.btn_exit1.Size = New System.Drawing.Size(233, 43)
        Me.btn_exit1.TabIndex = 8
        Me.btn_exit1.Text = "Get me outta here!"
        Me.btn_exit1.UseVisualStyleBackColor = False
        '
        'lbl_shopTitle
        '
        Me.lbl_shopTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_shopTitle.AutoSize = True
        Me.lbl_shopTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_shopTitle.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_shopTitle.Font = New System.Drawing.Font("Snap ITC", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_shopTitle.Location = New System.Drawing.Point(194, 0)
        Me.lbl_shopTitle.Name = "lbl_shopTitle"
        Me.lbl_shopTitle.Size = New System.Drawing.Size(443, 57)
        Me.lbl_shopTitle.TabIndex = 4
        Me.lbl_shopTitle.Text = "Fun Craft Store"
        '
        'lbl_shopSubTitle
        '
        Me.lbl_shopSubTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_shopSubTitle.AutoSize = True
        Me.lbl_shopSubTitle.Font = New System.Drawing.Font("Georgia", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl_shopSubTitle.Location = New System.Drawing.Point(223, 68)
        Me.lbl_shopSubTitle.Name = "lbl_shopSubTitle"
        Me.lbl_shopSubTitle.Size = New System.Drawing.Size(384, 24)
        Me.lbl_shopSubTitle.TabIndex = 5
        Me.lbl_shopSubTitle.Text = "Where the Crafty Creations Belongs"
        '
        'lbl_date
        '
        Me.lbl_date.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Font = New System.Drawing.Font("Georgia", 9.0!)
        Me.lbl_date.Location = New System.Drawing.Point(704, 9)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(36, 18)
        Me.lbl_date.TabIndex = 7
        Me.lbl_date.Text = "date"
        Me.lbl_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.btn_exit1)
        Me.Panel1.Controls.Add(Me.lbl_shopSubTitle)
        Me.Panel1.Controls.Add(Me.lbl_date)
        Me.Panel1.Controls.Add(Me.lbl_shopTitle)
        Me.Panel1.Controls.Add(Me.note)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(216, -8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(830, 689)
        Me.Panel1.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkGray
        Me.GroupBox1.Controls.Add(Me.btn_toinsert)
        Me.GroupBox1.Controls.Add(Me.txt_address)
        Me.GroupBox1.Controls.Add(Me.txt_phone)
        Me.GroupBox1.Controls.Add(Me.txt_email)
        Me.GroupBox1.Controls.Add(Me.txt_name)
        Me.GroupBox1.Controls.Add(Me.txt_id)
        Me.GroupBox1.Controls.Add(Me.btn_insert)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.grd_product)
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 12.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(800, 520)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add New Customer"
        '
        'btn_toinsert
        '
        Me.btn_toinsert.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_toinsert.Location = New System.Drawing.Point(567, 473)
        Me.btn_toinsert.Name = "btn_toinsert"
        Me.btn_toinsert.Size = New System.Drawing.Size(227, 41)
        Me.btn_toinsert.TabIndex = 37
        Me.btn_toinsert.Text = "Go to Edit"
        Me.btn_toinsert.UseVisualStyleBackColor = True
        '
        'txt_address
        '
        Me.txt_address.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txt_address.Font = New System.Drawing.Font("Georgia", 12.0!)
        Me.txt_address.Location = New System.Drawing.Point(214, 382)
        Me.txt_address.Multiline = True
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(580, 85)
        Me.txt_address.TabIndex = 36
        '
        'txt_phone
        '
        Me.txt_phone.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txt_phone.Font = New System.Drawing.Font("Georgia", 12.0!)
        Me.txt_phone.Location = New System.Drawing.Point(214, 345)
        Me.txt_phone.Name = "txt_phone"
        Me.txt_phone.Size = New System.Drawing.Size(269, 30)
        Me.txt_phone.TabIndex = 35
        '
        'txt_email
        '
        Me.txt_email.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txt_email.Font = New System.Drawing.Font("Georgia", 12.0!)
        Me.txt_email.Location = New System.Drawing.Point(214, 308)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(580, 30)
        Me.txt_email.TabIndex = 34
        '
        'txt_name
        '
        Me.txt_name.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txt_name.Font = New System.Drawing.Font("Georgia", 12.0!)
        Me.txt_name.Location = New System.Drawing.Point(214, 271)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(580, 30)
        Me.txt_name.TabIndex = 33
        '
        'txt_id
        '
        Me.txt_id.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txt_id.Font = New System.Drawing.Font("Georgia", 12.0!)
        Me.txt_id.Location = New System.Drawing.Point(214, 233)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(269, 30)
        Me.txt_id.TabIndex = 32
        '
        'btn_insert
        '
        Me.btn_insert.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_insert.Location = New System.Drawing.Point(270, 473)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(240, 41)
        Me.btn_insert.TabIndex = 3
        Me.btn_insert.Text = "Insert"
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 239)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 24)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Customer ID :"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(117, 274)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 24)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Name :"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(117, 311)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 24)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Email :"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(113, 348)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 24)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Phone :"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(99, 385)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 24)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Address :"
        '
        'grd_product
        '
        Me.grd_product.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grd_product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_product.Location = New System.Drawing.Point(0, 30)
        Me.grd_product.Name = "grd_product"
        Me.grd_product.RowTemplate.Height = 24
        Me.grd_product.Size = New System.Drawing.Size(794, 197)
        Me.grd_product.TabIndex = 0
        '
        'Timer1
        '
        '
        'frm_insert_customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_funcraftstore_a160979.My.Resources.Resources._11WhnTT
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_insert_customer"
        Me.Text = "frm_insert_customer"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents note As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btn_exit1 As System.Windows.Forms.Button
    Friend WithEvents lbl_shopTitle As System.Windows.Forms.Label
    Friend WithEvents lbl_shopSubTitle As System.Windows.Forms.Label
    Friend WithEvents lbl_date As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_insert As System.Windows.Forms.Button
    Friend WithEvents grd_product As System.Windows.Forms.DataGridView
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_toinsert As System.Windows.Forms.Button
    Friend WithEvents txt_address As System.Windows.Forms.TextBox
    Friend WithEvents txt_phone As System.Windows.Forms.TextBox
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
End Class
