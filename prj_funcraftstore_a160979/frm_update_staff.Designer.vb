<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_update_staff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_update_staff))
        Me.btn_mainmenu = New System.Windows.Forms.Button()
        Me.txt_staff_password = New System.Windows.Forms.TextBox()
        Me.txt_staff_name = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_shopSubTitle = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.lbl_shopTitle = New System.Windows.Forms.Label()
        Me.note = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_toinsert = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.grd_staff = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grd_staff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_mainmenu
        '
        Me.btn_mainmenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_mainmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_mainmenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btn_mainmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_mainmenu.Font = New System.Drawing.Font("Georgia", 7.8!)
        Me.btn_mainmenu.Location = New System.Drawing.Point(18, 630)
        Me.btn_mainmenu.Name = "btn_mainmenu"
        Me.btn_mainmenu.Size = New System.Drawing.Size(192, 43)
        Me.btn_mainmenu.TabIndex = 9
        Me.btn_mainmenu.Text = "Main Menu"
        Me.btn_mainmenu.UseVisualStyleBackColor = False
        '
        'txt_staff_password
        '
        Me.txt_staff_password.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txt_staff_password.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_staff_password.Location = New System.Drawing.Point(201, 304)
        Me.txt_staff_password.Name = "txt_staff_password"
        Me.txt_staff_password.Size = New System.Drawing.Size(328, 30)
        Me.txt_staff_password.TabIndex = 16
        '
        'txt_staff_name
        '
        Me.txt_staff_name.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txt_staff_name.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_staff_name.Location = New System.Drawing.Point(201, 267)
        Me.txt_staff_name.Name = "txt_staff_name"
        Me.txt_staff_name.Size = New System.Drawing.Size(593, 30)
        Me.txt_staff_name.TabIndex = 15
        '
        'txt_id
        '
        Me.txt_id.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txt_id.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(201, 230)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(328, 30)
        Me.txt_id.TabIndex = 14
        '
        'btn_exit
        '
        Me.btn_exit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_exit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exit.Font = New System.Drawing.Font("Georgia", 7.8!)
        Me.btn_exit.Location = New System.Drawing.Point(585, 630)
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
        Me.Panel1.Controls.Add(Me.btn_mainmenu)
        Me.Panel1.Controls.Add(Me.btn_exit)
        Me.Panel1.Controls.Add(Me.lbl_shopSubTitle)
        Me.Panel1.Controls.Add(Me.lbl_date)
        Me.Panel1.Controls.Add(Me.lbl_shopTitle)
        Me.Panel1.Controls.Add(Me.note)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(216, -8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(830, 689)
        Me.Panel1.TabIndex = 15
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
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkGray
        Me.GroupBox1.Controls.Add(Me.btn_toinsert)
        Me.GroupBox1.Controls.Add(Me.btn_delete)
        Me.GroupBox1.Controls.Add(Me.txt_staff_password)
        Me.GroupBox1.Controls.Add(Me.txt_staff_name)
        Me.GroupBox1.Controls.Add(Me.txt_id)
        Me.GroupBox1.Controls.Add(Me.btn_update)
        Me.GroupBox1.Controls.Add(Me.grd_staff)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 12.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(800, 520)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Edit Or Delete Staff"
        '
        'btn_toinsert
        '
        Me.btn_toinsert.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_toinsert.Location = New System.Drawing.Point(554, 473)
        Me.btn_toinsert.Name = "btn_toinsert"
        Me.btn_toinsert.Size = New System.Drawing.Size(240, 41)
        Me.btn_toinsert.TabIndex = 23
        Me.btn_toinsert.Text = "Go to Add"
        Me.btn_toinsert.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_delete.Location = New System.Drawing.Point(263, 473)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(240, 41)
        Me.btn_delete.TabIndex = 22
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_update.Location = New System.Drawing.Point(6, 473)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(240, 41)
        Me.btn_update.TabIndex = 3
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'grd_staff
        '
        Me.grd_staff.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grd_staff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_staff.Location = New System.Drawing.Point(0, 30)
        Me.grd_staff.Name = "grd_staff"
        Me.grd_staff.RowTemplate.Height = 24
        Me.grd_staff.Size = New System.Drawing.Size(794, 197)
        Me.grd_staff.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(85, 233)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 24)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Staff ID :"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 270)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 24)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Staff Name :"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 307)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 24)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Staff Phone No. :"
        '
        'Timer1
        '
        '
        'frm_update_staff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_funcraftstore_a160979.My.Resources.Resources._11WhnTT
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_update_staff"
        Me.Text = "frm_update_staff"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grd_staff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_mainmenu As System.Windows.Forms.Button
    Friend WithEvents txt_staff_password As System.Windows.Forms.TextBox
    Friend WithEvents txt_staff_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents note As System.Windows.Forms.Label
    Friend WithEvents lbl_shopSubTitle As System.Windows.Forms.Label
    Friend WithEvents lbl_date As System.Windows.Forms.Label
    Friend WithEvents lbl_shopTitle As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents grd_staff As System.Windows.Forms.DataGridView
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btn_toinsert As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
