using System.Collections.Generic;
using System.Linq;

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

        public static List<Account> UpdateAccounts(List<Account> accounts, List<Transaction> transactions)
        {
            foreach (var currentTransaction in transactions)
            {
                var fromAccount = FindAccount(accounts, currentTransaction.from);
                var toAccount = FindAccount(accounts, currentTransaction.to);
                
                fromAccount.outgoingTransactions.Add(currentTransaction);
                toAccount.incomingTransactions.Add(currentTransaction);
            }

            return accounts;
        }

        private static Account FindAccount(List<Account> accounts, string accountName)
        {
            return accounts.FirstOrDefault(account => account.name == accountName);
        }
    }
}