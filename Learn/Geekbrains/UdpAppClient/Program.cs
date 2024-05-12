using System.Net;
using System.Net.Sockets;
using System.Text;
using UdpApp;

namespace UdpAppClient
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SentMessage(args[0], args[1]);
        }

        public static void SentMessage(string From, string ip)
        {
            UdpClient updClient = new UdpClient();

            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(ip), 12345);


            string messageText;
            do
            {
                Console.Clear();
                Console.WriteLine("Введите сообщение.");
                messageText = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(messageText));


            Message message = new Message()
                { Text = messageText, NicknameFrom = From, NicknameTo = "Server", DateTime = DateTime.Now };

            string json = message.SerialiseMessageToJson();

            var data = Encoding.UTF8.GetBytes(json);
            updClient.Send(data, data.Length, ep);

            byte[] buffer = updClient.Receive(ref ep);
            string answer = Encoding.UTF8.GetString(buffer);

            Console.WriteLine(answer);
        }
    }
}