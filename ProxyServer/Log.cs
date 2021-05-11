using System;
using System.IO;

namespace Proxy_Server
{
    public static class Log
    {
        static object locker = new object(); 

        public static void LogData(string request, string response)
        {
            lock(locker)
            {
                using (StreamWriter writer = File.AppendText("History.log"))
                {
                    writer.WriteLine("REQUEST\n" + request);
                    writer.WriteLine(response + "\n");
                }
                Console.WriteLine($"{response}\n");
            }
        }

    }
}