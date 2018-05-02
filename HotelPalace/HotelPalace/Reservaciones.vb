Imports BaseDeDatos

Public Class Reservaciones
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cedula, id_habitacion, id_oferta, id_reserva, tipo, id_empleado, id_cancelacion As String
        id_reserva = TextBox4.Text()
        cedula = TextBox1.Text()
        id_habitacion = TextBox3.Text()
        id_oferta = TextBox2.Text()
        tipo = ComboBox1.Text()
        id_cancelacion = TextBox6.Text()
        id_empleado = TextBox5.Text()

        Dim consulta As String
        consulta = "Insert into reserva(id_reserva, tipo_reserva, cedula_cliente, id_empleado, id_oferta, id_habitacion, id_cancelacion) values(" + id_reserva + ", '" + tipo + "', '" + cedula + ", " + id_empleado + ", " + id_oferta + ", " + id_habitacion + ", " + id_cancelacion + ");"
        Operaciones.SaveData(consulta)

        Label9.Text() = "La reservaciòn se guardó exitosamente..!"

        Cancelacion.Show()
        Button2_Click(sender, e)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text() = ""
        TextBox2.Text() = ""
        TextBox3.Text() = ""
        TextBox4.Text() = ""
        TextBox5.Text() = ""
        TextBox6.Text() = ""
        ComboBox1.Text() = ""
    End Sub

    Private Sub Reservaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim consulta As String
            consulta = "Select * from Reserva;"
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
        Reservaciones_Load(sender, e)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim consulta, reserva As String
        reserva = TextBox7.Text()
        consulta = "Delete from reserva Where id_reserva = " + reserva + ";"
        Operaciones.SaveData(consulta)
        Button2_Click(sender, e)
        Label13.Text() = "La reservación ha sido eliminada...!"
    End Sub
End Class