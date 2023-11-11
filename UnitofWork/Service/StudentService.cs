using Microsoft.VisualBasic;
using UnitOfWork.Data;
using UnitOfWork.Repository;

namespace UnitOfWork.Service;

public class StudentService: IStudentService
{

    private readonly IStudentUnitOfWork _studentUnitOfWork;

    public StudentService(IStudentUnitOfWork studentUnitOfWork)
    {
        _studentUnitOfWork = studentUnitOfWork;
    }
    
    
    public async Task<IEnumerable<Student>> GetAll()
    {
        return await _studentUnitOfWork.Student.GetAll();
    }

    public async Task<bool> Add(Student student)
    {
        return await _studentUnitOfWork.Student.Add(student);
    }

    public async Task<string> getEmail(int id)
    {
        return await _studentUnitOfWork.Student.GetEmail(id);
    }
}