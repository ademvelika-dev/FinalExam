using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    internal class Customer
    {
        public int AccountNumber { get; set; }
        public string CustomerNumber { get; set; }
        public string Pin { get; set; }
      

        public Customer(int AccountNumber, string CustomerNumber, string Pin)
        {
            this.AccountNumber = AccountNumber;
            this.CustomerNumber = CustomerNumber;
            this.Pin = Pin;
           
        }

      

    }
}
