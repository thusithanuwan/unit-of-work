namespace UnitOfWork.Repository;

public interface IStudentUnitOfWork
{
    IStudentRepository Student { get; }

    Task CompleteAsync();
}