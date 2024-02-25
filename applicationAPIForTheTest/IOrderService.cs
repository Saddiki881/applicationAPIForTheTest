namespace applicationAPIForTheTest
{
    public interface IOrderService
    {
        Task<Order> CreateOrderAsync(Order order);
        Task<Order> GetOrderAsync(int orderId);
    }
}
