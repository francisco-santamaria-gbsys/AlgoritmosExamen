Public Class AlgArbol
    Class TreeNode(Of T)
        Public Value As Double
        Public LeftNode As TreeNode(Of T)
        Public RightNode As TreeNode(Of T)
    End Class

    Sub OrdenarArreglo(arreglo As Integer())
        Dim newTree As New TreeNode(Of Integer)
        Dim arbol As TreeNode(Of Integer)
        For i = 0 To arreglo.Length - 1
            newTree.Value = arreglo(i)
            Insertar(arbol, newTree)
        Next
        PostOrden(arbol)
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

    Public Sub PreOrden(raiz As TreeNode(Of Integer))
        If (raiz IsNot Nothing) Then
            Console.Write(raiz.Value)
            Console.Write(" | ")
            PreOrden(raiz.LeftNode)
            PreOrden(raiz.RightNode)

        End If
    End Sub
    Public Sub InOrden(raiz As TreeNode(Of Integer))
        If (raiz IsNot Nothing) Then
            InOrden(raiz.LeftNode)
            Console.Write(raiz.Value)
            Console.Write(" | ")
            InOrden(raiz.RightNode)
        End If
    End Sub

    Public Sub PostOrden(raiz As TreeNode(Of Integer))
        If (raiz IsNot Nothing) Then
            PostOrden(raiz.LeftNode)
            PostOrden(raiz.RightNode)
            Console.Write(raiz.Value)
            Console.Write(" | ")
        End If
    End Sub

    Public Sub ObtenerHojas(raiz As TreeNode(Of Integer))
        If (raiz IsNot Nothing) Then
            ObtenerHojas(raiz.LeftNode)
            ObtenerHojas(raiz.RightNode)
            If (raiz.LeftNode Is Nothing And raiz.RightNode Is Nothing) Then
                Console.Write("*")
                Console.Write(raiz.Value)
                Console.Write("*")
            End If
        End If
    End Sub
End Class
