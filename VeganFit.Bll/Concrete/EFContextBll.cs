using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using VeganFit.Bll.Concrete.Mapper;

namespace VeganFit.Bll.Concrete
{
    public static class EFContextBll
    {
        public static IServiceCollection AddScopedBll(this IServiceCollection services)
        {
            //services.AddScopedDal()
            //    .AddScoped<IAdminService, AdminService>()
            //    .AddScoped<IPlakService, PlakService>()
            //    .AddScoped<IArtistServise, ArtistServices>();


            var mapp = new MapperConfiguration(mpp =>
            {
                mpp.AddProfile(new Mapping());
            });

            IMapper mapper = mapp.CreateMapper();
            services.AddSingleton(mapper);

            return services;
        }
    }
}
