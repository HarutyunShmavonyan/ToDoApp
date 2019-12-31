using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp.DB.Entities
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
