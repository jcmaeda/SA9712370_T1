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
    


    <WebMethod()> _
    Public Function Diponibilidad(ByVal piloto As String) As String
        'Metodo que verifica la disponiblidad del piloto para atender una carrera
        Dim pilotolibre As String = "Libre"
        Dim matriz(5, 2) As String
        Dim Disponiblidad(5, 2) As Integer

        'Matriz simulando una base de dato sen la que se guarda el nombre, id y estadus del piloto
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

        Disponiblidad(0, 1) = 1
        Disponiblidad(0, 2) = 0
        Disponiblidad(1, 1) = 2
        Disponiblidad(1, 2) = 1
        Disponiblidad(2, 1) = 3
        Disponiblidad(2, 2) = 0
        Disponiblidad(3, 1) = 4
        Disponiblidad(3, 2) = 1
        Disponiblidad(4, 1) = 5
        Disponiblidad(4, 2) = 1


        For ctr As Integer = 0 To 4
            If matriz(ctr, 2) = piloto Then
                If Disponiblidad(ctr, 2) = 1 Then
                    pilotolibre = "Ocupado"
                End If
                ctr = 4
            End If
        Next

        Return pilotolibre
    End Function


    <WebMethod()> _
    Public Function EnviarCarrera(ByVal piloto As String, ByVal Cliente As String, ByVal Direccion As String) As String
        'Esta funcion envia la carrera al taxista y le indica quien es el cliente y la direccion a donde lo debe recibir
        'este metodo se puede ampliar y que el taxista lo acepte o rechace, en este caso para temas de la tarea si esta
        'ocupado el taxista rechaza la carrera, si est alibre la acepta y el ruteador informa al cliente si la carrera fue 
        'aceptada.

        Dim Aceptada As String = "Aceptada"
        Dim matriz(5, 2) As String
        Dim Disponiblidad(5, 2) As Integer

        'Matriz simulando una base de dato sen la que se guarda el nombre, id y estadus del piloto
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

        Disponiblidad(0, 1) = 1
        Disponiblidad(0, 2) = 0
        Disponiblidad(1, 1) = 2
        Disponiblidad(1, 2) = 1
        Disponiblidad(2, 1) = 3
        Disponiblidad(2, 2) = 0
        Disponiblidad(3, 1) = 4
        Disponiblidad(3, 2) = 1
        Disponiblidad(4, 1) = 5
        Disponiblidad(4, 2) = 1

        For ctr As Integer = 0 To 4
            If matriz(ctr, 2) = piloto Then
                If Disponiblidad(ctr, 2) = 1 Then
                    Aceptada = "Rechazada"
                End If
                ctr = 4
            End If
        Next


        Return Aceptada
    End Function

End Class