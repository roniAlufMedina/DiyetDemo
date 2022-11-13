namespace DiyetDemo.Core
{
    public class BaseEntity
    {
        public int ID { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set;}
        public bool  isActive { get; set; }
    }
}