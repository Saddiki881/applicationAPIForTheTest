namespace applicationAPIForTheTest
{
    public class OrderItem : Entity<int>
    {
        public string ProductName { get; }
        public Money Price { get; }
        public int Quantity { get; }

        public OrderItem(string productName, Money price, int quantity)
        {
            ProductName = productName;
            Price = price;
            Quantity = quantity;
        }
    }
}
