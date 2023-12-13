using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    internal class InvalidInput:Exception
    {
        public InvalidInput() { }
        public InvalidInput(string message) : base(message) { }
        public InvalidInput(string message, Exception innerException) : base(message, innerException) { }
    }
}
