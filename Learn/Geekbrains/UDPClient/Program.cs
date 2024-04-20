using System.Net;
using System.Net.Sockets;

namespace UDPClient
{
    internal class Program
    {
        private static IPEndPoint ep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);

        static void Receiver()
        {
            using (var client = new UdpClient(1234))
            {
                var lp = new IPEndPoint(IPAddress.Any, 1234);

                int cnt = 0;

                while (cnt < 9_000)
                {
                    var recv = client.Receive(ref lp);

                    foreach (var x in recv)
                    {
                        Console.Write(x + " ");
                    }

                    cnt += recv.Length;
                }
                Console.WriteLine("End");
            }
        }

        static void UdpSender(byte b)
        {
            using (var client = new UdpClient())
            {
                client.Connect(ep);

                for (int i = 0; i < 3000; i++)
                {
                    client.Send(new byte[] { b });
                }
            }
        }

        static void Main(string[] args)
        {
            new Thread(Receiver).Start();

            for (int i = 0; i < 3; i++)
            {
                byte t = (byte)i;

                new Thread(() => { UdpSender(t); }).Start();
            }
        }
    }
}