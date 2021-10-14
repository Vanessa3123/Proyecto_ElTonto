Public Class Llamar_TXT

    Public Shared Sub llamarescritura(ByVal ruta As String, ByVal strAutor As String, ByVal strAutor2 As String, ByVal strAutor3 As String, ByVal dtFecha As Date, ByVal dmlVersion As Decimal,
       ByVal strInformacion As String)
        Dim obj As New Datos.ClaseEscrituraTXT
        obj.GeneraArchivo(ruta, strAutor, strAutor2, strAutor3, dtFecha, dmlVersion, strInformacion)
    End Sub

    Public Shared Sub llamarescrituraagregar(ByVal ruta As String, ByVal strAutor As String, ByVal strAutor2 As String, ByVal strAutor3 As String, ByVal dtFecha As Date, ByVal dmlVersion As Decimal,
       ByVal strInformacion As String)
        Dim obj As New Datos.ClaseEscrituraTXT

        obj.GeneraArchivoagregar(ruta, strAutor, strAutor2, strAutor3, dtFecha, dmlVersion, strInformacion)
    End Sub
End Class
