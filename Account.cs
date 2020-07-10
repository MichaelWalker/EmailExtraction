using System.Collections.Generic;

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
            var total = new decimal(0);

            foreach (var transaction in IncomingTransactions)
            {
                total = total + transaction.Amount;
            }

            return total;
        }

        public decimal GetTotalOutgoing()
        {
            var total = new decimal(0);

            foreach (var transaction in OutgoingTransactions)
            {
                total = total + transaction.Amount;
            }

            return total;
        }

        public decimal GetTotalToPay()
        {
            return GetTotalOutgoing() - GetTotalIncoming();
        }
    }
}