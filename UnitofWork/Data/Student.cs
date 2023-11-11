using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace UnitOfWork.Data;

public class Student
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set ;}
    [Required]
    public string Email { get; set; }

    
}   