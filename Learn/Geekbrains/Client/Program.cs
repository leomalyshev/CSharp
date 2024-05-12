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
                var remotEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 12345);

                var localEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 12346);

                Console.WriteLine("Connecting...");

                client.Bind(localEndPoint);

                try
                {
                    client.Connect(remotEndPoint);
                }
                catch (SocketException ex)
                {
                    Console.WriteLine($"ErrorCode {ex.ErrorCode}, message = {ex.Message}");
                }

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

                byte[] bytes = Encoding.UTF8.GetBytes("Привет");

                //Console.WriteLine("Нажмите клавишу для отправки...");
                //Console.ReadKey();

                //client.SendTimeout = 100;

                int count = client.Send(bytes);

                if (count == bytes.Length)
                {
                    Console.WriteLine("Отправлено");
                }
                else
                {
                    Console.WriteLine("Что-то пошло не так");
                }
            }
        }
    }
}