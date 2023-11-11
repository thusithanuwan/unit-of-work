using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UnitOfWork.Data;

public class Course
{
    [Key]
    private int Id { get; set; }
    [Required]
    private string Description { get; set; }
    
    [InverseProperty("Course")]
    public List<Student> Students { get; set; }
    
}