﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    [Serializable]
    internal class InvalidAccountException:Exception
    {
        public InvalidAccountException() { }
        public InvalidAccountException(string message) : base(message) { }
        public  InvalidAccountException(string message, Exception innerException) : base(message, innerException) { }
    }
}
