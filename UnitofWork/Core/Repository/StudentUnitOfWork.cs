using UnitOfWork.Data;

namespace UnitOfWork.Repository.Repository;

public class StudentUnitOfWork : IStudentUnitOfWork, IDisposable
{
    private readonly Context _context;
    private readonly ILogger _logger;
    
    public IStudentRepository Student { get; }


    public StudentUnitOfWork(Context context)
    {
        _context = context;
        Student = new StudentRepository(_context);
    }

    
    public async Task CompleteAsync()
    {
        await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}