Public Class frm_insert_products
    Dim defaultpicture As String = Application.StartupPath & "\pictures\nophoto.jpg"
    

    Private Sub frm_insert_products_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        grd_product.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A160979 ORDER BY FLD_PRODUCT_ID ASC")

        txt_id.Text = generate_id()

        lbl_shopSubTitle.Text = shopSubTitle
        lbl_shopTitle.Text = shopTitle
        Dim current_date = Date.Now
        lbl_date.Text = current_date.DayOfWeek.ToString() & vbNewLine & current_date.Date & vbNewLine & current_date.Hour & ":" & current_date.Minute

        Timer1.Start()
        txt_picture.Text = defaultpicture
        product_pic.Image = Image.FromFile(defaultpicture)
        product_pic.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Function generate_id() As String
        Dim lastid As String = run_sql_query("SELECT MAX(FLD_PRODUCT_ID) AS LASTID FROM TBL_PRODUCTS_A160979").Rows(0).Item("LASTID")

        MsgBox("The last item you have is " & lastid)

        Dim newid As String = "A0" & Mid(lastid, 2) + 1
        Return newid
    End Function

    Private Sub btn_select_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_select.Click
        Dim mydeskstop As String = My.Computer.FileSystem.SpecialDirectories.Desktop

        OpenFileDialog1.InitialDirectory = mydeskstop
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg"
        OpenFileDialog1.ShowDialog()

        product_pic.Image = Image.FromFile(OpenFileDialog1.FileName)
        product_pic.SizeMode = PictureBoxSizeMode.StretchImage
        txt_picture.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub btn_insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_insert.Click
        If txt_name.Text = "" Or txt_price.Text = "" Or txt_category.Text = "" Or txt_type.Text = "" Or txt_madefrom.Text = "" Or txt_description.Text = "" Then
            Beep()
            MsgBox("Make sure you have add the details of the products")
        Else
            Dim mysql As String = "INSERT INTO TBL_PRODUCTS_A160979 VALUES('" & txt_id.Text & "','" & txt_name.Text & "','" & txt_price.Text & "','" & txt_category.Text & "','" & txt_type.Text & "','" & txt_madefrom.Text & "','" & txt_description.Text & "')"
            Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

            Try
                mywriter.Connection.Open()
                mywriter.ExecuteNonQuery()
                mywriter.Connection.Close()

                My.Computer.FileSystem.CopyFile(txt_picture.Text, "pictures\" & txt_id.Text & ".jpg")

                grd_product.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A160979 ORDER BY FLD_PRODUCT_ID")

                txt_id.Text = generate_id()
                txt_name.Text = ""
                txt_price.Text = ""
                txt_category.Text = ""
                txt_type.Text = ""
                txt_madefrom.Text = ""
                txt_description.Text = ""
                txt_picture.Text = defaultpicture
                product_pic.BackgroundImage = Image.FromFile(defaultpicture)

            Catch ex As Exception
                Beep()
                MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)
                mywriter.Connection.Close()

            End Try
        End If
        
    End Sub

    Private Sub btn_exit1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit1.Click
        End
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frm_mainmenu.Show()
        Me.Close()

    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim random As New Random
        lbl_shopTitle.ForeColor = Color.FromArgb(random.Next(0, 230), random.Next(0, 230), random.Next(0, 230))
    End Sub

    Private Sub btn_toinsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_toinsert.Click
        frm_update_products.Show()
        Me.Close()

    End Sub
End Class