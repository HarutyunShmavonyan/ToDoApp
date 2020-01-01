using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage;
using ToDoApp.Common.SL.Abstract;
using ToDoApp.DB;

namespace ToDoApp.Services
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ToDoAppDbContext _context;
        private IDbContextTransaction _transaction;

        public UnitOfWork(ToDoAppDbContext context)
        {
            _context = context;
        }

        public async Task BeginTransactionAsync()
        {
            _transaction = await _context.Database.BeginTransactionAsync();
        }

        public void Commit()
        {
            try
            {
                _transaction.Commit();
            }
            catch
            {
                _transaction.Rollback();
                throw;
            }
            finally
            {
                DisposeTransaction();
            }
        }

        private void DisposeTransaction() => _transaction.Dispose();
        public void Dispose() => _context?.Dispose();
    }
}
