namespace ELDOKKAN.Repositories;
public class OrderDetailsRepository : Repository<OrderDetails> , IOrderDetailsRepository
{
    public OrderDetailsRepository(AppDbContext context) : base(context)
    {
    }
}