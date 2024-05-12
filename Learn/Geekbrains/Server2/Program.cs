using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices.JavaScript;
using System.Text;

namespace Server2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listener = new TcpListener(IPAddress.Any, 12345);

            listener.Start();

            using (TcpClient client = listener.AcceptTcpClient())
            {
                Console.WriteLine("Connected");
                var reader = new StreamReader(client.GetStream());
                var writer = new StreamWriter(client.GetStream());
                var s = reader.ReadLine();
                Console.WriteLine(s);

                var r = new string(s.Reverse().ToArray());

                writer.WriteLine(r);

                writer.Flush();
            }
        }
    }
}