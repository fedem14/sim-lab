Public Class RandomTest
    Dim i As Integer = -1
'Modificar el arreglo segun se precise para la prueba
Dim aleatorios() As Double = {0.20,0.76,0.3,0.17,0.12,0.89,0.99,0.23,0.57,0.77,0.17,0.48,0.18,0.99,0.89,0.99,0.13,0.3,0.57} 
    
Public Function NextDouble() As Double
    i=i+1
    'Si se acaban los randoms en el arreglo,vuelve a empezar
    If (i > aleatorios.Length - 1) Then
        i=0
    End If
     
    Return aleatorios(i) 
         
 End Function                       

End Class
