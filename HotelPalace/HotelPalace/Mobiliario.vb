Imports BaseDeDatos

Public Class Mobiliario
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id, descripcion, tipo, cant, idhabi As String
        id = TextBox1.Text()
        descripcion = TextBox4.Text()
        tipo = ComboBox1.Text()
        idhabi = TextBox2.Text()
        cant = TextBox3.Text()

        Dim consulta As String
        consulta = "Insert into mobiliario values(" + id + ", '" + descripcion + "', '" + tipo + "' ," + cant + ", " + idhabi + ");"
        Operaciones.SaveData(consulta)

        Label6.Text() = "El mobiliario fue registrado..!"

        Button2_Click(sender, e)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text() = ""
        TextBox2.Text() = ""
        TextBox3.Text() = ""
        TextBox4.Text() = ""
        ComboBox1.Text() = ""
    End Sub

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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Mobiliario_Load(sender, e)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim consulta, id As String
        id = TextBox5.Text()
        consulta = "Delete from mobiliario Where id_mobiliario = '" + id + "';"
        Operaciones.SaveData(consulta)
        Button2_Click(sender, e)
        Label8.Text() = "El mobiliario ha sido eliminado...!"
    End Sub
End Class