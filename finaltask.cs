namespace FinalTask
{
    public abstract class Telephone
    {
        public string name;
        public string firm;
        public double price;
        public string Name { get; set; }
        public string Firm { get; set; }
        public double Price { get; set; }
        public Telephone(string name, string firm, double price)
        {
            Name = name;
            Firm = firm;
            Price = price;
        }
    }
    public class MobilePhone : Telephone
    {
        public string color;
        public uint capacity;
        public string Color { get; set; }
        public uint Capacity { get; set; }
        public MobilePhone(string name, string firm, double price, string color, uint capacity) 
            : base(name, firm, price)
        {
            Color = color;
            Capacity = capacity;
        }
    }
    class Program
    {
        public static void Main(string[] args) 
        {
            
        }
    }
}
