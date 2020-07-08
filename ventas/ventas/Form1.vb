'ing este es mi proyecto , lo realice con lo que vimos en clase , no es mucho pero es un codigo honesto .
'att : walther efrain aguilar ulloa 0318200300249 '

Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class Form1
    Dim conexion As conexion = New conexion()

    Public Sub mostrardatos()
        conexion.consulta("select * from Venta", "Venta")

        DataGridView1.DataSource = conexion.ds.Tables("Venta")

    End Sub
    Public Sub mostrarproductos()
        conexion.consulta("select * from producto", "producto")

        DataGridView1.DataSource = conexion.ds.Tables("producto")

    End Sub
    Public Sub mostrargente()
        conexion.consulta("select * from cliente", "cliente")

        DataGridView1.DataSource = conexion.ds.Tables("cliente")

    End Sub
    Public Sub mostrardatos2(ByVal idventa As Integer)

        conexion.consulta(" SELECT concat(cliente.nombre, ' ', cliente.apellido) as Nombre, producto.nombreProducto,Venta.precio, Venta.cantidad, Venta.fechaVenta FROM Venta
INNER JOIN cliente On Venta.idCliente = cliente.idCliente
INNER JOIN producto on Venta.idProducto = producto.idProducto
WHERE Venta.idVenta = " & idventa, "Venta")

        DataGridView1.DataSource = conexion.ds.Tables("Venta")

    End Sub
    Public Sub mostrardatos3()

        conexion.consulta(" SELECT concat(cliente.nombre, ' ', cliente.apellido) as Nombre, producto.nombreProducto,Venta.precio, Venta.cantidad, Venta.fechaVenta FROM Venta
INNER JOIN cliente On Venta.idCliente = cliente.idCliente
INNER JOIN producto on Venta.idProducto = producto.idProducto
", "Venta")

        DataGridView1.DataSource = conexion.ds.Tables("Venta")

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        mostrardatos()
    End Sub
    Public Sub mostrarnombre(ByVal condicion)
        conexion.consulta("Select nombre from cliente " + "where" + condicion, "cliente")
        txtNombrecliente.Text = conexion.ds.Tables("cliente").Rows(0)(0)
    End Sub
    Public Sub mostrarapellido(ByVal condicion)
        conexion.consulta("Select apellido from cliente " + "where" + condicion, "cliente")
        txtapellido.Text = conexion.ds.Tables("cliente").Rows(0)(0)
    End Sub
    Public Sub mostrardireccion(ByVal condicion)
        conexion.consulta("Select direccion from cliente " + "where" + condicion, "cliente")
        direccion.Text = conexion.ds.Tables("cliente").Rows(0)(0)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Dim conexion As String
            conexion = "Data source= DESKTOP-LGDBE5Q \ SQLEXPRESS ;Initial catalog=Tienda;integrated security =true"
            Dim cn As New SqlConnection
            cn.ConnectionString = conexion
            Dim adaptador As New SqlDataAdapter("select * from cliente where idCliente =" & txtcodigo.Text & " ", cn)
            Dim ds As New DataSet
            adaptador.Fill(ds, "datos")
            If ds.Tables("datos").Rows.Count > 0 Then
                txtcodigo.Text = ds.Tables("datos").Rows(0).Item(0).ToString
                txtNombrecliente.Text = ds.Tables("datos").Rows(0).Item(1).ToString
                txtapellido.Text = ds.Tables("datos").Rows(0).Item(2).ToString
                direccion.Text = ds.Tables("datos").Rows(0).Item(3).ToString
                DataGridView1.DataSource = ds.Tables("datos")


            Else
                MsgBox("Usuario no existe")
            End If
        Catch ex As Exception
            MessageBox.Show("Ingrese el codigo del cliente")
        End Try

    End Sub

    Private Sub insertarbtn_Click(sender As Object, e As EventArgs) Handles insertarbtn.Click
        Try

            Dim agregar As String = "insert into cliente  values ('" + txtcodigo.Text + "','" + txtNombrecliente.Text + "','" + txtapellido.Text + "','" + direccion.Text + "')"

            If (conexion.insertar(agregar)) Then
                MessageBox.Show("Datos Agregados Correctamente")
                mostrargente()
            Else
                MessageBox.Show("error al agregar")

            End If
        Catch ex As Exception
            MessageBox.Show("Pueda que tenga campos vacios o quiera insertar con el mismo codigo de cliente")
        End Try

    End Sub

    Private Sub txtcodigo_TextChanged(sender As Object, e As EventArgs) Handles txtcodigo.TextChanged

    End Sub

    Private Sub txtcodigo_MouseHover(sender As Object, e As EventArgs) Handles txtcodigo.MouseHover
        tmensaje.SetToolTip(txtcodigo, "Ingrese el codigo del cliente")
        tmensaje.ToolTipTitle = "Codigo"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub





    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        If (conexion.eliminar("Venta", "idVenta = " + txtidventa.Text)) Then
            MessageBox.Show("Registro eliminado correctamente")
            mostrardatos()
        Else
            MessageBox.Show("error al eliminar")

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        mostrardatos2(txtcodigo.Text)
    End Sub

    Private Sub btnbuscarproducto_Click(sender As Object, e As EventArgs) Handles btnbuscarproducto.Click
        Try
            Dim conexion As String
            conexion = "Data source= DESKTOP-LGDBE5Q \ SQLEXPRESS ;Initial catalog=Tienda;integrated security =true"
            Dim cn As New SqlConnection
            cn.ConnectionString = conexion
            Dim adaptador As New SqlDataAdapter("select * from producto where idProducto = " & txtidp.Text & " ", cn)
            Dim ds As New DataSet
            adaptador.Fill(ds, "datos")
            If ds.Tables("datos").Rows.Count > 0 Then
                txtidp.Text = ds.Tables("datos").Rows(0).Item(0).ToString
                txtproducto.Text = ds.Tables("datos").Rows(0).Item(1).ToString
                txtdescripcionproductos.Text = ds.Tables("datos").Rows(0).Item(2).ToString

                DataGridView1.DataSource = ds.Tables("datos")


            Else
                MsgBox("Usuario no existe")
            End If
        Catch ex As Exception
            MessageBox.Show("porfavor ingrese el codigo del producto")
        End Try

    End Sub

    Private Sub btninsertarproducto_Click(sender As Object, e As EventArgs) Handles btninsertarproducto.Click
        Try
            Dim agregar As String = "insert into producto  values ('" + txtidp.Text + "','" + txtproducto.Text + "','" + txtdescripcionproductos.Text + "')"

            If (conexion.insertar(agregar)) Then
                MessageBox.Show("Datos Agregados Correctamente")
                mostrarproductos()
            Else
                MessageBox.Show("error al agregar")

            End If
        Catch ex As Exception
            MessageBox.Show("Registro existente ")
        End Try
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Try
            If (conexion.eliminar("producto", "idProducto = " + txtidp.Text)) Then
                MessageBox.Show("Registro eliminado correctamente")
                mostrardatos()
            Else
                MessageBox.Show("error al eliminar")

            End If
        Catch ex As Exception
            MessageBox.Show("por favor realice una busqueda con codigo de producto para poder eliminar")
        End Try

    End Sub

    Private Sub btnmodificarproducto_Click(sender As Object, e As EventArgs) Handles btnmodificarproducto.Click
        Try
            Dim actualizar As String = "  nombreProducto='" + txtproducto.Text + "', descripcion='" + txtdescripcionproductos.Text + "'"
            Dim sql As String = String.Format("update producto set  nombreProducto='{0}', descripcion='{1}'  where idProducto={2}", txtproducto.Text, txtdescripcionproductos.Text, txtidp.Text)
            If (conexion.actualizar(sql)) Then
                MessageBox.Show("datos actualizados correctamente")
                mostrardatos()
            Else
                MessageBox.Show("error al actualizar")

            End If
        Catch ex As Exception
            MessageBox.Show("realice una busqueda con codigo producto para poder modificar")
        End Try

    End Sub

    Private Sub btnmostrarproductos_Click(sender As Object, e As EventArgs) Handles btnmostrarproductos.Click
        mostrarproductos()
    End Sub

    Private Sub btneliminarcliente_Click(sender As Object, e As EventArgs) Handles btneliminarcliente.Click
        Try
            If (conexion.eliminar("cliente", "idCliente = " + txtcodigo.Text)) Then
                MessageBox.Show("Registro eliminado correctamente")
                mostrardatos()
            Else
                MessageBox.Show("error al eliminar")

            End If
        Catch ex As Exception
            MessageBox.Show("Haga una busqueda con codigo de cliente para poder eliminar")
        End Try

    End Sub

    Private Sub btnmodificarcliente_Click(sender As Object, e As EventArgs) Handles btnmodificarcliente.Click
        Try

            Dim actualizar As String = "  nombre='" + txtNombrecliente.Text + "', apellido='" + txtdescripcionproductos.Text + "',direccion'" + direccion.Text + "'"
            Dim sql As String = String.Format("update cliente set  nombre='{0}', apellido='{1}', direccion='{2}'  where idCliente={3}", txtNombrecliente.Text, txtapellido.Text, direccion.Text, txtcodigo.Text)
            If (conexion.actualizar(sql)) Then
                MessageBox.Show("datos actualizados correctamente")
                mostrardatos()
            Else
                MessageBox.Show("error al actualizar")

            End If
        Catch ex As Exception
            MessageBox.Show("realice una busqueda con codigo cliente para poder modificar")
        End Try

    End Sub

    Private Sub btnmostrarcliente_Click(sender As Object, e As EventArgs) Handles btnmostrarcliente.Click
        mostrargente()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        If txtcodcliente.Text = "" Then
            MessageBox.Show("Porfavor ingrese el codigo del cliente para realizar la busqueda")
        Else
            mostrardatos2(txtcodcliente.Text)
        End If

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        Try
            Dim dgv As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            txtidventa.Text = dgv.Cells(0).Value.ToString()
            MaskedTextBox1.Text = dgv.Cells(1).Value.ToString()
            txtprecio.Text = dgv.Cells(2).Value.ToString()
            txtcantidad.Text = dgv.Cells(3).Value.ToString()
            txtcodcliente.Text = dgv.Cells(4).Value.ToString()
            txtidproducto.Text = dgv.Cells(5).Value.ToString()

        Catch ex As Exception
            MessageBox.Show("Solo puede dar click si esta la informacion de ventas")
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        mostrardatos3()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Btnagrgarventa.Click
        Try
            Dim agregar As String = "insert into Venta  values ('" + txtidventa.Text + "','" + MaskedTextBox1.Text + "','" + txtprecio.Text + "','" + txtcantidad.Text + "','" + txtcodcliente.Text + "','" + txtidproducto.Text + "')"

            If (conexion.insertar(agregar)) Then
                MessageBox.Show("Datos Agregados Correctamente")
                mostrardatos()
            Else
                MessageBox.Show("error al agregar")

            End If
        Catch ex As Exception
            MessageBox.Show("Registro existente")
        End Try
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles btneliminarventa.Click
        Try
            If (conexion.eliminar("Venta", "idVenta = " + txtidventa.Text)) Then
                MessageBox.Show("Registro eliminado correctamente")
                mostrardatos()
            Else
                MessageBox.Show("error al eliminar")

            End If
        Catch ex As Exception
            MessageBox.Show("selecion algun registro del data grid para poder eliminar")
        End Try

    End Sub

    Private Sub btnmodificarventa_Click(sender As Object, e As EventArgs) Handles btnmodificarventa.Click
        Try
            Dim actualizar As String = "  fechaVenta='" + MaskedTextBox1.Text + "', precio='" + txtprecio.Text + "',cantidad='" + txtcantidad.Text + "',idCliente='" + txtcodcliente.Text + "',idProducto'" + txtidproducto.Text + "'"
            Dim sql As String = String.Format("update Venta set  fechaVenta='{0}', precio='{1}', cantidad='{2}', idCliente='{3}', [idProducto]='{4}' where idVenta={5}", MaskedTextBox1.Text, txtprecio.Text, txtcantidad.Text, txtcodcliente.Text, txtidproducto.Text, txtidventa.Text)
            If (conexion.actualizar(sql)) Then
                MessageBox.Show("datos actualizados correctamente")
                mostrardatos()
            Else
                MessageBox.Show("error al actualizar")

            End If
        Catch ex As Exception
            MessageBox.Show("seleccione algun registro del data grid para poder modificar")
        End Try

    End Sub

    Private Sub btnmostrarventas_Click(sender As Object, e As EventArgs) Handles btnmostrarventas.Click
        mostrardatos()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        txtcodcliente.Enabled = True
        txtidventa.Enabled = True
        MaskedTextBox1.Enabled = True
        txtprecio.Enabled = True
        txtcantidad.Enabled = True
        txtidproducto.Enabled = True

        txtcodigo.Enabled = False
        txtapellido.Enabled = False
        direccion.Enabled = False

        txtNombrecliente.Enabled = False


        txtidp.Enabled = False
        txtproducto.Enabled = False
        txtdescripcionproductos.Enabled = False



        txtcodcliente.Clear()
        txtidventa.Clear()
        MaskedTextBox1.Clear()
        txtprecio.Clear()
        txtcantidad.Clear()
        txtidproducto.Clear()

        btnmostrarventas.Enabled = True
        Button5.Enabled = True
        Btnagrgarventa.Enabled = True
        btneliminarventa.Enabled = True
        btnmodificarventa.Enabled = True
        Button6.Enabled = True


        If CheckBox1.Checked = False Then
            txtcodcliente.Enabled = False
            txtidventa.Enabled = False
            MaskedTextBox1.Enabled = False
            txtprecio.Enabled = False
            txtcantidad.Enabled = False
            txtidproducto.Enabled = False

            btnmostrarventas.Enabled = False
            Button5.Enabled = False
            Btnagrgarventa.Enabled = False
            btneliminarventa.Enabled = False
            btnmodificarventa.Enabled = False
            Button6.Enabled = False



            txtcodigo.Enabled = True
            txtapellido.Enabled = True
            direccion.Enabled = True

            txtNombrecliente.Enabled = True


            txtidp.Enabled = True
            txtproducto.Enabled = True
            txtdescripcionproductos.Enabled = True
        End If

    End Sub

    Private Sub CheckBox1_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckStateChanged

    End Sub

    Private Sub txtcodigo_Validating(sender As Object, e As CancelEventArgs) Handles txtcodigo.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Ingrese el codigo del cliente ")
        End If
    End Sub

    Private Sub txtcodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodigo.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtcodcliente_TextChanged(sender As Object, e As EventArgs) Handles txtcodcliente.TextChanged

    End Sub

    Private Sub txtcodcliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodcliente.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtidp_TextChanged(sender As Object, e As EventArgs) Handles txtidp.TextChanged

    End Sub

    Private Sub txtidp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtidp.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtidventa_TextChanged(sender As Object, e As EventArgs) Handles txtidventa.TextChanged

    End Sub

    Private Sub txtidventa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtidventa.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtprecio_TextChanged(sender As Object, e As EventArgs) Handles txtprecio.TextChanged

    End Sub

    Private Sub txtprecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprecio.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtcantidad_TextChanged(sender As Object, e As EventArgs) Handles txtcantidad.TextChanged

    End Sub

    Private Sub txtcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantidad.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtidproducto_TextChanged(sender As Object, e As EventArgs) Handles txtidproducto.TextChanged

    End Sub

    Private Sub txtidproducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtidproducto.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected

    End Sub

    Private Sub MaskedTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaskedTextBox1.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNombrecliente_TextChanged(sender As Object, e As EventArgs) Handles txtNombrecliente.TextChanged

    End Sub

    Private Sub txtNombrecliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombrecliente.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub txtapellido_TextChanged(sender As Object, e As EventArgs) Handles txtapellido.TextChanged

    End Sub

    Private Sub txtapellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtapellido.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub direccion_TextChanged(sender As Object, e As EventArgs) Handles direccion.TextChanged

    End Sub

    Private Sub direccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles direccion.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub



    Private Sub txtdescripcionproductos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdescripcionproductos.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub txtproducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtproducto.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub txtidp_MouseHover(sender As Object, e As EventArgs) Handles txtidp.MouseHover
        tmensaje.SetToolTip(txtcodigo, "Ingrese el codigo del producto")
        tmensaje.ToolTipTitle = "Codigo"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtcodcliente_MouseHover(sender As Object, e As EventArgs) Handles txtcodcliente.MouseHover
        tmensaje.SetToolTip(txtcodigo, "Ingrese el codigo del cliente")
        tmensaje.ToolTipTitle = "Codigo"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtidp_Validating(sender As Object, e As CancelEventArgs) Handles txtidp.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Ingrese el codigo del Producto ")
        End If
    End Sub

    Private Sub txtNombrecliente_MouseHover(sender As Object, e As EventArgs) Handles txtNombrecliente.MouseHover
        tmensaje.SetToolTip(txtcodigo, "Ingrese el nombre del cliente")
        tmensaje.ToolTipTitle = "Nombre"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtapellido_MouseHover(sender As Object, e As EventArgs) Handles txtapellido.MouseHover
        tmensaje.SetToolTip(txtcodigo, "Ingrese el apellido del cliente")
        tmensaje.ToolTipTitle = "Apellido"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub direccion_MouseHover(sender As Object, e As EventArgs) Handles direccion.MouseHover
        tmensaje.SetToolTip(txtcodigo, "Ingrese la direccion del cliente")
        tmensaje.ToolTipTitle = "direccion"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class
