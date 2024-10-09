namespace ELDOKKAN.Repositories;
public class ProductRepository : Repository<Product> , IProductRepository
{
    public ProductRepository(AppDbContext context) : base(context)
    {
    }

    public IQueryable<Product> SearchByName(string productName)
    {
        return _context.Products.Where(
                    p => p.Name.ToLower().Equals(productName.ToLower()));
    }
    
}