using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using UnitOfWork.Data;
using UnitOfWork.Repository;
using UnitOfWork.Repository.Repository;
using UnitOfWork.Service;

namespace UnitOfWork.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentController : Controller
{
    private readonly IStudentService _studentService;

    public StudentController(IStudentService studentService)
    {
        _studentService = studentService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _studentService.GetAll());
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] Student student)
    {
        await _studentService.Add(student);
        return Ok(true);
    }
}