namespace Product.Management.Domain.Interface.Repository
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        TEntity Add(TEntity entity);

        TEntity Update(TEntity entity);

        bool Commit();
    }
}
