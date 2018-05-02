Imports BaseDeDatos

Public Class Clientes
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cedula, nombre, apellido, correo, telefono, sexo, numVis As String
        cedula = TextBox4.Text()
        nombre = TextBox2.Text()
        apellido = TextBox3.Text()
        numVis = TextBox6.Text()
        correo = TextBox1.Text()
        telefono = TextBox5.Text()
        sexo = ComboBox1.Text()

        Dim consulta As String
        consulta = "Insert into Cliente values('" + cedula + "', '" + nombre + "', '" + apellido + "' ,'" + sexo + "', " + numVis + ", '" + telefono + "', '" + correo + "');"
        Operaciones.SaveData(consulta)

        Label8.Text() = "El cliente fue registrado..!"

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

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim consulta As String
            consulta = "Select * from Cliente;"
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
        Try
            Dim consulta As String
            consulta = "Select * from Cliente Where cedula_cliente = " + TextBox7.Text()
            If Operaciones.Buscar(consulta) Then

            Else
                Label15.Text() = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Clientes_Load(sender, e)
    End Sub
End Class