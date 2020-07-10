namespace EmailExtraction
{
    public class Transaction
    {
        public string Date { get; }
        public string From { get; }
        public string To { get; }
        public string Narrative { get; }
        public decimal Amount { get; }

        public Transaction(string date, string from, string to, string narrative, decimal amount)
        {
            Date = date;
            From = from;
            To = to;
            Narrative = narrative;
            Amount = amount;
        }
    }
}