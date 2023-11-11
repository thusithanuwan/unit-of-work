using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using UnitOfWork.Data;

namespace UnitOfWork.Repository.Repository;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    protected readonly Context _context;
    private readonly DbSet<T> _dbSet;

    public GenericRepository(Context context)
    {
        _context = context;
        _dbSet = _context.Set<T>();    // Inside the context we set dbSet
    }


    public async Task<IEnumerable<T>> GetAll()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task<T?> GetById(int id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async  Task<bool> Delete(T entity)
    {
        _dbSet.Remove(entity);
        return true;
    }

    public async Task<bool> Add(T entity)
    {
        await _dbSet.AddAsync(entity);
        return true;
    }

    public async Task<bool> Update(T entity)
    {
        _dbSet.Update(entity);
        return true;
    }
}