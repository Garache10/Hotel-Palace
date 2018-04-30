Imports BaseDeDatos

Public Class Mobiliario
    Private Sub Mobiliario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim consulta As String
            consulta = "Select * from mobiliario;"
            If Operaciones.Buscar(consulta) Then
                DataGridView1.DataSource = Acceso.ds.Tables(0)
            Else
                DataGridView1.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class