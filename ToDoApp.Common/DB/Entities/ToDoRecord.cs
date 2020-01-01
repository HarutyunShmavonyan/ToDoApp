using System;
using ToDoApp.Common.DAL.Abstract;

namespace ToDoApp.Common.DB.Entities
{
    public class ToDoRecord : Entity
    {
        public string Title { get; set; }
        public DateTime DueTo { get; set; }
        public Priority Priority { get; set; }
        public long OwningUserId { get; set; }
        public User OwningUser { get; set; }
    }

    public enum Priority
    {
        Low,
        Middle,
        High
    }
}
