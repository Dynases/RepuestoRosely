<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F1_ImagenProducto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PanelImagenes = New System.Windows.Forms.Panel()
        Me.PanelVerImagen = New System.Windows.Forms.Panel()
        Me.btnImagen = New DevComponents.DotNetBar.ButtonX()
        Me.btnDelete = New DevComponents.DotNetBar.ButtonX()
        Me.pbImgProdu = New System.Windows.Forms.PictureBox()
        Me.PanelListImagenes = New System.Windows.Forms.Panel()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.PanelImagenes.SuspendLayout()
        Me.PanelVerImagen.SuspendLayout()
        CType(Me.pbImgProdu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelImagenes
        '
        Me.PanelImagenes.BackColor = System.Drawing.Color.White
        Me.PanelImagenes.Controls.Add(Me.PanelVerImagen)
        Me.PanelImagenes.Controls.Add(Me.PanelListImagenes)
        Me.PanelImagenes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelImagenes.Location = New System.Drawing.Point(0, 0)
        Me.PanelImagenes.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelImagenes.Name = "PanelImagenes"
        Me.PanelImagenes.Size = New System.Drawing.Size(916, 639)
        Me.PanelImagenes.TabIndex = 5
        '
        'PanelVerImagen
        '
        Me.PanelVerImagen.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelVerImagen.Controls.Add(Me.ButtonX1)
        Me.PanelVerImagen.Controls.Add(Me.btnImagen)
        Me.PanelVerImagen.Controls.Add(Me.btnDelete)
        Me.PanelVerImagen.Controls.Add(Me.pbImgProdu)
        Me.PanelVerImagen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelVerImagen.Location = New System.Drawing.Point(157, 0)
        Me.PanelVerImagen.Name = "PanelVerImagen"
        Me.PanelVerImagen.Size = New System.Drawing.Size(759, 639)
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
        Me.pbImgProdu.Size = New System.Drawing.Size(759, 639)
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
        Me.PanelListImagenes.Size = New System.Drawing.Size(157, 639)
        Me.PanelListImagenes.TabIndex = 3
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.BackColor = System.Drawing.Color.Transparent
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.ButtonX1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Image = Global.DinoM.My.Resources.Resources.cancel
        Me.ButtonX1.ImageFixedSize = New System.Drawing.Size(50, 50)
        Me.ButtonX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonX1.Location = New System.Drawing.Point(690, 12)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.ButtonX1.Size = New System.Drawing.Size(57, 61)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.ButtonX1.TabIndex = 16
        Me.ButtonX1.TextColor = System.Drawing.Color.White
        '
        'F1_ImagenProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(916, 639)
        Me.Controls.Add(Me.PanelImagenes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "F1_ImagenProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "F1_Cantidad"
        Me.PanelImagenes.ResumeLayout(False)
        Me.PanelVerImagen.ResumeLayout(False)
        CType(Me.pbImgProdu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelImagenes As Panel
    Friend WithEvents PanelVerImagen As Panel
    Friend WithEvents btnImagen As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnDelete As DevComponents.DotNetBar.ButtonX
    Friend WithEvents pbImgProdu As PictureBox
    Friend WithEvents PanelListImagenes As Panel
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
End Class
