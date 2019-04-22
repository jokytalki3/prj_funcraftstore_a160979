Public Class frm_product_views
    Dim id As String
    Private Sub frm_product_views_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Width = 1500
        Me.Height = 1080
        Timer1.Start()
        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A160979 ORDER BY FLD_PRODUCT_ID"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        Dim count As Integer = 0
        FlowLayoutPanel1.Padding = New Padding(10, 10, 10, 10)
        For Each item As DataRow In mydatatable.Rows
            Dim panel As New Panel
            panel.Width = 265
            panel.Height = 360
            panel.Margin = New Padding(10, 10, 10, 10)
            Dim pic_id As String = mydatatable.Rows(count).Item("FLD_PRODUCT_ID")
            id = pic_id
            Dim picturebox As New PictureBox
            picturebox.Image = Image.FromFile("pictures/" & pic_id & ".jpg")
            picturebox.Name = pic_id
            picturebox.Width = 265
            picturebox.Height = 250
            picturebox.SizeMode = PictureBoxSizeMode.StretchImage
            picturebox.Cursor = Cursors.Hand
            panel.Controls.Add(picturebox)


            Dim pdetail As New Label
            pdetail.Text = mydatatable.Rows(count).Item("FLD_PRODUCT_NAME") 'Script MT Bold, 16.2pt, style=Bold
            pdetail.Font = New Font("Comic Sans MS", 10, FontStyle.Bold)
            pdetail.Width = 265
            pdetail.Height = 80
            pdetail.Location = New Point(0, picturebox.Height)
            panel.Controls.Add(pdetail)

            Dim price As New Label
            price.Text = "RM" & mydatatable.Rows(count).Item("FLD_PRICE")
            price.Font = New Font("Conmic San MS", 11, FontStyle.Bold)
            price.Width = 265
            price.Height = 30
            price.ForeColor = Color.Red
            price.Location = New Point(0, picturebox.Height + pdetail.Height)
            panel.Controls.Add(price)
            FlowLayoutPanel1.Controls.Add(panel)




            count = count + 1

            AddHandler picturebox.Click, AddressOf picturebox_Click

        Next

        'pic_box.Image = Image.FromFile("pictures/A001.jpg")
        'pic_box.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub



    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        Panel2.Visible = False
        panel1.Visible = True
    End Sub

    Private Sub picturebox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Panel2.Visible = True
        panel1.Visible = False
        Timer1.Start()

        product_pic.Image = sender.image
        product_pic.Width = 700
        product_pic.Height = 500
        product_pic.Location = New Point(50, 100)
        If product_pic.Image.Width < 600 Then
            product_pic.SizeMode = PictureBoxSizeMode.Zoom
        ElseIf product_pic.Image.Width >= 600 Then
            product_pic.SizeMode = PictureBoxSizeMode.StretchImage
        End If
        Dim pid As String
        pid = sender.Name
        lbl_id.Text = "Product ID : " & sender.Name
        lbl_id.Location = New Point(product_pic.Width + 50, 100)

        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A160979 WHERE FLD_PRODUCT_ID='" & pid & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        Label5.Location = New Point(product_pic.Width + 50, 150)
        lbl_name.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_NAME")
        lbl_name.Location = New Point(product_pic.Width + 180, 150)
        lbl_name.Size = New Size(550, 400)
        lbl_name.AutoSize = False

        lbl_price.Text = "Price     :     RM " & mydatatable.Rows(0).Item("FLD_PRICE")
        lbl_price.Location = New Point(product_pic.Width + 50, 300)

        lbl_category.Text = "Category    : " & mydatatable.Rows(0).Item("FLD_CATEGORY")
        lbl_category.Location = New Point(product_pic.Width + 50, 360)

        lbl_type.Text = "Type             : " & mydatatable.Rows(0).Item("FLD_TYPE")
        lbl_type.Location = New Point(product_pic.Width + 50, 420)

        lbl_madefrom.Text = "Made From     : " & mydatatable.Rows(0).Item("FLD_MADEFROM")
        lbl_madefrom.Location = New Point(product_pic.Width + 50, 480)

        Label6.Location = New Point(product_pic.Width + 50, 540)
        lbl_description.Text = mydatatable.Rows(0).Item("FLD_DESCRIPTION")
        lbl_description.Location = New Point(product_pic.Width + 230, 540)
        lbl_description.Size = New Size(550, 400)
        lbl_description.AutoSize = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim random As New Random
        lbl_shopTitle.ForeColor = Color.FromArgb(Random.Next(0, 230), Random.Next(0, 230), Random.Next(0, 230))
        Label4.ForeColor = Color.FromArgb(Random.Next(0, 230), Random.Next(0, 230), Random.Next(0, 230))
    End Sub

    Private Sub btn_backtomain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_backtomain.Click
        frm_splashscreen_a160979.Show()
        Me.Close()

    End Sub
End Class