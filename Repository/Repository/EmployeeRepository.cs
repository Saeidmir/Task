using Contracts;
using Entities;

namespace Repository.Repository;

public class EmployeeRepository:RepositoryBase<Employee, RepositoryContext>, IEmployeeRepository
{
    public EmployeeRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }
}