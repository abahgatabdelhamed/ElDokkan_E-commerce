namespace ELDOKKAN.Repositories;
public class Repository<TEntity> : IRepository<TEntity> 
where TEntity : class
{
    protected readonly AppDbContext _context;
    private readonly DbSet<TEntity> _dbSet;

    public Repository(AppDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<TEntity>();
    }

    public TEntity GetById(int id)
    {
        return _dbSet.Find(id);
        // return _dbSet
        //     .Include(o => o.OrderDetails)
        //     .ThenInclude(od => od.Product)
        //     .FirstOrDefaultAsync(o => o.OrderId == id);
    }

    public IEnumerable<TEntity> GetAll()
    {
        return _dbSet.ToList();
    }

    public TEntity Add(TEntity entity)
    {
        _dbSet.Add(entity);
        return entity;
    }

    public void Update(TEntity entity)
    {
        _dbSet.Update(entity);
    }

    public TEntity Delete(int id)
    {
        var entity = _dbSet.Find(id);
        if (entity != null)
        {
            _dbSet.Remove(entity);
        }
        return entity;
    }

    public int SaveChanges()
    {
        return _context.SaveChanges();
    }
}

