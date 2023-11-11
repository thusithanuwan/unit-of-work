using UnitOfWork.Data;

namespace UnitOfWork.Service;

public interface IStudentService
{
    Task<IEnumerable<Student>> GetAll();

    Task<bool> Add(Student student);

    Task<string> getEmail(int id);
}