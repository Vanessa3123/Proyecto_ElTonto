Public Class ClaseJugador
    Dim nombre As String
    Dim punto As Integer


    Public Property Nombres As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property Puntos As Integer
        Get
            Return Puntos
        End Get
        Set(value As Integer)
            punto = value
        End Set
    End Property

End Class
