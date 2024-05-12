using System.Collections.Concurrent;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace Seminar_2_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string ya = "yandex.ru";

            IPAddress[] ipAddress = Dns.GetHostAddresses(ya, AddressFamily.InterNetwork);

            //foreach (var ipAddr in ipAddress)
            //{
            //    Console.WriteLine(ipAddr);
            //}

            ConcurrentDictionary<IPAddress, long> pings = new ConcurrentDictionary<IPAddress, long>();

            List<Thread> threads = new List<Thread>();

            foreach (var ipAddr in ipAddress)
            {
                Thread thread = new Thread(() =>
                {
                    Ping p = new Ping();
                    PingReply pingReply = p.Send(ipAddr);
                    pings[ipAddr] = pingReply.RoundtripTime;
                    Console.WriteLine($"ip = {ipAddr}, ping = {pingReply.RoundtripTime}");
                });
                threads.Add(thread);
                thread.Start();
            }

            foreach (var thread in threads)
            {
                thread.Join();
            }

            long minPing = pings.Min(x => x.Value);

            Console.WriteLine($"Minimum ping = {minPing}");
        }
    }
}