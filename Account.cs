using System.Collections.Generic;

namespace EmailExtraction
{
    public class Account
    {
        public string name;
        public List<Transaction> incomingTransactions;
        public List<Transaction> outgoingTransactions;

        public decimal GetTotalIncoming()
        {
            var total = new decimal(0);

            foreach (var transaction in incomingTransactions)
            {
                total = total + transaction.amount;
            }

            return total;
        }

        public decimal GetTotalOutgoing()
        {
            var total = new decimal(0);

            foreach (var transaction in outgoingTransactions)
            {
                total = total + transaction.amount;
            }

            return total;
        }

        public decimal GetTotalToPay()
        {
            return GetTotalOutgoing() - GetTotalIncoming();
        }
    }
}