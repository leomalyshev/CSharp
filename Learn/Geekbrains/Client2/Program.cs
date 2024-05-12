using System.Net.Sockets;
using System.Net;
using System.Text;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {

                var addresses = Dns.GetHostAddresses("yandex.ru");

                Console.WriteLine("Адреса:");
                foreach (var a in addresses)
                {
                    Console.WriteLine(a);
                }

                try
                {
                    client.Connect(addresses, 80);
                }
                catch { }

                if (client.Connected)
                {
                    Console.WriteLine("Connected!");
                    Console.WriteLine($"localEndPoint = {client.LocalEndPoint}");
                    Console.WriteLine($"remoteEndPoint = {client.RemoteEndPoint}");
                }
                else
                {
                    Console.WriteLine("Connection problem");
                    return;
                }

            }
        }
    }
}