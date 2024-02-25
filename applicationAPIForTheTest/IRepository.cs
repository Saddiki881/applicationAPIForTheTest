namespace applicationAPIForTheTest
{
    public interface IRepository<TEntity, TId> where TEntity : Entity<TId>
    {
        Task<TEntity> GetByIdAsync(TId id);
        Task<TEntity> AddAsync(TEntity entity);
    }
}
