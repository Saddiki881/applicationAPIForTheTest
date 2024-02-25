namespace applicationAPIForTheTest
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<Order> CreateOrderAsync(Order order)
        {
            return await _orderRepository.AddAsync(order);
        }

        public async Task<Order> GetOrderAsync(int orderId)
        {
            return await _orderRepository.GetByIdAsync(orderId);
        }
    }
}
