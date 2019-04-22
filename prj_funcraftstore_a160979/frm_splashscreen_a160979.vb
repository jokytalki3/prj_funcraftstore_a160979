
Public Class frm_splashscreen_a160979

    Private Sub frm_splashscreen_a160979_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim random As New Random
        lbl_shopTitle.ForeColor = Color.FromArgb(random.Next(0, 230), random.Next(0, 230), random.Next(0, 230))
        Button1.ForeColor = Color.FromArgb(random.Next(0, 230), random.Next(0, 230), random.Next(0, 230))
        Button2.ForeColor = Color.FromArgb(random.Next(0, 230), random.Next(0, 230), random.Next(0, 230))
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frm_product_views.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frm_mainmenu.Show()
        Me.Hide()

    End Sub
End Class