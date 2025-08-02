<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F0_BuscarProductos
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
        Me.components = New System.ComponentModel.Container()
        Dim cbSucursal_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F0_BuscarProductos))
        Me.GPanelProductos = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.PanelImagenes = New System.Windows.Forms.Panel()
        Me.PanelVerImagen = New System.Windows.Forms.Panel()
        Me.btnImagen = New DevComponents.DotNetBar.ButtonX()
        Me.btnDelete = New DevComponents.DotNetBar.ButtonX()
        Me.pbImgProdu = New System.Windows.Forms.PictureBox()
        Me.PanelListImagenes = New System.Windows.Forms.Panel()
        Me.grProductos = New Janus.Windows.GridEX.GridEX()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Copiar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.btnAgregar = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.tbProducto = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cbSucursal = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.lbSucursal = New DevComponents.DotNetBar.LabelX()
        Me.GPanelProductos.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.PanelImagenes.SuspendLayout()
        Me.PanelVerImagen.SuspendLayout()
        CType(Me.pbImgProdu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.cbSucursal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GPanelProductos
        '
        Me.GPanelProductos.CanvasColor = System.Drawing.SystemColors.Control
        Me.GPanelProductos.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GPanelProductos.Controls.Add(Me.Panel7)
        Me.GPanelProductos.DisabledBackColor = System.Drawing.Color.Empty
        Me.GPanelProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GPanelProductos.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GPanelProductos.Location = New System.Drawing.Point(0, 0)
        Me.GPanelProductos.Name = "GPanelProductos"
        Me.GPanelProductos.Size = New System.Drawing.Size(1080, 548)
        '
        '
        '
        Me.GPanelProductos.Style.BackColor = System.Drawing.Color.DodgerBlue
        Me.GPanelProductos.Style.BackColor2 = System.Drawing.Color.DodgerBlue
        Me.GPanelProductos.Style.BackColorGradientAngle = 90
        Me.GPanelProductos.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPanelProductos.Style.BorderBottomWidth = 1
        Me.GPanelProductos.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GPanelProductos.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPanelProductos.Style.BorderLeftWidth = 1
        Me.GPanelProductos.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPanelProductos.Style.BorderRightWidth = 1
        Me.GPanelProductos.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPanelProductos.Style.BorderTopWidth = 1
        Me.GPanelProductos.Style.CornerDiameter = 4
        Me.GPanelProductos.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GPanelProductos.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GPanelProductos.Style.TextColor = System.Drawing.Color.White
        Me.GPanelProductos.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GPanelProductos.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GPanelProductos.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GPanelProductos.TabIndex = 5
        Me.GPanelProductos.Text = "LISTADO PRODUCTOS"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Controls.Add(Me.PanelImagenes)
        Me.Panel7.Controls.Add(Me.grProductos)
        Me.Panel7.Controls.Add(Me.Panel3)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1074, 525)
        Me.Panel7.TabIndex = 0
        '
        'PanelImagenes
        '
        Me.PanelImagenes.BackColor = System.Drawing.Color.White
        Me.PanelImagenes.Controls.Add(Me.PanelVerImagen)
        Me.PanelImagenes.Controls.Add(Me.PanelListImagenes)
        Me.PanelImagenes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelImagenes.Location = New System.Drawing.Point(0, 41)
        Me.PanelImagenes.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelImagenes.Name = "PanelImagenes"
        Me.PanelImagenes.Size = New System.Drawing.Size(1074, 484)
        Me.PanelImagenes.TabIndex = 4
        '
        'PanelVerImagen
        '
        Me.PanelVerImagen.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelVerImagen.Controls.Add(Me.btnImagen)
        Me.PanelVerImagen.Controls.Add(Me.btnDelete)
        Me.PanelVerImagen.Controls.Add(Me.pbImgProdu)
        Me.PanelVerImagen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelVerImagen.Location = New System.Drawing.Point(157, 0)
        Me.PanelVerImagen.Name = "PanelVerImagen"
        Me.PanelVerImagen.Size = New System.Drawing.Size(917, 484)
        Me.PanelVerImagen.TabIndex = 2
        '
        'btnImagen
        '
        Me.btnImagen.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnImagen.BackColor = System.Drawing.Color.Transparent
        Me.btnImagen.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnImagen.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImagen.Image = Global.DinoM.My.Resources.Resources.jpg
        Me.btnImagen.ImageFixedSize = New System.Drawing.Size(50, 50)
        Me.btnImagen.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnImagen.Location = New System.Drawing.Point(6, 8)
        Me.btnImagen.Name = "btnImagen"
        Me.btnImagen.Padding = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.btnImagen.Size = New System.Drawing.Size(57, 61)
        Me.btnImagen.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.btnImagen.TabIndex = 15
        Me.btnImagen.TextColor = System.Drawing.Color.White
        '
        'btnDelete
        '
        Me.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = Global.DinoM.My.Resources.Resources.delete
        Me.btnDelete.ImageFixedSize = New System.Drawing.Size(50, 50)
        Me.btnDelete.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnDelete.Location = New System.Drawing.Point(9, 73)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Padding = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.btnDelete.Size = New System.Drawing.Size(52, 50)
        Me.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.TextColor = System.Drawing.Color.White
        '
        'pbImgProdu
        '
        Me.pbImgProdu.BackColor = System.Drawing.Color.White
        Me.pbImgProdu.Location = New System.Drawing.Point(0, 0)
        Me.pbImgProdu.Name = "pbImgProdu"
        Me.pbImgProdu.Size = New System.Drawing.Size(280, 316)
        Me.pbImgProdu.TabIndex = 0
        Me.pbImgProdu.TabStop = False
        '
        'PanelListImagenes
        '
        Me.PanelListImagenes.AutoScroll = True
        Me.PanelListImagenes.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelListImagenes.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelListImagenes.Location = New System.Drawing.Point(0, 0)
        Me.PanelListImagenes.Name = "PanelListImagenes"
        Me.PanelListImagenes.Size = New System.Drawing.Size(157, 484)
        Me.PanelListImagenes.TabIndex = 3
        '
        'grProductos
        '
        Me.grProductos.BackColor = System.Drawing.Color.GhostWhite
        Me.grProductos.ColumnAutoResize = True
        Me.grProductos.ContextMenuStrip = Me.ContextMenuStrip1
        Me.grProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grProductos.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
        Me.grProductos.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grProductos.HeaderFormatStyle.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grProductos.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grProductos.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight
        Me.grProductos.Location = New System.Drawing.Point(0, 41)
        Me.grProductos.Name = "grProductos"
        Me.grProductos.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.grProductos.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.grProductos.RecordNavigator = True
        Me.grProductos.SelectedFormatStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.grProductos.SelectedFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grProductos.SelectedFormatStyle.ForeColor = System.Drawing.Color.White
        Me.grProductos.Size = New System.Drawing.Size(1074, 484)
        Me.grProductos.TabIndex = 0
        Me.grProductos.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Copiar})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(110, 26)
        '
        'Copiar
        '
        Me.Copiar.Name = "Copiar"
        Me.Copiar.Size = New System.Drawing.Size(109, 22)
        Me.Copiar.Text = "Copiar"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lbSucursal)
        Me.Panel3.Controls.Add(Me.cbSucursal)
        Me.Panel3.Controls.Add(Me.ButtonX2)
        Me.Panel3.Controls.Add(Me.btnAgregar)
        Me.Panel3.Controls.Add(Me.LabelX9)
        Me.Panel3.Controls.Add(Me.tbProducto)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1074, 41)
        Me.Panel3.TabIndex = 1
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta
        Me.ButtonX2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX2.Image = Global.DinoM.My.Resources.Resources.search
        Me.ButtonX2.ImageFixedSize = New System.Drawing.Size(30, 30)
        Me.ButtonX2.Location = New System.Drawing.Point(388, 6)
        Me.ButtonX2.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(110, 31)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.ButtonX2.TabIndex = 377
        Me.ButtonX2.Text = "Buscar"
        '
        'btnAgregar
        '
        Me.btnAgregar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAgregar.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnAgregar.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Image = Global.DinoM.My.Resources.Resources.reload_5
        Me.btnAgregar.ImageFixedSize = New System.Drawing.Size(30, 30)
        Me.btnAgregar.Location = New System.Drawing.Point(525, 6)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(152, 32)
        Me.btnAgregar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013
        Me.btnAgregar.SymbolColor = System.Drawing.Color.Transparent
        Me.btnAgregar.TabIndex = 372
        Me.btnAgregar.Text = "Actualizar"
        '
        'LabelX9
        '
        Me.LabelX9.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX9.Location = New System.Drawing.Point(9, 11)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX9.Size = New System.Drawing.Size(113, 23)
        Me.LabelX9.TabIndex = 226
        Me.LabelX9.Text = "Buscar Producto:"
        '
        'tbProducto
        '
        Me.tbProducto.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.tbProducto.Border.Class = "TextBoxBorder"
        Me.tbProducto.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.tbProducto.Location = New System.Drawing.Point(134, 13)
        Me.tbProducto.Name = "tbProducto"
        Me.tbProducto.PreventEnterBeep = True
        Me.tbProducto.Size = New System.Drawing.Size(249, 22)
        Me.tbProducto.TabIndex = 3
        '
        'cbSucursal
        '
        cbSucursal_DesignTimeLayout.LayoutString = resources.GetString("cbSucursal_DesignTimeLayout.LayoutString")
        Me.cbSucursal.DesignTimeLayout = cbSucursal_DesignTimeLayout
        Me.cbSucursal.Location = New System.Drawing.Point(682, 12)
        Me.cbSucursal.Name = "cbSucursal"
        Me.cbSucursal.SelectedIndex = -1
        Me.cbSucursal.SelectedItem = Nothing
        Me.cbSucursal.Size = New System.Drawing.Size(100, 22)
        Me.cbSucursal.TabIndex = 378
        Me.cbSucursal.Visible = False
        '
        'lbSucursal
        '
        '
        '
        '
        Me.lbSucursal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbSucursal.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbSucursal.Font = New System.Drawing.Font("Georgia", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lbSucursal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbSucursal.Location = New System.Drawing.Point(682, 0)
        Me.lbSucursal.Name = "lbSucursal"
        Me.lbSucursal.Size = New System.Drawing.Size(392, 41)
        Me.lbSucursal.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013
        Me.lbSucursal.TabIndex = 379
        Me.lbSucursal.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'F0_BuscarProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1080, 548)
        Me.Controls.Add(Me.GPanelProductos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "F0_BuscarProductos"
        Me.Text = "F0_BuscarProductos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GPanelProductos.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.PanelImagenes.ResumeLayout(False)
        Me.PanelVerImagen.ResumeLayout(False)
        CType(Me.pbImgProdu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.cbSucursal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GPanelProductos As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents grProductos As Janus.Windows.GridEX.GridEX
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnAgregar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbProducto As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Copiar As ToolStripMenuItem
    Friend WithEvents PanelImagenes As Panel
    Friend WithEvents PanelVerImagen As Panel
    Friend WithEvents btnImagen As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnDelete As DevComponents.DotNetBar.ButtonX
    Friend WithEvents pbImgProdu As PictureBox
    Friend WithEvents PanelListImagenes As Panel
    Friend WithEvents cbSucursal As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents lbSucursal As DevComponents.DotNetBar.LabelX
End Class
