using System.Threading.Tasks;

namespace ToDoApp.Common.SL.Abstract
{
    public interface IUnitOfWork
    {
        Task BeginTransactionAsync();
        void Commit();
        void Dispose();
    }
}