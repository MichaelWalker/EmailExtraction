using System.Collections.Generic;
using System.Linq;

namespace EmailExtraction
{
    public class Account
    {
        public string Name { get; }
        public List<Transaction> IncomingTransactions { get; }
        public List<Transaction> OutgoingTransactions { get; }

        public Account(string name)
        {
            Name = name;
            IncomingTransactions = new List<Transaction>();
            OutgoingTransactions = new List<Transaction>();
        }
        
        public decimal GetTotalIncoming()
        {
            return IncomingTransactions.Sum(t =>  t.Amount);
        }

        public decimal GetTotalOutgoing()
        {
            return OutgoingTransactions.Sum(t =>  t.Amount);
        }

        public decimal GetTotalToPay()
        {
            return GetTotalOutgoing() - GetTotalIncoming();
        }
    }
}