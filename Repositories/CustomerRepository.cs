namespace ELDOKKAN.Repositories;
public class CustomerRepository : Repository<Customer> , ICustomerRepository
{
    public CustomerRepository(AppDbContext context) : base(context)
    {
    }
}