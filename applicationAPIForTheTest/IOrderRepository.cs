namespace applicationAPIForTheTest
{
    public interface IOrderRepository
    {
        Task<Order> AddAsync(Order order);
        Task<Order> GetByIdAsync(int orderId);
    }
}
