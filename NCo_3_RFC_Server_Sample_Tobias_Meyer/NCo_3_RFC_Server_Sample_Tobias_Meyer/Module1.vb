Imports SAP.Middleware.Connector
Imports System.Threading

Module Module1

    Sub Main()
        Dim RemoteServer As RfcServer
        RemoteServer = RfcServerManager.GetServer("DINOZZO", New Type(0) {GetType(ServerFunction)})
        RemoteServer.Start()
        Thread.Sleep(400000)
    End Sub
End Module