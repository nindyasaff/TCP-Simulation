using System;

namespace _4210191025_tcp_simulation
{
    class Client
    {
        Console.WriteLine("Enter the server IP address: ");
        string serverIp = Console.ReadLine();
        Console.WriteLine("Enter the server Port number: ");
        int serverPort = int.Parse(Console.ReadLine());

        // Create the endpoint for the server
        IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(serverIp), serverPort);
        // Create a TCP socket to send data over
        Socket sendSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
 
        try{

            // Connect to the server
            sendSocket.Connect(endPoint);
            // Start looping for multiple messages
            
            while (true){
            Console.WriteLine("Enter the message to send: ");
            string message = Console.ReadLine() + "\n";
 
                if (message.Equals("EXIT\n")){
                // Close socket connection to the server
                sendSocket.Close();
                break;
            }

            else{
                // Convert the string message to a byte array with ASCII encoding
                byte[] sendMessage = Encoding.ASCII.GetBytes(message);
    // Send the data to the server over the TCP socket
    sendSocket.SendTo(sendMessage, endPoint);
            }
        }
    
        Console.WriteLine("Client shutting down.");
    }


        catch (Exception e)
{
    Console.WriteLine(e.ToString());
}
