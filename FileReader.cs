using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EmailExtraction
{
    public class FileReader
    {
        public static List<Transaction> ReadTransactions()
        {
            var linesFromFile = File.ReadAllLines("Data/Transactions2014.csv");
            
            var transactions = new List<Transaction>();
            foreach (var line in linesFromFile.Skip(1))
            {
                var newTransaction = CreateTransaction(line);
                transactions.Add(newTransaction);
            }

            return transactions;
        }
        
        private static Transaction CreateTransaction(string csvLine)
        {
            var parts = csvLine.Split(",");
                
            return new Transaction(
                parts[0], 
                parts[1],
                parts[2],
                parts[3],
                Convert.ToDecimal(parts[4])
            );
        }
    }
}