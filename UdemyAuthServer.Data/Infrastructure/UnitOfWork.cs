using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using UdemyAuthServer.Core;
using UdemyAuthServer.Data.DAL;

namespace UdemyAuthServer.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;

        public UnitOfWork(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
