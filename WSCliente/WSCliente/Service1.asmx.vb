Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

' Para permitir que se llame a este servicio Web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class Service1
    Inherits System.Web.Services.WebService

    'Metodo para solicitar el servicio y enviar el estatus del cliente
    <WebMethod()> _
    Public Function SolicitarServicio(ByVal cliente As String) As String
        Dim matriz(5, 2) As String
        Dim Disponiblidad(5, 2) As String
        Dim idcliente As Integer
        Dim estado As String = "No definido"

        matriz(0, 1) = "1"
        matriz(0, 2) = "Miriam Mejia"
        matriz(1, 1) = "2"
        matriz(1, 2) = "Brenda Real"
        matriz(2, 1) = "3"
        matriz(2, 2) = "Luis Velasquez"
        matriz(3, 1) = "4"
        matriz(3, 2) = "Hugo Huard"
        matriz(4, 1) = "5"
        matriz(4, 2) = "Roberto Zahabedra"

        Disponiblidad(0, 1) = "1"
        Disponiblidad(0, 2) = "Solicitando"
        Disponiblidad(1, 1) = "2"
        Disponiblidad(1, 2) = "Esperando"
        Disponiblidad(2, 1) = "3"
        Disponiblidad(2, 2) = "Esperando"
        Disponiblidad(3, 1) = "4"
        Disponiblidad(3, 2) = "Llegando"
        Disponiblidad(4, 1) = "5"
        Disponiblidad(4, 2) = "Llegando"

        For ctr As Integer = 0 To 4
            If matriz(ctr, 2) = cliente Then
                idcliente = matriz(ctr, 1)
                If Disponiblidad(ctr, 1) = idcliente Then
                    estado = Disponiblidad(ctr, 2)
                End If
                ctr = 4
            End If
        Next

        Return estado
    End Function
End Class