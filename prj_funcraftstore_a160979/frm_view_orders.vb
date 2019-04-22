Public Class frm_view_orders
    Private Sub frm_view_orders_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT FLD_ORDER_ID FROM TBL_ORDERS_A160979"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        list_order.DataSource = mydatatable
        list_order.DisplayMember = "FLD_ORDER_ID"
        refresh_text(list_order.Text)
        refresh_grid()

    End Sub

    Private Sub refresh_text(ByVal ID As String)
        Dim mysql As String = "SELECT * FROM TBL_ORDERS_A160979 WHERE FLD_ORDER_ID = '" & ID & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        lbl_date.Text = mydatatable.Rows(0).Item("FLD_DATE")
        lbl_orderID.Text = list_order.Text

    End Sub

    Private Sub refresh_grid()
        Dim mysql As String = "SELECT FLD_PRODUCT_ID AS PRODUCT_ID,FLD_PRODUCT_NAME AS NAME, FLD_PRODUCT_QUANTITY AS QUANTITY,FLD_PRICE AS PRICE,FLD_TOTAL_PRICE AS SUBTOTAL FROM TBL_ORDER_DETAILS_A160979 WHERE FLD_ORDER_ID = '" & list_order.Text & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_order_record.DataSource = mydatatable

    End Sub

    Private Sub refresh_total()
        If grd_order_record.RowCount >= 1 Then
            Dim sum = 0

            For index As Integer = 0 To grd_order_record.RowCount - 1
                sum += grd_order_record.Rows(index).Cells(3).Value

            Next
            txt_total.Text = FormatCurrency(sum)

        End If
    End Sub

    Private Sub list_order_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles list_order.MouseClick
        refresh_text(list_order.Text)
        refresh_grid()
        refresh_total()

    End Sub

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        Me.Close()
        frm_mainmenu.Show()

    End Sub
    
End Class