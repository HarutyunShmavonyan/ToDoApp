using ToDoApp.Common.DAL.Abstract;
using ToDoApp.DB;
using ToDoApp.DB.Entities;

namespace ToDoApp.DAL
{
    public class ToDoRecordRepository : Repository<ToDoRecord>, IToDoRecordRepository
    {
        public ToDoRecordRepository(ToDoAppDbContext context) : base(context)
        {
        }
    }
}