Public Class frm_mainmenu

    Private Sub btn_customer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_customer.Click
        frm_customer.Show()
        Me.Close()
    End Sub

    Private Sub btn_products_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_products.Click
        frm_products.Show()
        Me.Close()

    End Sub

    Private Sub btn_staff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_staff.Click
        frm_staff.Show()
        Me.Close()

    End Sub

    Private Sub frm_mainmenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbl_shopSubTitle.Text= shopSubTitle
        lbl_shopTitle.Text = shopTitle
        Dim current_date = Date.Now
        lbl_date.Text = current_date.DayOfWeek.ToString() & vbNewLine & current_date.Date & vbNewLine & current_date.Hour & ":" & current_date.Minute

        Timer1.Start()
    End Sub

    Private Sub btn_orderlist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_orderlist.Click
        frm_orderlist.Show()
        Me.Close()

    End Sub

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        End
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim random As New Random
        lbl_shopTitle.ForeColor = Color.FromArgb(random.Next(0, 230), random.Next(0, 230), random.Next(0, 230))
    End Sub

    
    Private Sub btn_backmain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_backmain.Click
        frm_splashscreen_a160979.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frm_insert_products.Show()
        Me.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        frm_insert_customer.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frm_insert_staff.Show()
        Me.Close()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        frm_update_products.Show()
        Me.Close()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        frm_update_staff.Show()
        Me.Close()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        frm_update_customer.Show()
        Me.Close()

    End Sub

    Private Sub btn_make_order_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_make_order.Click
        frm_make_order.Show()
        Me.Close()

    End Sub

    Private Sub btn_invoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_invoice.Click
        frm_view_orders.Show()
        Me.Close()

    End Sub

    Private Sub btn_orders_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_orders.Click
        frm_orders.Show()
        Me.Close()
    End Sub
End Class
