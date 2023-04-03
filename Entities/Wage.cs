using System.Numerics;

namespace Entities;

public class Wage
{
    public BigInteger Id { get; set; }
    public  decimal BasicSalary { get; set; }
    public  decimal Allowance { get; set; }
    public  decimal Transportation { get; set; }
    public Guid EmployeeId { get; set; }
}