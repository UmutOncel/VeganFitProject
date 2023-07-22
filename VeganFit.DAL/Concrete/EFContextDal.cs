using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeganFit.DAL.Abstract;
using VeganFit.DAL.Concrete.Context;
using VeganFit.DAL.Concrete.Repositories;
using VeganFit.Entities;

namespace VeganFit.DAL.Concrete
{
    public static class EFContextDal
    {
        public static IServiceCollection AddScopeDal(this IServiceCollection services) 
        {
            services.AddDbContext<VeganFitDbContext>()
                    .AddScoped<IUserRepo, UserRepo>()
                    .AddScoped<IProductRepo, ProductRepo>()
                    .AddScoped<IOptionalProductRepo, OptionalProductRepo>()
                    .AddScoped<IFeedbackRepo, FeedbackRepo>()
                    .AddScoped<IWeightRepo, WeightRepo>()
                    .AddScoped<IDataRepo, DataRepo>();
            return services;
        }
    }
}
