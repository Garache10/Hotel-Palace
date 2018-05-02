Imports BaseDeDatos

Public Class Empleados
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nombre, apellido, cedula, puesto, sueldo, id As String
        id = TextBox5.Text()
        nombre = TextBox1.Text()
        apellido = TextBox2.Text()
        cedula = TextBox3.Text()
        puesto = ComboBox1.Text()
        sueldo = TextBox4.Text()

        Dim consulta As String
        consulta = "Insert into Empleado values(" + id + ", '" + cedula + "', '" + nombre + "' ,'" + apellido + "', '" + puesto + "', " + sueldo + ");"
        Operaciones.SaveData(consulta)

        Label7.Text = "El empleado ha sido guardado..!"

        Button2_Click(sender, e)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        ComboBox1.Text = ""
    End Sub

    Private Sub Empleados_Load(ByVal sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Dim consulta As String
            consulta = "Select * from Empleado;"
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