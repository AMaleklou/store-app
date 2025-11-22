namespace StoreApp.Domain.ValueObjects
{
    public class Money
    {
        public string Name { get; }
        public string Symbol { get; }

        public Money(string name, string symbol)
       {
          Name = name;
          Symbol = symbol;
        }  
    }
}
