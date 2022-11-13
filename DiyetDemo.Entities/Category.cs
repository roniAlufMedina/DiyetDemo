using System.Text;
using System.Threading.Tasks;

namespace DiyetDemo.Entities
{
    public class Category:BaseEntity
    {
        public string CategoryName { get; set; }
        public ICollection<Food> Foods { get; set; }

        public Category()
        {
            isActive = true;
            Foods = new HashSet<Food>();
        }

    }
}
