namespace applicationAPIForTheTest
{
    public class OrderRepository : IRepository<Order, int>
    {
        private readonly List<Order> _orders = new List<Order>();

        public async Task<Order> GetByIdAsync(int id)
        {
            return await Task.FromResult(_orders.FirstOrDefault(o => o.Id == id));
        }

        public async Task<Order> AddAsync(Order order)
        {
            order.Id = _orders.Count + 1;
            _orders.Add(order);
            return await Task.FromResult(order);
        }
    }
}
