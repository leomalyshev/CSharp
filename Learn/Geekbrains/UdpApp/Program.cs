using System.Net.Sockets;
using System.Net;
using System.Net.Security;
using System.Text;

namespace UdpApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Server("Hello");
        }

        public void task1()
        {
            Message msg = new Message() { Text = "Hello", DateTime = DateTime.Now, NicknameFrom = "Leonid" };

            string json = msg.SerialiseMessageToJson();
            Console.WriteLine(json);
            Message? msgDeserialized = Message.DeserializeFromJson(json);
        }


        public static void Server(string name)
        {
            UdpClient client = new UdpClient(12345);
            IPEndPoint ep = new IPEndPoint(IPAddress.Any, 0);

            Console.WriteLine("Сервер ждет сообщения от клиента");



            while (true)
            {
                byte[] buffer = client.Receive(ref ep);
                string message = Encoding.UTF8.GetString(buffer);
                Console.WriteLine("Сообщение получено");

                ThreadPool.QueueUserWorkItem(obj =>
                {
                    Message? msg = Message.DeserializeFromJson(message);
                    msg.Print();

                    byte[] reply = "Сообщение доставлено"u8.ToArray();
                    client.Send(reply, reply.Length, ep);
                });
            }
        }
    }
}