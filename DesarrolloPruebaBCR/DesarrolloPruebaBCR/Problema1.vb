Public Class Problema1
    Class TreeNode(Of T)
        Public Value As Double
        Public LeftNode As TreeNode(Of T)
        Public RightNode As TreeNode(Of T)
    End Class

    Class Pila(Of T)
        Public Value As Double
        Public RightNode As Pila(Of T)
    End Class
    'metodo que se debe llamar para el ejercicio problema 1
    Sub OrdenarArreglo(arreglo As Integer())
        Dim newTree As New TreeNode(Of Integer)
        Dim arbol As TreeNode(Of Integer)
        For i = 0 To arreglo.Length - 1
            newTree.Value = arreglo(i)
            Insertar(arbol, newTree)
        Next
        Dim pilaTemp As Pila(Of Integer)
        Console.Write("Al Obtener Hojas=>")
        ObtenerHojas(arbol, pilaTemp)
        Console.Write(" Recorrido de pila=>")
        RecorrerPila(pilaTemp)
    End Sub

    Public Sub Insertar(ByRef item As TreeNode(Of Integer), valor As TreeNode(Of Integer))
        If (item Is Nothing) Then
            item = New TreeNode(Of Integer)()
            item.Value = valor.Value
            item.RightNode = Nothing
            item.LeftNode = Nothing
        ElseIf (Integer.Parse(item.Value.ToString(),
                              System.Globalization.NumberStyles.HexNumber) < Integer.Parse(valor.Value.ToString(),
                                                                                           System.Globalization.NumberStyles.HexNumber)) Then
            Insertar(item.RightNode, valor)
        Else
            Insertar(item.LeftNode, valor)
        End If
    End Sub

    Public Sub ObtenerHojas(raiz As TreeNode(Of Integer), ByRef pila As Pila(Of Integer))
        If (raiz IsNot Nothing) Then
            ObtenerHojas(raiz.LeftNode, pila)
            ObtenerHojas(raiz.RightNode, pila)
            If (raiz.LeftNode Is Nothing And raiz.RightNode Is Nothing) Then
                InsertarPila(pila, raiz.Value)
                Console.Write("*")
                Console.Write(raiz.Value)
                Console.Write("*")
            End If
        End If
    End Sub

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
            Console.Write("|")
            Console.Write(pila.Value)
            Console.Write("|")
            RecorrerPila(pila.RightNode)
        End If
    End Sub

End Class
