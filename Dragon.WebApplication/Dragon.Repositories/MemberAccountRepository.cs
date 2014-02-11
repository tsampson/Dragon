using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Dragon.DataLayer;
using Dragon.DataLayer.Contexts;
using Dragon.DomainClasses;
using Dragon.DomainClasses.UnitOfWork;
using Dragon.Repositories.Interfaces;

namespace Dragon.Repositories
{
    public class MemberAccountRepository : IRepository<Member>
    {
        private MemberAccountContext _context;

        public MemberAccountRepository(IUnitOfWork uow)
        {
            _context = uow.Context as MemberAccountContext;
        }
        #region IRepository<Member>
        public IQueryable<Member> All { get { return _context.Members; } }

        public IQueryable<Member> AllIncluding(params Expression<Func<Member, object>>[] includeProperties)
        {
            IQueryable<Member> query = _context.Members;
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public Member Find(long id)
        {
            return _context.Members.Find(id);
        }

        public void InsertOrUpdate(Member member)
        {
            if (member.Id == default (long))
            {
                _context.Members.Add(member);
            }
            _context.ApplyStateChanges();
        }

        public void Delete(long id)
        {
            var Member = _context.Members.Find(id);
            _context.Members.Remove(Member);
        }
        #endregion

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
