﻿using AutoMapper;
using VeganFit.Entities;
using VeganFit.Models.DTOs.AdminDtos;
using VeganFit.Models.DTOs.DataDtos;
using VeganFit.Models.DTOs.FeedbackDtos;
using VeganFit.Models.DTOs.OptionalProductDtos;
using VeganFit.Models.DTOs.ProductDtos;
using VeganFit.Models.DTOs.UserDtos;
using VeganFit.Models.DTOs.WeigthDtos;
using VeganFit.Models.VMs.FeedbackVms;
using VeganFit.Models.VMs.OptionalProductVms;
using VeganFit.Models.VMs.ProductVms;
using VeganFit.Models.VMs.UserVms;
using VeganFit.Models.VMs.WeightVms;

namespace VeganFit.Bll.Concrete.Mapper
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Product,ProductCreateDto>().ReverseMap();
            CreateMap<Product,ProductUpdateDto>().ReverseMap();
            CreateMap<ProductCreateDto,ProductCreateVm>().ReverseMap();
            CreateMap<ProductUpdateDto,ProductUpdateVm>().ReverseMap();

            CreateMap<OptionalProduct,OptionalProductCreateDto>().ReverseMap();
            CreateMap<OptionalProductCreateDto,OptionalProductCreateVm>().ReverseMap();

            //CreateMap<User,UserCreateDto>().ReverseMap();
            //CreateMap<UserCreateDto,AdminCreateDto>().ReverseMap();
            //CreateMap<UserCreateDto, CreateVm>().ReverseMap();

            CreateMap<Feedback,FeedbackCreateDto>().ReverseMap();
            CreateMap<FeedbackCreateDto,FeedbackCreateVm>().ReverseMap();

            CreateMap<Weight,WeightCreateDto>().ReverseMap();
            CreateMap<WeightCreateDto,WeightCreateVm>().ReverseMap();  
            
            CreateMap<Data,DataDetailDto>().ReverseMap();

            CreateMap<User,UserCreateDto>().ReverseMap();
            CreateMap<User,LoginVm>().ReverseMap();
            CreateMap<UserCreateDto, CreateVm>().ReverseMap();
           

            
        }
    }
}
