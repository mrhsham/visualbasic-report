
Imports System.Data.Odbc
Imports System.IO

Public Class frmMain

    Dim CONN As New OdbcConnection
    Dim CMD As New OdbcCommand
    Dim DS As New DataSet
    Dim DA As OdbcDataAdapter
    Dim DR As OdbcDataReader
    Dim LokasiData As String

    Sub Koneksi()
        LokasiData = "Driver={MySQL ODBC 5.3 ANSI Driver};database=visualbasic_report;server=localhost;uid=root;pwd="
        CONN = New OdbcConnection(LokasiData)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
    End Sub

    Sub TampilGrid()
        Call Koneksi()
        DA = New OdbcDataAdapter("select * from report", CONN)
        DS = New DataSet
        DA.Fill(DS, "report")
        DataGridView1.DataSource = DS.Tables("report")
        DataGridView1.ReadOnly = True
    End Sub

    Sub TampilKembali()
        Try
            CONN.Open()
            CMD.Connection = CONN
            CMD.CommandType = CommandType.Text
            CMD.CommandText = "select * from report where kode='" & txtKode.Text & "'"
            DR = CMD.ExecuteReader
            If Not DR Is Nothing Then
                DR.Read()
                txtNama.Text = DR("nama").ToString
                txtAlamat.Text = DR("alamat").ToString
                txtPekerjaan.Text = DR("pekerjaan").ToString
                Dim data As Byte() = DirectCast(DR("foto"), Byte())
                Dim ms As New MemoryStream(data)
                ptbFoto.BackgroundImage = Image.FromStream(ms)
                ptbFoto.BackgroundImageLayout = ImageLayout.Stretch
                DR.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            CONN.Close()
        End Try
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call TampilGrid()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim row As New DataGridViewRow
        row = DataGridView1.CurrentRow
        txtKode.Text = row.Cells("kode").Value.ToString
        CONN.Close()
        Call TampilKembali()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Dim sTitle As String
        sTitle = txtKode.Text
        Dim frm As New View(sTitle)
        frm.Show()
    End Sub
End Class
