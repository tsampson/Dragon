namespace Dragon.Repositories.Interfaces
{
    public interface IRepositoryGraph<T> : IRepository<T>
    {
        void InsertOrUpdateGraph(T entity);
    }
}
