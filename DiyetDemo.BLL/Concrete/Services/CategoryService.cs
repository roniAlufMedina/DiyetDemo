global using DiyetDemo.ViewModels;
global using DiyetDemo.System;
using DiyetDemo.BLL.Abstract;
using DiyetDemo.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetDemo.BLL.Concrete.Services
{
    public class CategoryService: ICategoryBLL
    {
        ICategoryDAL categoryDAL;

        public CategoryService(ICategoryDAL categoryDAL)
        {
            this.categoryDAL = categoryDAL;
        }

        public ResultService<Category> CreateCategory(CategoryNewVM newVM) { 
            ResultService<Category> result = new ResultService<Category>();
            Category yeni = new Category()
            {
                CategoryName = newVM.Name
            };
            Category eklenen = categoryDAL.Add(yeni);
            if (eklenen != null)
            {
                result.Data = eklenen;
            }
            else { 
                result.Data = yeni;
            }
            return result;
        }

        public ResultService<CategoryBaseVM> GetCategoryID(string CategoryName)
        {
            ResultService<CategoryBaseVM> rs = new ResultService<CategoryBaseVM>();
            Category category = categoryDAL.Get(c => c.CategoryName == CategoryName);
            if (category != null)
            {
                rs.Data = new CategoryBaseVM()
                {
                    Id = category.ID,
                    Name = category.CategoryName
                };
                return rs;
            }
            else { 
                
                rs.Data = new CategoryBaseVM() { 
                    Id= -1,
                    Name= CategoryName
                };
                rs.AddError("Kayıt bulunamadı", "Bu isimde bir kategori Adı Bulunamadı");
                return rs;                    
            }

            
        }
    }
}
