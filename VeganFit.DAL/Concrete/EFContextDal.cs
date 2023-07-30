using Microsoft.Extensions.DependencyInjection;
using VeganFit.DAL.Abstract;
using VeganFit.DAL.Concrete.Context;
using VeganFit.DAL.Concrete.Repositories;

namespace VeganFit.DAL.Concrete
{
    public static class EFContextDal
    {
        /// <summary>
        /// UserRepo, ProductRepo, FeedbackRepo, WeightRepo ve DataRepo için dependency injection yapısını kullanmamızı sağlan metot. (Bu repo'lar bu metot sayesinde parametre olarak çağrıldığı zaman new'lenmeden kullanılabilir.)
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddScopeDal(this IServiceCollection services) 
        {
            services.AddDbContext<VeganFitDbContext>()
                    .AddScoped<IUserRepo, UserRepo>()
                    .AddScoped<IProductRepo, ProductRepo>()
                    .AddScoped<IFeedbackRepo, FeedbackRepo>()
                    .AddScoped<IWeightRepo, WeightRepo>()
                    .AddScoped<IDataRepo, DataRepo>();
                    //AddScoped => Interface ile class'ları birbirine bağlar.
            return  services;
        }
    }
}
