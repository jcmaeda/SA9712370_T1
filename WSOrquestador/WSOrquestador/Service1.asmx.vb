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

    'Logica del ESB se ve como un balanceador que recibe parametros para hacer la busqueda de servicio
    'Se hace referencia a 3 servicios el de CLiente, Pilotos y la Ubicacion
    'De momento no se hace llamado a base de datos solamente se valida la gestion del balanceador

    <WebMethod()> _
    Public Function balanceador(ByVal parametros As String, ByVal parametro2 As String, ByVal parametro3 As String) As String
        'Recibe 3 parametros
        ' EL primer parametro indica que tipo de servicio se desea consumir
        ' El Segundo parametro es variable, segun el tipo de servicio
        ' el parametro tres lleva el nombre del piloto o cliente
        Dim resultado As String = ""
        'Verifica dispobilidad del pilogo solamente es necesario el parametro 1 y el 3 para enviar el nombre del piloto
        If parametros = "Piloto" Then
            Dim wstest As New wsPiloto.Service1()
            resultado = wstest.Diponibilidad(parametro3)
        End If

        If parametros = "Rastreo" Then
            Dim wsRastreo As New wsUbicacion.Service1()
            If parametro2 = "Piloto" Or parametro2 = "piloto" Then
                resultado = wsRastreo.UbicacionPiloto(parametro3)
            Else
                resultado = wsRastreo.UbicacionCliente(parametro3)
            End If
        End If

        If parametros = "Solicitar Servicio" Then
            Dim wsCLiente As New wsCliente.Service1()
            Dim wsPiloto As New wsPiloto.Service1()
            Dim wsrastreo As New wsUbicacion.Service1()
            resultado = wsCLiente.SolicitarServicio()

            If resultado = "Creando Servicio" Then
                Dim direccionCarrera As String = wsrastreo.UbicacionCliente(parametro2)
                resultado = wsPiloto.Diponibilidad(parametro3)
                If resultado = "Libre" Then
                    If wsPiloto.EnviarCarrera(parametro3, parametro2, direccionCarrera) = "Aceptada" Then
                        resultado = "Sr(a) " + parametro2 + " su Servicio a sido solicitado, el piloto " + parametro3 + " Esta libre su ubicacion es: " + wsrastreo.UbicacionPiloto(parametro3) + " Pronto llegara a recogerlo a la direccion " + direccionCarrera
                    End If
                End If
            End If
        End If


        Return resultado
    End Function

End Class