<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_orderlist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_orderlist))
        Me.grd_orderlist = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.note = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_exit1 = New System.Windows.Forms.Button()
        Me.lbl_shopSubTitle = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.lbl_shopTitle = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.grd_orderlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grd_orderlist
        '
        Me.grd_orderlist.AllowUserToAddRows = False
        Me.grd_orderlist.AllowUserToDeleteRows = False
        Me.grd_orderlist.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grd_orderlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grd_orderlist.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grd_orderlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_orderlist.Location = New System.Drawing.Point(3, 27)
        Me.grd_orderlist.Name = "grd_orderlist"
        Me.grd_orderlist.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.grd_orderlist.RowTemplate.Height = 24
        Me.grd_orderlist.Size = New System.Drawing.Size(727, 481)
        Me.grd_orderlist.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.note)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.btn_exit1)
        Me.Panel1.Controls.Add(Me.lbl_shopSubTitle)
        Me.Panel1.Controls.Add(Me.lbl_date)
        Me.Panel1.Controls.Add(Me.lbl_shopTitle)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(217, -8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(832, 689)
        Me.Panel1.TabIndex = 11
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
        Me.btn_exit1.Location = New System.Drawing.Point(587, 630)
        Me.btn_exit1.Name = "btn_exit1"
        Me.btn_exit1.Size = New System.Drawing.Size(233, 43)
        Me.btn_exit1.TabIndex = 8
        Me.btn_exit1.Text = "Get me outta here!"
        Me.btn_exit1.UseVisualStyleBackColor = False
        '
        'lbl_shopSubTitle
        '
        Me.lbl_shopSubTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_shopSubTitle.AutoSize = True
        Me.lbl_shopSubTitle.Font = New System.Drawing.Font("Georgia", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl_shopSubTitle.Location = New System.Drawing.Point(224, 68)
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
        Me.lbl_shopTitle.Location = New System.Drawing.Point(195, 0)
        Me.lbl_shopTitle.Name = "lbl_shopTitle"
        Me.lbl_shopTitle.Size = New System.Drawing.Size(443, 57)
        Me.lbl_shopTitle.TabIndex = 4
        Me.lbl_shopTitle.Text = "Fun Craft Store"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkGray
        Me.GroupBox1.Controls.Add(Me.grd_orderlist)
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 12.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(52, 106)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(733, 511)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Order Lists"
        '
        'Timer1
        '
        '
        'frm_orderlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_funcraftstore_a160979.My.Resources.Resources._11WhnTT
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1280, 720)
        Me.Name = "frm_orderlist"
        Me.Text = "Order Lists"
        CType(Me.grd_orderlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grd_orderlist As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btn_exit1 As System.Windows.Forms.Button
    Friend WithEvents lbl_shopSubTitle As System.Windows.Forms.Label
    Friend WithEvents lbl_date As System.Windows.Forms.Label
    Friend WithEvents lbl_shopTitle As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents note As System.Windows.Forms.Label
End Class
