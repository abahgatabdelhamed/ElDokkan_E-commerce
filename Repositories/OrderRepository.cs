namespace ELDOKKAN.Repositories;
public class OrderRepository : Repository<Order> , IOrderRepository
{
    public OrderRepository(AppDbContext context) : base(context)
    {
    }
}