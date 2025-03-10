using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_System
{
    internal class Transaction
    {
        public string TransactionID { get; set; }
        public TransactionType transactionType { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public Status Status { get; set; }  
    }
}
