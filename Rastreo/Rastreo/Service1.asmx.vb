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
    Dim direccion As String = ""
    'Este servicio permite solicitar la ubicacion de un cliente o piloto y devolverla para saber o poder estimar el tiempo de llegada
    ' y le sirve a los pilots para saber el destino a donde se dirigen los clientes y aceptar o rechazar la carrera
    <WebMethod()> _
    Public Function UbicacionPiloto(ByVal piloto As String) As String
        Dim matriz(5, 2) As String
        Dim Disponiblidad(5, 2) As String
        Dim idpiloto As String
        'Matriz que simula la informacion de los pilotos

        matriz(0, 1) = "1"
        matriz(0, 2) = "Juan Carlos Maeda"
        matriz(1, 1) = "2"
        matriz(1, 2) = "Pablo Andres Maeda"
        matriz(2, 1) = "3"
        matriz(2, 2) = "Maria Vianey Maeda"
        matriz(3, 1) = "4"
        matriz(3, 2) = "Juan Pablo Maeda"
        matriz(4, 1) = "5"
        matriz(4, 2) = "Angel Maeda"

        Disponiblidad(0, 1) = "1"
        Disponiblidad(0, 2) = "5ta Avenida 8-95 zona 12"
        Disponiblidad(1, 1) = "2"
        Disponiblidad(1, 2) = "Edificio Plaza las conchas zona 14"
        Disponiblidad(2, 1) = "3"
        Disponiblidad(2, 2) = "Edificio Reforma Montufar zona 10"
        Disponiblidad(3, 1) = "4"
        Disponiblidad(3, 2) = "zona 4 de mixco"
        Disponiblidad(4, 1) = "5"
        Disponiblidad(4, 2) = "Plaza central zona 1"


        For ctr As Integer = 0 To 4
            If matriz(ctr, 2) = piloto Then
                idpiloto = matriz(ctr, 1)
                If Disponiblidad(ctr, 1) = idpiloto Then
                    direccion = Disponiblidad(ctr, 2)
                End If
                ctr = 4
            End If
        Next

        Return direccion
    End Function

    <WebMethod()> _
    Public Function UbicacionCliente(ByVal cliente As String) As String
        Dim matriz(5, 2) As String
        Dim Disponiblidad(5, 2) As String
        Dim idcliente As Integer

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
        Disponiblidad(0, 2) = "5ta Avenida 8-95 zona 12"
        Disponiblidad(1, 1) = "2"
        Disponiblidad(1, 2) = "6ta avenida 8-98 zona 13"
        Disponiblidad(2, 1) = "3"
        Disponiblidad(2, 2) = "Calle 5 7-90 zona 10"
        Disponiblidad(3, 1) = "4"
        Disponiblidad(3, 2) = "zona 4 de San Cristobal"
        Disponiblidad(4, 1) = "5"
        Disponiblidad(4, 2) = "Plaza central zona 1"

        For ctr As Integer = 0 To 4
            If matriz(ctr, 2) = cliente Then
                idcliente = matriz(ctr, 1)
                If Disponiblidad(ctr, 1) = idcliente Then
                    direccion = Disponiblidad(ctr, 2)
                End If
                ctr = 4
            End If
        Next


        Return direccion
    End Function


End Class