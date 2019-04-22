Public Class frm_update_products
    Dim current_id As String
    Dim defaultpicture As String = Application.StartupPath & "\pictures\nophoto.jpg"
    Private Sub frm_update_products_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        refresh_grid()

        get_current_id()

        lbl_shopSubTitle.Text = shopSubTitle
        lbl_shopTitle.Text = shopTitle
        Dim current_date = Date.Now
        lbl_date.Text = current_date.DayOfWeek.ToString() & vbNewLine & current_date.Date & vbNewLine & current_date.Hour & ":" & current_date.Minute

        Timer1.Start()
    End Sub

    Private Sub refresh_grid()
        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A160979 ORDER BY FLD_PRODUCT_ID"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_product.DataSource = mydatatable
    End Sub

    Private Sub clear_fields()
        txt_name.Text = ""
        txt_price.Text = ""
        txt_category.Text = ""
        txt_type.Text = ""
        txt_madefrom.Text = ""
        txt_description.Text = ""

    End Sub

    Private Sub get_current_id()
        Dim current_row As Integer = grd_product.CurrentRow.Index()

        current_id = grd_product(0, current_row).Value

        txt_id.Text = current_id
        txt_name.Text = grd_product(1, current_row).Value
        txt_price.Text = grd_product(2, current_row).Value
        txt_category.Text = grd_product(3, current_row).Value
        txt_type.Text = grd_product(4, current_row).Value
        txt_madefrom.Text = grd_product(5, current_row).Value
        txt_description.Text = grd_product(6, current_row).Value
    End Sub

    Private Sub grd_product_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_product.CellClick
        get_current_id()

    End Sub


    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        run_sql_command("UPDATE TBL_PRODUCTS_A160979 SET FLD_PRODUCT_NAME='" & txt_name.Text & "' WHERE FLD_PRODUCT_ID='" & current_id & "'")
        run_sql_command("UPDATE TBL_PRODUCTS_A160979 SET FLD_PRICE=" & txt_price.Text & " WHERE FLD_PRODUCT_ID='" & current_id & "'")
        run_sql_command("UPDATE TBL_PRODUCTS_A160979 SET FLD_CATEGORY='" & txt_category.Text & "' WHERE FLD_PRODUCT_ID='" & current_id & "'")
        run_sql_command("UPDATE TBL_PRODUCTS_A160979 SET FLD_TYPE='" & txt_type.Text & "' WHERE FLD_PRODUCT_ID='" & current_id & "'")
        run_sql_command("UPDATE TBL_PRODUCTS_A160979 SET FLD_MADEFROM='" & txt_madefrom.Text & "' WHERE FLD_PRODUCT_ID='" & current_id & "'")
        run_sql_command("UPDATE TBL_PRODUCTS_A160979 SET FLD_DESCRIPTION='" & txt_description.Text & "' WHERE FLD_PRODUCT_ID='" & current_id & "'")


        Beep()
        MsgBox("You have succesfully updated the course """ & current_id & """.")

        refresh_grid()
        clear_fields()
        get_current_id()
    End Sub

    Private Sub btn_mainmenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_mainmenu.Click
        frm_mainmenu.Show()
        Me.Close()

    End Sub

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        End

    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        Dim delete_confimation = MsgBox("Are you sure you would like to delete the student """ & current_id & """?", MsgBoxStyle.YesNo)

        If delete_confimation = MsgBoxResult.Yes Then
            run_sql_command("DELETE FROM TBL_PRODUCTS_A160979 WHERE FLD_PRODUCT_ID='" & current_id & "'")

            Beep()
            MsgBox("The student """ & current_id & """ has been successfully deleted.")

            refresh_grid()
            clear_fields()
            get_current_id()
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim random As New Random
        lbl_shopTitle.ForeColor = Color.FromArgb(random.Next(0, 230), random.Next(0, 230), random.Next(0, 230))
    End Sub


    Private Sub btn_toinsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_toinsert.Click
        frm_insert_products.Show()
        Me.Close()

    End Sub
End Class