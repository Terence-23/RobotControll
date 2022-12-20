using UnityEngine;
using System.Collections;
using System.Net;
using System.Net.Sockets;

public class ClickSender : MonoBehaviour
{
    // Static variable to store the IP address and port
    public static string ipAddress = "127.0.0.1";
    public static int port = 8080;

    void Start()
    {
        // Add an OnMouseDown event to the GameObject
        // this.gameObject.AddComponent<BoxCollider>().isTrigger = true;
        // this.gameObject.AddComponent<MouseDown>().onMouseDown.AddListener(SendName);
    }

    public void SendName()
    {
        // Send the name of the GameObject to the specified IP address and port
        string message = this.gameObject.name;
        byte[] data = System.Text.Encoding.ASCII.GetBytes(message);
        IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(ipAddress), port);

        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        socket.Connect(endPoint);
        socket.Send(data);
        socket.Close();
    }
}
