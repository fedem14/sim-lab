Public Class Form1


    Private Sub simular(R)

        Dim N As Double
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
        Dim tipo As String = 0
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
        Dim estadocomputadora4 As String
        Dim estadocomputadora5 As String
        Dim FinAtC1 As Decimal
        Dim finAtC2 As Decimal
        Dim FinAtC3 As Decimal
        Dim FinAtC4 As Decimal
        Dim FinAtC5 As Decimal
        Dim primeraVez As Boolean = True
        Dim tiempo_llegada_c1 As Decimal
        Dim tiempo_llegada_c2 As Decimal
        Dim tiempo_llegada_c3 As Decimal
        Dim tiempo_llegada_c4 As Decimal
        Dim tiempo_llegada_c5 As Decimal
        Dim tiempo_inicio_atencion1 As Decimal
        Dim tiempo_inicio_atencion2 As Decimal
        Dim i As Integer
        Dim varboolean As Boolean
        Dim G As Integer
        varboolean = True
        FinAtC1 = 0
        finAtC2 = 0
        FinAtC3 = 0
        FinAtC4 = 0
        FinAtC5 = 0
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
        evento = " "
        acum_tiempo_atencion = 0
        acum_permanencia = 0
        estadocomputadora = " "
        estadocomputadora2 = " "
        estadocomputadora3 = " "
        estadocomputadora4 = " "
        estadocomputadora5 = " "
        N = 0


        DataGridView1.Visible = True



        For i = 0 To (R - 1)

#Region "Inicializacion"

            If primeraVez Then
                'LLEGADA_COMPUTADORA
                rnd_llegada = Math.Round(RND.NextDouble, 2)
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
                N = 0
                If N >= txt_desde.Text Then
                    DataGridView1.Rows.Add(N, evento, rnd_llegada, tiempo_entre_llegadas, proxima_llegada, vbNullString, vbNullString, vbNullString, vbNullString, vbNullString, estado_tec1, vbNullString, vbNullString, vbNullString, vbNullString, vbNullString, estado_tec2, vbNullString, vbNullString, cola, acum_tiempo_atencion, contador_comp, cont_no_atendidas, acum_permanencia, i, vbNullString, vbNullString, vbNullString, vbNullString, vbNullString, vbNullString, vbNullString, vbNullString, vbNullString, vbNullString, vbNullString, vbNullString, vbNullString, vbNullString, vbNullString)
                End If
                primeraVez = False
#End Region
#Region "Esperando 15 minutos C1"
            ElseIf estadocomputadora = "Esperando 15 minutos" AndAlso ((FinAtC1 < proxima_llegada) Or proxima_llegada = 0) AndAlso ((FinAtC1 < fin_atencion1) Or fin_atencion1 = 0) AndAlso ((FinAtC1 < fin_atencion2) Or fin_atencion2 = 0) AndAlso ((FinAtC1 < fin_15c1) Or fin_15c1 = 0) AndAlso ((estadocomputadora2 = "Esperando 15 minutos" AndAlso FinAtC1 < finAtC2) Or estadocomputadora2 <> "Esperando 15 minutos") AndAlso
                ((estadocomputadora3 = "Esperando 15 minutos" AndAlso FinAtC1 < FinAtC3) Or estadocomputadora3 <> "Esperando 15 minutos") AndAlso
                ((estadocomputadora4 = "Esperando 15 minutos" AndAlso FinAtC1 < FinAtC4) Or estadocomputadora4 <> "Esperando 15 minutos") AndAlso
                ((estadocomputadora5 = "Esperando 15 minutos" AndAlso FinAtC1 < FinAtC5) Or estadocomputadora5 <> "Esperando 15 minutos") Then
                N = FinAtC1
                evento = "Volver a equipo"
                'acum_tiempo_atencion += 15
                If estado_tec1 = "Libre" Then
                    estado_tec1 = "Ocupado"
                    estadocomputadora = "Siendo reparada 1"
                    fin_atencion1 = N + 15
                    tiempo_inicio_atencion1 = N

                ElseIf estado_tec2 = "Libre" Then
                    estado_tec2 = "Ocupado"
                    estadocomputadora = "Siendo reparada 2"
                    fin_atencion2 = N + 15
                    tiempo_inicio_atencion2 = N

                ElseIf estado_tec1 = "Ocupado" Then
                    estadocomputadora = "Esperando tecnico"
                    FinAtC1 = N + 15

                End If
                tipo = "C"
                rnd_tipo_arreglo = 0
                If N >= txt_desde.Text Then

                    If i < G Then
                        DataGridView1.Rows.Add(N, evento, rnd_llegada, tiempo_entre_llegadas, proxima_llegada, rnd_tipo_arreglo, tipo, rnd_atencion1, tiempo_atencion1, fin_atencion1, estado_tec1, tiempo_inicio_atencion1, fin_15c1, finespera_15c1, vbNullString, vbNullString, fin_atencion2, estado_tec2, tiempo_inicio_atencion2, fin_15c2, finespera_15c2, cola, acum_tiempo_atencion, contador_comp, cont_no_atendidas, acum_permanencia, i, estadocomputadora, FinAtC1, estadocomputadora2, finAtC2, estadocomputadora3, FinAtC3, estadocomputadora4, FinAtC4, estadocomputadora5, FinAtC5)
                    End If
                End If
#End Region
#Region "Esperando 15 minutos C2"
            ElseIf estadocomputadora2 = "Esperando 15 minutos" AndAlso ((finAtC2 < proxima_llegada) Or proxima_llegada = 0) AndAlso ((finAtC2 < fin_atencion1) Or fin_atencion1 = 0) AndAlso ((finAtC2 < fin_atencion2) Or fin_atencion2 = 0) AndAlso ((finAtC2 < fin_15c1) Or fin_15c1 = 0) AndAlso ((estadocomputadora = "Esperando 15 minutos" AndAlso finAtC2 < FinAtC1) Or estadocomputadora <> "Esperando 15 minutos") AndAlso
                ((estadocomputadora3 = "Esperando 15 minutos" AndAlso finAtC2 < FinAtC3) Or estadocomputadora3 <> "Esperando 15 minutos") AndAlso
                ((estadocomputadora4 = "Esperando 15 minutos" AndAlso finAtC2 < FinAtC4) Or estadocomputadora4 <> "Esperando 15 minutos") AndAlso
                ((estadocomputadora5 = "Esperando 15 minutos" AndAlso finAtC2 < FinAtC5) Or estadocomputadora5 <> "Esperando 15 minutos") Then
                N = finAtC2
                evento = "Volver a equipo"
                'acum_tiempo_atencion += 15
                If estado_tec1 = "Libre" Then

                    estado_tec1 = "Ocupado"
                    estadocomputadora2 = "Siendo reparada 1"
                    fin_atencion1 = N + 15
                    tiempo_inicio_atencion1 = N
                ElseIf estado_tec2 = "Libre" Then


                    estado_tec2 = "Ocupado"
                    estadocomputadora2 = "Siendo reparada 2"
                    fin_atencion2 = N + 15
                    tiempo_inicio_atencion2 = N
                ElseIf estado_tec1 = "Ocupado" Then
                    estadocomputadora2 = "Esperando tecnico"
                    finAtC2 = N + 15
                End If
                tipo = "C"
                rnd_tipo_arreglo = 0
                If N >= txt_desde.Text Then

                    If i < G Then
                        DataGridView1.Rows.Add(N, evento, rnd_llegada, tiempo_entre_llegadas, proxima_llegada, rnd_tipo_arreglo, tipo, rnd_atencion1, tiempo_atencion1, fin_atencion1, estado_tec1, tiempo_inicio_atencion1, fin_15c1, finespera_15c1, vbNullString, vbNullString, fin_atencion2, estado_tec2, tiempo_inicio_atencion2, fin_15c2, finespera_15c2, cola, acum_tiempo_atencion, contador_comp, cont_no_atendidas, acum_permanencia, i, estadocomputadora, FinAtC1, estadocomputadora2, finAtC2, estadocomputadora3, FinAtC3, estadocomputadora4, FinAtC4, estadocomputadora5, FinAtC5)
                    End If
                End If
#End Region
#Region "Esperando 15 min C3"
            ElseIf estadocomputadora3 = "Esperando 15 minutos" AndAlso ((FinAtC3 < proxima_llegada) Or proxima_llegada = 0) AndAlso ((FinAtC3 < fin_atencion1) Or fin_atencion1 = 0) AndAlso ((FinAtC3 < fin_atencion2) Or fin_atencion2 = 0) AndAlso ((FinAtC3 < fin_15c1) Or fin_15c1 = 0) AndAlso ((estadocomputadora = "Esperando 15 minutos" AndAlso FinAtC3 < FinAtC1) Or estadocomputadora <> "Esperando 15 minutos") AndAlso
                ((estadocomputadora2 = "Esperando 15 minutos" AndAlso FinAtC3 < finAtC2) Or estadocomputadora3 <> "Esperando 15 minutos") AndAlso
                ((estadocomputadora4 = "Esperando 15 minutos" AndAlso FinAtC3 < FinAtC4) Or estadocomputadora4 <> "Esperando 15 minutos") AndAlso
                ((estadocomputadora5 = "Esperando 15 minutos" AndAlso FinAtC3 < FinAtC5) Or estadocomputadora5 <> "Esperando 15 minutos") Then
                N = FinAtC3
                evento = "Volver a equipo"
                'acum_tiempo_atencion += 15
                If estado_tec1 = "Libre" Then
                    estado_tec1 = "Ocupado"
                    estadocomputadora3 = "Siendo reparada 1"
                    fin_atencion1 = N + 15
                    tiempo_inicio_atencion1 = N
                ElseIf estado_tec2 = "Libre" Then
                    estado_tec2 = "Ocupado"
                    estadocomputadora3 = "Siendo reparada 2"
                    fin_atencion2 = N + 15
                    tiempo_inicio_atencion2 = N
                ElseIf estado_tec1 = "Ocupado" Then
                    estadocomputadora3 = "Esperando tecnico"
                    FinAtC3 = N + 15
                End If
                tipo = "C"
                rnd_tipo_arreglo = 0
                If N >= txt_desde.Text Then

                    If i < G Then
                        DataGridView1.Rows.Add(N, evento, rnd_llegada, tiempo_entre_llegadas, proxima_llegada, rnd_tipo_arreglo, tipo, rnd_atencion1, tiempo_atencion1, fin_atencion1, estado_tec1, tiempo_inicio_atencion1, fin_15c1, finespera_15c1, vbNullString, vbNullString, fin_atencion2, estado_tec2, tiempo_inicio_atencion2, fin_15c2, finespera_15c2, cola, acum_tiempo_atencion, contador_comp, cont_no_atendidas, acum_permanencia, i, estadocomputadora, FinAtC1, estadocomputadora2, finAtC2, estadocomputadora3, FinAtC3, estadocomputadora4, FinAtC4, estadocomputadora5, FinAtC5)
                    End If
                End If
#End Region
#Region "Esperando 15 min C4"
            ElseIf estadocomputadora4 = "Esperando 15 minutos" AndAlso ((FinAtC4 < proxima_llegada) Or proxima_llegada = 0) AndAlso ((FinAtC4 < fin_atencion1) Or fin_atencion1 = 0) AndAlso ((FinAtC4 < fin_atencion2) Or fin_atencion2 = 0) AndAlso ((FinAtC4 < fin_15c1) Or fin_15c1 = 0) AndAlso ((estadocomputadora = "Esperando 15 minutos" AndAlso FinAtC4 < FinAtC1) Or estadocomputadora <> "Esperando 15 minutos") AndAlso
                ((estadocomputadora3 = "Esperando 15 minutos" AndAlso FinAtC4 < FinAtC3) Or estadocomputadora3 <> "Esperando 15 minutos") AndAlso
                ((estadocomputadora2 = "Esperando 15 minutos" AndAlso FinAtC4 < finAtC2) Or estadocomputadora2 <> "Esperando 15 minutos") AndAlso
                ((estadocomputadora5 = "Esperando 15 minutos" AndAlso FinAtC4 < FinAtC5) Or estadocomputadora5 <> "Esperando 15 minutos") Then
                N = FinAtC4
                evento = "Volver a equipo"
                'acum_tiempo_atencion += 15
                If estado_tec1 = "Libre" Then
                    estado_tec1 = "Ocupado"
                    estadocomputadora4 = "Siendo reparada 1"
                    fin_atencion1 = N + 15
                    tiempo_inicio_atencion1 = N
                ElseIf estado_tec2 = "Libre" Then
                    estado_tec2 = "Ocupado"
                    estadocomputadora4 = "Siendo reparada 2"
                    fin_atencion2 = N + 15
                    tiempo_inicio_atencion2 = N
                ElseIf estado_tec1 = "Ocupado" Then
                    estadocomputadora4 = "Esperando tecnico"
                    FinAtC4 = N + 15
                End If

                tipo = "C"
                rnd_tipo_arreglo = 0



                If N >= txt_desde.Text Then

                    If i < G Then
                        DataGridView1.Rows.Add(N, evento, rnd_llegada, tiempo_entre_llegadas, proxima_llegada, rnd_tipo_arreglo, tipo, rnd_atencion1, tiempo_atencion1, fin_atencion1, estado_tec1, tiempo_inicio_atencion1, fin_15c1, finespera_15c1, vbNullString, vbNullString, fin_atencion2, estado_tec2, tiempo_inicio_atencion2, fin_15c2, finespera_15c2, cola, acum_tiempo_atencion, contador_comp, cont_no_atendidas, acum_permanencia, i, estadocomputadora, FinAtC1, estadocomputadora2, finAtC2, estadocomputadora3, FinAtC3, estadocomputadora4, FinAtC4, estadocomputadora5, FinAtC5)
                    End If
                End If
#End Region
#Region "Esperando 15 minutos C5"
            ElseIf estadocomputadora5 = "Esperando 15 minutos" AndAlso ((FinAtC5 < proxima_llegada) Or proxima_llegada = 0) AndAlso ((FinAtC5 < fin_atencion1) Or fin_atencion1 = 0) AndAlso ((FinAtC5 < fin_atencion2) Or fin_atencion2 = 0) AndAlso ((FinAtC5 < fin_15c1) Or fin_15c1 = 0) AndAlso ((estadocomputadora = "Esperando 15 minutos" AndAlso FinAtC5 < FinAtC1) Or estadocomputadora <> "Esperando 15 minutos") AndAlso
                ((estadocomputadora3 = "Esperando 15 minutos" AndAlso FinAtC5 < FinAtC3) Or estadocomputadora3 <> "Esperando 15 minutos") AndAlso
                ((estadocomputadora2 = "Esperando 15 minutos" AndAlso FinAtC5 < finAtC2) Or estadocomputadora2 <> "Esperando 15 minutos") AndAlso
                ((estadocomputadora4 = "Esperando 15 minutos" AndAlso FinAtC5 < FinAtC4) Or estadocomputadora4 <> "Esperando 15 minutos") Then
                N = FinAtC5
                evento = "Volver a equipo"
                'acum_tiempo_atencion += 15
                If estado_tec1 = "Libre" Then
                    estado_tec1 = "Ocupado"
                    estadocomputadora5 = "Siendo reparada 1"
                    fin_atencion1 = N + 15
                    tiempo_inicio_atencion1 = N
                ElseIf estado_tec2 = "Libre" Then
                    tiempo_inicio_atencion2 = N
                    estado_tec2 = "Ocupado"
                    estadocomputadora5 = "Siendo reparada 2"
                    fin_atencion2 = N + 15

                ElseIf estado_tec1 = "Ocupado" Then
                    estadocomputadora5 = "Esperando tecnico"
                    FinAtC5 = N + 15

                End If
                tipo = "C"
                rnd_tipo_arreglo = 0
                If N >= txt_desde.Text Then

                    If i < G Then
                        DataGridView1.Rows.Add(N, evento, rnd_llegada, tiempo_entre_llegadas, proxima_llegada, rnd_tipo_arreglo, tipo, rnd_atencion1, tiempo_atencion1, fin_atencion1, estado_tec1, tiempo_inicio_atencion1, fin_15c1, finespera_15c1, vbNullString, vbNullString, fin_atencion2, estado_tec2, tiempo_inicio_atencion2, fin_15c2, finespera_15c2, cola, acum_tiempo_atencion, contador_comp, cont_no_atendidas, acum_permanencia, i, estadocomputadora, FinAtC1, estadocomputadora2, finAtC2, estadocomputadora3, FinAtC3, estadocomputadora4, FinAtC4, estadocomputadora5, FinAtC5)
                    End If
                End If
#End Region
#Region "Llegada computadora"
            ElseIf (((proxima_llegada < fin_atencion1) Or fin_atencion1 = 0) AndAlso ((proxima_llegada < fin_atencion2) Or fin_atencion2 = 0) AndAlso ((proxima_llegada < fin_15c1) Or fin_15c1 = 0) AndAlso ((proxima_llegada < fin_15c2) Or fin_15c2 = 0) AndAlso proxima_llegada <> 0) Then
                N = proxima_llegada
                evento = "Llegada computadora"

                'Calcular Próxima llegada
                rnd_llegada = Math.Round(RND.NextDouble, 2)
                tiempo_entre_llegadas = ((rnd_llegada * (b_llegada.Text - a_llegada.Text)) + a_llegada.Text)
                proxima_llegada = N + tiempo_entre_llegadas

                'Verifica estados de tecnicos
                If estado_tec1 = "Ocupado" AndAlso estado_tec2 = "Ocupado" Then
                    If cola >= 3 Then
                        cont_no_atendidas += 1
                        If N >= txt_desde.Text Then

                            If i < G Then
                                DataGridView1.Rows.Add(N, evento, rnd_llegada, tiempo_entre_llegadas, proxima_llegada, vbNullString, vbNullString, vbNullString, vbNullString, fin_atencion1, estado_tec1, vbNullString, fin_15c1, finespera_15c1, vbNullString, vbNullString, fin_atencion2, estado_tec2, vbNullString, fin_15c2, finespera_15c2, cola, acum_tiempo_atencion, contador_comp, cont_no_atendidas, acum_permanencia, i, vbNullString, vbNullString, vbNullString, vbNullString, vbNullString, vbNullString, vbNullString, vbNullString, vbNullString, vbNullString, vbNullString, vbNullString, vbNullString)
                            End If
                        End If
                    Else
                        cola += 1

                        If estadocomputadora = " " Then
                            estadocomputadora = "Esperando atencion"
                            tiempo_llegada_c1 = N
                        ElseIf estadocomputadora2 = " " Then
                            estadocomputadora2 = "Esperando atencion"
                            tiempo_llegada_c2 = N
                        ElseIf estadocomputadora3 = " " Then
                            estadocomputadora3 = "Esperando atencion"
                            tiempo_llegada_c3 = N
                        ElseIf estadocomputadora4 = " " Then
                            estadocomputadora4 = "Esperando atencion"
                            tiempo_llegada_c4 = N
                        ElseIf estadocomputadora5 = " " Then
                            estadocomputadora5 = "Esperando atencion"
                            tiempo_llegada_c5 = N
                        End If
                    End If
                    If N >= txt_desde.Text Then

                        If i < G Then
                            DataGridView1.Rows.Add(N, evento, rnd_llegada, tiempo_entre_llegadas, proxima_llegada, "", "", vbNullString, vbNullString, fin_atencion1, estado_tec1, vbNullString, fin_15c1, finespera_15c1, vbNullString, vbNullString, fin_atencion2, estado_tec2, vbNullString, fin_15c2, finespera_15c2, cola, acum_tiempo_atencion, contador_comp, cont_no_atendidas, acum_permanencia, i, estadocomputadora, FinAtC1, estadocomputadora2, finAtC2, estadocomputadora3, FinAtC3, estadocomputadora4, FinAtC4, estadocomputadora5, FinAtC5)
                        End If
                    End If
                Else
                    If estado_tec1 = "Libre" Then
                        estado_tec1 = "Ocupado"
                        tiempo_inicio_atencion1 = N

                        'TIPO_ARREGLO
                        rnd_tipo_arreglo = Math.Round(RND.NextDouble, 2)
                        Select Case rnd_tipo_arreglo
                            Case 0 To 0.29
                                tipo = "A"
                                tipo_nombre = "Cambio de placa"
                                rnd_atencion1 = Math.Round(RND.NextDouble, 2)
                                tiempo_atencion1 = ((rnd_atencion1 * (b_placa.Text - a_placa.Text)) + a_placa.Text)
                                fin_atencion1 = N + tiempo_atencion1
                            Case 0.3 To 0.54
                                tipo = "B"
                                tipo_nombre = "Ampliacion de memoria"
                                rnd_atencion1 = Math.Round(RND.NextDouble, 2)
                                tiempo_atencion1 = ((rnd_atencion1 * (b_ampliacion.Text - a_ampliacion.Text)) + a_ampliacion.Text)
                                fin_atencion1 = N + tiempo_atencion1
                            Case 0.55 To 0.69
                                tipo = "C"
                                tipo_nombre = "Formateo de disco"
                                rnd_atencion1 = Math.Round(RND.NextDouble, 2)
                                tiempo_atencion1 = ((rnd_atencion1 * (b_formateo.Text - a_formateo.Text)) + a_formateo.Text)
                                fin_atencion1 = N + tiempo_atencion1
                                fin_15c1 = N + 15
                                finespera_15c1 = fin_atencion1 - 15
                            Case 0.7 To 0.79
                                tipo = "D"
                                tipo_nombre = "Agregar CD o DVD"
                                rnd_atencion1 = Math.Round(RND.NextDouble, 2)
                                tiempo_atencion1 = ((rnd_atencion1 * (b_agregar.Text - a_agregar.Text)) + a_agregar.Text)
                                fin_atencion1 = N + tiempo_atencion1
                            Case 0.8 To 1
                                tipo = "E"
                                tipo_nombre = "Cambio de memoria"
                                rnd_atencion1 = Math.Round(RND.NextDouble, 2)
                                tiempo_atencion1 = ((rnd_atencion1 * (b_cambio.Text - a_cambio.Text)) + a_cambio.Text)
                                fin_atencion1 = N + tiempo_atencion1
                        End Select

                        'ESTADO DE COMPUTADORAS
                        If estadocomputadora = " " Then
                            estadocomputadora = "Siendo reparada 1"
                            tiempo_llegada_c1 = N
                            FinAtC1 = fin_atencion1
                        ElseIf estadocomputadora2 = " " Then
                            estadocomputadora2 = "Siendo reparada 1"
                            tiempo_llegada_c2 = N
                            finAtC2 = fin_atencion1
                        ElseIf estadocomputadora3 = " " Then
                            estadocomputadora3 = "Siendo reparada 1"
                            tiempo_llegada_c3 = N
                            FinAtC3 = fin_atencion1
                        ElseIf estadocomputadora4 = " " Then
                            estadocomputadora4 = "Siendo reparada 1"
                            tiempo_llegada_c4 = N
                            FinAtC4 = fin_atencion1
                        ElseIf estadocomputadora5 = " " Then
                            estadocomputadora5 = "Siendo reparada 1"
                            tiempo_llegada_c5 = N
                            FinAtC5 = fin_atencion1
                        End If

                        If N >= txt_desde.Text Then

                            If i < G Then
                                DataGridView1.Rows.Add(N, evento, rnd_llegada, tiempo_entre_llegadas, proxima_llegada, rnd_tipo_arreglo, tipo, rnd_atencion1, tiempo_atencion1, fin_atencion1, estado_tec1, tiempo_inicio_atencion1, fin_15c1, finespera_15c1, vbNullString, vbNullString, fin_atencion2, estado_tec2, tiempo_inicio_atencion2, fin_15c2, finespera_15c2, cola, acum_tiempo_atencion, contador_comp, cont_no_atendidas, acum_permanencia, i, estadocomputadora, FinAtC1, estadocomputadora2, finAtC2, estadocomputadora3, FinAtC3, estadocomputadora4, FinAtC4, estadocomputadora5, FinAtC5)
                            End If
                        End If

                    ElseIf estado_tec2 = "Libre" Then
                        estado_tec2 = "Ocupado"
                        tiempo_inicio_atencion2 = N
                        rnd_tipo_arreglo = Math.Round(RND.NextDouble, 2)

                        'TIPO_ARREGLO
                        Select Case rnd_tipo_arreglo
                            Case 0 To 0.29
                                tipo = "A"
                                tipo_nombre = "Cambio de placa"
                                rnd_atencion2 = Math.Round(RND.NextDouble, 2)
                                tiempo_atencion2 = ((rnd_atencion2 * (b_placa.Text - a_placa.Text)) + a_placa.Text)
                                fin_atencion2 = N + tiempo_atencion2
                            Case 0.3 To 0.54
                                tipo = "B"
                                tipo_nombre = "Ampliacion de memoria"
                                rnd_atencion2 = Math.Round(RND.NextDouble, 2)
                                tiempo_atencion2 = ((rnd_atencion2 * (b_ampliacion.Text - a_ampliacion.Text)) + a_ampliacion.Text)
                                fin_atencion2 = N + tiempo_atencion2
                            Case 0.55 To 0.69
                                tipo = "C"
                                tipo_nombre = "Formateo de disco"
                                rnd_atencion2 = Math.Round(RND.NextDouble, 2)
                                tiempo_atencion2 = ((rnd_atencion2 * (b_formateo.Text - a_formateo.Text)) + a_formateo.Text)
                                fin_atencion2 = N + tiempo_atencion2
                                fin_15c2 = N + 15
                                finespera_15c2 = fin_atencion2 - 15
                            Case 0.7 To 0.79
                                tipo = "D"
                                tipo_nombre = "Agregar CD o DVD"
                                rnd_atencion2 = Math.Round(RND.NextDouble, 2)
                                tiempo_atencion2 = ((rnd_atencion2 * (b_agregar.Text - a_agregar.Text)) + a_agregar.Text)
                                fin_atencion2 = N + tiempo_atencion2
                            Case 0.8 To 1
                                tipo = "E"
                                tipo_nombre = "Cambio de memoria"
                                rnd_atencion2 = Math.Round(RND.NextDouble, 2)
                                tiempo_atencion2 = ((rnd_atencion2 * (b_cambio.Text - a_cambio.Text)) + a_cambio.Text)
                                fin_atencion2 = N + tiempo_atencion2
                        End Select

                        If estadocomputadora = " " Then
                            estadocomputadora = "Siendo reparada 2"
                            tiempo_llegada_c1 = N
                            FinAtC1 = fin_atencion2
                        ElseIf estadocomputadora2 = " " Then
                            estadocomputadora2 = "Siendo reparada 2"
                            tiempo_llegada_c2 = N
                            finAtC2 = fin_atencion2
                        ElseIf estadocomputadora3 = " " Then
                            estadocomputadora3 = "Siendo reparada 2"
                            tiempo_llegada_c3 = N
                            FinAtC3 = fin_atencion2
                        ElseIf estadocomputadora4 = " " Then
                            estadocomputadora4 = "Siendo reparada 2"
                            tiempo_llegada_c4 = N
                            FinAtC4 = fin_atencion2
                        ElseIf estadocomputadora5 = " " Then
                            estadocomputadora5 = "Siendo reparada 2"
                            tiempo_llegada_c5 = N
                            FinAtC5 = fin_atencion2
                        End If

                        If N >= txt_desde.Text Then
                            If i < G Then
                                DataGridView1.Rows.Add(N, evento, rnd_llegada, tiempo_entre_llegadas, proxima_llegada, rnd_tipo_arreglo, tipo, vbNullString, vbNullString, fin_atencion1, estado_tec1, tiempo_inicio_atencion1, fin_15c1, finespera_15c1, rnd_atencion2, tiempo_atencion2, fin_atencion2, estado_tec2, tiempo_inicio_atencion2, fin_15c2, finespera_15c2, cola, acum_tiempo_atencion, contador_comp, cont_no_atendidas, acum_permanencia, i, estadocomputadora, FinAtC1, estadocomputadora2, finAtC2, estadocomputadora3, FinAtC3, estadocomputadora4, FinAtC4, estadocomputadora5, FinAtC5)
                            End If
                        End If

                    End If
                End If
#End Region
#Region "Fin atencion 1"
            ElseIf ((fin_atencion1 < proxima_llegada) Or proxima_llegada = 0) AndAlso ((fin_atencion1 < fin_atencion2) Or fin_atencion2 = 0) AndAlso ((fin_atencion1 < fin_15c1) Or fin_15c1 = 0) AndAlso ((fin_atencion1 < fin_15c2) Or fin_15c2 = 0) AndAlso (fin_atencion1 <> 0) Then
                N = fin_atencion1
                evento = "Fin atención Técnico 1"
                estado_tec1 = "Libre"
                fin_atencion1 = 0
                fin_15c1 = 0
                finespera_15c1 = 0
                tipo = " "
                rnd_tipo_arreglo = 0

                'ESTADO COMPUTADORA
                If estadocomputadora = "Siendo reparada 1" Then
                    FinAtC1 = 0
                    estadocomputadora = " "
                    acum_permanencia += N - tiempo_llegada_c1
                ElseIf estadocomputadora2 = "Siendo reparada 1" Then
                    finAtC2 = 0
                    estadocomputadora2 = " "
                    acum_permanencia += N - tiempo_llegada_c2
                ElseIf estadocomputadora3 = "Siendo reparada 1" Then
                    FinAtC3 = 0
                    estadocomputadora3 = " "
                    acum_permanencia += N - tiempo_llegada_c3
                ElseIf estadocomputadora4 = "Siendo reparada 1" Then
                    FinAtC4 = 0
                    estadocomputadora4 = " "
                    acum_permanencia += N - tiempo_llegada_c4
                ElseIf estadocomputadora5 = "Siendo reparada 1" Then
                    FinAtC5 = 0
                    estadocomputadora5 = " "
                    acum_permanencia += N - tiempo_llegada_c5
                End If

                If cola >= 1 And ((estadocomputadora = "Esperando tecnico") Or (estadocomputadora2 = "Esperando tecnico") Or (estadocomputadora3 = "Esperando tecnico") Or (estadocomputadora4 = "Esperando tecnico") Or (estadocomputadora5 = "Esperando tecnico")) Then

                    If estadocomputadora = "Esperando tecnico" Then
                        estadocomputadora = "Siendo reparada 1"
                        FinAtC1 = N + 15
                        fin_atencion1 = N + 15
                    ElseIf estadocomputadora2 = "Esperando tecnico" Then
                        estadocomputadora2 = "Siendo reparada 1"
                        finAtC2 = N + 15
                        fin_atencion1 = N + 15
                    ElseIf estadocomputadora3 = "Esperando tecnico" Then
                        estadocomputadora3 = "Siendo reparada 1"
                        FinAtC3 = N + 15
                        fin_atencion1 = N + 15
                    ElseIf estadocomputadora4 = "Esperando tecnico" Then
                        estadocomputadora4 = "Siendo reparada 1"
                        FinAtC4 = N + 15
                        fin_atencion1 = N + 15
                    ElseIf estadocomputadora5 = "Esperando tecnico" Then
                        estadocomputadora5 = "Siendo reparada 1"
                        FinAtC5 = N + 15
                        fin_atencion1 = N + 15
                    End If
                    estado_tec1 = "Ocupado"

                ElseIf cola >= 1 And (((estadocomputadora <> "Esperando 15 minutos") Or (estadocomputadora <> "Esperando tecnico")) Or ((estadocomputadora2 <> "Esperando 15 minutos") Or (estadocomputadora2 <> "Esperando tecnico")) Or ((estadocomputadora3 <> "Esperando 15 minutos") Or (estadocomputadora3 <> "Esperando tecnico")) Or ((estadocomputadora4 <> "Esperando 15 minutos") Or (estadocomputadora4 <> "Esperando tecnico")) Or ((estadocomputadora5 <> "Esperando 15 minutos") Or (estadocomputadora5 <> "Esperando tecnico"))) Then
                    rnd_tipo_arreglo = Math.Round(RND.NextDouble, 2)

                    Select Case rnd_tipo_arreglo
                        Case 0 To 0.29
                            tipo = "A"
                            tipo_nombre = "Cambio de placa"
                            rnd_atencion1 = Math.Round(RND.NextDouble, 2)
                            tiempo_atencion1 = ((rnd_atencion1 * (b_placa.Text - a_placa.Text)) + a_placa.Text)
                            fin_atencion1 = N + tiempo_atencion1
                        Case 0.3 To 0.54
                            tipo = "B"
                            tipo_nombre = "Ampliacion de memoria"
                            rnd_atencion1 = Math.Round(RND.NextDouble, 2)
                            tiempo_atencion1 = ((rnd_atencion1 * (b_ampliacion.Text - a_ampliacion.Text)) + a_ampliacion.Text)
                            fin_atencion1 = N + tiempo_atencion1
                        Case 0.55 To 0.69
                            tipo = "C"
                            tipo_nombre = "Formateo de disco"
                            rnd_atencion1 = Math.Round(RND.NextDouble, 2)
                            tiempo_atencion1 = ((rnd_atencion1 * (b_formateo.Text - a_formateo.Text)) + a_formateo.Text)
                            fin_atencion1 = N + tiempo_atencion1
                            fin_15c1 = N + 15
                            finespera_15c1 = fin_atencion1 - 15
                        Case 0.7 To 0.79
                            tipo = "D"
                            tipo_nombre = "Agregar CD o DVD"
                            rnd_atencion1 = Math.Round(RND.NextDouble, 2)
                            tiempo_atencion1 = ((rnd_atencion1 * (b_agregar.Text - a_agregar.Text)) + a_agregar.Text)
                            fin_atencion1 = N + tiempo_atencion1
                        Case 0.8 To 1
                            tipo = "E"
                            tipo_nombre = "Cambio de memoria"
                            rnd_atencion1 = Math.Round(RND.NextDouble, 2)
                            tiempo_atencion1 = ((rnd_atencion1 * (b_cambio.Text - a_cambio.Text)) + a_cambio.Text)
                            fin_atencion1 = N + tiempo_atencion1
                    End Select
                    cola -= 1
                    estado_tec1 = "Ocupado"

                    If estadocomputadora5 = "Esperando atencion" Then
                        estadocomputadora5 = "Siendo reparada 1"
                        FinAtC5 = fin_atencion1
                    ElseIf estadocomputadora2 = "Esperando atencion" Then
                        estadocomputadora2 = "Siendo reparada 1"
                        finAtC2 = fin_atencion1
                    ElseIf estadocomputadora3 = "Esperando atencion" Then
                        estadocomputadora3 = "Siendo reparada 1"
                        FinAtC3 = fin_atencion1
                    ElseIf estadocomputadora4 = "Esperando atencion" Then
                        estadocomputadora4 = "Siendo reparada 1"
                        FinAtC4 = fin_atencion1
                    ElseIf estadocomputadora = "Esperando atencion" Then
                        estadocomputadora = "Siendo reparada 1"
                        FinAtC1 = fin_atencion1
                    End If


                Else
                    acum_tiempo_atencion += (N - tiempo_inicio_atencion1)


                End If
                If N >= txt_desde.Text Then

                    If i < G Then
                        DataGridView1.Rows.Add(N, evento, "", "", proxima_llegada, rnd_tipo_arreglo, tipo, rnd_atencion1, tiempo_atencion1, fin_atencion1, estado_tec1, tiempo_inicio_atencion1, fin_15c1, finespera_15c1, vbNullString, vbNullString, fin_atencion2, estado_tec2, tiempo_inicio_atencion2, fin_15c2, finespera_15c2, cola, acum_tiempo_atencion, contador_comp, cont_no_atendidas, acum_permanencia, i, estadocomputadora, FinAtC1, estadocomputadora2, finAtC2, estadocomputadora3, FinAtC3, estadocomputadora4, FinAtC4, estadocomputadora5, FinAtC5)
                    End If
                End If
#End Region
#Region "Fin Atencion Tecnico 2"
            ElseIf ((fin_atencion2 < proxima_llegada) Or proxima_llegada = 0) AndAlso ((fin_atencion2 < fin_atencion1) Or fin_atencion1 = 0) AndAlso ((fin_atencion2 < fin_15c1) Or fin_15c1 = 0) AndAlso ((fin_atencion2 < fin_15c2) Or fin_15c2 = 0) AndAlso (fin_atencion2 <> 0) Then
                N = fin_atencion2
                evento = "Fin atención Técnico 2"
                contador_comp += 1
                estado_tec2 = "Libre"
                fin_atencion2 = 0
                fin_15c2 = 0
                finespera_15c2 = 0


                tipo = " "
                rnd_tipo_arreglo = 0
                'ESTADO COMPUTADORA
                If estadocomputadora = "Siendo reparada 2" Then
                    estadocomputadora = " "
                    FinAtC1 = 0
                    acum_permanencia += N - tiempo_llegada_c1
                ElseIf estadocomputadora2 = "Siendo reparada 2" Then
                    estadocomputadora2 = " "
                    finAtC2 = 0
                    acum_permanencia += N - tiempo_llegada_c2
                ElseIf estadocomputadora3 = "Siendo reparada 2" Then
                    estadocomputadora3 = " "
                    FinAtC3 = 0
                    acum_permanencia += N - tiempo_llegada_c3
                ElseIf estadocomputadora4 = "Siendo reparada 2" Then
                    estadocomputadora4 = " "
                    FinAtC4 = 0
                    acum_permanencia += N - tiempo_llegada_c4
                ElseIf estadocomputadora5 = "Siendo reparada 2" Then
                    estadocomputadora5 = " "
                    FinAtC5 = 0
                    acum_permanencia += N - tiempo_llegada_c5
                End If


                If cola >= 1 And ((estadocomputadora = "Esperando tecnico") Or (estadocomputadora2 = "Esperando tecnico") Or (estadocomputadora3 = "Esperando tecnico") Or (estadocomputadora4 = "Esperando tecnico") Or (estadocomputadora5 = "Esperando tecnico")) Then

                    If estadocomputadora = "Esperando tecnico" Then
                        estadocomputadora = "Siendo reparada 2"
                        FinAtC1 = N + 15
                        fin_atencion2 = N + 15
                    ElseIf estadocomputadora2 = "Esperando tecnico" Then
                        estadocomputadora2 = "Siendo reparada 2"
                        finAtC2 = N + 15
                        fin_atencion2 = N + 15
                    ElseIf estadocomputadora3 = "Esperando tecnico" Then
                        estadocomputadora3 = "Siendo reparada 2"
                        FinAtC3 = N + 15
                        fin_atencion2 = N + 15
                    ElseIf estadocomputadora4 = "Esperando tecnico" Then
                        estadocomputadora4 = "Siendo reparada 2"
                        FinAtC4 = N + 15
                        fin_atencion2 = N + 15
                    ElseIf estadocomputadora5 = "Esperando tecnico" Then
                        estadocomputadora5 = "Siendo reparada 2"
                        FinAtC5 = N + 15
                        fin_atencion2 = N + 15
                    End If
                    estado_tec2 = "Ocupado"

                ElseIf cola >= 1 And (((estadocomputadora <> "Esperando 15 minutos") Or (estadocomputadora <> "Esperando tecnico")) Or ((estadocomputadora2 <> "Esperando 15 minutos") Or (estadocomputadora2 <> "Esperando tecnico")) Or ((estadocomputadora3 <> "Esperando 15 minutos") Or (estadocomputadora3 <> "Esperando tecnico")) Or ((estadocomputadora4 <> "Esperando 15 minutos") Or (estadocomputadora4 <> "Esperando tecnico")) Or ((estadocomputadora5 <> "Esperando 15 minutos") Or (estadocomputadora5 <> "Esperando tecnico"))) Then
                    rnd_tipo_arreglo = Math.Round(RND.NextDouble, 2)
                    tiempo_inicio_atencion2 = N
                    Select Case rnd_tipo_arreglo
                        Case 0 To 0.29
                            tipo = "A"
                            tipo_nombre = "Cambio de placa"
                            rnd_atencion2 = Math.Round(RND.NextDouble, 2)
                            tiempo_atencion2 = ((rnd_atencion2 * (b_placa.Text - a_placa.Text)) + a_placa.Text)
                            fin_atencion2 = N + tiempo_atencion2
                        Case 0.3 To 0.54
                            tipo = "B"
                            tipo_nombre = "Ampliacion de memoria"
                            rnd_atencion2 = Math.Round(RND.NextDouble, 2)
                            tiempo_atencion2 = ((rnd_atencion2 * (b_ampliacion.Text - a_ampliacion.Text)) + a_ampliacion.Text)
                            fin_atencion2 = N + tiempo_atencion2
                        Case 0.55 To 0.69
                            tipo = "C"
                            tipo_nombre = "Formateo de disco"
                            rnd_atencion2 = Math.Round(RND.NextDouble, 2)
                            tiempo_atencion2 = ((rnd_atencion2 * (b_formateo.Text - a_formateo.Text)) + a_formateo.Text)
                            fin_atencion2 = N + tiempo_atencion2
                            fin_15c2 = N + 15
                            finespera_15c2 = fin_atencion2 - 15
                        Case 0.7 To 0.79
                            tipo = "D"
                            tipo_nombre = "Agregar CD o DVD"
                            rnd_atencion2 = Math.Round(RND.NextDouble, 2)
                            tiempo_atencion2 = ((rnd_atencion2 * (b_agregar.Text - a_agregar.Text)) + a_agregar.Text)
                            fin_atencion2 = N + tiempo_atencion2
                        Case 0.8 To 1
                            tipo = "E"
                            tipo_nombre = "Cambio de memoria"
                            rnd_atencion2 = Math.Round(RND.NextDouble, 2)
                            tiempo_atencion2 = ((rnd_atencion2 * (b_cambio.Text - a_cambio.Text)) + a_cambio.Text)
                            fin_atencion2 = N + tiempo_atencion2
                    End Select

                    cola -= 1
                    estado_tec2 = "Ocupado"
                    If estadocomputadora5 = "Esperando atencion" Then
                        estadocomputadora5 = "Siendo reparada 2"
                        FinAtC5 = fin_atencion2
                    ElseIf estadocomputadora2 = "Esperando atencion" Then
                        estadocomputadora2 = "Siendo reparada 2"
                        finAtC2 = fin_atencion2
                    ElseIf estadocomputadora3 = "Esperando atencion" Then
                        estadocomputadora3 = "Siendo reparada 2"
                        FinAtC3 = fin_atencion2
                    ElseIf estadocomputadora4 = "Esperando atencion" Then
                        estadocomputadora4 = "Siendo reparada 2"
                        FinAtC4 = fin_atencion2
                    ElseIf estadocomputadora = "Esperando atencion" Then
                        estadocomputadora = "Siendo reparada 2"
                        FinAtC1 = fin_atencion2
                    End If


                Else

                    acum_tiempo_atencion += (N - tiempo_inicio_atencion2)

                End If
                If N >= txt_desde.Text Then

                    If i < G Then
                        DataGridView1.Rows.Add(N, evento, "", "", proxima_llegada, rnd_tipo_arreglo, tipo, vbNullString, "", fin_atencion1, estado_tec1, tiempo_inicio_atencion1, fin_15c1, finespera_15c1, rnd_atencion2, tiempo_atencion2, fin_atencion2, estado_tec2, tiempo_inicio_atencion2, fin_15c2, finespera_15c2, cola, acum_tiempo_atencion, contador_comp, cont_no_atendidas, acum_permanencia, i, estadocomputadora, FinAtC1, estadocomputadora2, finAtC2, estadocomputadora3, FinAtC3, estadocomputadora4, FinAtC4, estadocomputadora5, FinAtC5)
                    End If
                End If
#End Region
#Region "Dejar equipo solo"
            ElseIf ((fin_15c1 < proxima_llegada) Or proxima_llegada = 0) AndAlso ((fin_15c1 < fin_atencion1) Or fin_atencion1 = 0) AndAlso ((fin_15c1 < fin_atencion2) Or fin_atencion2 = 0) AndAlso ((fin_15c1 < fin_15c2) Or fin_15c2 = 0) AndAlso (fin_15c1 <> 0) Then
                'acum_tiempo_atencion += fin_15c1 - N
                N = fin_15c1
                fin_15c1 = 0
                evento = "Dejar equipo sólo T1"
                estado_tec1 = "Libre"
                fin_atencion1 = 0

                'Si el arreglo es tipo c, lo arreglo los primeros 15 min y desp dejo el equipo solo
                'ESTADO COMPUTADORA
                If estadocomputadora = "Siendo reparada 1" Then
                    estadocomputadora = "Esperando 15 minutos"
                    FinAtC1 = finespera_15c1
                ElseIf estadocomputadora2 = "Siendo reparada 1" Then
                    estadocomputadora2 = "Esperando 15 minutos"
                    finAtC2 = finespera_15c1
                ElseIf estadocomputadora3 = "Siendo reparada 1" Then
                    estadocomputadora3 = "Esperando 15 minutos"
                    FinAtC3 = finespera_15c1
                ElseIf estadocomputadora4 = "Siendo reparada 1" Then
                    estadocomputadora4 = "Esperando 15 minutos"
                    FinAtC4 = finespera_15c1
                ElseIf estadocomputadora5 = "Siendo reparada 1" Then
                    estadocomputadora5 = "Esperando 15 minutos"
                    FinAtC5 = finespera_15c1
                End If

                If cola >= 1 Then
                    rnd_tipo_arreglo = Math.Round(RND.NextDouble, 2)

                    Select Case rnd_tipo_arreglo
                        Case 0 To 0.29
                            tipo = "A"
                            tipo_nombre = "Cambio de placa"
                            rnd_atencion1 = Math.Round(RND.NextDouble, 2)
                            tiempo_atencion1 = ((rnd_atencion1 * (b_placa.Text - a_placa.Text)) + a_placa.Text)
                            fin_atencion1 = N + tiempo_atencion1
                        Case 0.3 To 0.54
                            tipo = "B"
                            tipo_nombre = "Ampliacion de memoria"
                            rnd_atencion1 = Math.Round(RND.NextDouble, 2)
                            tiempo_atencion1 = ((rnd_atencion1 * (b_ampliacion.Text - a_ampliacion.Text)) + a_ampliacion.Text)
                            fin_atencion1 = N + tiempo_atencion1
                        Case 0.55 To 0.69
                            tipo = "C"
                            tipo_nombre = "Formateo de disco"
                            rnd_atencion1 = Math.Round(RND.NextDouble, 2)
                            tiempo_atencion1 = ((rnd_atencion1 * (b_formateo.Text - a_formateo.Text)) + a_formateo.Text)
                            fin_atencion1 = N + tiempo_atencion1
                            fin_15c1 = N + 15
                            finespera_15c1 = fin_atencion1 - 15
                        Case 0.7 To 0.79
                            tipo = "D"
                            tipo_nombre = "Agregar CD o DVD"
                            rnd_atencion1 = Math.Round(RND.NextDouble, 2)
                            tiempo_atencion1 = ((rnd_atencion1 * (b_agregar.Text - a_agregar.Text)) + a_agregar.Text)
                            fin_atencion1 = N + tiempo_atencion1
                        Case 0.8 To 1
                            tipo = "E"
                            tipo_nombre = "Cambio de memoria"
                            rnd_atencion1 = Math.Round(RND.NextDouble, 2)
                            tiempo_atencion1 = ((rnd_atencion1 * (b_cambio.Text - a_cambio.Text)) + a_cambio.Text)
                            fin_atencion1 = N + tiempo_atencion1
                    End Select
                    cola -= 1

                    estado_tec1 = "Ocupado"
                    If estadocomputadora = "Esperando atencion" Then
                        estadocomputadora = "Siendo reparada 1"
                        FinAtC1 = fin_atencion1
                    ElseIf estadocomputadora2 = "Esperando atencion" Then
                        estadocomputadora2 = "Siendo reparada 1"
                        finAtC2 = fin_atencion1
                    ElseIf estadocomputadora3 = "Esperando atencion" Then
                        estadocomputadora3 = "Siendo reparada 1"
                        FinAtC3 = fin_atencion1
                    ElseIf estadocomputadora4 = "Esperando atencion" Then
                        estadocomputadora4 = "Siendo reparada 1"
                        FinAtC4 = fin_atencion1
                    ElseIf estadocomputadora5 = "Esperando atencion" Then
                        estadocomputadora5 = "Siendo reparada 1"
                        FinAtC5 = fin_atencion1
                    End If
                Else
                    tiempo_inicio_atencion1 = N
                End If
                If N >= txt_desde.Text Then

                    If i < G Then
                        DataGridView1.Rows.Add(N, evento, rnd_llegada, tiempo_entre_llegadas, proxima_llegada, rnd_tipo_arreglo, tipo, rnd_atencion1, tiempo_atencion1, fin_atencion1, estado_tec1, tiempo_inicio_atencion1, fin_15c1, finespera_15c1, vbNullString, vbNullString, fin_atencion2, estado_tec2, tiempo_inicio_atencion2, fin_15c2, finespera_15c2, cola, acum_tiempo_atencion, contador_comp, cont_no_atendidas, acum_permanencia, i, estadocomputadora, FinAtC1, estadocomputadora2, finAtC2, estadocomputadora3, FinAtC3, estadocomputadora4, FinAtC4, estadocomputadora5, FinAtC5)
                    End If
                End If
            ElseIf ((fin_15c2 < proxima_llegada) Or proxima_llegada = 0) AndAlso ((fin_15c2 < fin_atencion1) Or fin_atencion1 = 0) AndAlso ((fin_15c2 < fin_atencion2) Or fin_atencion2 = 0) AndAlso ((fin_15c2 < fin_15c1) Or fin_15c1 = 0) AndAlso (fin_15c2 <> 0) Then
                'acum_tiempo_atencion += N - tiempo_inicio_atencion2
                N = fin_15c2
                fin_15c2 = 0
                evento = "Dejar equipo sólo T2"
                estado_tec2 = "Libre"
                fin_atencion2 = 0
                'Si el arreglo es tipo c, lo arreglo los primeros 15 min y desp dejo el equipo solo
                'ESTADO COMPUTADORA
                If estadocomputadora = "Siendo reparada 2" Then
                    estadocomputadora = "Esperando 15 minutos"
                    FinAtC1 = finespera_15c2
                ElseIf estadocomputadora2 = "Siendo reparada 2" Then
                    estadocomputadora2 = "Esperando 15 minutos"
                    finAtC2 = finespera_15c2
                ElseIf estadocomputadora3 = "Siendo reparada 2" Then
                    estadocomputadora3 = "Esperando 15 minutos"
                    FinAtC3 = finespera_15c2
                ElseIf estadocomputadora4 = "Siendo reparada 2" Then
                    estadocomputadora4 = "Esperando 15 minutos"
                    FinAtC4 = finespera_15c2
                ElseIf estadocomputadora5 = "Siendo reparada 2" Then
                    estadocomputadora5 = "Esperando 15 minutos"
                    FinAtC5 = finespera_15c2
                End If


                If cola >= 1 Then
                    rnd_tipo_arreglo = Math.Round(RND.NextDouble, 2)

                    Select Case rnd_tipo_arreglo
                        Case 0 To 0.29
                            tipo = "A"
                            tipo_nombre = "Cambio de placa"
                            rnd_atencion2 = Math.Round(RND.NextDouble, 2)
                            tiempo_atencion2 = ((rnd_atencion2 * (b_placa.Text - a_placa.Text)) + a_placa.Text)
                            fin_atencion2 = N + tiempo_atencion2
                        Case 0.3 To 0.54
                            tipo = "B"
                            tipo_nombre = "Ampliacion de memoria"
                            rnd_atencion2 = Math.Round(RND.NextDouble, 2)
                            tiempo_atencion2 = ((rnd_atencion2 * (b_ampliacion.Text - a_ampliacion.Text)) + a_ampliacion.Text)
                            fin_atencion2 = N + tiempo_atencion2
                        Case 0.55 To 0.69
                            tipo = "C"
                            tipo_nombre = "Formateo de disco"
                            rnd_atencion2 = Math.Round(RND.NextDouble, 2)
                            tiempo_atencion2 = ((rnd_atencion2 * (b_formateo.Text - a_formateo.Text)) + a_formateo.Text)
                            fin_atencion2 = N + tiempo_atencion2
                            fin_15c2 = N + 15
                            finespera_15c2 = fin_atencion2 - 15
                        Case 0.7 To 0.79
                            tipo = "D"
                            tipo_nombre = "Agregar CD o DVD"
                            rnd_atencion2 = Math.Round(RND.NextDouble, 2)
                            tiempo_atencion2 = ((rnd_atencion2 * (b_agregar.Text - a_agregar.Text)) + a_agregar.Text)
                            fin_atencion2 = N + tiempo_atencion2
                        Case 0.8 To 1
                            tipo = "E"
                            tipo_nombre = "Cambio de memoria"
                            rnd_atencion2 = Math.Round(RND.NextDouble, 2)
                            tiempo_atencion2 = ((rnd_atencion2 * (b_cambio.Text - a_cambio.Text)) + a_cambio.Text)
                            fin_atencion2 = N + tiempo_atencion2
                    End Select
                    cola -= 1
                    estado_tec2 = "Ocupado"

                    If estadocomputadora = "Esperando atencion" Then
                        estadocomputadora = "Siendo reparada 2"
                        FinAtC1 = fin_atencion2
                    ElseIf estadocomputadora2 = "Esperando atencion" Then
                        estadocomputadora2 = "Siendo reparada 2"
                        finAtC2 = fin_atencion2
                    ElseIf estadocomputadora3 = "Esperando atencion" Then
                        estadocomputadora3 = "Siendo reparada 2"
                        FinAtC3 = fin_atencion2
                    ElseIf estadocomputadora4 = "Esperando atencion" Then
                        estadocomputadora4 = "Siendo reparada 2"
                        FinAtC4 = fin_atencion2
                    ElseIf estadocomputadora5 = "Esperando atencion" Then
                        estadocomputadora5 = "Siendo reparada 2"
                        FinAtC5 = fin_atencion2
                    End If
                Else
                    tiempo_inicio_atencion2 = N
                End If
                If N >= txt_desde.Text Then

                    If i < G Then
                        DataGridView1.Rows.Add(N, evento, rnd_llegada, tiempo_entre_llegadas, proxima_llegada, rnd_tipo_arreglo, tipo, rnd_atencion1, tiempo_atencion1, fin_atencion1, estado_tec1, tiempo_inicio_atencion1, fin_15c1, finespera_15c1, vbNullString, vbNullString, fin_atencion2, estado_tec2, tiempo_inicio_atencion2, fin_15c2, finespera_15c2, cola, acum_tiempo_atencion, contador_comp, cont_no_atendidas, acum_permanencia, i, estadocomputadora, FinAtC1, estadocomputadora2, finAtC2, estadocomputadora3, FinAtC3, estadocomputadora4, FinAtC4, estadocomputadora5, FinAtC5)
                    End If
                End If
#End Region


            End If
            ' If N >= txt_desde.Text And i <= cant_iteraciones.Text Then
            '   DataGridView2.Rows.Add(N, evento, rnd_llegada, tiempo_entre_llegadas, proxima_llegada, rnd_tipo_arreglo, tipo, rnd_atencion1, tiempo_atencion1, fin_atencion1, estado_tec1, fin_15c1, finespera_15c1, rnd_atencion2, tiempo_atencion2, fin_atencion2, estado_tec2, fin_15c2, finespera_15c2, cola, acum_tiempo_atencion, contador_comp, cont_no_atendidas, acum_permanencia, i, estadocomputadora, FinAtC1, estadocomputadora2, finAtC2, estadocomputadora3, FinAtC3, estadocomputadora4, FinAtC4, estadocomputadora5, FinAtC5)
            ' End If
            If N >= txt_desde.Text And varboolean = True Then
                G = (i + cant_iteraciones.Text)
                varboolean = False
            End If
        Next

        ' Salida de la simulación
        DataGridView1.Rows.Add(N, evento, rnd_llegada, tiempo_entre_llegadas, proxima_llegada, rnd_tipo_arreglo, tipo, rnd_atencion1, tiempo_atencion1, fin_atencion1, estado_tec1, tiempo_inicio_atencion1, fin_15c1, finespera_15c1, rnd_atencion2, tiempo_atencion2, fin_atencion2, estado_tec2, tiempo_inicio_atencion2, fin_15c2, finespera_15c2, cola, acum_tiempo_atencion, contador_comp, cont_no_atendidas, acum_permanencia, 0, estadocomputadora, FinAtC1, estadocomputadora2, finAtC2, estadocomputadora3, FinAtC3, estadocomputadora4, FinAtC4, estadocomputadora5, FinAtC5)

        prom_permanencia.Text = Math.Round((acum_permanencia) / (contador_comp + cont_no_atendidas), 4)
        cant_no_atendidos.Text = Math.Round(cont_no_atendidas / (contador_comp + cont_no_atendidas) * 100, 4)
        cant_no_atendidos.Text += "%"
        ocupacion_tecnicos.Text = Math.Round(((((acum_tiempo_atencion * 100) / N)) / 2), 4)
        ocupacion_tecnicos.Text += "%"

    End Sub


    Private Sub btn_iniciar_Click(sender As Object, e As EventArgs) Handles btn_iniciar.Click
        DataGridView1.Rows.Clear()
        prom_permanencia.Text = 0
        cant_no_atendidos.Text = 0
        ocupacion_tecnicos.Text = 0
        simular(Iteraciones.Text)


    End Sub

    Private Sub Borrar_Click(sender As Object, e As EventArgs) Handles Borrar.Click

        DataGridView1.Rows.Clear()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        txt_desde.Clear()

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




    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

        Iteraciones.Enabled = True
    End Sub

    Private Sub b_ampliacion_TextChanged(sender As Object, e As EventArgs) Handles b_ampliacion.TextChanged

    End Sub
End Class

