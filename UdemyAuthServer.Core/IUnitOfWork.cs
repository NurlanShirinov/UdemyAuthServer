using System.Threading.Tasks;

namespace UdemyAuthServer.Core
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
        void Commit();
    }
}
