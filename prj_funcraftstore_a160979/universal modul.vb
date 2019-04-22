Imports System.Drawing.Text
Module universal_modul
    Public shopTitle As String = "Fun Craft Store"
    Public shopSubTitle As String = "Where the Crafty Creations Belongs"
    Public myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_FUNCRAFTSTORE_A160979.accdb;Persist Security Info=False;"
    Public myconnection2 As New OleDb.OleDbConnection(myconnection)
    Public pfc As New PrivateFontCollection

    Public Function run_sql_query(ByVal mysql As String) As DataTable
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        Try
            myreader.Fill(mydatatable)
        Catch ex As Exception

            Beep()
            MsgBox("There is an error" & vbCrLf & vbCrLf & ex.Message)
        End Try

        Return mydatatable

    End Function

    Public Sub run_sql_command(ByVal thissql As String)

        Dim mywriter As New OleDb.OleDbCommand(thissql, myconnection2)

        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

        Catch ex As Exception
            Beep()
            MsgBox("There is a mistake in the data you entered, as show below" & vbCrLf & vbCrLf & ex.Message)

            mywriter.Connection.Close()
        End Try
    End Sub

    Public Sub addFont()
        pfc.AddFontFile(Application.StartupPath & "\Lithos Pro Regular.ttf")
        pfc.AddFontFile(Application.StartupPath & "\TektonPro-Regular.otf")

    End Sub
End Module
