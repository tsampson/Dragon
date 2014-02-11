using System.Data.Entity;

namespace Dragon.DataLayer.Contexts
{
    /// <summary>
    /// Class to make sure that you never reinitialize the database and set the connection string of the DbContext
    /// </summary>
    /// <typeparam name="TContext"></typeparam>
    public class BaseContext<TContext> : DbContext where TContext : DbContext
    {
        static BaseContext()
        {
            //never initialize database
            Database.SetInitializer<TContext>(null);
        }

        protected BaseContext(string connectionString) : base(connectionString) { }
    }
}
