using DiyetDemo.DAL.Abstract;
using DiyetDemo.DAL.Base.EntityFramework;
using DiyetDemo.DAL.Concrete.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetDemo.DAL.Concrete.Repository
{
    public class CategoryRepository:EFRepositryBase<Category,DiyetDemoDBContext>, ICategoryDAL
    {
        public CategoryRepository(DiyetDemoDBContext dBContext ):base(dBContext)
        {

        }
    }
}
