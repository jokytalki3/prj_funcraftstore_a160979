Public Class frm_update_staff
    Dim current_staff_id As String
    Private Sub btn_mainmenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_mainmenu.Click
        frm_mainmenu.Show()
        Me.Close()

    End Sub

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        End
    End Sub

    Private Sub frm_update_staff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        refresh_grid()

        get_current_staff_id()

        lbl_shopSubTitle.Text = shopSubTitle
        lbl_shopTitle.Text = shopTitle
        Dim current_date = Date.Now
        lbl_date.Text = current_date.DayOfWeek.ToString() & vbNewLine & current_date.Date & vbNewLine & current_date.Hour & ":" & current_date.Minute

        Timer1.Start()
    End Sub

    Private Sub refresh_grid()
        Dim mysql As String = "SELECT * FROM TBL_STAFF_A160979 ORDER BY FLD_STAFF_ID"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_staff.DataSource = mydatatable
    End Sub

    Private Sub clear_fields()
        txt_staff_name.Text = ""
        txt_staff_password.Text = ""
    End Sub

    Private Sub get_current_staff_id()
        Dim current_row As Integer = grd_staff.CurrentRow.Index()

        current_staff_id = grd_staff(0, current_row).Value

        txt_id.Text = current_staff_id
        txt_staff_name.Text = grd_staff(1, current_row).Value
        txt_staff_password.Text = grd_staff(2, current_row).Value

    End Sub


    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        run_sql_command("UPDATE TBL_STAFF_A160979 SET FLD_STAFF_NAME='" & txt_staff_name.Text & "' WHERE FLD_STAFF_ID='" & current_staff_id & "'")
        run_sql_command("UPDATE TBL_STAFF_A160979 SET FLD_STAFF_TEL='" & txt_staff_password.Text & "' WHERE FLD_STAFF_ID='" & current_staff_id & "'")

        Beep()
        MsgBox("You have succesfully updated the course """ & current_staff_id & """.")

        refresh_grid()
        clear_fields()
        get_current_staff_id()
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        Dim delete_confimation = MsgBox("Are you sure you would like to delete the student """ & current_staff_id & """?", MsgBoxStyle.YesNo)

        If delete_confimation = MsgBoxResult.Yes Then
            run_sql_command("DELETE FROM TBL_STAFF_A160979 WHERE FLD_STAFF_ID='" & current_staff_id & "'")

            Beep()
            MsgBox("The student """ & current_staff_id & """ has been successfully deleted.")

            refresh_grid()
            clear_fields()
            get_current_staff_id()
        End If
    End Sub

    Private Sub grd_staff_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_staff.CellClick
        get_current_staff_id()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim random As New Random
        lbl_shopTitle.ForeColor = Color.FromArgb(random.Next(0, 230), random.Next(0, 230), random.Next(0, 230))
    End Sub

    Private Sub btn_toinsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_toinsert.Click
        frm_insert_staff.Show()
        Me.Close()

    End Sub
End Class