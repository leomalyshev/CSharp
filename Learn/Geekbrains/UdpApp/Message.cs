using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;

namespace UdpApp
{
    public class Message
    {
        public string Text { get; set; }
        public DateTime DateTime { get; set; }
        public string NicknameFrom { get; set; }
        public string NicknameTo { get; set; }

        public string SerialiseMessageToJson()
        {
            return JsonSerializer.Serialize(this);
        }

        public static Message? DeserializeFromJson(string message)
        {
            return JsonSerializer.Deserialize<Message>(message);
        }


        public void Print()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString() => $"{this.DateTime} получено сообщение {this.Text} от {this.NicknameFrom}";
    }
}