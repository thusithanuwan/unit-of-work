using UnitOfWork.Data;

namespace UnitOfWork.Repository;

public interface IStudentRepository : IGenericRepository<Student>
{
    Task<string?> GetEmail(int id);
}