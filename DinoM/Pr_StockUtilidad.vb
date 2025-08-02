Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports Janus.Windows.GridEX
Imports System.IO

Public Class Pr_StockUtilidad
    Dim _Inter As Integer = 0

    'gb_FacturaIncluirICE 
    Public _nameButton As String
    Public _tab As SuperTabItem
    Dim bandera As Boolean = False
    Dim RutaGlobal As String = gs_CarpetaRaiz

    Public Sub _prIniciarTodo()
        L_prAbrirConexion(gs_Ip, gs_UsuarioSql, gs_ClaveSql, gs_NombreBD)
        _prCargarComboLibreriaSucursal(tbAlmacen)
        _prCargarComboLibreriaPrecioVenta(tbcatprecio)

        _PMIniciarTodo()
        Me.Text = "UTILIDAD DE PRODUCTOS"
        MReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        _IniciarComponentes()
        bandera = True
    End Sub
    Public Sub _IniciarComponentes()

    End Sub
    Public Sub _prInterpretarDatos(ByRef _dt As DataTable)
        If swConsolidado.Value = False Then
            tbAlmacen.Value = 1
            _dt = L_prReporteUtilidadConsolidado(tbAlmacen.Value, tbcatprecio.Value, date1.Text, tbTCambio.Value)


        Else
            If (tbAlmacen.SelectedIndex >= 0 And tbcatprecio.SelectedIndex >= 0 And Checktodos.Checked And CheckBox1.Checked = False) Then
                _dt = L_prReporteUtilidad(tbAlmacen.Value, tbcatprecio.Value)
            End If

            If (tbAlmacen.SelectedIndex >= 0 And tbcatprecio.SelectedIndex >= 0 And checkMayorCero.Checked And CheckBox1.Checked = False) Then
                _dt = L_prReporteUtilidadStockMayorCero(tbAlmacen.Value, tbcatprecio.Value)
            End If

            If (tbAlmacen.SelectedIndex >= 0 And tbcatprecio.SelectedIndex >= 0 And Checktodos.Checked And CheckBox1.Checked) Then
                _dt = L_prReporteUtilidadal(tbAlmacen.Value, tbcatprecio.Value, date1.Text)
            End If

            If (tbAlmacen.SelectedIndex >= 0 And tbcatprecio.SelectedIndex >= 0 And checkMayorCero.Checked And CheckBox1.Checked) Then
                _dt = L_prReporteUtilidadmayor(tbAlmacen.Value, tbcatprecio.Value, date1.Text)
            End If

            If (tbAlmacen.SelectedIndex >= 0 And tbcatprecio.SelectedIndex >= 0 And checkMayorCero.Checked And CheckBox1.Checked) Then
                _dt = L_prReporteUtilidadConsolidado(tbAlmacen.Value, tbcatprecio.Value, date1.Text, tbTCambio.Value)
            End If
        End If

    End Sub
    Private Sub _prCargarReporte()
        Dim dt As New DataTable
        dt = L_fnListarSucursales()
        Dim _dt As New DataTable
        _prInterpretarDatos(_dt)

        'If (CheckBox1.Checked = True) Then
        '    _prObtenerKardexGeneral(_dt)
        'End If

        If (_dt.Rows.Count > 0) Then

            Dim objrep As New R_StockActualUtilidad
            objrep.SetDataSource(_dt)

            objrep.SetParameterValue("usuario", L_Usuario)
            objrep.SetParameterValue("categoria", tbAlmacen.Text + " - " + tbcatprecio.Text)
            objrep.SetParameterValue("fechafin", date1.Text + " - " + date1.Text)

            objrep.SetParameterValue("moneda", IIf(tbcatprecio.Value = "1099", "Dolares", "Bolivianos"))

            MReportViewer.ReportSource = objrep
            MReportViewer.Show()
            MReportViewer.BringToFront()

            JGrM_Buscador.DataSource = _dt
            JGrM_Buscador.RetrieveStructure()
            JGrM_Buscador.AlternatingColors = True

            With JGrM_Buscador.RootTable.Columns("abnumi")
                .Width = 90
                .Visible = False
            End With
            If swConsolidado.Value = False Then
                With JGrM_Buscador.RootTable.Columns("abdesc")
                    .Width = 100
                    .Visible = False
                    .Caption = "Almacen"
                End With
                With JGrM_Buscador.RootTable.Columns("yfCodigoMarca")
                    .Width = 100
                    .Visible = True
                    .Caption = "Cod. Marca"
                End With
            Else
                With JGrM_Buscador.RootTable.Columns("abdesc")
                    .Width = 100
                    .Visible = True
                    .Caption = "Almacen"
                End With

            End If

            With JGrM_Buscador.RootTable.Columns("yfnumi")
                .Width = 90
                .Visible = True
                .Caption = "Item"
            End With
            With JGrM_Buscador.RootTable.Columns("yfcprod")
                .Width = 100
                .Visible = True
                .Caption = "Cod. Fabrica"
            End With


            With JGrM_Buscador.RootTable.Columns("yfcdprod1")
                .Width = 170
                .Caption = "Producto"
                .Visible = True
            End With
            With JGrM_Buscador.RootTable.Columns("yfMed")
                .Width = 100
                .Caption = "Medida"
                .Visible = False
            End With
            With JGrM_Buscador.RootTable.Columns("yfap")
                .Width = 90
                .Visible = False
            End With
            With JGrM_Buscador.RootTable.Columns("iccprod")
                .Width = 120
                .Visible = False
            End With
            If swConsolidado.Value = False Then
                With JGrM_Buscador.RootTable.Columns("iccven")
                    .Width = 100
                    .Caption = "Stock Total"
                    .Visible = True
                End With
            Else
                With JGrM_Buscador.RootTable.Columns("iccven")
                    .Width = 100
                    .Caption = "Stock"
                    .Visible = True
                End With
            End If
            With JGrM_Buscador.RootTable.Columns("yccod3")
                .Width = 50
                .Visible = False
            End With
            With JGrM_Buscador.RootTable.Columns("ycdes3")
                .Width = 100
                .Visible = False
            End With
            With JGrM_Buscador.RootTable.Columns("preciou")
                .Width = 100
                .Caption = "Precio U."
                .Visible = True
            End With
            With JGrM_Buscador.RootTable.Columns("total")
                .Width = 100
                .Caption = "Total"
                .Visible = True
            End With

            If swConsolidado.Value = False Then
                With JGrM_Buscador.RootTable.Columns("iccprod1")
                    .Width = 100
                    .Caption = "Procedencia"
                    .Visible = False
                End With

                For i = 0 To dt.Rows.Count - 1 Step 1
                    With JGrM_Buscador.RootTable.Columns(dt.Rows(i).Item("aabdes"))
                        .Width = 100
                        .Caption = dt.Rows(i).Item("aabdes")
                        .Visible = True
                    End With
                Next
            End If
            With JGrM_Buscador
                .DefaultFilterRowComparison = FilterConditionOperator.Contains
                .FilterMode = FilterMode.Automatic
                .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
                .GroupByBoxVisible = False
                .TotalRow = InheritableBoolean.True
                .TotalRowFormatStyle.BackColor = Color.Gold
                .TotalRowPosition = TotalRowPosition.BottomFixed
                'diseño de la grilla
            End With


        Else
            ToastNotification.Show(Me, "NO HAY DATOS PARA LOS PARAMETROS SELECCIONADOS..!!!",
                                       My.Resources.INFORMATION, 2000,
                                       eToastGlowColor.Blue,
                                       eToastPosition.BottomLeft)
            MReportViewer.ReportSource = Nothing
        End If

    End Sub
    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        _prCargarReporte()

    End Sub

    Private Sub Pr_VentasAtendidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _prIniciarTodo()

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
        If (dt.Rows.Count > 0) Then
            tbAlmacen.SelectedIndex = 0
        End If
    End Sub

    Private Sub _prCargarComboLibreriaPrecioVenta(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim dt As New DataTable
        dt = L_prListarPrecioVenta()
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("ygnumi").Width = 60
            .DropDownList.Columns("ygnumi").Caption = "COD"
            .DropDownList.Columns.Add("ygdesc").Width = 500
            .DropDownList.Columns("ygdesc").Caption = "SUCURSAL"
            .ValueMember = "ygnumi"
            .DisplayMember = "ygdesc"
            .DataSource = dt
            .Refresh()
        End With
        If (dt.Rows.Count > 0) Then
            tbcatprecio.SelectedIndex = 0
        End If
    End Sub
    Private Sub _prCargarComboLibreriaPrecioCosto(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim dt As New DataTable
        dt = L_prListarPrecioCosto()
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("ygnumi").Width = 60
            .DropDownList.Columns("ygnumi").Caption = "COD"
            .DropDownList.Columns.Add("ygdesc").Width = 500
            .DropDownList.Columns("ygdesc").Caption = "SUCURSAL"
            .ValueMember = "ygnumi"
            .DisplayMember = "ygdesc"
            .DataSource = dt
            .Refresh()
        End With
        If (dt.Rows.Count > 0) Then
            tbcatprecio.SelectedIndex = 0
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        Me.Close()

    End Sub

    Private Sub swTipoVenta_ValueChanged(sender As Object, e As EventArgs) Handles swTipoVenta.ValueChanged
        If (bandera = False) Then
            Return
        End If
        If (swTipoVenta.Value = True) Then
            _prCargarComboLibreriaPrecioVenta(tbcatprecio)
            LabelX4.Visible = False
            tbTCambio.Visible = False
            tbTCambio.Value = 1
        Else
            _prCargarComboLibreriaPrecioCosto(tbcatprecio)
            LabelX4.Visible = True
            tbTCambio.Visible = True

        End If
    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked = True) Then
            date1.Enabled = True
        Else
            date1.Enabled = False
        End If

    End Sub


    Private Function P_ArmarGrillaDatosGeneral(codprod As Integer, fechaI As String, fechaF As String, almacen As Integer, DescProd As String, UnidPro As String, ByRef SaldoAnt As String,
                                              ByRef Entradas As String, ByRef Salidas As String,
                                              ByRef SaldoFinal As String) As DataTable
        Dim Dt1Kardex = New DataTable
        Dim Dt2KardexTotal = New DataTable

        Dt2KardexTotal = L_fnObtenerHistorialProductoGeneral(codprod, fechaI, almacen)
        Dt1Kardex = L_fnObtenerKardexPorProducto(codprod, fechaI, fechaF, almacen)
        If (Dt1Kardex.Rows.Count > 0) Then
            P_ArmarKardexGeneral(Dt1Kardex, Dt2KardexTotal, codprod, DescProd, UnidPro,
                          SaldoAnt, Entradas, Salidas, SaldoFinal)

        End If
        Return Dt1Kardex
    End Function

    Private Sub P_ArmarKardexGeneral(ByRef Dt1Kardex As DataTable, ByRef Dt2KardexTotal As DataTable,
                                 codprod As Integer, Descprod As String, Unidad As String, ByRef SaldoAnt As String,
                                ByRef Entradas As String, ByRef Salidas As String, ByRef SaldoFinal As String)

        Dim saldo As Double = 0
        Dim ingT As Double = 0
        Dim salT As Double = 0

        If (Not IsDBNull(Dt2KardexTotal.Compute("Sum(entrada)+Sum(salida)", "cprod = " + Str(codprod) + " and concep = 1 or concep=3"))) Then
            ingT = Dt2KardexTotal.Compute("Sum(entrada)+Sum(salida)", "cprod = " + Str(codprod) + " and concep = 1 or concep=3")
        End If
        If (Not IsDBNull(Dt2KardexTotal.Compute("Sum(entrada)+Sum(salida)", "cprod = " + Str(codprod) + " and concep = 2 or concep=4"))) Then
            salT = Dt2KardexTotal.Compute("Sum(entrada)+Sum(salida)", "cprod = " + Str(codprod) + " and concep = 2 or concep=4")
        End If
        saldo = ingT + salT
        Dim ing As Double = 0
        Dim sal As Double = 0
        Dim saldoInicial As Double = 0
        'Sumar ingreso de inventario
        ing = IIf(IsDBNull(Dt1Kardex.Compute("Sum(entrada)", " concep = 1 or concep=3")), 0, Dt1Kardex.Compute("Sum(entrada)", "concep = 1 or concep=3"))
        'Sumar salida de inventario
        sal = IIf(IsDBNull(Dt1Kardex.Compute("Sum(salida)", " concep = 2 or concep=4")), 0, Dt1Kardex.Compute("Sum(salida)", "concep = 2 or concep=4"))
        SaldoAnt = Str(saldo).Trim
        Entradas = Str(ing).Trim
        Salidas = Str(Math.Abs(sal)).Trim
        SaldoFinal = Str(Math.Abs((ing + saldo) + sal)).Trim

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
                            data = data.Replace(vbLf, "")
                            data = data.Replace(vbCr, "")
                            data = data.Replace("""", "")
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
End Class