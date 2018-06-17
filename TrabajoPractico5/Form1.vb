Public Class Form1


    Private Sub simular(N)

        Dim i As Integer
        Dim RND As New RandomTest
        Dim rnd_llegada As Double
        Dim tiempo_entre_llegadas As Double
        Dim proxima_llegada As Decimal
        Dim rnd_atencion1 As Double
        Dim rnd_atencion2 As Double
        Dim tiempo_atencion1 As Double
        Dim tiempo_atencion2 As Double
        Dim fin_atencion1 As Decimal
        Dim fin_atencion2 As Decimal
        Dim rnd_tipo_arreglo As Double
        Dim tipo As String = ""
        Dim tipo_nombre As String
        Dim estado_tec1 As String
        Dim estado_tec2 As String
        Dim cola As Integer
        Dim contador_comp As Integer
        Dim cont_no_atendidas As Integer
        Dim evento As String
        Dim fin_15c1 As Decimal
        Dim finespera_15c1 As Decimal
        Dim fin_15c2 As Decimal
        Dim finespera_15c2 As Decimal
        Dim acum_tiempo_atencion As Double
        Dim acum_permanencia As Double
        Dim estadocomputadora As String
        Dim estadocomputadora2 As String
        Dim estadocomputadora3 As String
        Dim primeraVez As Boolean = True
        



        i = 0
        N = 0
        Dim tiempoSim  As Integer =  CInt(Int(Iteraciones.Text))
        estado_tec1 = "Libre"
        estado_tec2 = "Libre"
        cola = 0
        fin_atencion1 = 0
        fin_atencion2 = 0
        fin_15c1 = 0
        fin_15c2 = 0
        finespera_15c1 = 0
        finespera_15c2 = 0
        contador_comp = 0
        cont_no_atendidas = 0
        evento = ""
        acum_tiempo_atencion = 0
        acum_permanencia = 0
        estadocomputadora = ""
        estadocomputadora2 = ""
        estadocomputadora3 = ""

        
 For i = 0 To tiempoSim - 1
            ' i += 1 En visual basic el mismo Next va de 1 en 1 si agregan esta linea iria de 2 en 2
     #Region "Llegada Computadora"  
            If primeraVez Then
                'LLEGADA_COMPUTADORA
                rnd_llegada = Math.Round(RND.NextDouble,4)
                tiempo_entre_llegadas = ((rnd_llegada * (b_llegada.Text - a_llegada.Text)) + a_llegada.Text)
                proxima_llegada = N + tiempo_entre_llegadas
                contador_comp = 0
                cont_no_atendidas = 0
                evento = "Inicializacion"
                cola = 0
                estado_tec1 = "Libre"
                estado_tec2 = "Libre"
                acum_permanencia = 0
                acum_tiempo_atencion = 0
                DataGridView1.Rows.Add(N, evento, rnd_llegada, tiempo_entre_llegadas, proxima_llegada, vbNullString, vbNullString, vbNullString, vbNullString, vbNullString, estado_tec1, vbNullString, vbNullString, vbNullString, vbNullString, vbNullString, estado_tec2, vbNullString, vbNullString, cola, acum_tiempo_atencion, contador_comp, cont_no_atendidas, acum_permanencia, i, vbNullString, vbNullString, vbNullString, vbNullString, vbNullString, vbNullString)
                N = proxima_llegada
                primeraVez = False
     
            ElseIf (((proxima_llegada < fin_atencion1) Or fin_atencion1 = 0) AndAlso ((proxima_llegada < fin_atencion2) Or fin_atencion2 = 0) AndAlso ((proxima_llegada < fin_15c1) Or fin_15c1 = 0) AndAlso ((proxima_llegada < fin_15c2) Or fin_15c2 = 0) AndAlso ((proxima_llegada < finespera_15c1) Or finespera_15c1 = 0) AndAlso ((proxima_llegada < finespera_15c2) Or finespera_15c2 = 0)) Then
                N = proxima_llegada
                evento = "Llegada computadora"
                If cola >= 3 Then
                    
                    cont_no_atendidas += 1
                   ' contador_comp += 1
                    DataGridView1.Rows.Add(N, evento, rnd_llegada, tiempo_entre_llegadas, proxima_llegada, vbNullString, vbNullString, vbNullString, vbNullString, fin_atencion1, estado_tec1, fin_15c1, finespera_15c1, vbNullString, vbNullString, fin_atencion2, estado_tec2, fin_15c2, finespera_15c2, cola, acum_tiempo_atencion, contador_comp, cont_no_atendidas, acum_permanencia, i, vbNullString, vbNullString, vbNullString)

                Else
                   'LLEGADA_COMPUTADORA
                     rnd_llegada = Math.Round(RND.NextDouble,4)
                    tiempo_entre_llegadas = ((rnd_llegada * (b_llegada.Text - a_llegada.Text)) + a_llegada.Text)
                    proxima_llegada = N + tiempo_entre_llegadas
                    acum_tiempo_atencion += proxima_llegada - N

                    If estado_tec1 = "Libre" Then

                        estado_tec1 = "Ocupado"

                        'TIPO_ARREGLO
                        rnd_tipo_arreglo = Math.Round(RND.NextDouble,4)
                        Select Case rnd_tipo_arreglo
                            Case 0 To 0.3
                                tipo = "A"
                                tipo_nombre = "Cambio de placa"
                            Case 0.3 To 0.55
                                tipo = "B"
                                tipo_nombre = "Ampliacion de memoria"
                            Case 0.55 To 0.7
                                tipo = "C"
                                tipo_nombre = "Formateo de disco"
                            Case 0.7 To 0.8
                                tipo = "D"
                                tipo_nombre = "Agregar CD o DVD"
                            Case 0.8 To 0.99
                                tipo = "E"
                                tipo_nombre = "Cambio de memoria"
                        End Select

                        'CLACULAR TIEMPO ARREGLO
                        Select Case tipo
                            Case "A"
                                rnd_atencion1 = Math.Round(RND.NextDouble,4)
                                tiempo_atencion1 = ((rnd_atencion1 * (b_placa.Text - a_placa.Text)) + a_placa.Text)
                                fin_atencion1 = N + tiempo_atencion1
                            Case "B"
                                rnd_atencion1 = Math.Round(RND.NextDouble,4)
                                tiempo_atencion1 = ((rnd_atencion1 * (b_ampliacion.Text - a_ampliacion.Text)) + a_ampliacion.Text)
                                fin_atencion1 = N + tiempo_atencion1
                            Case "C"
                                rnd_atencion1 = Math.Round(RND.NextDouble,4)
                                tiempo_atencion1 = ((rnd_atencion1 * (b_formateo.Text - a_formateo.Text)) + a_formateo.Text)
                                fin_atencion1 = N + tiempo_atencion1
                              fin_15c1 = N + 15
                              finespera_15c1 = fin_atencion1 - 15
                            Case "D"
                                rnd_atencion1 = Math.Round(RND.NextDouble,4)
                                tiempo_atencion1 = ((rnd_atencion1 * (b_agregar.Text - a_agregar.Text)) + a_agregar.Text)
                                fin_atencion1 = N + tiempo_atencion1
                            Case "E"
                                rnd_atencion1 = Math.Round(RND.NextDouble,4)
                                tiempo_atencion1 = ((rnd_atencion1 * (b_cambio.Text - a_cambio.Text)) + a_cambio.Text)
                                fin_atencion1 = N + tiempo_atencion1
                        End Select
                       ' contador_comp += 1
                        acum_tiempo_atencion += proxima_llegada - N

                        acum_permanencia += tiempo_atencion1
                        DataGridView1.Rows.Add(N, evento, rnd_llegada, tiempo_entre_llegadas, proxima_llegada,  rnd_tipo_arreglo, tipo, rnd_atencion1, tiempo_atencion1, fin_atencion1, estado_tec1, fin_15c1, finespera_15c1, vbNullString, vbNullString, fin_atencion2, estado_tec2, fin_15c2, finespera_15c2, cola, acum_tiempo_atencion, contador_comp, cont_no_atendidas, acum_permanencia, i, estadocomputadora, estadocomputadora2, estadocomputadora3)

                    ElseIf estado_tec2 = "Libre" Then

                        estado_tec2 = "Ocupado"

                        'TIPO_ARREGLO
                        rnd_tipo_arreglo = Math.Round(RND.NextDouble,4)
                        Select Case rnd_tipo_arreglo
                            Case 0 To 0.29
                                tipo = "A"
                                tipo_nombre = "Cambio de placa"
                            Case 0.3 To 0.54
                                tipo = "B"
                                tipo_nombre = "Ampliacion de memoria"
                            Case 0.55 To 0.69
                                tipo = "C"
                                tipo_nombre = "Formateo de disco"
                            Case 0.7 To 0.79
                                tipo = "D"
                                tipo_nombre = "Agregar CD o DVD"
                            Case 0.8 To 0.99
                                tipo = "E"
                                tipo_nombre = "Cambio de memoria"
                        End Select

                        'CLACULAR TIEMPO ARREGLO
                        Select Case tipo
                            Case "A"
                                rnd_atencion2 = Math.Round(RND.NextDouble,4)
                                tiempo_atencion2 = ((rnd_atencion2 * (b_placa.Text - a_placa.Text)) + a_placa.Text)
                                fin_atencion2 = N + tiempo_atencion2
                            Case "B"
                                rnd_atencion2 = Math.Round(RND.NextDouble,4)
                                tiempo_atencion2 = ((rnd_atencion2 * (b_ampliacion.Text - a_ampliacion.Text)) + a_ampliacion.Text)
                                fin_atencion2 = N + tiempo_atencion2
                            Case "C"
                                rnd_atencion2 = Math.Round(RND.NextDouble,4)
                                tiempo_atencion2 = ((rnd_atencion2 * (b_formateo.Text - a_formateo.Text)) + a_formateo.Text)
                                fin_atencion2 = N + tiempo_atencion2
                            Case "D"
                                rnd_atencion2 = Math.Round(RND.NextDouble,4)
                                tiempo_atencion2 = ((rnd_atencion2 * (b_agregar.Text - a_agregar.Text)) + a_agregar.Text)
                                fin_atencion2 = N + tiempo_atencion2
                            Case "E"
                                rnd_atencion2 = Math.Round(RND.NextDouble,4)
                                tiempo_atencion2 = ((rnd_atencion2 * (b_cambio.Text - a_cambio.Text)) + a_cambio.Text)
                                fin_atencion2 = N + tiempo_atencion2
                        End Select
                        If tipo = "C" Then
                            fin_15c2 = N + 15
                            finespera_15c2 = fin_atencion2 - 15
                        End If

                      '  contador_comp += 1
                        acum_tiempo_atencion += proxima_llegada - N
                        acum_permanencia += tiempo_atencion2
                        DataGridView1.Rows.Add(N, evento, rnd_llegada, tiempo_entre_llegadas, proxima_llegada, rnd_tipo_arreglo, tipo, rnd_atencion1, tiempo_atencion1, fin_atencion1, estado_tec1, fin_15c1, finespera_15c1, vbNullString, vbNullString, fin_atencion2, estado_tec2, fin_15c2, finespera_15c2, cola, acum_tiempo_atencion, contador_comp, cont_no_atendidas, acum_permanencia, i, estadocomputadora, estadocomputadora2, estadocomputadora3)


                    ElseIf estado_tec1 = "Ocupado" And estado_tec2 = "Ocupado" Then
                        cola += 1
                        acum_tiempo_atencion += proxima_llegada - N
                        If cola = 1 Then
                            estadocomputadora = "Esperando atencion"
                        ElseIf cola = 2 Then
                            estadocomputadora2 = "Esperando atencion"
                        ElseIf cola = 3 Then
                            estadocomputadora3 = "Esperando atención"
                        End If
                        DataGridView1.Rows.Add(N, evento, rnd_llegada, tiempo_entre_llegadas, proxima_llegada, rnd_tipo_arreglo, tipo, rnd_atencion1, tiempo_atencion1, fin_atencion1, estado_tec1, fin_15c1, finespera_15c1, vbNullString, vbNullString, fin_atencion2, estado_tec2, fin_15c2, finespera_15c2, cola, acum_tiempo_atencion, contador_comp, cont_no_atendidas, acum_permanencia, i, estadocomputadora, estadocomputadora2, estadocomputadora3)


                    End If

                End If
     #End Region
     #Region "Fin Atencion 1"
            
            ElseIf ((fin_atencion1 < proxima_llegada) Or proxima_llegada = 0) AndAlso ((fin_atencion1 < fin_atencion2) Or fin_atencion2 = 0) AndAlso ((fin_atencion1 < fin_15c1) Or fin_15c1 = 0) AndAlso ((fin_atencion1 < fin_15c2) Or fin_15c2 = 0) AndAlso ((fin_atencion1 < finespera_15c1) Or finespera_15c1 = 0) AndAlso ((fin_atencion1 < finespera_15c2) Or finespera_15c2 = 0) AndAlso (fin_atencion1 <> 0 Or cola > 0) Then
                N = fin_atencion1
                
                fin_atencion1 = 0
                evento = "Fin atención Técnico1"
                contador_comp += 1
                'Fin atención
                estado_tec1 = "Libre"

                If cola > 0 Then

                    estado_tec1 = "Ocupado"
                    cola -= 1
                    If cola = 1 Then
                        estadocomputadora = "Siendo atendida"
                    ElseIf cola = 2 Then
                        estadocomputadora2 = "Siendo atendida"
                    ElseIf cola = 3 Then
                        estadocomputadora3 = "Siendo atendida"
                    End If
                                        'TIPO_ARREGLO
                    rnd_tipo_arreglo = Math.Round(RND.NextDouble,4)
                    Select Case rnd_tipo_arreglo
                        Case 0 To 0.29
                            tipo = "A"
                            tipo_nombre = "Cambio de placa"
                        Case 0.3 To 0.54
                            tipo = "B"
                            tipo_nombre = "Ampliacion de memoria"
                        Case 0.55 To 0.69
                            tipo = "C"
                            tipo_nombre = "Formateo de disco"
                        Case 0.7 To 0.79
                            tipo = "D"
                            tipo_nombre = "Agregar CD o DVD"
                        Case 0.8 To 0.99
                            tipo = "E"
                            tipo_nombre = "Cambio de memoria"
                    End Select

                    'CLACULAR TIEMPO ARREGLO
                    Select Case tipo
                        Case "A"
                            rnd_atencion1 = Math.Round(RND.NextDouble,4)
                            tiempo_atencion1 = ((rnd_atencion1 * (b_placa.Text - a_placa.Text)) + a_placa.Text)
                            fin_atencion1 = N + tiempo_atencion1
                        Case "B"
                            rnd_atencion1 = Math.Round(RND.NextDouble,4)
                            tiempo_atencion1 = ((rnd_atencion1 * (b_ampliacion.Text - a_ampliacion.Text)) + a_ampliacion.Text)
                            fin_atencion1 = N + tiempo_atencion1
                        Case "C"
                            rnd_atencion1 = Math.Round(RND.NextDouble,4)
                            tiempo_atencion1 = ((rnd_atencion1 * (b_formateo.Text - a_formateo.Text)) + a_formateo.Text)
                            fin_atencion1 = N + tiempo_atencion1
                            fin_15c1 = N + 15
                            finespera_15c1 = fin_atencion1 - 15

                        Case "D"
                            rnd_atencion1 = Math.Round(RND.NextDouble,4)
                            tiempo_atencion1 = ((rnd_atencion1 * (b_agregar.Text - a_agregar.Text)) + a_agregar.Text)
                            fin_atencion1 = N + tiempo_atencion1
                        Case "E"
                            rnd_atencion1 = Math.Round(RND.NextDouble,4)
                            tiempo_atencion1 = ((rnd_atencion1 * (b_cambio.Text - a_cambio.Text)) + a_cambio.Text)
                            fin_atencion1 = N + tiempo_atencion1
                    End Select

                    contador_comp += 1
                    If estado_tec1 = "Ocupado" Or estado_tec2 = "Ocupado" Then
                        acum_tiempo_atencion += tiempo_atencion1
                    End If
                    acum_permanencia += 0
                    DataGridView1.Rows.Add(N, evento, "", "", proxima_llegada, rnd_tipo_arreglo, tipo, rnd_atencion1, tiempo_atencion1, fin_atencion1, estado_tec1, fin_15c1, finespera_15c1, vbNullString, vbNullString, fin_atencion2, estado_tec2, fin_15c2, finespera_15c2, cola, acum_tiempo_atencion, contador_comp, cont_no_atendidas, acum_permanencia, i, estadocomputadora, estadocomputadora2, estadocomputadora3)

                Else

                    estado_tec1 = "Libre"
                    If estado_tec2 = "Ocupado" Then
                        acum_tiempo_atencion += tiempo_atencion1
                    End If
                    estadocomputadora = ""
                    estadocomputadora2 = ""
                    estadocomputadora3 = ""

                    DataGridView1.Rows.Add(N, evento, "", "", proxima_llegada, rnd_tipo_arreglo, tipo, rnd_atencion1, tiempo_atencion1, fin_atencion1, estado_tec1, fin_15c1, finespera_15c1, vbNullString, vbNullString, fin_atencion2, estado_tec2, fin_15c2, finespera_15c2, cola, acum_tiempo_atencion, contador_comp, cont_no_atendidas, acum_permanencia, i, estadocomputadora, estadocomputadora2, estadocomputadora3)
                End If
                #End Region
     #Region "Fin Atencion Tecnico 2"
            ElseIf ((fin_atencion2 < proxima_llegada) Or proxima_llegada = 0) AndAlso ((fin_atencion2 < fin_atencion1) Or fin_atencion1 = 0) AndAlso ((fin_atencion2 < fin_15c1) Or fin_15c1 = 0) AndAlso ((fin_atencion2 < fin_15c2) Or fin_15c2 = 0) AndAlso ((fin_atencion2 < finespera_15c1) Or finespera_15c1 = 0) AndAlso ((fin_atencion2 < finespera_15c2) Or finespera_15c2 = 0) AndAlso (fin_atencion2 <> 0 Or cola > 0) Then
                N = fin_atencion2
                fin_atencion2 = 0
                evento = "Fin atención Técnico2"
                contador_comp += 1
                
                estado_tec2 = "Libre"

                If cola > 0 Then

                    estado_tec2 = "Ocupado"
                    cola -= 1
                    If cola = 1 Then
                        estadocomputadora = "Siendo atendida"
                    ElseIf cola = 2 Then
                        estadocomputadora2 = "Siendo atendida"
                    ElseIf cola = 3 Then
                        estadocomputadora3 = "Siendo atendida"
                    End If
                   'TIPO_ARREGLO
                    rnd_tipo_arreglo = Math.Round(RND.NextDouble,4)
                    Select Case rnd_tipo_arreglo
                        Case 0 To 0.29
                            tipo = "A"
                            tipo_nombre = "Cambio de placa"
                        Case 0.3 To 0.54
                            tipo = "B"
                            tipo_nombre = "Ampliacion de memoria"
                        Case 0.55 To 0.69
                            tipo = "C"
                            tipo_nombre = "Formateo de disco"
                        Case 0.7 To 0.79
                            tipo = "D"
                            tipo_nombre = "Agregar CD o DVD"
                        Case 0.8 To 0.99
                            tipo = "E"
                            tipo_nombre = "Cambio de memoria"
                    End Select

                    'CLACULAR TIEMPO ARREGLO
                    Select Case tipo
                        Case "A"
                            rnd_atencion2 = Math.Round(RND.NextDouble,4)
                            tiempo_atencion2 = ((rnd_atencion2 * (b_placa.Text - a_placa.Text)) + a_placa.Text)
                            fin_atencion2 = N + tiempo_atencion2
                        Case "B"
                            rnd_atencion2 = Math.Round(RND.NextDouble,4)
                            tiempo_atencion2 = ((rnd_atencion2 * (b_ampliacion.Text - a_ampliacion.Text)) + a_ampliacion.Text)
                            fin_atencion2 = N + tiempo_atencion2
                        Case "C"
                            rnd_atencion2 = Math.Round(RND.NextDouble,4)
                            tiempo_atencion2 = ((rnd_atencion2 * (b_formateo.Text - a_formateo.Text)) + a_formateo.Text)
                            fin_atencion2 = N + tiempo_atencion2
                            fin_15c2 = N + 15
                            finespera_15c2 = fin_atencion2 - 15

                        Case "D"
                            rnd_atencion2 = Math.Round(RND.NextDouble,4)
                            tiempo_atencion2 = ((rnd_atencion1 * (b_agregar.Text - a_agregar.Text)) + a_agregar.Text)
                            fin_atencion2 = N + tiempo_atencion1
                        Case "E"
                            rnd_atencion2 = Math.Round(RND.NextDouble,4)
                            tiempo_atencion2 = ((rnd_atencion2 * (b_cambio.Text - a_cambio.Text)) + a_cambio.Text)
                            fin_atencion2 = N + tiempo_atencion2
                    End Select


                    contador_comp += 1

                    acum_tiempo_atencion += tiempo_atencion2

                    acum_permanencia += 0
                    DataGridView1.Rows.Add(N, evento, "", "", proxima_llegada, rnd_tipo_arreglo, tipo, rnd_atencion1, "", fin_atencion1, estado_tec1, fin_15c1, finespera_15c1, vbNullString, vbNullString, fin_atencion2, estado_tec2, fin_15c2, finespera_15c2, cola, acum_tiempo_atencion, contador_comp, cont_no_atendidas, acum_permanencia, i, estadocomputadora, estadocomputadora2, estadocomputadora3)

                Else

                    estado_tec2 = "Libre"
                    If estado_tec1 = "Ocupado" Then
                        acum_tiempo_atencion += tiempo_atencion2
                    End If
                    estadocomputadora = ""
                    estadocomputadora2 = ""
                    estadocomputadora3 = ""

                    DataGridView1.Rows.Add(N, evento, rnd_llegada, tiempo_entre_llegadas, proxima_llegada, rnd_tipo_arreglo, tipo, rnd_atencion1, tiempo_atencion1, fin_atencion1, estado_tec1, fin_15c1, finespera_15c1, vbNullString, vbNullString, fin_atencion2, estado_tec2, fin_15c2, finespera_15c2, cola, acum_tiempo_atencion, contador_comp, cont_no_atendidas, acum_permanencia, i, estadocomputadora, estadocomputadora2, estadocomputadora3)
                End If
                #End Region
     #Region "Dejar equipo solo"
            ElseIf ((fin_15c1 < proxima_llegada) Or proxima_llegada = 0) AndAlso ((fin_15c1 < fin_atencion1) Or fin_atencion1 = 0) AndAlso ((fin_15c1 < fin_atencion2) Or fin_atencion2 = 0) AndAlso ((fin_15c1 < fin_15c2) Or fin_15c2 = 0) AndAlso ((fin_15c1 < finespera_15c1) Or finespera_15c1 = 0) AndAlso ((fin_15c1 < finespera_15c2) Or finespera_15c2 = 0) AndAlso (fin_15c1 <> 0) Then
                acum_tiempo_atencion += N - fin_15c1
                N = fin_15c1
                fin_15c1 = 0
                evento = "Dejar equipo sólo T1"
                estado_tec1 = "Libre"
                
                'Si el arreglo es tipo c, lo arreglo los primeros 15 min y desp dejo el equipo solo


                If cola > 0 Then

                    estado_tec1 = "Ocupado"
                    cola -= 1
                    If cola = 1 Then
                        estadocomputadora = "Siendo atendida"
                    ElseIf cola = 2 Then
                        estadocomputadora2 = "Siendo atendida"
                    ElseIf cola = 3 Then
                        estadocomputadora3 = "Siendo atendida"
                    End If
                    contador_comp += 1
                    acum_permanencia += 0
                    DataGridView1.Rows.Add(N, evento, rnd_llegada, tiempo_entre_llegadas, proxima_llegada, rnd_tipo_arreglo, tipo, rnd_atencion1, tiempo_atencion1, fin_atencion1, estado_tec1, fin_15c1, finespera_15c1, vbNullString, vbNullString, fin_atencion2, estado_tec2, fin_15c2, finespera_15c2, cola, acum_tiempo_atencion, contador_comp, cont_no_atendidas, acum_permanencia, i, estadocomputadora, estadocomputadora2, estadocomputadora3)

                Else

                    estado_tec1 = "Libre"
                    estadocomputadora = ""
                    estadocomputadora2 = ""
                    estadocomputadora3 = ""

                    DataGridView1.Rows.Add(N, evento, rnd_llegada, tiempo_entre_llegadas, proxima_llegada, rnd_tipo_arreglo, tipo, rnd_atencion1, tiempo_atencion1, fin_atencion1, estado_tec1, fin_15c1, finespera_15c1, vbNullString, vbNullString, fin_atencion2, estado_tec2, fin_15c2, finespera_15c2, cola, acum_tiempo_atencion, contador_comp, cont_no_atendidas, acum_permanencia, i, estadocomputadora, estadocomputadora2, estadocomputadora3)
                End If
       #End Region
     #Region "Dejar equipo solo T2"
     ElseIf ((fin_15c2 < proxima_llegada) Or proxima_llegada = 0) AndAlso ((fin_15c2 < fin_atencion1) Or fin_atencion1 = 0) AndAlso ((fin_15c2 < fin_atencion2) Or fin_atencion2 = 0) AndAlso ((fin_15c2 < fin_15c1) Or fin_15c1 = 0) AndAlso ((fin_15c2 < finespera_15c1) Or finespera_15c1 = 0) AndAlso ((fin_15c2 < finespera_15c2) Or finespera_15c2 = 0) AndAlso (fin_15c2 <> 0) Then
                acum_tiempo_atencion += N - fin_15c2
                N = fin_15c2
                fin_15c2 = 0
                evento = "Dejar equipo sólo T2"
                estado_tec2 = "Libre"
            'Si el arreglo es tipo c, lo arreglo los primeros 15 min y desp dejo el equipo solo


                If cola > 0 Then

                    estado_tec2 = "Ocupado"
                    cola -= 1
                    If cola = 1 Then
                        estadocomputadora = "Siendo atendida"
                    ElseIf cola = 2 Then
                        estadocomputadora2 = "Siendo atendida"
                    ElseIf cola = 3 Then
                        estadocomputadora3 = "Siendo atendida"
                    End If
                                       'TIPO_ARREGLO
                    rnd_tipo_arreglo = Math.Round(RND.NextDouble,4)
                    Select Case rnd_tipo_arreglo
                        Case 0 To 0.29
                            tipo = "A"
                            tipo_nombre = "Cambio de placa"
                        Case 0.3 To 0.54
                            tipo = "B"
                            tipo_nombre = "Ampliacion de memoria"
                        Case 0.55 To 0.69
                            tipo = "C"
                            tipo_nombre = "Formateo de disco"
                        Case 0.7 To 0.79
                            tipo = "D"
                            tipo_nombre = "Agregar CD o DVD"
                        Case 0.8 To 0.99
                            tipo = "E"
                            tipo_nombre = "Cambio de memoria"
                    End Select

                    'CLACULAR TIEMPO ARREGLO
                    Select Case tipo
                        Case "A"
                            rnd_atencion1 = Math.Round(RND.NextDouble,4)
                            tiempo_atencion1 = ((rnd_atencion1 * (b_placa.Text - a_placa.Text)) + a_placa.Text)
                            fin_atencion1 = N + tiempo_atencion1
                        Case "B"
                            rnd_atencion1 = Math.Round(RND.NextDouble,4)
                            tiempo_atencion1 = ((rnd_atencion1 * (b_ampliacion.Text - a_ampliacion.Text)) + a_ampliacion.Text)
                            fin_atencion1 = N + tiempo_atencion1
                        Case "C"
                            rnd_atencion1 = Math.Round(RND.NextDouble,4)
                            tiempo_atencion1 = ((rnd_atencion1 * (b_formateo.Text - a_formateo.Text)) + a_formateo.Text)
                            fin_atencion1 = N + tiempo_atencion1
                            fin_15c1 = N + 15
                            fin_15c2 = fin_atencion1 - 15

                        Case "D"
                            rnd_atencion1 = Math.Round(RND.NextDouble,4)
                            tiempo_atencion1 = ((rnd_atencion1 * (b_agregar.Text - a_agregar.Text)) + a_agregar.Text)
                            fin_atencion1 = N + tiempo_atencion1
                        Case "E"
                            rnd_atencion1 = Math.Round(RND.NextDouble,4)
                            tiempo_atencion1 = ((rnd_atencion1 * (b_cambio.Text - a_cambio.Text)) + a_cambio.Text)
                            fin_atencion1 = N + tiempo_atencion1
                    End Select
               
                    contador_comp += 1

                    

                    acum_permanencia += 0
                    DataGridView1.Rows.Add(N, evento, rnd_llegada, tiempo_entre_llegadas, proxima_llegada, rnd_tipo_arreglo, tipo, rnd_atencion1, tiempo_atencion1, fin_atencion1, estado_tec1, fin_15c1, finespera_15c1, vbNullString, vbNullString, fin_atencion2, estado_tec2, fin_15c2, finespera_15c2, cola, acum_tiempo_atencion, contador_comp, cont_no_atendidas, acum_permanencia, i, estadocomputadora, estadocomputadora2, estadocomputadora3)

                Else

                    If estado_tec1 = "Ocupado" Then
                        acum_tiempo_atencion += N - fin_15c2
                    End If
                    estadocomputadora = ""
                    estadocomputadora2 = ""
                    estadocomputadora3 = ""

                    DataGridView1.Rows.Add(N, evento, rnd_llegada, tiempo_entre_llegadas, proxima_llegada, rnd_tipo_arreglo, tipo, rnd_atencion1, tiempo_atencion1, fin_atencion1, estado_tec1, fin_15c1, finespera_15c1, vbNullString, vbNullString, fin_atencion2, estado_tec2, fin_15c2, finespera_15c2, cola, acum_tiempo_atencion, contador_comp, cont_no_atendidas, acum_permanencia, i, estadocomputadora, estadocomputadora2, estadocomputadora3)
                End If
       #End Region
     #Region "Volver el equipo"
            ElseIf ((finespera_15c1 < proxima_llegada) Or proxima_llegada = 0) AndAlso ((finespera_15c1 < fin_atencion1) Or fin_atencion1 = 0) AndAlso ((finespera_15c1 < fin_atencion2) Or fin_atencion2 = 0) AndAlso ((finespera_15c1 < fin_15c1) Or fin_15c1 = 0) AndAlso ((finespera_15c1 < finespera_15c2) Or finespera_15c2 = 0) AndAlso ((finespera_15c1 < fin_15c2) Or fin_15c2 = 0) AndAlso (finespera_15c1 <> 0) Then
                N = finespera_15c1
                finespera_15c1 = 0
                evento = "Volver a equipo T1"
               
               'Si el arreglo es tipo c, luego de dejar el equipo solo, 15 min antes que termino vuelvo a arreglarlo


                If estado_tec1 = "Ocupado" Then

                    If cola < 3 Then
                       
                        cola += 1
                        If cola = 0 Then
                            estadocomputadora = "Esperando Atencion"
                        ElseIf cola = 1 Then
                            estadocomputadora2 = "Esperando Atencion"
                        ElseIf cola = 2 Then
                            estadocomputadora3 = "Esperando Atencion"
                        End If
                        fin_atencion1 += 15

                    End If

                    contador_comp += 1
                    acum_tiempo_atencion += finespera_15c1 - N

                    acum_permanencia += 0
                    DataGridView1.Rows.Add(N, evento, rnd_llegada, tiempo_entre_llegadas, proxima_llegada, rnd_tipo_arreglo, tipo, rnd_atencion1, tiempo_atencion1, fin_atencion1, estado_tec1, fin_15c1, finespera_15c1, vbNullString, vbNullString, fin_atencion2, estado_tec2, fin_15c2, finespera_15c2, cola, acum_tiempo_atencion, contador_comp, cont_no_atendidas, acum_permanencia, i, estadocomputadora, estadocomputadora2, estadocomputadora3)

                Else
                    fin_atencion1 += 15
                    If estado_tec1 = "Ocupado" Then
                        acum_tiempo_atencion +=  N - finespera_15c1
                    End If
                    estadocomputadora = ""
                    estadocomputadora2 = ""
                    estadocomputadora3 = ""

                    DataGridView1.Rows.Add(N, evento, rnd_llegada, tiempo_entre_llegadas, proxima_llegada, rnd_tipo_arreglo, tipo, rnd_atencion1, tiempo_atencion1, fin_atencion1, estado_tec1, fin_15c1, finespera_15c1, vbNullString, vbNullString, fin_atencion2, estado_tec2, fin_15c2, finespera_15c2, cola, acum_tiempo_atencion, contador_comp, cont_no_atendidas, acum_permanencia, i, estadocomputadora, estadocomputadora2, estadocomputadora3)
                End If
          #End Region
     #Region "Volver el equipo T2"
            ElseIf ((finespera_15c2 < proxima_llegada) Or proxima_llegada = 0) AndAlso ((finespera_15c2 < fin_atencion1) Or fin_atencion1 = 0) AndAlso ((finespera_15c2 < fin_atencion2) Or fin_atencion2 = 0) AndAlso ((finespera_15c2 < fin_15c1) Or fin_15c1 = 0) AndAlso ((finespera_15c2 < finespera_15c1) Or finespera_15c1 = 0) AndAlso ((finespera_15c2 < fin_15c2) Or fin_15c2 = 0) AndAlso (finespera_15c2 <> 0)  Then
                acum_tiempo_atencion +=  N -finespera_15c2
                N = finespera_15c2
                finespera_15c2 = 0
                evento = "Volver a equipo T2"

                contador_comp += 0
                'Si el arreglo es tipo c, luego de dejar el equipo solo, 15 min antes que termino vuelvo a arreglarlo
                If estado_tec2 = "Ocupado" Then

                    If cola < 3 Then

                        cola += 1
                        If cola = 0 Then
                            estadocomputadora = "Esperando Atencion"
                        ElseIf cola = 1 Then
                            estadocomputadora2 = "Esperando Atencion"
                        ElseIf cola = 2 Then
                            estadocomputadora3 = "Esperando Atencion"
                        End If
                        fin_atencion1 += 15

                    End If
                     contador_comp += 1
                    'acum_tiempo_atencion += finespera_15c2 - N

                   DataGridView1.Rows.Add(N, evento, rnd_llegada, tiempo_entre_llegadas, proxima_llegada, rnd_tipo_arreglo, tipo, rnd_atencion1, tiempo_atencion1, fin_atencion1, estado_tec1, fin_15c1, finespera_15c1, vbNullString, vbNullString, fin_atencion2, estado_tec2, fin_15c2, finespera_15c2, cola, acum_tiempo_atencion, contador_comp, cont_no_atendidas, acum_permanencia, i, estadocomputadora, estadocomputadora2, estadocomputadora3)


               Else
                  fin_atencion2 += 15
                    'If estado_tec2 = "Ocupado" Then
                    '    acum_tiempo_atencion +=  N -finespera_15c2
                    'End If
                    estadocomputadora = ""
                    estadocomputadora2 = ""
                    estadocomputadora3 = ""
                    DataGridView1.Rows.Add(N, evento, rnd_llegada, tiempo_entre_llegadas, proxima_llegada, rnd_tipo_arreglo, tipo, rnd_atencion1, tiempo_atencion1, fin_atencion1, estado_tec1, fin_15c1, finespera_15c1, vbNullString, vbNullString, fin_atencion2, estado_tec2, fin_15c2, finespera_15c2, cola, acum_tiempo_atencion, contador_comp, cont_no_atendidas, acum_permanencia, i, estadocomputadora, estadocomputadora2, estadocomputadora3)


                End If
            End If
  #End Region
        Next
        ' Salida de la simulación
        prom_permanencia.Text = Math.Round(acum_permanencia / contador_comp,4)
        cant_no_atendidos.Text = Math.Round(cont_no_atendidas/(contador_comp+cont_no_atendidas) * 100,4)
        cant_no_atendidos.Text+= "%"
        ocupacion_tecnicos.Text = Math.Round((acum_tiempo_atencion / (acum_tiempo_atencion + acum_permanencia))*100,4) 
        ocupacion_tecnicos.Text+= "%"
        MessageBox.Show("Simulados " + DataGridView1.Rows.Count().ToString())
    End Sub
 

    Private Sub btn_iniciar_Click(sender As Object, e As EventArgs) Handles btn_iniciar.Click
        DataGridView1.Rows.Clear()
        prom_permanencia.Text = ""
        cant_no_atendidos.Text = ""
        ocupacion_tecnicos.Text = ""

        If RadioButton1.Checked = True Then
            simular(tiempo.Text)
        ElseIf RadioButton2.Checked = True Then
            simular(Iteraciones.Text)
        End If
    End Sub

    Private Sub Borrar_Click(sender As Object, e As EventArgs) Handles Borrar.Click
   
            DataGridView1.Rows.Clear()
     
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txt_desde.Clear()
        tiempo.Clear()
        cant_iteraciones.Clear()
        a_agregar.Clear()
        a_ampliacion.Clear()
        a_cambio.Clear()
        a_formateo.Clear()
        a_llegada.Clear()
        a_placa.Clear()
        b_agregar.Clear()
        b_ampliacion.Clear()
        b_cambio.Clear()
        b_llegada.Clear()
        b_formateo.Clear()
        b_placa.Clear()
        prom_permanencia.Clear()
        cant_no_atendidos.Clear()
        ocupacion_tecnicos.Clear()
        DataGridView1.Rows.Clear()
    End Sub


 
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        tiempo.Enabled = True
        Iteraciones.Enabled = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        tiempo.Enabled = False
        Iteraciones.Enabled = True
    End Sub

End Class
