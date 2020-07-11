using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EmailExtraction
{
    public static class FileReader
    {
        public static IEnumerable<Transaction> ReadTransactions()
        {
            var linesFromFile = File.ReadAllLines("Data/Transactions2014.csv");
            return linesFromFile
                .Skip(1)
                .Select(CreateTransaction);
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