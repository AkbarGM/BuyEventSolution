using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyEventSolution.Log
{
    static class MessageLog
    {
        private static string filePath = Directory.GetParent(@"..\..\").FullName + @"\Log\LogFiles\messageLog.txt";
        private static StringBuilder sb = new StringBuilder();
        public static void Log(Exception e)
        {
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {

                sb.Append($"\r\nFile sent is failed!\n");
                sb.Append("Log Entry: ");
                sb.Append($"{DateTime.Now.ToLongTimeString()}, {DateTime.Now.ToLongDateString()}\n");
                sb.Append(e.Message);
                sb.Append("\n-------------------------------------------------");
                sw.WriteLine(sb);
                sw.Close();
            }
        }
        public static string GetLog()
        {
            return sb.ToString();
        }
    }
}
