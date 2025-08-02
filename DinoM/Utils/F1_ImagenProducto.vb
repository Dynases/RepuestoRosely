Imports DevComponents.DotNetBar.Controls
Imports DevComponents.DotNetBar
Imports Logica.AccesoLogica
Imports Janus.Windows.GridEX
Imports System.IO

Public Class F1_ImagenProducto
    Public Stock As Decimal
    Public Cantidad As Decimal
    Public Producto As String
    Public bandera As Boolean
    Public CategoriaPrecio As Integer = 0
    Public idProducto As Integer = 0
    Public conversion As Integer = 0
    Public Precio As Integer = 0
    Public TablaImagenes As DataTable


    Dim RutaGlobal As String = gs_CarpetaRaiz
    Private Sub F_Cantidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        _prCargarImagen(TablaImagenes)
    End Sub

    Public Sub _prCargarImagen(TablaImagenes As DataTable)
        PanelListImagenes.Controls.Clear()

        pbImgProdu.Image = Nothing

        Dim i As Integer = 0
        For Each fila As DataRow In TablaImagenes.Rows
            Dim elemImg As UCLavadero = New UCLavadero
            Dim rutImg = fila.Item("nameImage").ToString
            'Dim estado As Integer = fila.Item("estado")

            'If (estado = 0) Then
            'elemImg.pbImg.SizeMode = PictureBoxSizeMode.StretchImage
            '    Dim bm As Bitmap = Nothing
            '    Dim by As Byte() = fila.Item("img")
            '    Dim ms As New MemoryStream(by)
            '    bm = New Bitmap(ms)


            '    elemImg.pbImg.Image = bm

            '    pbImgProdu.SizeMode = PictureBoxSizeMode.StretchImage
            '    pbImgProdu.Image = bm
            '    elemImg.pbImg.Tag = i
            '    elemImg.Dock = DockStyle.Top
            '    pbImgProdu.Tag = i
            '    AddHandler elemImg.pbImg.MouseEnter, AddressOf pbImg_MouseEnter

            '    PanelListImagenes.Controls.Add(elemImg)
            '    ms.Dispose()

            'Else
            'If (estado = 1) Then
            If (File.Exists(RutaGlobal + "\Imagenes\Imagenes Productos\ProductosTodos" + rutImg)) Then
                Dim bm As Bitmap = New Bitmap(RutaGlobal + "\Imagenes\Imagenes Productos\ProductosTodos" + rutImg)
                elemImg.pbImg.SizeMode = PictureBoxSizeMode.StretchImage
                elemImg.pbImg.Image = bm
                pbImgProdu.SizeMode = PictureBoxSizeMode.StretchImage
                pbImgProdu.Image = bm
                elemImg.pbImg.Tag = i
                elemImg.Dock = DockStyle.Top
                pbImgProdu.Tag = i
                AddHandler elemImg.pbImg.MouseEnter, AddressOf pbImg_MouseEnter

                PanelListImagenes.Controls.Add(elemImg)
                PanelImagenes.Visible = True
            End If

            'End If
            'End If




            i += 1
        Next

    End Sub


    Private Sub pbImg_MouseEnter(sender As Object, e As EventArgs)
        Dim pb As PictureBox = CType(sender, PictureBox)
        pbImgProdu.Image = pb.Image
        pbImgProdu.Tag = pb.Tag

    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub
End Class