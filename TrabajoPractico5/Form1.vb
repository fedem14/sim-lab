Public Class Form1


    Private Sub simular(N)

        Dim i As Integer
        Dim RND As New Random
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
        Dim tipo As String
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



        i = 0
        N = 0
        estado_tec1 = "Libre"
        estado_tec2 = "Libre"
        cola = 0
        fin_atencion1 = vbNull
        fin_atencion2 = vbNull
        fin_15c1 = vbNull
        fin_15c2 = vbNull
        finespera_15c1 = vbNull
        finespera_15c2 = vbNull
        contador_comp = 0
        cont_no_atendidas = 0
        evento = ""
        acum_tiempo_atencion = 0
        acum_permanencia = 0
        estadocomputadora = ""
        estadocomputadora2 = ""
        estadocomputadora3 = ""

        i = 0
        For i = 0 To N
            i += 1

            If N = 0 Then
                'LLEGADA_COMPUTADORA
                rnd_llegada = RND.NextDouble
                tiempo_entre_llegadas = ((rnd_llegada * (b_llegada.Text - a_llegada.Text)) + a_llegada.Text)
                proxima_llegada = N + tiempo_entre_llegadas
                contador_comp = 0
                cont_no_atendidas = 0
                evento = ""
                cola = 0
                estado_tec1 = "Libre"
                estado_tec2 = "Libre"
                acum_permanencia = 0
                acum_tiempo_atencion = 0
                DataGridView1.Rows.Add(N, evento, rnd_llegada, tiempo_entre_llegadas, proxima_llegada, vbNullString, vbNullString, vbNullString, vbNullString, vbNullString, estado_tec1, vbNullString, vbNullString, vbNullString, vbNullString, vbNullString, estado_tec2, vbNullString, vbNullString, cola, acum_tiempo_atencion, contador_comp, cont_no_atendidas, acum_permanencia, i, vbNullString, vbNullString, vbNullString, vbNullString, vbNullString, vbNullString)
                N = proxima_llegada
            ElseIf (((proxima_llegada < fin_atencion1) Or fin_atencion1 = vbNull) AndAlso ((proxima_llegada < fin_atencion2) Or fin_atencion2 = vbNull) AndAlso ((proxima_llegada < fin_15c1) Or fin_15c1 = vbNull) AndAlso ((proxima_llegada < fin_15c2) Or fin_15c2 = vbNull) AndAlso ((proxima_llegada < finespera_15c1) Or finespera_15c1 = vbNull) AndAlso ((proxima_llegada < finespera_15c2) Or finespera_15c2 = vbNull)) Then
                N = proxima_llegada

                If cola >= 3 Then
                    evento = "Llegada computadora"
                    cont_no_atendidas += 1
                    contador_comp += 1
                    DataGridView1.Rows.Add(N, evento, rnd_llegada, tiempo_entre_llegadas, proxima_llegada, vbNullString, vbNullString, vbNullString, vbNullString, fin_atencion1, estado_tec1, fin_15c1, finespera_15c1, vbNullString, vbNullString, fin_atencion2, estado_tec2, fin_15c2, finespera_15c2, cola, acum_tiempo_atencion, contador_comp, cont_no_atendidas, acum_permanencia, i, vbNullString, vbNullString, vbNullString)

                Else
                    evento = "Llegada computadora"
                    contador_comp += 1
                    'LLEGADA_COMPUTADORA
                    rnd_llegada = RND.NextDouble
                    tiempo_entre_llegadas = ((rnd_llegada * (b_llegada.Text - a_llegada.Text)) + a_llegada.Text)
                    proxima_llegada = N + tiempo_entre_llegadas
                    acum_tiempo_atencion += proxima_llegada - N

                    If estado_tec1 = "Libre" Then

                        estado_tec1 = "Ocupado"

                        'TIPO_ARREGLO
                        rnd_tipo_arreglo = RND.NextDouble
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
                                rnd_atencion1 = RND.NextDouble
                                tiempo_atencion1 = ((rnd_atencion1 * (b_placa.Text - a_placa.Text)) + a_placa.Text)
                                fin_atencion1 = N + tiempo_atencion1
                            Case "B"
                                rnd_atencion1 = RND.NextDouble
                                tiempo_atencion1 = ((rnd_atencion1 * (b_ampliacion.Text - a_ampliacion.Text)) + a_ampliacion.Text)
                                fin_atencion1 = N + tiempo_atencion1
                            Case "C"
                                rnd_atencion1 = RND.NextDouble
                                tiempo_atencion1 = ((rnd_atencion1 * (b_formateo.Text - a_formateo.Text)) + a_formateo.Text)
                                fin_atencion1 = N + tiempo_atencion1
                                fin_15c1 = N + 15
                                fin_15c2 = fin_atencion1 - 15

                            Case "D"
                                rnd_atencion1 = RND.NextDouble
                                tiempo_atencion1 = ((rnd_atencion1 * (b_agregar.Text - a_agregar.Text)) + a_agregar.Text)
                                fin_atencion1 = N + tiempo_atencion1
                            Case "E"
                                rnd_atencion1 = RND.NextDouble
                                tiempo_atencion1 = ((rnd_atencion1 * (b_cambio.Text - a_cambio.Text)) + a_cambio.Text)
                                fin_atencion1 = N + tiempo_atencion1
                        End Select
                        If tipo = "C" Then
                            fin_15c1 = N + 15
                            finespera_15c1 = fin_atencion1 - 15
                        End If
                        contador_comp += 1
                        acum_tiempo_atencion += proxima_llegada - N

                        acum_permanencia += tiempo_atencion1
                        DataGridView1.Rows.Add(N, evento, rnd_llegada, tiempo_entre_llegadas, proxima_llegada, rnd_tipo_arreglo, tipo, rnd_atencion1, tiempo_atencion1, fin_atencion1, estado_tec1, fin_15c1, finespera_15c1, vbNullString, vbNullString, fin_atencion2, estado_tec2, fin_15c2, finespera_15c2, cola, acum_tiempo_atencion, contador_comp, cont_no_atendidas, acum_permanencia, i, vbNullString, vbNullString, vbNullString)

                    ElseIf estado_tec2 = "Libre" Then

                        estado_tec2 = "Ocupado"

                        'TIPO_ARREGLO
                        rnd_tipo_arreglo = RND.NextDouble
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
                                rnd_atencion2 = RND.NextDouble
                                tiempo_atencion2 = ((rnd_atencion2 * (b_placa.Text - a_placa.Text)) + a_placa.Text)
                                fin_atencion2 = N + tiempo_atencion2
                            Case "B"
                                rnd_atencion2 = RND.NextDouble
                                tiempo_atencion2 = ((rnd_atencion2 * (b_ampliacion.Text - a_ampliacion.Text)) + a_ampliacion.Text)
                                fin_atencion2 = N + tiempo_atencion2
                            Case "C"
                                rnd_atencion2 = RND.NextDouble
                                tiempo_atencion2 = ((rnd_atencion2 * (b_formateo.Text - a_formateo.Text)) + a_formateo.Text)
                                fin_atencion2 = N + tiempo_atencion2
                            Case "D"
                                rnd_atencion2 = RND.NextDouble
                                tiempo_atencion2 = ((rnd_atencion2 * (b_agregar.Text - a_agregar.Text)) + a_agregar.Text)
                                fin_atencion2 = N + tiempo_atencion2
                            Case "E"
                                rnd_atencion2 = RND.NextDouble
                                tiempo_atencion2 = ((rnd_atencion2 * (b_cambio.Text - a_cambio.Text)) + a_cambio.Text)
                                fin_atencion2 = N + tiempo_atencion2
                        End Select
                        If tipo = "C" Then
                            fin_15c2 = N + 15
                            finespera_15c2 = fin_atencion2 - 15
                        End If
                        contador_comp += 1
                        acum_tiempo_atencion += proxima_llegada - N
                        acum_permanencia += tiempo_atencion2
                        DataGridView1.Rows.Add(N, evento, rnd_llegada, tiempo_entre_llegadas, proxima_llegada, rnd_tipo_arreglo, tipo, rnd_atencion1, tiempo_atencion1, fin_atencion1, estado_tec1, fin_15c1, finespera_15c1, vbNullString, vbNullString, fin_atencion2, estado_tec2, fin_15c2, finespera_15c2, cola, acum_tiempo_atencion, contador_comp, cont_no_atendidas, acum_permanencia, i, vbNullString, vbNullString, vbNullString)


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


            ElseIf ((fin_atencion1 < proxima_llegada) Or proxima_llegada = vbNull) AndAlso ((fin_atencion1 < fin_atencion2) Or fin_atencion2 = vbNull) AndAlso ((fin_atencion1 < fin_15c1) Or fin_15c1 = vbNull) AndAlso ((fin_atencion1 < fin_15c2) Or fin_15c2 = vbNull) AndAlso ((fin_atencion1 < finespera_15c1) Or finespera_15c1 = vbNull) AndAlso ((fin_atencion1 < finespera_15c2) Or finespera_15c2 = vbNull) Then
                N = fin_atencion1
                fin_atencion1 = vbNull
                evento = "Fin atención Técnico1"
                contador_comp += 0
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
                    rnd_tipo_arreglo = RND.NextDouble
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
                            rnd_atencion1 = RND.NextDouble
                            tiempo_atencion1 = ((rnd_atencion1 * (b_placa.Text - a_placa.Text)) + a_placa.Text)
                            fin_atencion1 = N + tiempo_atencion1
                        Case "B"
                            rnd_atencion1 = RND.NextDouble
                            tiempo_atencion1 = ((rnd_atencion1 * (b_ampliacion.Text - a_ampliacion.Text)) + a_ampliacion.Text)
                            fin_atencion1 = N + tiempo_atencion1
                        Case "C"
                            rnd_atencion1 = RND.NextDouble
                            tiempo_atencion1 = ((rnd_atencion1 * (b_formateo.Text - a_formateo.Text)) + a_formateo.Text)
                            fin_atencion1 = N + tiempo_atencion1
                            fin_15c1 = N + 15
                            fin_15c2 = fin_atencion1 - 15

                        Case "D"
                            rnd_atencion1 = RND.NextDouble
                            tiempo_atencion1 = ((rnd_atencion1 * (b_agregar.Text - a_agregar.Text)) + a_agregar.Text)
                            fin_atencion1 = N + tiempo_atencion1
                        Case "E"
                            rnd_atencion1 = RND.NextDouble
                            tiempo_atencion1 = ((rnd_atencion1 * (b_cambio.Text - a_cambio.Text)) + a_cambio.Text)
                            fin_atencion1 = N + tiempo_atencion1
                    End Select
                    If tipo = "C" Then
                        fin_15c1 = N + 15
                        finespera_15c1 = fin_atencion1 - 15
                    End If
                    contador_comp += 1
                    If estado_tec1 = "Ocupado" Or estado_tec2 = "Ocupado" Then
                        acum_tiempo_atencion += fin_atencion1 - N
                    End If
                    acum_permanencia += 0
                    DataGridView1.Rows.Add(N, evento, rnd_llegada, tiempo_entre_llegadas, proxima_llegada, rnd_tipo_arreglo, tipo, rnd_atencion1, tiempo_atencion1, fin_atencion1, estado_tec1, fin_15c1, finespera_15c1, vbNullString, vbNullString, fin_atencion2, estado_tec2, fin_15c2, finespera_15c2, cola, acum_tiempo_atencion, contador_comp, cont_no_atendidas, acum_permanencia, i, estadocomputadora, estadocomputadora2, estadocomputadora3)

                Else

                    estado_tec1 = "Libre"
                    If estado_tec2 = "Ocupado" Then
                        acum_tiempo_atencion += fin_atencion1 - N
                    End If
                    estadocomputadora = ""
                    estadocomputadora2 = ""
                    estadocomputadora3 = ""

                    DataGridView1.Rows.Add(N, evento, rnd_llegada, tiempo_entre_llegadas, proxima_llegada, rnd_tipo_arreglo, tipo, rnd_atencion1, tiempo_atencion1, fin_atencion1, estado_tec1, fin_15c1, finespera_15c1, vbNullString, vbNullString, fin_atencion2, estado_tec2, fin_15c2, finespera_15c2, cola, acum_tiempo_atencion, contador_comp, cont_no_atendidas, acum_permanencia, i, estadocomputadora, estadocomputadora2, estadocomputadora3)
                End If
            ElseIf ((fin_atencion2 < proxima_llegada) Or proxima_llegada = vbNull) AndAlso ((fin_atencion2 < fin_atencion1) Or fin_atencion1 = vbNull) AndAlso ((fin_atencion2 < fin_15c1) Or fin_15c1 = vbNull) AndAlso ((fin_atencion2 < fin_15c2) Or fin_15c2 = vbNull) AndAlso ((fin_atencion2 < finespera_15c1) Or finespera_15c1 = vbNull) AndAlso ((fin_atencion2 < finespera_15c2) Or finespera_15c2 = vbNull) Then
                N = fin_atencion2
                fin_atencion2 = vbNull
                evento = "Fin atención Técnico2"
                contador_comp += 0
                'Fin atención
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
                    rnd_tipo_arreglo = RND.NextDouble
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
                            rnd_atencion1 = RND.NextDouble
                            tiempo_atencion1 = ((rnd_atencion1 * (b_placa.Text - a_placa.Text)) + a_placa.Text)
                            fin_atencion1 = N + tiempo_atencion1
                        Case "B"
                            rnd_atencion1 = RND.NextDouble
                            tiempo_atencion1 = ((rnd_atencion1 * (b_ampliacion.Text - a_ampliacion.Text)) + a_ampliacion.Text)
                            fin_atencion1 = N + tiempo_atencion1
                        Case "C"
                            rnd_atencion1 = RND.NextDouble
                            tiempo_atencion1 = ((rnd_atencion1 * (b_formateo.Text - a_formateo.Text)) + a_formateo.Text)
                            fin_atencion1 = N + tiempo_atencion1
                            fin_15c1 = N + 15
                            fin_15c2 = fin_atencion1 - 15

                        Case "D"
                            rnd_atencion1 = RND.NextDouble
                            tiempo_atencion1 = ((rnd_atencion1 * (b_agregar.Text - a_agregar.Text)) + a_agregar.Text)
                            fin_atencion1 = N + tiempo_atencion1
                        Case "E"
                            rnd_atencion1 = RND.NextDouble
                            tiempo_atencion1 = ((rnd_atencion1 * (b_cambio.Text - a_cambio.Text)) + a_cambio.Text)
                            fin_atencion1 = N + tiempo_atencion1
                    End Select
                    If tipo = "C" Then
                        fin_15c1 = N + 15
                        finespera_15c1 = fin_atencion1 - 15
                    End If
                    contador_comp += 1

                    acum_tiempo_atencion += fin_atencion2 - N

                    acum_permanencia += 0
                    DataGridView1.Rows.Add(N, evento, rnd_llegada, tiempo_entre_llegadas, proxima_llegada, rnd_tipo_arreglo, tipo, rnd_atencion1, tiempo_atencion1, fin_atencion1, estado_tec1, fin_15c1, finespera_15c1, vbNullString, vbNullString, fin_atencion2, estado_tec2, fin_15c2, finespera_15c2, cola, acum_tiempo_atencion, contador_comp, cont_no_atendidas, acum_permanencia, i, estadocomputadora, estadocomputadora2, estadocomputadora3)

                Else

                    estado_tec2 = "Libre"
                    If estado_tec1 = "Ocupado" Then
                        acum_tiempo_atencion += fin_atencion2 - N
                    End If
                    estadocomputadora = ""
                    estadocomputadora2 = ""
                    estadocomputadora3 = ""

                    DataGridView1.Rows.Add(N, evento, rnd_llegada, tiempo_entre_llegadas, proxima_llegada, rnd_tipo_arreglo, tipo, rnd_atencion1, tiempo_atencion1, fin_atencion1, estado_tec1, fin_15c1, finespera_15c1, vbNullString, vbNullString, fin_atencion2, estado_tec2, fin_15c2, finespera_15c2, cola, acum_tiempo_atencion, contador_comp, cont_no_atendidas, acum_permanencia, i, estadocomputadora, estadocomputadora2, estadocomputadora3)
                End If
            ElseIf ((fin_15c1 < proxima_llegada) Or proxima_llegada = vbNull) AndAlso ((fin_15c1 < fin_atencion1) Or fin_atencion1 = vbNull) AndAlso ((fin_15c1 < fin_atencion2) Or fin_atencion2 = vbNull) AndAlso ((fin_15c1 < fin_15c2) Or fin_15c2 = vbNull) AndAlso ((fin_15c1 < finespera_15c1) Or finespera_15c1 = vbNull) AndAlso ((fin_15c1 < finespera_15c2) Or finespera_15c2 = vbNull) Then
                N = fin_15c1
                fin_15c1 = vbNull
                evento = "Dejar equipo sólo"
                estado_tec1 = "Libre"
                contador_comp += 0
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
                    'TIPO_ARREGLO
                    rnd_tipo_arreglo = RND.NextDouble
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
                            rnd_atencion1 = RND.NextDouble
                            tiempo_atencion1 = ((rnd_atencion1 * (b_placa.Text - a_placa.Text)) + a_placa.Text)
                            fin_atencion1 = N + tiempo_atencion1
                        Case "B"
                            rnd_atencion1 = RND.NextDouble
                            tiempo_atencion1 = ((rnd_atencion1 * (b_ampliacion.Text - a_ampliacion.Text)) + a_ampliacion.Text)
                            fin_atencion1 = N + tiempo_atencion1
                        Case "C"
                            rnd_atencion1 = RND.NextDouble
                            tiempo_atencion1 = ((rnd_atencion1 * (b_formateo.Text - a_formateo.Text)) + a_formateo.Text)
                            fin_atencion1 = N + tiempo_atencion1
                            fin_15c1 = N + 15
                            fin_15c2 = fin_atencion1 - 15

                        Case "D"
                            rnd_atencion1 = RND.NextDouble
                            tiempo_atencion1 = ((rnd_atencion1 * (b_agregar.Text - a_agregar.Text)) + a_agregar.Text)
                            fin_atencion1 = N + tiempo_atencion1
                        Case "E"
                            rnd_atencion1 = RND.NextDouble
                            tiempo_atencion1 = ((rnd_atencion1 * (b_cambio.Text - a_cambio.Text)) + a_cambio.Text)
                            fin_atencion1 = N + tiempo_atencion1
                    End Select
                    If tipo = "C" Then
                        fin_15c1 = N + 15
                        finespera_15c1 = fin_atencion1 - 15
                    End If
                    contador_comp += 1

                    acum_tiempo_atencion += fin_15c1 - N

                    acum_permanencia += 0
                    DataGridView1.Rows.Add(N, evento, rnd_llegada, tiempo_entre_llegadas, proxima_llegada, rnd_tipo_arreglo, tipo, rnd_atencion1, tiempo_atencion1, fin_atencion1, estado_tec1, fin_15c1, finespera_15c1, vbNullString, vbNullString, fin_atencion2, estado_tec2, fin_15c2, finespera_15c2, cola, acum_tiempo_atencion, contador_comp, cont_no_atendidas, acum_permanencia, i, estadocomputadora, estadocomputadora2, estadocomputadora3)

                Else

                    estado_tec1 = "Libre"
                    If estado_tec2 = "Ocupado" Then
                        acum_tiempo_atencion += fin_15c1 - N
                    End If
                    estadocomputadora = ""
                    estadocomputadora2 = ""
                    estadocomputadora3 = ""

                    DataGridView1.Rows.Add(N, evento, rnd_llegada, tiempo_entre_llegadas, proxima_llegada, rnd_tipo_arreglo, tipo, rnd_atencion1, tiempo_atencion1, fin_atencion1, estado_tec1, fin_15c1, finespera_15c1, vbNullString, vbNullString, fin_atencion2, estado_tec2, fin_15c2, finespera_15c2, cola, acum_tiempo_atencion, contador_comp, cont_no_atendidas, acum_permanencia, i, estadocomputadora, estadocomputadora2, estadocomputadora3)
                End If
            ElseIf ((fin_15c2 < proxima_llegada) Or proxima_llegada = vbNull) AndAlso ((fin_15c2 < fin_atencion1) Or fin_atencion1 = vbNull) AndAlso ((fin_15c2 < fin_atencion2) Or fin_atencion2 = vbNull) AndAlso ((fin_15c2 < fin_15c1) Or fin_15c1 = vbNull) AndAlso ((fin_15c2 < finespera_15c1) Or finespera_15c1 = vbNull) AndAlso ((fin_15c2 < finespera_15c2) Or finespera_15c2 = vbNull) Then
                N = fin_15c2
                fin_15c2 = vbNull
                evento = "Dejar equipo sólo"
                estado_tec2 = "Libre"
                contador_comp += 0
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
                    rnd_tipo_arreglo = RND.NextDouble
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
                            rnd_atencion1 = RND.NextDouble
                            tiempo_atencion1 = ((rnd_atencion1 * (b_placa.Text - a_placa.Text)) + a_placa.Text)
                            fin_atencion1 = N + tiempo_atencion1
                        Case "B"
                            rnd_atencion1 = RND.NextDouble
                            tiempo_atencion1 = ((rnd_atencion1 * (b_ampliacion.Text - a_ampliacion.Text)) + a_ampliacion.Text)
                            fin_atencion1 = N + tiempo_atencion1
                        Case "C"
                            rnd_atencion1 = RND.NextDouble
                            tiempo_atencion1 = ((rnd_atencion1 * (b_formateo.Text - a_formateo.Text)) + a_formateo.Text)
                            fin_atencion1 = N + tiempo_atencion1
                            fin_15c1 = N + 15
                            fin_15c2 = fin_atencion1 - 15

                        Case "D"
                            rnd_atencion1 = RND.NextDouble
                            tiempo_atencion1 = ((rnd_atencion1 * (b_agregar.Text - a_agregar.Text)) + a_agregar.Text)
                            fin_atencion1 = N + tiempo_atencion1
                        Case "E"
                            rnd_atencion1 = RND.NextDouble
                            tiempo_atencion1 = ((rnd_atencion1 * (b_cambio.Text - a_cambio.Text)) + a_cambio.Text)
                            fin_atencion1 = N + tiempo_atencion1
                    End Select
                    If tipo = "C" Then
                        fin_15c1 = N + 15
                        finespera_15c1 = fin_atencion1 - 15
                    End If
                    contador_comp += 1

                    acum_tiempo_atencion += fin_15c2 - N

                    acum_permanencia += 0
                    DataGridView1.Rows.Add(N, evento, rnd_llegada, tiempo_entre_llegadas, proxima_llegada, rnd_tipo_arreglo, tipo, rnd_atencion1, tiempo_atencion1, fin_atencion1, estado_tec1, fin_15c1, finespera_15c1, vbNullString, vbNullString, fin_atencion2, estado_tec2, fin_15c2, finespera_15c2, cola, acum_tiempo_atencion, contador_comp, cont_no_atendidas, acum_permanencia, i, estadocomputadora, estadocomputadora2, estadocomputadora3)

                Else

                    If estado_tec1 = "Ocupado" Then
                        acum_tiempo_atencion += fin_15c2 - N
                    End If
                    estadocomputadora = ""
                    estadocomputadora2 = ""
                    estadocomputadora3 = ""

                    DataGridView1.Rows.Add(N, evento, rnd_llegada, tiempo_entre_llegadas, proxima_llegada, rnd_tipo_arreglo, tipo, rnd_atencion1, tiempo_atencion1, fin_atencion1, estado_tec1, fin_15c1, finespera_15c1, vbNullString, vbNullString, fin_atencion2, estado_tec2, fin_15c2, finespera_15c2, cola, acum_tiempo_atencion, contador_comp, cont_no_atendidas, acum_permanencia, i, estadocomputadora, estadocomputadora2, estadocomputadora3)
                End If
            ElseIf ((finespera_15c1 < proxima_llegada) Or proxima_llegada = vbNull) AndAlso ((finespera_15c1 < fin_atencion1) Or fin_atencion1 = vbNull) AndAlso ((finespera_15c1 < fin_atencion2) Or fin_atencion2 = vbNull) AndAlso ((finespera_15c1 < fin_15c1) Or fin_15c1 = vbNull) AndAlso ((finespera_15c1 < finespera_15c2) Or finespera_15c2 = vbNull) AndAlso ((finespera_15c1 < fin_15c2) Or fin_15c2 = vbNull) Then
                N = finespera_15c1
                finespera_15c1 = vbNull
                evento = "Volver a equipo"

                contador_comp += 0
                'Si el arreglo es tipo c, luego de dejar el equipo solo, 15 min antes que termino vuelvo a arreglarlo


                If estado_tec1 = "Ocupado" Then

                    If cola > 3 Then

                    Else
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


                    acum_tiempo_atencion += finespera_15c1 - N

                    acum_permanencia += 0
                    DataGridView1.Rows.Add(N, evento, rnd_llegada, tiempo_entre_llegadas, proxima_llegada, rnd_tipo_arreglo, tipo, rnd_atencion1, tiempo_atencion1, fin_atencion1, estado_tec1, fin_15c1, finespera_15c1, vbNullString, vbNullString, fin_atencion2, estado_tec2, fin_15c2, finespera_15c2, cola, acum_tiempo_atencion, contador_comp, cont_no_atendidas, acum_permanencia, i, estadocomputadora, estadocomputadora2, estadocomputadora3)

                Else
                    fin_atencion1 += 15
                    If estado_tec2 = "Ocupado" Then
                        acum_tiempo_atencion += finespera_15c1 - N
                    End If
                    estadocomputadora = ""
                    estadocomputadora2 = ""
                    estadocomputadora3 = ""

                    DataGridView1.Rows.Add(N, evento, rnd_llegada, tiempo_entre_llegadas, proxima_llegada, rnd_tipo_arreglo, tipo, rnd_atencion1, tiempo_atencion1, fin_atencion1, estado_tec1, fin_15c1, finespera_15c1, vbNullString, vbNullString, fin_atencion2, estado_tec2, fin_15c2, finespera_15c2, cola, acum_tiempo_atencion, contador_comp, cont_no_atendidas, acum_permanencia, i, estadocomputadora, estadocomputadora2, estadocomputadora3)
                End If
            ElseIf ((finespera_15c2 < proxima_llegada) Or proxima_llegada = vbNull) AndAlso ((finespera_15c2 < fin_atencion1) Or fin_atencion1 = vbNull) AndAlso ((finespera_15c2 < fin_atencion2) Or fin_atencion2 = vbNull) AndAlso ((finespera_15c2 < fin_15c1) Or fin_15c1 = vbNull) AndAlso ((finespera_15c2 < finespera_15c1) Or finespera_15c1 = vbNull) AndAlso ((finespera_15c2 < fin_15c2) Or fin_15c2 = vbNull) Then
                N = finespera_15c2
                finespera_15c2 = vbNull
                evento = "Volver a equipo"

                contador_comp += 0
                'Si el arreglo es tipo c, luego de dejar el equipo solo, 15 min antes que termino vuelvo a arreglarlo





                fin_atencion2 += 15
                acum_tiempo_atencion += finespera_15c2 - N
                acum_permanencia += 0
                DataGridView1.Rows.Add(N, evento, rnd_llegada, tiempo_entre_llegadas, proxima_llegada, rnd_tipo_arreglo, tipo, rnd_atencion1, tiempo_atencion1, fin_atencion1, estado_tec1, fin_15c1, finespera_15c1, vbNullString, vbNullString, fin_atencion2, estado_tec2, fin_15c2, finespera_15c2, cola, acum_tiempo_atencion, contador_comp, cont_no_atendidas, acum_permanencia, i, estadocomputadora, estadocomputadora2, estadocomputadora3)



            End If

        Next

    End Sub

    Private Sub btn_iniciar_Click(sender As Object, e As EventArgs) Handles btn_iniciar.Click
        If RadioButton1.Checked = True Then
            simular(tiempo.Text)
        ElseIf RadioButton2.Checked = True Then
            simular(Iteraciones.Text)
        End If
    End Sub

    Private Sub Borrar_Click(sender As Object, e As EventArgs) Handles Borrar.Click
        For Each row As DataGridViewRow In DataGridView1.Rows
            DataGridView1.Rows.Clear()
        Next
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
