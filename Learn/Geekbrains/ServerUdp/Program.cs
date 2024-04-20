using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ServerUdp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp))
            {
                var localEndPoint = new IPEndPoint(IPAddress.Parse("0.0.0.0"), 1234);
                socket.Bind(localEndPoint);

                byte[] buffer = new byte[1];

                int count = 0;

                while (count < 200)
                {
                    EndPoint endPoint = new IPEndPoint(IPAddress.Any, 0);
                    int c = socket.ReceiveFrom(buffer, ref endPoint);

                    if (c == 1)
                    {
                        var buffOut = new byte[1] { (byte)(buffer[0] * 2) };

                        try
                        {
                            socket.SendTo(buffOut, endPoint);
                        }
                        catch { }
                        

                        //if ((endPoint as IPEndPoint)?.Port == 2235)
                        //{
                        //    Console.Write(buffer[0]);
                        //}


                    }
                    count += c;

                }

                Console.WriteLine("\nПрочитали 200 байт");
            }
        }
    }
}