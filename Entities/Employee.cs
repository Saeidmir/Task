using System.ComponentModel.DataAnnotations.Schema;

namespace Entities;

public class Employee
{
    private Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
    [ForeignKey(nameof(Wage))]
    public ICollection<Wage>? Wages { get; set; }
}