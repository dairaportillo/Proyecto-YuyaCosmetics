<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_Principal))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.bCliente = New System.Windows.Forms.Button()
        Me.bProv = New System.Windows.Forms.Button()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IrAPáginaWebToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.picUsuarios = New System.Windows.Forms.PictureBox()
        Me.bUsuarios = New System.Windows.Forms.Button()
        Me.picPaginaWeb = New System.Windows.Forms.PictureBox()
        Me.bPaginaWeb = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPaginaWeb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(241, 185)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(174, 158)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'bCliente
        '
        Me.bCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.bCliente.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bCliente.Location = New System.Drawing.Point(250, 349)
        Me.bCliente.Name = "bCliente"
        Me.bCliente.Size = New System.Drawing.Size(151, 39)
        Me.bCliente.TabIndex = 5
        Me.bCliente.Text = "Clientes"
        Me.bCliente.UseVisualStyleBackColor = False
        '
        'bProv
        '
        Me.bProv.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.bProv.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bProv.Location = New System.Drawing.Point(35, 183)
        Me.bProv.Name = "bProv"
        Me.bProv.Size = New System.Drawing.Size(130, 39)
        Me.bProv.TabIndex = 6
        Me.bProv.Text = "Proveedores"
        Me.bProv.UseVisualStyleBackColor = False
        '
        'bSalir
        '
        Me.bSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.bSalir.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bSalir.Location = New System.Drawing.Point(26, 553)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(185, 63)
        Me.bSalir.TabIndex = 7
        Me.bSalir.Text = "Salir del programa"
        Me.bSalir.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SistemaToolStripMenuItem, Me.VentasToolStripMenuItem, Me.ComprasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(681, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SistemaToolStripMenuItem
        '
        Me.SistemaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem, Me.IrAPáginaWebToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.SistemaToolStripMenuItem.Name = "SistemaToolStripMenuItem"
        Me.SistemaToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.SistemaToolStripMenuItem.Text = "Sistema"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'IrAPáginaWebToolStripMenuItem
        '
        Me.IrAPáginaWebToolStripMenuItem.Name = "IrAPáginaWebToolStripMenuItem"
        Me.IrAPáginaWebToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.IrAPáginaWebToolStripMenuItem.Text = "Ir a página web"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem})
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProveedoresToolStripMenuItem})
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.ComprasToolStripMenuItem.Text = "Compras"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'picUsuarios
        '
        Me.picUsuarios.BackgroundImage = CType(resources.GetObject("picUsuarios.BackgroundImage"), System.Drawing.Image)
        Me.picUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picUsuarios.Location = New System.Drawing.Point(478, 42)
        Me.picUsuarios.Name = "picUsuarios"
        Me.picUsuarios.Size = New System.Drawing.Size(159, 135)
        Me.picUsuarios.TabIndex = 9
        Me.picUsuarios.TabStop = False
        '
        'bUsuarios
        '
        Me.bUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.bUsuarios.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bUsuarios.Location = New System.Drawing.Point(481, 185)
        Me.bUsuarios.Name = "bUsuarios"
        Me.bUsuarios.Size = New System.Drawing.Size(156, 35)
        Me.bUsuarios.TabIndex = 10
        Me.bUsuarios.Text = "Administradores"
        Me.bUsuarios.UseVisualStyleBackColor = False
        '
        'picPaginaWeb
        '
        Me.picPaginaWeb.BackgroundImage = CType(resources.GetObject("picPaginaWeb.BackgroundImage"), System.Drawing.Image)
        Me.picPaginaWeb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picPaginaWeb.Location = New System.Drawing.Point(518, 492)
        Me.picPaginaWeb.Name = "picPaginaWeb"
        Me.picPaginaWeb.Size = New System.Drawing.Size(107, 76)
        Me.picPaginaWeb.TabIndex = 13
        Me.picPaginaWeb.TabStop = False
        '
        'bPaginaWeb
        '
        Me.bPaginaWeb.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.bPaginaWeb.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bPaginaWeb.Location = New System.Drawing.Point(509, 574)
        Me.bPaginaWeb.Name = "bPaginaWeb"
        Me.bPaginaWeb.Size = New System.Drawing.Size(128, 42)
        Me.bPaginaWeb.TabIndex = 14
        Me.bPaginaWeb.Text = "Ir a página web"
        Me.bPaginaWeb.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(26, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(151, 135)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(245, 438)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 29)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "¡Bienvenido/a!"
        '
        'Menu_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(681, 638)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bPaginaWeb)
        Me.Controls.Add(Me.picPaginaWeb)
        Me.Controls.Add(Me.bUsuarios)
        Me.Controls.Add(Me.picUsuarios)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.bProv)
        Me.Controls.Add(Me.bCliente)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Menu_Principal"
        Me.Text = "Menú principal"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPaginaWeb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents bCliente As Button
    Friend WithEvents bProv As Button
    Friend WithEvents bSalir As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents picUsuarios As PictureBox
    Friend WithEvents bUsuarios As Button
    Friend WithEvents picPaginaWeb As PictureBox
    Friend WithEvents bPaginaWeb As Button
    Friend WithEvents IrAPáginaWebToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
