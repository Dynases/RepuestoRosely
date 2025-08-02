Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports System.IO
Imports Janus.Windows.GridEX

Public Class Pr_VentasAtendidasExcel
    Dim _Inter As Integer = 0

    'gb_FacturaIncluirICE


    Public _nameButton As String
    Public _tab As SuperTabItem
    Dim RutaGlobal As String = gs_CarpetaRaiz

    Public Sub _prIniciarTodo()
        tbFechaI.Value = Now.Date
        tbFechaF.Value = Now.Date
        _PMIniciarTodo()
        'L_prAbrirConexion(gs_Ip, gs_UsuarioSql, gs_ClaveSql, gs_NombreBD)
        Me.Text = "REPORTE VENTAS ATENDIDAS"
        MReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        _IniciarComponentes()
    End Sub
    Public Sub _IniciarComponentes()
        tbVendedor.ReadOnly = True
        tbAlmacen.ReadOnly = True
        tbVendedor.Enabled = False
        tbAlmacen.Enabled = False
        CheckTodosVendedor.CheckValue = True
        CheckTodosAlmacen.CheckValue = True

    End Sub
    Public Sub _prInterpretarDatos(ByRef _dt As DataTable)
        'If (gb_FacturaEmite) Then ''''Con factura 
        _dt = L_prVentasExcelL(tbFechaI.Value.ToString("yyyy/MM/dd"), tbFechaF.Value.ToString("yyyy/MM/dd"), IIf(CheckTodosAlmacen.Checked = True, -1, tbAlmacen.Value), IIf(CheckTodosVendedor.Checked = True, -1, tbCodigoVendedor.Text))





        'Else  ''''''''''NO EMITE FACTURAS

        '    If (swIce.Value = True) Then '''sin Factura + Ice
        '        If (CheckTodosVendedor.Checked And CheckTodosAlmacen.Checked) Then
        '            _dt = L_prVentasAtendidaGeneralAlmacenVendedorSinFacturaConIce(tbFechaI.Value.ToString("yyyy/MM/dd"), tbFechaF.Value.ToString("yyyy/MM/dd"))
        '        End If
        '        If (checkUnaVendedor.Checked And CheckTodosAlmacen.Checked) Then
        '            If (tbCodigoVendedor.Text.Length > 0) Then
        '                _dt = L_prVentasAtendidaPorVendedorTodosAlmacenSinFacturaConIce(tbFechaI.Value.ToString("yyyy/MM/dd"), tbFechaF.Value.ToString("yyyy/MM/dd"), tbCodigoVendedor.Text)
        '            End If

        '        End If
        '        If (CheckTodosVendedor.Checked And CheckUnaALmacen.Checked) Then
        '            If (tbAlmacen.SelectedIndex >= 0) Then
        '                _dt = L_prVentasAtendidaTodosVendedorUnaAlmacenSinFacturaConIce(tbFechaI.Value.ToString("yyyy/MM/dd"), tbFechaF.Value.ToString("yyyy/MM/dd"), tbAlmacen.Value)
        '            End If

        '        End If

        '        If (checkUnaVendedor.Checked And CheckUnaALmacen.Checked) Then
        '            If (tbAlmacen.SelectedIndex >= 0 And tbCodigoVendedor.Text.Length > 0) Then
        '                _dt = L_prVentasAtendidaUnaVendedorUnaAlmacenSinFacturaConIce(tbFechaI.Value.ToString("yyyy/MM/dd"), tbFechaF.Value.ToString("yyyy/MM/dd"), tbAlmacen.Value, tbCodigoVendedor.Text)
        '            End If

        '        End If
        '    Else  'sin Factura Sin Ice

        '        If (CheckTodosVendedor.Checked And CheckTodosAlmacen.Checked) Then
        '            _dt = L_prVentasAtendidaGeneralAlmacenVendedorSinFacturaSinIce(tbFechaI.Value.ToString("yyyy/MM/dd"), tbFechaF.Value.ToString("yyyy/MM/dd"))
        '        End If
        '        If (checkUnaVendedor.Checked And CheckTodosAlmacen.Checked) Then
        '            If (tbCodigoVendedor.Text.Length > 0) Then
        '                _dt = L_prVentasAtendidaPorVendedorTodosAlmacenSinFacturaSinIce(tbFechaI.Value.ToString("yyyy/MM/dd"), tbFechaF.Value.ToString("yyyy/MM/dd"), tbCodigoVendedor.Text)
        '            End If

        '        End If
        '        If (CheckTodosVendedor.Checked And CheckUnaALmacen.Checked) Then
        '            If (tbAlmacen.SelectedIndex >= 0) Then
        '                _dt = L_prVentasAtendidaTodosVendedorUnaAlmacenSinFacturaSinIce(tbFechaI.Value.ToString("yyyy/MM/dd"), tbFechaF.Value.ToString("yyyy/MM/dd"), tbAlmacen.Value)
        '            End If

        '        End If

        '        If (checkUnaVendedor.Checked And CheckUnaALmacen.Checked) Then
        '            If (tbAlmacen.SelectedIndex >= 0 And tbCodigoVendedor.Text.Length > 0) Then
        '                _dt = L_prVentasAtendidaUnaVendedorUnaAlmacenSinFacturaSinIce(tbFechaI.Value.ToString("yyyy/MM/dd"), tbFechaF.Value.ToString("yyyy/MM/dd"), tbAlmacen.Value, tbCodigoVendedor.Text)
        '            End If

        '        End If


        '    End If



        'End If



    End Sub
    Private Sub _prCargarReporte()
        Dim _dt As New DataTable
        _prInterpretarDatos(_dt)
        If (_dt.Rows.Count > 0) Then

            Dim objrep As New R_VentasProductosExcel

            objrep.SetDataSource(_dt)
            Dim fechaI As String = tbFechaI.Value.ToString("dd/MM/yyyy")
            Dim fechaF As String = tbFechaF.Value.ToString("dd/MM/yyyy")
            objrep.SetParameterValue("usuario", L_Usuario)
            objrep.SetParameterValue("fechaI", fechaI)
            objrep.SetParameterValue("fechaF", fechaF)
            objrep.SetParameterValue("almacen", IIf(CheckTodosAlmacen.Checked = True, "Todos", tbAlmacen.Text))
            MReportViewer.ReportSource = objrep
            MReportViewer.Show()
            MReportViewer.BringToFront()


        Else
            ToastNotification.Show(Me, "NO HAY DATOS PARA LOS PARAMETROS SELECCIONADOS..!!!",
                                       My.Resources.INFORMATION, 2000,
                                       eToastGlowColor.Blue,
                                       eToastPosition.BottomLeft)
            MReportViewer.ReportSource = Nothing
        End If

        JGrM_Buscador.DataSource = _dt
        JGrM_Buscador.RetrieveStructure()
        JGrM_Buscador.AlternatingColors = True

        With JGrM_Buscador.RootTable.Columns("tanumi")
            .Width = 90
            .Visible = True
            .Caption = "COD. VENTA"
        End With
        With JGrM_Buscador.RootTable.Columns("tafdoc")
            .Width = 90
            .Visible = True
            .Caption = "FEC. VENTA"
        End With
        With JGrM_Buscador.RootTable.Columns("yddesc")
            .Width = 90
            .Visible = True
            .Caption = "CLIENTE"
        End With
        With JGrM_Buscador.RootTable.Columns("vendedor")
            .Width = 90
            .Visible = True
            .Caption = "VENDEDOR"
        End With
        With JGrM_Buscador.RootTable.Columns("yfnumi")
            .Width = 90
            .Visible = True
            .Caption = "ITEM"
        End With
        With JGrM_Buscador.RootTable.Columns("CodigoFabrica")
            .Width = 90
            .Visible = True
            .Caption = "COD. FABRICA"
        End With
        With JGrM_Buscador.RootTable.Columns("CodigoMarca")
            .Width = 90
            .Visible = True
            .Caption = "COD. MARCA"
        End With
        With JGrM_Buscador.RootTable.Columns("medida")
            .Width = 90
            .Visible = True
            .Caption = "MEDIDA"
        End With
        With JGrM_Buscador.RootTable.Columns("marca")
            .Width = 90
            .Visible = True
            .Caption = "MARCA"
        End With
        With JGrM_Buscador.RootTable.Columns("procedencia")
            .Width = 90
            .Visible = True
            .Caption = "PROCEDENCIA"
        End With
        With JGrM_Buscador.RootTable.Columns("producto")
            .Width = 90
            .Visible = True
            .Caption = "DESCRIPCION"
        End With
        With JGrM_Buscador.RootTable.Columns("tbcmin")
            .Width = 90
            .Visible = True
            .Caption = "CANTIDAD"
        End With
        With JGrM_Buscador.RootTable.Columns("tbPrecioReferencia")
            .Width = 90
            .Visible = True
            .Caption = "PRE. FACT."
        End With
        With JGrM_Buscador.RootTable.Columns("tbpbas")
            .Width = 90
            .Visible = True
            .Caption = "PRECIO U."
        End With
        With JGrM_Buscador.RootTable.Columns("tbPorcentajeReferencia")
            .Width = 90
            .Visible = True
            .Caption = "% DIF."
        End With
        With JGrM_Buscador.RootTable.Columns("tbptot")
            .Width = 90
            .Visible = True
            .Caption = "SUB TOTAL"
        End With
        With JGrM_Buscador.RootTable.Columns("tbporc")
            .Width = 90
            .Visible = True
            .Caption = "P. DESC(%)"
        End With
        With JGrM_Buscador.RootTable.Columns("tbdesc")
            .Width = 90
            .Visible = True
            .Caption = "M. DESC"
        End With
        With JGrM_Buscador.RootTable.Columns("tbtotdesc")
            .Width = 90
            .Visible = True
            .Caption = "TOTAL"
        End With
        With JGrM_Buscador.RootTable.Columns("tbptot2")
            .Width = 90
            .Visible = False
            .Caption = "TOTAL"
        End With

    End Sub
    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        _prCargarReporte()

    End Sub

    Private Sub Pr_VentasAtendidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _prIniciarTodo()

    End Sub



    Private Sub checkUnaVendedor_CheckValueChanged(sender As Object, e As EventArgs) Handles checkUnaVendedor.CheckValueChanged
        If (checkUnaVendedor.Checked) Then
            CheckTodosVendedor.CheckValue = False
            tbVendedor.Enabled = True
            tbVendedor.BackColor = Color.White
            tbVendedor.Focus()

        End If
    End Sub

    Private Sub CheckTodosVendedor_CheckValueChanged(sender As Object, e As EventArgs) Handles CheckTodosVendedor.CheckValueChanged
        If (CheckTodosVendedor.Checked) Then
            checkUnaVendedor.CheckValue = False
            tbVendedor.Enabled = True
            tbVendedor.BackColor = Color.Gainsboro
            tbVendedor.Clear()
            tbCodigoVendedor.Clear()

        End If
    End Sub

    Private Sub CheckUnaALmacen_CheckValueChanged(sender As Object, e As EventArgs) Handles CheckUnaALmacen.CheckValueChanged
        If (CheckUnaALmacen.Checked) Then
            CheckTodosAlmacen.CheckValue = False
            tbAlmacen.Enabled = True
            tbAlmacen.BackColor = Color.White
            tbAlmacen.Focus()
            tbAlmacen.ReadOnly = False
            _prCargarComboLibreriaSucursal(tbAlmacen)
            If (CType(tbAlmacen.DataSource, DataTable).Rows.Count > 0) Then
                tbAlmacen.SelectedIndex = 0

            End If
        End If
    End Sub

    Private Sub CheckTodosAlmacen_CheckValueChanged(sender As Object, e As EventArgs) Handles CheckTodosAlmacen.CheckValueChanged
        If (CheckTodosAlmacen.Checked) Then
            CheckUnaALmacen.CheckValue = False
            tbAlmacen.Enabled = True
            tbAlmacen.BackColor = Color.Gainsboro
            tbAlmacen.ReadOnly = True
            _prCargarComboLibreriaSucursal(tbAlmacen)
            CType(tbAlmacen.DataSource, DataTable).Rows.Clear()
            tbAlmacen.SelectedIndex = -1

        End If
    End Sub

    Private Sub _prCargarComboLibreriaSucursal(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim dt As New DataTable
        dt = L_fnListarSucursales()
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("aanumi").Width = 60
            .DropDownList.Columns("aanumi").Caption = "COD"
            .DropDownList.Columns.Add("aabdes").Width = 500
            .DropDownList.Columns("aabdes").Caption = "SUCURSAL"
            .ValueMember = "aanumi"
            .DisplayMember = "aabdes"
            .DataSource = dt
            .Refresh()
        End With
    End Sub

    Private Sub tbVendedor_KeyDown_1(sender As Object, e As KeyEventArgs) Handles tbVendedor.KeyDown
        If (checkUnaVendedor.Checked) Then
            If e.KeyData = Keys.Control + Keys.Enter Then
                Dim dt As DataTable
                dt = L_fnListarEmpleado()
                '              a.ydnumi, a.ydcod, a.yddesc, a.yddctnum, a.yddirec
                ',a.ydtelf1 ,a.ydfnac 
                Dim listEstCeldas As New List(Of Modelo.Celda)
                listEstCeldas.Add(New Modelo.Celda("ydnumi,", False, "ID", 50))
                listEstCeldas.Add(New Modelo.Celda("ydcod", True, "ID", 50))
                listEstCeldas.Add(New Modelo.Celda("yddesc", True, "NOMBRE", 280))
                listEstCeldas.Add(New Modelo.Celda("yddctnum", True, "N. Documento".ToUpper, 150))
                listEstCeldas.Add(New Modelo.Celda("yddirec", True, "DIRECCION", 220))
                listEstCeldas.Add(New Modelo.Celda("ydtelf1", True, "Telefono".ToUpper, 200))
                listEstCeldas.Add(New Modelo.Celda("ydfnac", True, "F.Nacimiento".ToUpper, 150, "MM/dd,YYYY"))
                Dim ef = New Efecto
                ef.tipo = 3
                ef.dt = dt
                ef.SeleclCol = 1
                ef.listEstCeldas = listEstCeldas
                ef.alto = 50
                ef.ancho = 350
                ef.Context = "Seleccione Vendedor".ToUpper
                ef.ShowDialog()
                Dim bandera As Boolean = False
                bandera = ef.band
                If (bandera = True) Then
                    Dim Row As Janus.Windows.GridEX.GridEXRow = ef.Row
                    If (IsNothing(Row)) Then
                        tbVendedor.Focus()
                        Return
                    End If
                    tbCodigoVendedor.Text = Row.Cells("ydnumi").Value
                    tbVendedor.Text = Row.Cells("yddesc").Value
                    btnGenerar.Focus()
                End If

            End If

        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        _Inter = _Inter + 1
        If _Inter = 1 Then
            Me.WindowState = FormWindowState.Normal

        Else
            Me.Opacity = 100
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        _prCrearCarpetaReportes()
        Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
        If (P_ExportarExcel(RutaGlobal + "\Reporte\Reporte Productos")) Then
            ToastNotification.Show(Me, "EXPORTACIÓN DE LISTA DE PRODUCTOS EXITOSA..!!!",
                                       img, 2000,
                                       eToastGlowColor.Green,
                                       eToastPosition.BottomCenter)
        Else
            ToastNotification.Show(Me, "FALLO AL EXPORTACIÓN DE LISTA DE PRODUCTOS..!!!",
                                       My.Resources.WARNING, 2000,
                                       eToastGlowColor.Red,
                                       eToastPosition.BottomLeft)
        End If
    End Sub

    Public Function P_ExportarExcel(_ruta As String) As Boolean
        Dim _ubicacion As String
        'Dim _directorio As New FolderBrowserDialog

        If (1 = 1) Then 'If(_directorio.ShowDialog = Windows.Forms.DialogResult.OK) Then
            '_ubicacion = _directorio.SelectedPath
            _ubicacion = _ruta
            Try
                Dim _stream As Stream
                Dim _escritor As StreamWriter
                Dim _fila As Integer = JGrM_Buscador.GetRows.Length
                Dim _columna As Integer = JGrM_Buscador.RootTable.Columns.Count
                Dim _archivo As String = _ubicacion & "\SaldoDeProductos_" & Now.Date.Day &
                    "." & Now.Date.Month & "." & Now.Date.Year & "_" & Now.Hour & "." & Now.Minute & "." & Now.Second & ".csv"
                Dim _linea As String = ""
                Dim _filadata = 0, columndata As Int32 = 0
                File.Delete(_archivo)
                _stream = File.OpenWrite(_archivo)
                _escritor = New StreamWriter(_stream, System.Text.Encoding.UTF8)

                For Each _col As GridEXColumn In JGrM_Buscador.RootTable.Columns
                    If (_col.Visible) Then
                        _linea = _linea & _col.Caption & ";"
                    End If
                Next
                _linea = Mid(CStr(_linea), 1, _linea.Length - 1)
                _escritor.WriteLine(_linea)
                _linea = Nothing

                'Pbx_Precios.Visible = True
                'Pbx_Precios.Minimum = 1
                'Pbx_Precios.Maximum = Dgv_Precios.RowCount
                'Pbx_Precios.Value = 1

                For Each _fil As GridEXRow In JGrM_Buscador.GetRows
                    For Each _col As GridEXColumn In JGrM_Buscador.RootTable.Columns
                        If (_col.Visible) Then
                            Dim data As String = CStr(_fil.Cells(_col.Key).Value)
                            data = data.Replace(";", ",")
                            _linea = _linea & data & ";"
                        End If
                    Next
                    _linea = Mid(CStr(_linea), 1, _linea.Length - 1)
                    _escritor.WriteLine(_linea)
                    _linea = Nothing
                    'Pbx_Precios.Value += 1
                Next
                _escritor.Close()
                'Pbx_Precios.Visible = False
                Try
                    Dim ef = New Efecto
                    ef._archivo = _archivo

                    ef.tipo = 1
                    ef.Context = "Su archivo ha sido Guardado en la ruta: " + _archivo + vbLf + "DESEA ABRIR EL ARCHIVO?"
                    ef.Header = "PREGUNTA"
                    ef.ShowDialog()
                    Dim bandera As Boolean = False
                    bandera = ef.band
                    If (bandera = True) Then
                        Process.Start(_archivo)
                    End If

                    'If (MessageBox.Show("Su archivo ha sido Guardado en la ruta: " + _archivo + vbLf + "DESEA ABRIR EL ARCHIVO?", "PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                    '    Process.Start(_archivo)
                    'End If
                    Return True
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Return False
                End Try
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End If
        Return False
    End Function

    Private Sub _prCrearCarpetaReportes()
        Dim rutaDestino As String = RutaGlobal + "\Reporte\Reporte Productos\"

        If System.IO.Directory.Exists(RutaGlobal + "\Reporte\Reporte Productos\") = False Then
            If System.IO.Directory.Exists(RutaGlobal + "\Reporte") = False Then
                System.IO.Directory.CreateDirectory(RutaGlobal + "\Reporte")
                If System.IO.Directory.Exists(RutaGlobal + "\Reporte\Reporte Productos") = False Then
                    System.IO.Directory.CreateDirectory(RutaGlobal + "\Reporte\Reporte Productos")
                End If
            Else
                If System.IO.Directory.Exists(RutaGlobal + "\Reporte\Reporte Productos") = False Then
                    System.IO.Directory.CreateDirectory(RutaGlobal + "\Reporte\Reporte Productos")

                End If
            End If
        End If
    End Sub
End Class