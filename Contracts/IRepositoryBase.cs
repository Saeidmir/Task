using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Contracts;
public interface IRepositoryBase<T,TContext> where T: class where TContext: DbContext 
{
    IQueryable<T> FindAll();

    public IQueryable<T> Paginated(Expression<Func<T, bool>> where = null,
        Func<IQueryable<T>, IOrderedQueryable<T>> orderby = null, int? page = null, int? pageCont = null,
        params string[] Include);
    IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
    int GetCount(Expression<Func<T, bool>>? expression);
    void Create(T entity);
    void CreateRange(IEnumerable<T> entities);
    void UpdateRange(IEnumerable<T> entities);
    void DeleteRange(IEnumerable<T> entities);
    void Update(T entity);
    void Delete(T entity);
    void InsertRange(IEnumerable<T> entities);
    bool Exists(Expression<Func<T, bool>> expression);

    Task DeleteById(object id);
    EntityEntry<T> Entry(T en);
    Task<T> Max();
    ValueTask<T?> Find(object id);


}