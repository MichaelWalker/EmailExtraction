using System.Collections.Generic;
using System.Linq;

namespace EmailExtraction
{
    public class Account
    {
        public string Name { get; }
        public List<Transaction> IncomingTransactions { get; }
        public List<Transaction> OutgoingTransactions { get; }

        public decimal TotalIncoming => IncomingTransactions.Sum(t => t.Amount);
        public decimal TotalOutgoing => OutgoingTransactions.Sum(t =>  t.Amount);
        public decimal TotalToPay => TotalOutgoing - TotalIncoming;
        
        public Account(string name)
        {
            Name = name;
            IncomingTransactions = new List<Transaction>();
            OutgoingTransactions = new List<Transaction>();
        }
    }
}