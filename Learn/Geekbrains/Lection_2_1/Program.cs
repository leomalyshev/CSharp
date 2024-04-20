using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (Socket listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                var localEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 12345);

                listener.Blocking = true;

                Console.WriteLine("Сокет привязан " + listener.IsBound);
                listener.Bind(localEndPoint);

                Console.WriteLine("Сокет привязан " + listener.IsBound);
                listener.Listen(100);

                Console.WriteLine("Waiting for connection...");



                while (true)
                {
                    List<Socket> sread = new List<Socket>() { listener };
                    List<Socket> swrite = new List<Socket>() {  };
                    List<Socket> serror = new List<Socket>() {  };

                    Socket.Select(sread, swrite, serror, 100);

                    if (sread.Count > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write(".");
                        Thread.Sleep(500);
                    }
                }



                //while (!listener.Poll(100, SelectMode.SelectRead))
                //{
                //    Console.Write('.');
                //    Thread.Sleep(500);
                //}


                Socket? socket = null;

                do
                {
                    try
                    {
                        //socket = listener.Accept();
                        //socket.LingerState = new LingerOption(true, 1);
                        Task<Socket> task = listener.AcceptAsync();
                        task.Wait();
                        socket = task.Result;

                    }
                    catch
                    {
                        //Console.Write('.');
                        //Thread.Sleep(1000);
                    }
                } while (socket == null);


                Console.WriteLine("Connected!");

                Console.WriteLine($"localEndPoint = {socket.LocalEndPoint}");
                Console.WriteLine($"remoteEndPoint = {socket.RemoteEndPoint}");


                while (socket.Available == 0) ;

                Console.WriteLine("Доступно " + socket.Available + " байт для чтения");
                byte[] buffer = new byte[255];

                //socket.ReceiveTimeout = 5000;

                int count = socket.Receive(buffer);

                if (count > 0)
                {
                    string message = Encoding.UTF8.GetString(buffer);
                    Console.WriteLine(message);
                }
                else
                {
                    Console.WriteLine("Сообщение не получено!");
                }

                listener.Close();
            }
        }
    }
}