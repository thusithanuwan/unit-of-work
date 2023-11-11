using UnitOfWork.Data;

namespace UnitOfWork.Repository.Repository;

public class StudentRepository : GenericRepository<Student>, IStudentRepository
{
    public StudentRepository(Context context) : base(context)
    {
    }

    public async Task<string?> GetEmail(int id)
    {
        var student = await _context.Students.FindAsync(id);
        return student.Email;
    }
}