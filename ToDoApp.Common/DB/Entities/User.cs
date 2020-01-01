using System.Collections.Generic;
using ToDoApp.Common.DAL.Abstract;

namespace ToDoApp.Common.DB.Entities
{
    public class User : Entity
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }

        public ICollection<ToDoRecord> ToDos { get; set; }
    }
}