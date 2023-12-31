﻿using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using VeganFit.Bll.Abstract.IServices;
using VeganFit.Bll.Concrete.Mapper;
using VeganFit.Bll.Concrete.Services;
using VeganFit.DAL.Concrete;

namespace VeganFit.Bll.Concrete
{
    public static class EFContextBll
    {
        /// <summary>
        /// Service'ler (IDataService, DataService vb.) için dependency injection yapısını kullanmamızı sağlan metot. (Bu repo'lar bu metot sayesinde parametre olarak çağrıldığı zaman new'lenmeden kullanılabilir.)
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddScopedBll(this IServiceCollection services)
        {
            services.AddScopeDal()
            .AddScoped<IDataService, DataService>()
            .AddScoped<IFeedbackService, FeedbackService>()
            .AddScoped<IProductService, ProductService>()
            .AddScoped<IUserService, UserService>()
            .AddScoped<IWeightService, WeightService>();

            var mapp = new MapperConfiguration(mpp =>
            {
                mpp.AddProfile(new Mapping());
            });

            IMapper mapper = mapp.CreateMapper();
            services.AddSingleton(mapper).BuildServiceProvider();

            return services;
        }
    }
}
