using Contracts;
using Repository.Repository;

namespace Repository.UnitOfWork;

public class UnitOfWork:BaseUnitOfWork<RepositoryContext>, IUnitOfWork
{
    private IWageRepository _wageRepository;
    private IEmployeeRepository _employeeRepository;
    public UnitOfWork(RepositoryContext context) : base(context)
    {
        
    }
    
    public IEmployeeRepository EmployeeRepository
    {
        get
        {
            if (_employeeRepository == null)
            {
                _employeeRepository = new EmployeeRepository(context);
            }

            return _employeeRepository;
        }
    }
    
    public IWageRepository WageRepository
    {
        get
        {
            if (_wageRepository == null)
            {
                _wageRepository = new WageRepository(context);
            }

            return _wageRepository;
        }
    }
    
}