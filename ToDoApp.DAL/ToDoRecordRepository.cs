using ToDoApp.Common.DAL.Abstract;
using ToDoApp.Common.DB.Entities;
using ToDoApp.DB;

namespace ToDoApp.DAL
{
    public class ToDoRecordRepository : Repository<ToDoRecord>, IToDoRecordRepository
    {
        public ToDoRecordRepository(ToDoAppDbContext context) : base(context)
        {
        }
    }
}