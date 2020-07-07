using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Paymee.API.Helpers
{
    public class LogLine
    {
        public LogLine(string message, LogType tipo = LogType.Info, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = null)
        {
            Message = message;
            Tipo = tipo;
            LineNumber = lineNumber;
            Caller = caller;
        }

        public string Message { get; set; }
        public LogType Tipo { get; set; }
        public int LineNumber { get; set; }
        public string Caller { get; set; }
    }
}
