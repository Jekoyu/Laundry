Imports System.IO
Imports System.Security.Cryptography
Imports System.Data.SqlClient

Module All
    Public cmd As SqlCommand
    Public dr As SqlDataReader
    Public da As SqlDataAdapter
    Public ds As DataSet
    Public conn As SqlConnection
    Public q As String
    Public role As String

    Public Function Md5(ByVal Pwd As String) As String
        Dim x As New MD5CryptoServiceProvider
        Dim bs As Byte() = System.Text.Encoding.UTF8.GetBytes(Pwd)
        bs = x.ComputeHash(bs)
        Dim s As New System.Text.StringBuilder()
        For Each b As Byte In bs
            s.Append(b.ToString("x2").ToLower())
        Next
        Return s.ToString
    End Function
    Public Function Md5de(ByVal Pwd As String) As String
        Dim x As New MD5CryptoServiceProvider
        Dim bs As Byte() = System.Text.Encoding.UTF8.GetBytes(Pwd)
        bs = x.ComputeHash(bs)
        Dim s As New System.Text.StringBuilder()
        For Each b As Byte In bs
            s.Append(b.ToString("x2").ToUpper())
        Next
        Return s.ToString
    End Function

    Public Sub koneksi()
        Try
            conn = New SqlConnection("Data Source=DESKTOP-VOQEHKC\SQLEXPRESS;Initial Catalog=db_laundry;Integrated Security=True;MultipleActiveResultSets=True")
            conn.Open()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function Cari(ByVal q As String) As Boolean
        Try
            koneksi()
            cmd = New SqlCommand(q, conn)
            dr = cmd.ExecuteReader()
            dr.Read()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return True
    End Function


    Public Function ENQ(ByVal q As String) As Boolean

        Try
            koneksi()
            cmd = New SqlCommand(q, conn)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return True
    End Function

    Public Function Tampil(ByVal clm As String, tbl As String) As Boolean

        Try
            da = New SqlDataAdapter("select " + clm + " from " + tbl, conn)
            da.Fill(ds)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return True
    End Function
End Module
