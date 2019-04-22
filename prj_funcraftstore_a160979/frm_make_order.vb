Public Class frm_make_order
    Private Sub frm_make_order_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_order_id.Text = generate_id()

        Dim mysql As String = "SELECT FLD_PRODUCT_ID FROM TBL_PRODUCTS_A160979 ORDER BY FLD_PRODUCT_ID"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        list_product.DataSource = mydatatable
        list_product.DisplayMember = "FLD_PRODUCT_ID"
        refresh_Ptext(list_product.Text)

        Dim mysql2 As String = "SELECT FLD_STAFF_ID FROM TBL_STAFF_A160979"
        Dim mydatatable2 As New DataTable
        Dim myreader2 As New OleDb.OleDbDataAdapter(mysql2, myconnection)
        myreader2.Fill(mydatatable2)
        list_staff.DataSource = mydatatable2
        list_staff.DisplayMember = "FLD_STAFF_ID"
        refresh_Stext(list_staff.Text)

        Dim mysql3 As String = "SELECT FLD_CUSTOMER_ID FROM TBL_CUSTOMER_A160979"
        Dim mydatatable3 As New DataTable
        Dim myreader3 As New OleDb.OleDbDataAdapter(mysql3, myconnection)
        myreader3.Fill(mydatatable3)
        list_cust.DataSource = mydatatable3
        list_cust.DisplayMember = "FLD_CUSTOMER_ID"
        refresh_Ctext(list_cust.Text)
        order_quantity.Value = 1
    End Sub

    Private Function generate_id() As String
        Dim lastid As String = run_sql_query("SELECT MAX(FLD_ORDER_ID) AS LASTID FROM TBL_ORDERS_A160979").Rows(0).Item("LASTID")
        Dim newid As String = "O" & Mid(lastid, 2) + 1
        Return newid

    End Function

    Private Sub refresh_Ptext(ByVal PID As String)
        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A160979 WHERE FLD_PRODUCT_ID = '" & PID & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        txt_name.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_NAME")
        txt_category.Text = mydatatable.Rows(0).Item("FLD_CATEGORY")
        txt_description.Text = mydatatable.Rows(0).Item("FLD_DESCRIPTION")
        txt_madefrom.Text = mydatatable.Rows(0).Item("FLD_MADEFROM")
        txt_price.Text = FormatCurrency(mydatatable.Rows(0).Item("FLD_PRICE"))
        txt_type.Text = mydatatable.Rows(0).Item("FLD_TYPE")

        If order_quantity.Value = 1 Then
            txt_sub.Text = FormatCurrency(mydatatable.Rows(0).Item("FLD_PRICE"))

        ElseIf order_quantity.Value > 1 Then
            txt_sub.Text = FormatCurrency(mydatatable.Rows(0).Item("FLD_PRICE") * order_quantity.Value)

        ElseIf order_quantity.Value = 0 Then
            txt_sub.Text = FormatCurrency(0)

        End If

        Try
            product_pic.BackgroundImage = Image.FromFile("pictures/" & list_product.Text & ".jpg")

        Catch ex As Exception
            product_pic.BackgroundImage = Image.FromFile("pictures/no photo.jpg")

        End Try

    End Sub

    Private Sub refresh_Stext(ByVal SID As String)
        Dim mysql2 As String = "SELECT * FROM TBL_STAFF_A160979 WHERE FLD_STAFF_ID = '" & SID & "'"
        Dim mydatatable2 As New DataTable
        Dim myreader2 As New OleDb.OleDbDataAdapter(mysql2, myconnection)
        myreader2.Fill(mydatatable2)
        txt_staff_name.Text = mydatatable2.Rows(0).Item("FLD_STAFF_NAME")
        txt_staff_tel.Text = mydatatable2.Rows(0).Item("FLD_STAFF_TEL")

    End Sub

    Private Sub refresh_Ctext(ByVal CID As String)
        Dim mysql3 As String = "SELECT * FROM TBL_CUSTOMER_A160979 WHERE FLD_CUSTOMER_ID = '" & CID & "'"
        Dim mydatatable3 As New DataTable
        Dim myreader3 As New OleDb.OleDbDataAdapter(mysql3, myconnection)
        myreader3.Fill(mydatatable3)
        txt_cust_name.Text = mydatatable3.Rows(0).Item("FLD_NAME")
        txt_cust_tel.Text = mydatatable3.Rows(0).Item("FLD_PHONE")

    End Sub

    Private Sub list_product_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles list_product.MouseClick
        refresh_Ptext(list_product.Text)

    End Sub

    Private Sub order_quantity_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles order_quantity.ValueChanged
        refresh_Ptext(list_product.Text)

    End Sub

    Private Sub list_staff_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles list_staff.MouseClick
        refresh_Stext(list_staff.Text)

    End Sub

    Private Sub list_cust_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles list_cust.MouseClick
        refresh_Ctext(list_cust.Text)

    End Sub

    Private Sub btn_order_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_order.Click
        If order_quantity.Value = 0 Then
            Beep()
            MsgBox("Please select the quantity of the product")
        Else
            grd_orders.Rows.Add(New String() {list_product.Text, txt_name.Text, txt_price.Text, order_quantity.Value, txt_sub.Text, DateTime.Now.ToString("yyyy/MM/dd")})
            refresh_total()
        End If
    End Sub

    Private Sub refresh_total()
        If grd_orders.RowCount >= 1 Then
            Dim sum = 0

            For index As Integer = 0 To grd_orders.RowCount - 1
                sum += grd_orders.Rows(index).Cells(4).Value

            Next

            txt_total.Text = FormatCurrency(sum)

        ElseIf grd_orders.RowCount = 0 Then
            txt_total.Text = FormatCurrency(0)

        End If
    End Sub

    Private Sub btn_confirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_confirm.Click

        If grd_orders.RowCount >= 1 Then
            Beep()
            Dim delete_confimation = MsgBox("Are you sure you would like to Comfirm the Order """ & txt_order_id.Text & """?", MsgBoxStyle.YesNo)

            If delete_confimation = MsgBoxResult.Yes Then

                Dim mytransaction As OleDb.OleDbTransaction
                myconnection2.Open()
                mytransaction = myconnection2.BeginTransaction
                Try
                    Dim mysql As String = "INSERT INTO TBL_ORDERS_A160979 VALUES('" & txt_order_id.Text & "', '" & list_cust.Text & "', '" & list_staff.Text & "', '" & DateTime.Now.ToString("yyyy/MM/dd") & "')"
                    Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2, mytransaction)
                    mywriter.ExecuteNonQuery()

                    For i As Integer = 0 To grd_orders.RowCount - 1
                        Dim product_id As String = grd_orders(0, i).Value
                        Dim product_name As String = grd_orders(1, i).Value
                        Dim price As String = grd_orders(2, i).Value
                        Dim quantity As String = grd_orders(3, i).Value
                        Dim subtotal As String = grd_orders(4, i).Value
                        Dim order_date As String = grd_orders(5, i).Value
                        Dim mysql2 As String = "INSERT INTO TBL_ORDER_DETAILS_A160979 VALUES('" & txt_order_id.Text & "', '" & product_id & "', '" & product_name & "', '" & price & "', " & quantity & ", '" & subtotal & "')"
                        Dim mywriter2 As New OleDb.OleDbCommand(mysql2, myconnection2, mytransaction)
                        mywriter2.ExecuteNonQuery()

                    Next

                    mytransaction.Commit()
                    myconnection2.Close()
                    Beep()
                    MsgBox("Transaction successful")
                    grd_orders.Rows.Clear()
                    txt_order_id.Text = generate_id()
                    txt_total.Text = ""
                Catch ex As Exception
                    Beep()
                    MsgBox("Problem with transaction:" & vbCrLf & vbCrLf & ex.Message)
                    mytransaction.Rollback()
                    myconnection2.Close()

                End Try


            End If
            
        Else
            Beep()
            MsgBox("Make sure you have added items")

        End If
       

    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        If grd_orders.RowCount >= 1 Then
            grd_orders.Rows.Remove(grd_orders.CurrentRow)
            refresh_total()
        Else
            Beep()
            MsgBox("No items to delete")
        End If

    End Sub

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        frm_mainmenu.Show()
        Me.Close()

    End Sub

End Class