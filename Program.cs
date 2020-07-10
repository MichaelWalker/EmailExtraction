using System;

namespace EmailExtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            var transactions = FileReader.ReadTransactions();
            
            Console.WriteLine(transactions);
        }
    }
}