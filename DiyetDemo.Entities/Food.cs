using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetDemo.Entities
{
    public class Food:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        
        public Category Category { get; set; }
        public Food()
        {
            isActive= true;
        }
    }
}
