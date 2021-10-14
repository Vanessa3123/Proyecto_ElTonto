Imports System.IO
Public Class ArchivosTxt
    Public Function LeerArchivoPorLineas(ByVal RutaArchivo As String) As ArrayList
        Try
            Dim strDatos As New ArrayList

            'Lectura del archivo indicado
            Dim strContenidoTexto As New StreamReader(RutaArchivo, System.Text.Encoding.UTF8)

            'Recorre linea a línea los datos que estan almacenados en el archivo 
            While strContenidoTexto.Peek >= 0
                'Lee la información contenida en la línea
                Dim strAcerca_de As String = strContenidoTexto.ReadLine

                'Agrega la información al cliente en el arreglo de salida
                strDatos.Add(strAcerca_de)

            End While

            Return strDatos
        Catch ex As Exception
            Throw ex
        End Try

    End Function



End Class
