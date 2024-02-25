namespace applicationAPIForTheTest
{
    public class Order : Entity<int>
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; }
        public Money TotalAmount { get; }
        public List<OrderItem> Items { get; }

        public Order(DateTime orderDate, Money totalAmount, List<OrderItem> items)
        {
            OrderDate = orderDate;
            TotalAmount = totalAmount;
            Items = items;
        }
    }
}
