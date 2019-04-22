Public Class frm_insert_customer

    Private Sub frm_insert_customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        grd_product.DataSource = run_sql_query("SELECT * FROM TBL_CUSTOMER_A160979")

        txt_id.Text = generate_id()

        lbl_shopSubTitle.Text = shopSubTitle
        lbl_shopTitle.Text = shopTitle
        Dim current_date = Date.Now
        lbl_date.Text = current_date.DayOfWeek.ToString() & vbNewLine & current_date.Date & vbNewLine & current_date.Hour & ":" & current_date.Minute

        Timer1.Start()
    End Sub

    Private Function generate_id() As String
        Dim lastid As String = run_sql_query("SELECT MAX(FLD_CUSTOMER_ID) AS LASTID FROM TBL_CUSTOMER_A160979").Rows(0).Item("LASTID")

        MsgBox("The last customer you have is " & lastid)

        Dim newid As String = "G00" & Mid(lastid, 2) + 1
        Return newid
    End Function

    Private Sub btn_insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_insert.Click
        If txt_name.Text = "" Or txt_email.Text = "" Or txt_phone.Text = "" Or txt_address.Text = "" Then
            Beep()
            MsgBox("Make sure you add all the details of customer")
        Else
            Dim mysql As String = "INSERT INTO TBL_CUSTOMER_A160979 VALUES('" & txt_id.Text & "','" & txt_name.Text & "','" & txt_email.Text & "','" & txt_phone.Text & "','" & txt_address.Text & "')"

            Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

            Try
                mywriter.Connection.Open()
                mywriter.ExecuteNonQuery()
                mywriter.Connection.Close()


                grd_product.DataSource = run_sql_query("SELECT * FROM TBL_CUSTOMER_A160979")

                txt_id.Text = generate_id()
                txt_name.Text = ""
                txt_email.Text = ""
                txt_phone.Text = ""
                txt_address.Text = ""

            Catch ex As Exception
                Beep()
                MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)
                mywriter.Connection.Close()

            End Try
        End If
        
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frm_mainmenu.Show()
        Me.Close()

    End Sub

    Private Sub btn_exit1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit1.Click
        End
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim random As New Random
        lbl_shopTitle.ForeColor = Color.FromArgb(random.Next(0, 230), random.Next(0, 230), random.Next(0, 230))
    End Sub

    Private Sub btn_toinsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_toinsert.Click
        frm_update_customer.Show()
        Me.Close()

    End Sub
End Class