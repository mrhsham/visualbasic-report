Imports CrystalDecisions.CrystalReports.Engine
Imports MySql.Data.MySqlClient
Imports CrystalDecisions.Shared

Public Class View
    Dim p(7) As MySqlParameter

    Dim conn As New MySqlConnection("database=visualbasic_report;server=localhost;uid=root;pwd=")
    Dim cmd As MySqlCommand
    Dim ds As DataSet
    Dim da As MySqlDataAdapter

    Public Sub New(ByVal sTitle As String)
        'Call Koneksi()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            'conn.Open()
            Dim ds As New DataSet
            Dim query As String
            p(0) = New MySqlParameter("@kode", MySqlDbType.String)
            p(0).Value = sTitle
            query = "select * from report where kode=@kode"
            Dim dscmd As New MySqlDataAdapter(query, conn)
            dscmd.SelectCommand.Parameters.Add(p(0))
            dscmd.Fill(ds, "report")
            'conn.Close()
            Dim cryds As New RPT
            cryds.SetDataSource(ds.Tables(0))
            RPTView.ReportSource = cryds
            RPTView.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
        conn.Close()
    End Sub
End Class