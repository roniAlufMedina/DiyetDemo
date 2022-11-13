global using DiyetDemo.Core;

namespace DiyetDemo.Entities
{
    public class User:BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }    
        public string Email { get; set; }

        public User()
        {
            isActive= true;
        }
    }
}