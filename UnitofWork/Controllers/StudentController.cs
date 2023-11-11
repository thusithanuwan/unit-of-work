using Microsoft.AspNetCore.Mvc;
using UnitOfWork.Data;
using UnitOfWork.Repository;
using UnitOfWork.Repository.Repository;

namespace UnitOfWork.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentController : Controller
{
    private readonly IStudentUnitOfWork _StudentUnitOfWork;

    public StudentController(IStudentUnitOfWork studentUnitOfWork)
    {
        _StudentUnitOfWork = studentUnitOfWork;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _StudentUnitOfWork.Student.GetAll());
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] Student student)
    {
        await _StudentUnitOfWork.Student.Add(student);
        await _StudentUnitOfWork.CompleteAsync();
        return Ok();
    }
}