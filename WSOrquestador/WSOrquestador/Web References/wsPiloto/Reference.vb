﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

'
'Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
'
Namespace wsPiloto
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="Service1Soap", [Namespace]:="http://tempuri.org/")>  _
    Partial Public Class Service1
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private DiponibilidadOperationCompleted As System.Threading.SendOrPostCallback
        
        Private EnviarCarreraOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.WSOrquestador.My.MySettings.Default.WSOrquestador_wsPiloto_Service1
            If (Me.IsLocalFileSystemWebService(Me.Url) = true) Then
                Me.UseDefaultCredentials = true
                Me.useDefaultCredentialsSetExplicitly = false
            Else
                Me.useDefaultCredentialsSetExplicitly = true
            End If
        End Sub
        
        Public Shadows Property Url() As String
            Get
                Return MyBase.Url
            End Get
            Set
                If (((Me.IsLocalFileSystemWebService(MyBase.Url) = true)  _
                            AndAlso (Me.useDefaultCredentialsSetExplicitly = false))  _
                            AndAlso (Me.IsLocalFileSystemWebService(value) = false)) Then
                    MyBase.UseDefaultCredentials = false
                End If
                MyBase.Url = value
            End Set
        End Property
        
        Public Shadows Property UseDefaultCredentials() As Boolean
            Get
                Return MyBase.UseDefaultCredentials
            End Get
            Set
                MyBase.UseDefaultCredentials = value
                Me.useDefaultCredentialsSetExplicitly = true
            End Set
        End Property
        
        '''<remarks/>
        Public Event DiponibilidadCompleted As DiponibilidadCompletedEventHandler
        
        '''<remarks/>
        Public Event EnviarCarreraCompleted As EnviarCarreraCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Diponibilidad", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function Diponibilidad(ByVal piloto As String) As String
            Dim results() As Object = Me.Invoke("Diponibilidad", New Object() {piloto})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub DiponibilidadAsync(ByVal piloto As String)
            Me.DiponibilidadAsync(piloto, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub DiponibilidadAsync(ByVal piloto As String, ByVal userState As Object)
            If (Me.DiponibilidadOperationCompleted Is Nothing) Then
                Me.DiponibilidadOperationCompleted = AddressOf Me.OnDiponibilidadOperationCompleted
            End If
            Me.InvokeAsync("Diponibilidad", New Object() {piloto}, Me.DiponibilidadOperationCompleted, userState)
        End Sub
        
        Private Sub OnDiponibilidadOperationCompleted(ByVal arg As Object)
            If (Not (Me.DiponibilidadCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent DiponibilidadCompleted(Me, New DiponibilidadCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/EnviarCarrera", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function EnviarCarrera(ByVal piloto As String, ByVal Cliente As String, ByVal Direccion As String) As String
            Dim results() As Object = Me.Invoke("EnviarCarrera", New Object() {piloto, Cliente, Direccion})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub EnviarCarreraAsync(ByVal piloto As String, ByVal Cliente As String, ByVal Direccion As String)
            Me.EnviarCarreraAsync(piloto, Cliente, Direccion, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub EnviarCarreraAsync(ByVal piloto As String, ByVal Cliente As String, ByVal Direccion As String, ByVal userState As Object)
            If (Me.EnviarCarreraOperationCompleted Is Nothing) Then
                Me.EnviarCarreraOperationCompleted = AddressOf Me.OnEnviarCarreraOperationCompleted
            End If
            Me.InvokeAsync("EnviarCarrera", New Object() {piloto, Cliente, Direccion}, Me.EnviarCarreraOperationCompleted, userState)
        End Sub
        
        Private Sub OnEnviarCarreraOperationCompleted(ByVal arg As Object)
            If (Not (Me.EnviarCarreraCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent EnviarCarreraCompleted(Me, New EnviarCarreraCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
        
        Private Function IsLocalFileSystemWebService(ByVal url As String) As Boolean
            If ((url Is Nothing)  _
                        OrElse (url Is String.Empty)) Then
                Return false
            End If
            Dim wsUri As System.Uri = New System.Uri(url)
            If ((wsUri.Port >= 1024)  _
                        AndAlso (String.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) = 0)) Then
                Return true
            End If
            Return false
        End Function
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")>  _
    Public Delegate Sub DiponibilidadCompletedEventHandler(ByVal sender As Object, ByVal e As DiponibilidadCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class DiponibilidadCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")>  _
    Public Delegate Sub EnviarCarreraCompletedEventHandler(ByVal sender As Object, ByVal e As EnviarCarreraCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class EnviarCarreraCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
End Namespace
