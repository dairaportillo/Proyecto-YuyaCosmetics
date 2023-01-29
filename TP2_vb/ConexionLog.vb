Imports System.Data.Sql
Imports System.Data.SqlClient

Module ConexionLog

    Public conexion As SqlConnection 'me permite realizar la conexión entre el sql y el visual
    Public enunciado As SqlCommand ' me permite ejecutar los comandos de sql
    Public respuesta As SqlDataReader ' leer registros obtenidos por una consulta sqlcommand

    Sub abrir() 'función que se encarga de la conexión entre el visual y el sql
        Try
            conexion = New SqlConnection("Data Source=NOVABOOK-V2\SQLEXPRESS2014;Initial Catalog=ABM_TP;Integrated Security=True")
            conexion.Open()
            MsgBox("Conectado.") 'se conecta

        Catch ex As Exception
            MsgBox("No se puede conectar" + ex.ToString) 'si no se conecta captura el error y me lo muestra

        End Try

    End Sub

    Function usuarioRegistrado(ByVal nombreUsuario As String) As Boolean 'retorna true o false dependiendo de si está o no registrado
        'el nombreUsuario NO ES el nombre de nuestro textbox, sólo es uno que estamos utilizando, este recibe un texto
        'y lo consulta a la base de datos para saber si está o no está
        Dim resultado As Boolean = False
        Try
            enunciado = New SqlCommand("Select * from Usuarios where Username='" & nombreUsuario & "'", conexion)
            respuesta = enunciado.ExecuteReader
            If respuesta.Read Then 'si busca un usuario, y no lo encuentra no va a entrar a este if
                resultado = True ' si existe me tira true
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function


    Function clave(ByVal nombreUsuario As String) As String 'esta función nos devuelve un String
        Dim resultado As String = ""
        Try
            enunciado = New SqlCommand("Select clave from Usuarios where Username='" & nombreUsuario)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = respuesta.Item("clave")
            End If
            respuesta.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
        Return resultado

    End Function
















End Module
