using Contracts;
using Entities;

namespace Repository;

public class WageRepository:RepositoryBase<Wage, RepositoryContext>, IWageRepository
{
    public WageRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }
}