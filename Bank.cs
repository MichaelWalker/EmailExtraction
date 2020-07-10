using System.Collections.Generic;

namespace EmailExtraction
{
    public class Bank
    {
        public static List<Account> GetAccounts(List<Transaction> transactions)
        {
            var names = GetUniqueNames(transactions);

            var accounts = new List<Account>();

            foreach (var name in names)
            {
                var account = new Account(name);
                accounts.Add(account);
            }

            return accounts;
        }

        private static HashSet<string> GetUniqueNames(List<Transaction> transactions)
        {
            var names = new HashSet<string>();

            foreach (var transaction in transactions)
            {
                names.Add(transaction.from);
                names.Add(transaction.to);
            }

            return names;
        }
    }
}