using Paymee.API.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace Paymee.API.Services
{
    public static class LogService
    {
        public static void DebugWrite(string message, 
            string arquivo = "debug.txt", 
            LogType tipo = LogType.Info,
            [CallerLineNumber] int lineNumber = 0, 
            [CallerMemberName] string caller = null)
        {
            if (!Directory.Exists("log-paymee"))
                Directory.CreateDirectory("log-paymee");

            using (var sw = File.AppendText($"log-paymee\\{arquivo}"))
            {
                sw.WriteLine($"{DateTime.Now:dd/MM/yyyy HH:mm:ss}, Line {lineNumber} [{caller}] {tipo.ToString().ToUpper()} - {message}");
            }
        }

        public static void DebugWrite(
            List<LogLine> debugLines,
            string arquivo = "log-paymee.txt")
        {
            if (!Directory.Exists("log-paymee"))
                Directory.CreateDirectory("log-paymee");

            using (var sw = File.AppendText($"log-paymee\\{arquivo}"))
            {
                foreach (var line in debugLines)
                {
                    sw.WriteLine(
                        $"{DateTime.Now:dd/MM/yyyy HH:mm:ss}, Line {line.LineNumber} [{line.Caller}] {line.Tipo.ToString().ToUpper()} - {line.Message}{Environment.NewLine}");
                }
            }
        }

    }
}
