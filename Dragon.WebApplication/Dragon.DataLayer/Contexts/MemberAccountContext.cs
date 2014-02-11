using System.Configuration;
using System.Data.Entity;
using Dragon.DomainClasses;

namespace Dragon.DataLayer.Contexts
{
    public class MemberAccountContext : BaseContext<MemberAccountContext>
    {
        public DbSet<Member> Members { get; set; }

        private static readonly string ConnectionString;
        static MemberAccountContext()
        {
            ConnectionString = ConfigurationManager.AppSettings["MemberAccountContext"];
            if (!ConnectionString.Contains("name="))
            {
                ConnectionString = string.Concat("name=", ConnectionString);
            }
        }
        public MemberAccountContext() : base(ConnectionString) { }
    }
}
