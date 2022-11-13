using DiyetDemo.DAL.Abstract;
using DiyetDemo.DAL.Concrete.Context;
using DiyetDemo.DAL.Concrete.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DiyetDemo.DAL.Concrete
{
    public static class EFContextDAL
    {
        public static void AddScopeDAL(this IServiceCollection services)
        {
            services.AddDbContext<DiyetDemoDBContext>()
                .AddScoped<ICategoryDAL, CategoryRepository>()
                .AddScoped<IFoodDAL, FoodRepository>()
                .AddScoped<IUserDAL, UserRepository>();       
        }
    }
}
