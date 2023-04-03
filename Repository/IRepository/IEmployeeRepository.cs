using Entities;
using Repository;

namespace Contracts;

public interface IEmployeeRepository:IRepositoryBase<Employee,RepositoryContext>
{

}