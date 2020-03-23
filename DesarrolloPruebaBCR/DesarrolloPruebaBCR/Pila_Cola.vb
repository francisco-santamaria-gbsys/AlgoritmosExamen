Public Class Pila_Cola
    Class Pila(Of T)
        Public Value As Double
        Public RightNode As Pila(Of T)
    End Class

    Public Sub InsertarPila(ByRef item As Pila(Of Integer), valor As Integer)
        If (item Is Nothing) Then
            item = New Pila(Of Integer)()
            item.Value = valor
            item.RightNode = Nothing
        Else
            Dim oux = New Pila(Of Integer)()
            oux.Value = valor
            oux.RightNode = item
            item = oux
        End If
    End Sub

    Public Sub RecorrerPila(pila As Pila(Of Integer))
        If (pila IsNot Nothing) Then
            Console.Write(pila.Value)
            RecorrerPila(pila.RightNode)
        End If
    End Sub
End Class
