Public Class Menu_Principal

    '-----------------------------------------Botones de salida------------------------------------------
    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        If MessageBox.Show("¿Está seguro de que desea salir?", "Salir del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then End
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MessageBox.Show("¿Está seguro de que desea salir?", "Salir del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then End
    End Sub

    '--------------------------------------- Parte de cliente ---------------------------------------------------

    Private Sub bCliente_Click(sender As Object, e As EventArgs) Handles bCliente.Click
        Dim clientes As New Clientes
        clientes.Show()
    End Sub
    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim clientes As New Clientes
        clientes.Show()
    End Sub



    '-----------------------------------------Parte de proveedores ---------------------------------------

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        Dim proveedores As New Proveedores
        proveedores.Show()
    End Sub

    Private Sub bProv_Click(sender As Object, e As EventArgs) Handles bProv.Click
        Dim proveedores As New Proveedores
        proveedores.Show()
    End Sub

    Private Sub Menu_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    '----------------------------------- Parte de la pág web -------------------------------------------
    Private Sub bPaginaWeb_Click(sender As Object, e As EventArgs) Handles bPaginaWeb.Click
        System.Diagnostics.Process.Start("https://yuyatiendaoficial.com/")
    End Sub

    Private Sub IrAPáginaWebToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IrAPáginaWebToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://yuyatiendaoficial.com/")
    End Sub

    '--------------------------------- Parte de Usuarios ---------------------------------
    Private Sub bUsuarios_Click(sender As Object, e As EventArgs) Handles bUsuarios.Click
        Dim usuarios As New Usuarios
        usuarios.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        Dim usuarios As New Usuarios
        usuarios.Show()
    End Sub


End Class