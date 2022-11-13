global using DiyetDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetDemo.BLL.Abstract
{
    public interface ICategoryBLL: IBaseBLL<Category>
    {
        int GetCategoryID(string CategoryName);
    }
}
