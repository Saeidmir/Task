using Contracts;

namespace Repository.UnitOfWork;

public interface IUnitOfWork
{
    IEmployeeRepository EmployeeRepository { get; }
    IWageRepository WageRepository { get; }
    Task<int> Save(CancellationToken token = default);

}