Imports System.IO
Imports System.Data.SqlClient
Imports System.Net.Mail

Public Class Clientes

    Dim ar As String
    Dim con As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=ABM_TP; integrated security=true")

    Function leerarchivo(ByVal archivo As String) As String
        If File.Exists("c:\ABM\ip.txt") = True Then
            Dim SR As StreamReader = File.OpenText("c:\ABM\ip.txt")
            Dim Line As String = SR.ReadLine()
            SR.Close()
            Return Line
        Else
            MsgBox("Verifique si falta el archivo de configuración en el Disco C:")
            Me.Close()
        End If
    End Function

    Private Sub Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buscar(" ApeYNom like '" & tBuscador.Text & "%' ")
    End Sub

    Sub buscar(ByVal condicion As String)
        Dim da As New SqlDataAdapter("SELECT TOP (100) PERCENT NCli, ApeYNom from Clientes_búsqueda where " & condicion & " order by ApeYNom", con)
        Dim ds As New DataSet
        da.Fill(ds, "Clientes")

        If ds.Tables("Clientes").Rows.Count = 0 Then

            DataGridView1.Visible = False
            pBotonesCli.Visible = False
            pCamposCli.Visible = False
            lLegajo.Visible = False
        Else
            DataGridView1.DataSource = ds.Tables("Clientes")
            DataGridView1.Refresh()
            DataGridView1.Visible = True
            lLegajo.Visible = True
        End If

    End Sub

    Sub FilaClick(ByVal e As Object)
        Dim fila As Integer = e.RowIndex
        Dim tfila As String

        If IsNothing(DataGridView1.Rows(fila).Cells(0).Value) Then
            lLegajo.Text = "0"
            pBotonesCli.Visible = False
            pCamposCli.Visible = False
            Exit Sub
        Else
            tfila = DataGridView1.Rows(fila).Cells(0).Value
            lLegajo.Text = tfila.ToString()
            CargarCamposClientes()
        End If

    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        FilaClick(e)
    End Sub

    Private Sub DataGridView1_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.RowEnter
        FilaClick(e)
    End Sub

    Sub CargarCamposClientes()
        If Val(lLegajo.Text) = 0 Then
            pBotonesCli.Visible = False
            pCamposCli.Visible = False
            Exit Sub

        Else
            pBotonesCli.Visible = True
            pCamposCli.Visible = True

            Dim da As New SqlDataAdapter("SELECT  upper(ltrim(rtrim(isnull(ApellidoCli,'****')))) as apellido, 
                upper(ltrim(rtrim(isnull(NombreCli,'****')))) as nombres, isnull([Documento-Cli],0) as doc, 
                ltrim(rtrim(isnull(CuitCli,''))) as cuit, ltrim(rtrim(isnull(PostalCli,''))) as cp,
                ltrim(rtrim(isnull(DomicilioCli,''))) as direccion, ltrim(rtrim(isnull(LocalidadCli,''))) as localidad, 
                ltrim(rtrim(isnull(ProvinciaCli,''))) as provincia, ltrim(rtrim(isnull(TelefonosCli,''))) as telefonos,
                FechaNacimientoCli as fechanacimiento,ltrim(rtrim(isnull(ComentariosCli,''))) as comentarios,
                ltrim(rtrim(isnull([E-Mail-Cli],''))) as email,ltrim(rtrim(isnull(UsuarioCli,''))) as usuario,
                ltrim(rtrim(isnull(ClaveCli,''))) as clave from Clientes where NCli=" & Val(lLegajo.Text), con)

            Dim ds As New DataSet
            da.Fill(ds, "Clientes")
            TextBox1.Text = ds.Tables("Clientes").Rows(0)("apellido")
            TextBox2.Text = ds.Tables("Clientes").Rows(0)("nombres")
            TextBox3.Text = ds.Tables("Clientes").Rows(0)("doc")
            TextBox4.Text = ds.Tables("Clientes").Rows(0)("cuit")
            TextBox5.Text = ds.Tables("Clientes").Rows(0)("direccion")
            TextBox6.Text = ds.Tables("Clientes").Rows(0)("cp")
            TextBox7.Text = ds.Tables("Clientes").Rows(0)("localidad")
            TextBox8.Text = ds.Tables("Clientes").Rows(0)("provincia")
            TextBox9.Text = ds.Tables("Clientes").Rows(0)("comentarios")
            TextBox10.Text = ds.Tables("Clientes").Rows(0)("telefonos")
            TextBox11.Text = ds.Tables("Clientes").Rows(0)("email")
            TextBox12.Text = ds.Tables("Clientes").Rows(0)("usuario")
            TextBox13.Text = ds.Tables("Clientes").Rows(0)("clave")

            DateTimePicker1.Value = ds.Tables("Clientes").Rows(0)("fechanacimiento")


        End If

    End Sub

    Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click
        buscar(" ApeYNom like '" & tBuscador.Text & "%' ")
        tBuscador.Text = ""
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        tBuscador.Text = ""
    End Sub

    Private Sub bEliminarCli_Click(sender As Object, e As EventArgs) Handles bEliminarCli.Click
        If MessageBox.Show("Está por ELIMINAR definitivamente al cliente: " & TextBox1.Text.Trim.ToUpper & ", " & TextBox2.Text.Trim.ToUpper & ". Es algo EXTREMO, se eliminarán todas las referencias asociadas a esta. ¿Desea eliminarlo?", "Eliminar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        If SQL_Accion("delete from ABM_TP.dbo.Clientes  where  NCli=" & Val(lLegajo.Text)) = False Then
            MsgBox("Hubo un error al intentar borrar al cliente. Reintente, y si el error persiste, anote todos los datos que quizo ingresar y comuníquese con la programadora.")
        Else

            buscar(" NCli=" & Val(lLegajo.Text))
            MsgBox("El cliente fue eliminado de la base de datos.")

        End If

    End Sub

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
        Dim errores As String = "", en As String = vbCrLf
        If TextBox1.Text.Trim.Length < 3 Then
            errores &= "Debe completar el apellido del cliente." & en
        End If

        If TextBox2.Text.Trim.Length < 3 Then
            errores &= "Debe completar el/los nombres del cliente." & en
        End If

        TextBox3.Text = Val(TextBox3.Text.Trim.Replace(".", "").Replace(" ", "").Replace(",", ""))
        If TextBox3.Text.Trim.Length < 4 Or TextBox3.Text.IndexOf("11111") > -1 Or TextBox3.Text.IndexOf("12345") > -1 Or TextBox3.Text.IndexOf("000000") > -1 Then
            errores &= "Debe completar CORRECTAMENTE el documento del cliente." & en
        End If

        If TextBox12.Text.Trim.Length <> 0 And (TextBox12.Text.IndexOf("@") < 0 Or TextBox12.Text.IndexOf(".") < 0) Then
            errores &= "Verifique por favor el email del cliente. No es obligatorio, pero si lo escribe debe ser correcto." & en
        End If

        If errores.Length > 0 Then
            MsgBox("Hubo errores. Por favor, verifique y corrija antes de intentar de nuevo: " & en & en & errores)
            Exit Sub
        End If

        If TextBox12.Text.Trim.Length < 3 Then
            errores &= "Debe completar el usuario." & en
        End If

        If TextBox13.Text.Trim.Length < 3 Then
            errores &= "Debe completar la contraseña." & en
        End If

        If SQL_Accion("update ABM_TP.dbo.Clientes set ApellidoCli='" & TextBox1.Text.Trim.ToUpper.Replace("'", "´") & "', NombreCli='" & TextBox2.Text.Trim.ToUpper.Replace("'", "´") & "', 
            [Documento-Cli]='" & TextBox3.Text.Trim.Replace("'", "´") & "', 
            PostalCli='" & TextBox6.Text.Trim.ToUpper.Replace("'", "´") & "', 
            DomicilioCli='" & TextBox5.Text.Trim.ToUpper.Replace("'", "´") & "', 
            ComentariosCli='" & TextBox9.Text.Trim.ToUpper.Replace("'", "´") & "', 
            CuitCli='" & TextBox4.Text.Trim.ToUpper.Replace("'", "´") & "', 
            [E-Mail-Cli]='" & TextBox12.Text.Trim.ToUpper.Replace("'", "´") & "', 
            TelefonosCli='" & TextBox10.Text.Trim.ToUpper.Replace("'", "´") & "', 
            FechaNacimientoCli=" & FechaSQL(DateTimePicker1.Value) & ", 
            ProvinciaCli='" & TextBox8.Text.Trim.ToUpper.Replace("'", "´") & "', 
            LocalidadCli='" & TextBox7.Text.Trim.ToUpper.Replace("'", "´") & "',
            UsuarioCli='" & TextBox12.Text.Trim.ToUpper.Replace("'", "´") & "',
            ClaveCli='" & TextBox13.Text.Trim.ToUpper.Replace("'", "´") & "',
            where NCli=" & VNum(lLegajo.Text)) = True Then
            MsgBox("Cambios realizados correctamente.")
            buscar(" NCli=" & VNum(lLegajo.Text))
        Else
            MsgBox("Se produjo un error al querer guardar los datos del Cliente. Reintente, y si el error persiste, anote todos los datos que quizo ingresar y comuníquese con la programadora.")
        End If
    End Sub


    Private Sub bNuevoCli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bNuevoCli.Click
        If SQL_Accion("insert into ABM_TP.dbo.Clientes (ApellidoCli, NombreCli, [Documento-Cli], DomicilioCli, CuitCli, PostalCli, LocalidadCli, ProvinciaCli, TelefonosCli, FechaNacimientoCli, ComentariosCli, [E-Mail-Cli], UsuarioCli, ClaveCli) values ('*****',           '',                  0,           '',           '',           '',           '',           '',           '',           getdate(),          '',          '',          '',          '')  ") Then
            buscar(" ApeYNom like '****%' ")
            MsgBox("Se ha creado un nuevo registro para el Usuario que desea ingresar. Seleccione la línea nueva, cargue los datos y luego confirme con el botón 'Guardar cambios'.")
        End If
    End Sub

    Private Sub bAtras_Click(sender As Object, e As EventArgs) Handles bAtras.Click

        Me.Close()

    End Sub


End Class
