using Microsoft.VisualBasic.CompilerServices;

namespace UnitOfWork.Repository;

public interface IGenericRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAll();

    Task<T?> GetById(int id);

    Task<bool> Delete(T entity);

    Task<bool> Add(T entity);

    Task<bool> Update(T entity);
}