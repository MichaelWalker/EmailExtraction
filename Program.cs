using System;

namespace EmailExtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            var transactions = FileReader.ReadTransactions();
            var accounts = Bank.GetAccounts(transactions);
            var updatedAccounts = Bank.UpdateAccounts(accounts, transactions);
            
            Console.WriteLine(accounts);
        }
    }
}