Imports BaseDeDatos

Public Class Ofertas
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id, porcentaje, desc As String
        id = TextBox3.Text()
        porcentaje = TextBox1.Text()
        desc = TextBox2.Text()

        Dim consulta As String
        consulta = "Insert into oferta(id_oferta, descripcion, porcentaje_descuento) values(" + id + ", '" + desc + "', " + porcentaje + ");"
        Operaciones.SaveData(consulta)

        Label6.Text() = "La oferta ha sido registrada..!"

        Button2_Click(sender, e)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text() = ""
        TextBox2.Text() = ""
        TextBox3.Text() = ""
        DateTimePicker1.ResetText()
        DateTimePicker2.ResetText()
    End Sub

    Private Sub Ofertas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim consulta As String
            consulta = "Select * from oferta;"
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