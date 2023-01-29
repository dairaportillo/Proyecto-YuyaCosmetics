Imports System.IO
Imports System.Data.SqlClient
Imports System.Net.Mail


Public Class Proveedores

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
        Dim da As New SqlDataAdapter("SELECT TOP (100) PERCENT NProv, ApeYNom from Proveedores_búsqueda where " & condicion & " order by ApeYNom", con)
        Dim ds As New DataSet
        da.Fill(ds, "Proveedores")

        If ds.Tables("Proveedores").Rows.Count = 0 Then

            DataGridView1.Visible = False
            pBotones.Visible = False
            pCampos.Visible = False
            lLegajoProv.Visible = False
        Else
            DataGridView1.DataSource = ds.Tables("Proveedores")
            DataGridView1.Refresh()
            DataGridView1.Visible = True
            lLegajoProv.Visible = True
        End If

    End Sub

    Sub FilaClick(ByVal e As Object)
        Dim fila As Integer = e.RowIndex
        Dim tfila As String

        If IsNothing(DataGridView1.Rows(fila).Cells(0).Value) Then
            lLegajoProv.Text = "0"
            pBotones.Visible = False
            pCampos.Visible = False
            Exit Sub
        Else
            tfila = DataGridView1.Rows(fila).Cells(0).Value
            lLegajoProv.Text = tfila.ToString()
            CargarCamposProveedores()
        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        FilaClick(e)
    End Sub

    Private Sub DataGridView1_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.RowEnter
        FilaClick(e)
    End Sub

    Sub CargarCamposProveedores()
        If Val(lLegajoProv.Text) = 0 Then
            pBotones.Visible = False
            pCampos.Visible = False
            Exit Sub

        Else
            pBotones.Visible = True
            pCampos.Visible = True

            Dim da As New SqlDataAdapter("SELECT  upper(ltrim(rtrim(isnull(ApellidoProv,'****')))) as apellido, 
                upper(ltrim(rtrim(isnull(NombreProv,'****')))) as nombres, isnull([Documento-Prov],0) as doc, 
                ltrim(rtrim(isnull(CuitProv,''))) as cuit, ltrim(rtrim(isnull(CodPostalProv,''))) as cp,
                ltrim(rtrim(isnull(DomicilioProv,''))) as direccion, ltrim(rtrim(isnull(LocalidadProv,''))) as localidad, 
                ltrim(rtrim(isnull(ProvinciaProv,''))) as provincia, ltrim(rtrim(isnull(TelefonosProv,''))) as telefonos,
                FechaNacimientoProv as fechanacimiento,ltrim(rtrim(isnull(ComentariosProv,''))) as comentarios,
                ltrim(rtrim(isnull([E-Mail-Prov],''))) as email from proveedores where NProv=" & Val(lLegajoProv.Text), con)

            Dim ds As New DataSet
            da.Fill(ds, "Proveedores")
            TextBox1.Text = ds.Tables("Proveedores").Rows(0)("apellido")
            TextBox2.Text = ds.Tables("Proveedores").Rows(0)("nombres")
            TextBox3.Text = ds.Tables("Proveedores").Rows(0)("doc")
            TextBox4.Text = ds.Tables("Proveedores").Rows(0)("cuit")
            TextBox5.Text = ds.Tables("Proveedores").Rows(0)("direccion")
            TextBox6.Text = ds.Tables("Proveedores").Rows(0)("cp")
            TextBox7.Text = ds.Tables("Proveedores").Rows(0)("localidad")
            TextBox8.Text = ds.Tables("Proveedores").Rows(0)("provincia")
            TextBox9.Text = ds.Tables("Proveedores").Rows(0)("telefonos")
            TextBox12.Text = ds.Tables("Proveedores").Rows(0)("email")
            TextBox10.Text = ds.Tables("Proveedores").Rows(0)("comentarios")

            DateTimePicker1.Value = ds.Tables("Proveedores").Rows(0)("fechanacimiento")


        End If

    End Sub

    Private Sub bAtras_Click(sender As Object, e As EventArgs) Handles bAtras.Click
        Me.Close()
    End Sub

    Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click
        buscar(" ApeYNom like '" & tBuscador.Text & "%' ")
        tBuscador.Text = ""

    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        tBuscador.Text = ""

    End Sub

    Private Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
        If MessageBox.Show("Está por ELIMINAR definitivamente al Proveedor: " & TextBox1.Text.Trim.ToUpper & ", " & TextBox2.Text.Trim.ToUpper & ". Es algo EXTREMO, se eliminarán todas las referencias asociadas a esta. ¿Desea eliminarlo?", "Eliminar proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        If SQL_Accion("delete from  ABM_TP.dbo.Proveedores  where  NProv=" & Val(lLegajoProv.Text)) = False Then
            MsgBox("Hubo un error al intentar borrar al Proveedor. Reintente, y si el error persiste, anote todos los datos que quizo ingresar y comuníquese con la programadora.")
        Else

            buscar(" NProv=" & Val(lLegajoProv.Text))
            MsgBox("El proveedor fue eliminado de la base de datos.")

        End If
    End Sub

    Private Sub bGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bGuardar.Click
        Dim errores As String = "", en As String = vbCrLf
        If TextBox1.Text.Trim.Length < 3 Then
            errores &= "Debe completar el apellido del proveedor." & en
        End If
        If TextBox2.Text.Trim.Length < 3 Then
            errores &= "Debe completar el/los nombres del proveedor." & en
        End If
        TextBox3.Text = Val(TextBox3.Text.Trim.Replace(".", "").Replace(" ", "").Replace(",", ""))
        If TextBox3.Text.Trim.Length < 4 Or TextBox3.Text.IndexOf("11111") > -1 Or TextBox3.Text.IndexOf("12345") > -1 Or TextBox3.Text.IndexOf("000000") > -1 Then
            errores &= "Debe completar CORRECTAMENTE el documento del proveedor." & en
        End If
        If TextBox12.Text.Trim.Length <> 0 And (TextBox12.Text.IndexOf("@") < 0 Or TextBox12.Text.IndexOf(".") < 0) Then
            errores &= "Verifique por favor el email del proveedor. No es obligatorio, pero si lo escribe debe ser correcto." & en
        End If
        If errores.Length > 0 Then
            MsgBox("Hubo errores. Por favor, verifique y corrija antes de intentar de nuevo: " & en & en & errores)
            Exit Sub
        End If
        If SQL_Accion("update ABM_TP.dbo.Proveedores set ApellidoProv='" & TextBox1.Text.Trim.ToUpper.Replace("'", "´") & "', NombreProv='" & TextBox2.Text.Trim.ToUpper.Replace("'", "´") & "', 
            [Documento-Prov]='" & TextBox3.Text.Trim.Replace("'", "´") & "', 
            CuitProv='" & TextBox4.Text.Trim.ToUpper.Replace("'", "´") & "', 
            DomicilioProv='" & TextBox5.Text.Trim.ToUpper.Replace("'", "´") & "', 
            CodPostalProv='" & TextBox6.Text.Trim.ToUpper.Replace("'", "´") & "', 
            LocalidadProv='" & TextBox7.Text.Trim.ToUpper.Replace("'", "´") & "'
            ProvinciaProv='" & TextBox8.Text.Trim.ToUpper.Replace("'", "´") & "', 
            TelefonosProv='" & TextBox9.Text.Trim.ToUpper.Replace("'", "´") & "', 
            FechaNacimientoProv=" & FechaSQL(DateTimePicker1.Value) & ", 
            [E-Mail-Prov]='" & TextBox12.Text.Trim.ToUpper.Replace("'", "´") & "', 
            ComentariosProv='" & TextBox10.Text.Trim.ToUpper.Replace("'", "´") & "', where NProv=" & VNum(lLegajoProv.Text)) = True Then
            MsgBox("Cambios realizados correctamente.")
            buscar(" NProv=" & VNum(lLegajoProv.Text))
        Else
            MsgBox("Se produjo un error al querer guardar los datos del Proveedor. Reintente, y si el error persiste, anote todos los datos que quizo ingresar y comuníquese con la programadora.")
        End If
    End Sub

    Private Sub bNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bNuevo.Click
        If SQL_Accion("insert into ABM_TP.dbo.Proveedores (ApellidoProv, NombreProv, [Documento-Prov], CuitProv, DomicilioProv, CodPostalProv, LocalidadProv, ProvinciaProv, TelefonosProv, FechaNacimientoProv, ComentariosProv, [E-Mail-Prov]) values ('*****',           '',                  0,           '',           '',           '',           '',           '',             '',           getdate(),          '',          '')  ") Then
            buscar(" ApeYNom like '****%' ")
            MsgBox("Se ha creado un nuevo registro para el Proveedor que desea ingresar. Seleccione la línea nueva, cargue los datos y luego confirme con el botón 'Guardar cambios'.")
        End If

    End Sub


End Class