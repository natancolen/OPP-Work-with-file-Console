namespace Entities
{
    class Product
    {
        public string name { get; set; }
        public double price { get; set; }
        public int amount { get; set; }

        public Product(string name, double price, int amount)
        {
            this.name = name;
            this.price = price;
            this.amount = amount;
        }

        public double TotalCost()
        {
            return (amount * price) * 0.01;
        }
    }
}
