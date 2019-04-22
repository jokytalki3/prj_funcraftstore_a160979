Public Class frm_products

    Private Sub frm_products_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A160979 ORDER BY FLD_PRODUCT_ID"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_products.DataSource = mydatatable

        lbl_shopSubTitle.Text = shopSubTitle
        lbl_shopTitle.Text = shopTitle
        Dim current_date = Date.Now
        lbl_date.Text = current_date.DayOfWeek.ToString() & vbNewLine & current_date.Date & vbNewLine & current_date.Hour & ":" & current_date.Minute

        Timer1.Start()

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
End Class