using Microsoft.EntityFrameworkCore;

namespace Repository.UnitOfWork;

    public abstract class BaseUnitOfWork<TContext> : IDisposable where TContext : DbContext
    {
        protected readonly TContext context;
        private bool disposed = false;
        public BaseUnitOfWork(TContext context)
        {
            this.context = context;
        }

        public virtual async Task<int> Save(CancellationToken token = default)
        {
            var entries = context.ChangeTracker.Entries();


            var res = await context.SaveChangesAsync(token);
            return res;

        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
