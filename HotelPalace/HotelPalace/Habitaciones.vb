Imports BaseDeDatos

Public Class Habitaciones
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id, tipo, precio As String
        id = TextBox2.Text()
        tipo = ComboBox1.Text()
        precio = TextBox1.Text()

        Dim consulta As String
        consulta = "Insert into habitacion values(" + id + ", '" + tipo + "', " + precio + ", 'desocupado');"
        Operaciones.SaveData(consulta)

        Label4.Text() = "La habitaciòn ha sido registrada..!"

        Button2_Click(sender, e)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text() = ""
        TextBox2.Text() = ""
        ComboBox1.Text() = ""
    End Sub

    Private Sub Habitaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim consulta As String
            consulta = "Select * from habitacion;"
            If Operaciones.Buscar(consulta) Then
                DataGridView1.DataSource = Acceso.ds.Tables(0)
            Else
                DataGridView1.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Habitaciones_Load(sender, e)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim consulta, id As String
        id = TextBox3.Text()
        consulta = "Delete from habitacion Where id_habitacion = " + id + ";"
        Operaciones.SaveData(consulta)
        Button2_Click(sender, e)
        Label6.Text() = "La habitación ha sido eliminada...!"
    End Sub
End Class