using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALMemoryStore.Exceptions
{
    public class PermanentDalException : Exception
    {
        public readonly string? ExeptionMessage;
        public readonly string Message;
        public PermanentDalException(string message, string? exeptionMessage = null) : base(message)
        {
            Message = message;
            ExeptionMessage = exeptionMessage;
        }
        public string GetFullException()
        {
            return $"{Message} {ExeptionMessage}";
        }
    }
}

