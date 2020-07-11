using System.Collections.Generic;
using System.Linq;

namespace EmailExtraction
{
    public static class Bank
    {
        public static IEnumerable<Account> GetAccounts(IEnumerable<Transaction> transactions)
        {
            var names = GetUniqueNames(transactions);
            return names.Select(name => new Account(name));
        }

        private static IEnumerable<string> GetUniqueNames(IEnumerable<Transaction> transactions)
        {
            return transactions
                .SelectMany(t => new List<string> {t.From, t.To})
                .Distinct();
        }
    }
}