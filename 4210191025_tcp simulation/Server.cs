using System;

public class Class1
{
    class Server
    {
        // Create the TCP listener that will accept incoming connection requests
        TcpListener listener = new TcpListener(IPAddress.Parse(GetIpAddress()), 6000);
        // Start listening
        listener.Start();
        Console.WriteLine("Server listening on " + listener.LocalEndpoint);
 
        // Create the server socket that will connect to the client
        Socket socket = listener.AcceptSocket();
        // Create a byte array to hold the incoming data
        byte[] receivedBytes = new byte[1500];
 
        try{
        while (true){
        // Receive the incoming byte array over the server socket
        int receivedSize = socket.Receive(receivedBytes);
 
        for(int i=0; i&lt;receivedSize; i++){
        // Print each character to the console window
        Console.Write(Convert.ToChar(receivedBytes[i]));
        }
}
        }
    catch (Exception e)
{
    Console.WriteLine(e.ToString());
}


