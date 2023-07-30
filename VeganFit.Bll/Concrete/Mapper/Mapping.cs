using AutoMapper;
using VeganFit.Entities;
using VeganFit.Models.DTOs.AdminDtos;
using VeganFit.Models.DTOs.DataDtos;
using VeganFit.Models.DTOs.FeedbackDtos;
using VeganFit.Models.DTOs.ProductDtos;
using VeganFit.Models.DTOs.UserDtos;
using VeganFit.Models.DTOs.WeigthDtos;
using VeganFit.Models.VMs.DataVms;
using VeganFit.Models.VMs.FeedbackVms;
using VeganFit.Models.VMs.ProductVms;
using VeganFit.Models.VMs.UserVms;
using VeganFit.Models.VMs.WeightVms;

namespace VeganFit.Bll.Concrete.Mapper
{
    public class Mapping : Profile
    {
        /// <summary>
        /// DTO ve VM arasında (çift taraflı) mapping işlemi için ilişki kuran metot.
        /// </summary>
        public Mapping()
        {
            CreateMap<Product,ProductCreateDto>().ReverseMap();
            CreateMap<Product,ProductUpdateDto>().ReverseMap();
            CreateMap<ProductCreateDto,ProductCreateVm>().ReverseMap();
            CreateMap<ProductUpdateDto,ProductUpdateVm>().ReverseMap();

            //CreateMap<User,UserCreateDto>().ReverseMap();
            //CreateMap<UserCreateDto,AdminCreateDto>().ReverseMap();
            //CreateMap<UserCreateDto, CreateVm>().ReverseMap();

            CreateMap<Feedback,FeedbackCreateDto>().ReverseMap();
            CreateMap<FeedbackCreateDto,FeedbackCreateVm>().ReverseMap();

            CreateMap<Weight,WeightCreateDto>().ReverseMap();
            CreateMap<WeightCreateDto,WeightCreateVm>().ReverseMap();  
            
            CreateMap<Data,DataDetailDto>().ReverseMap();
            CreateMap<DataDetailDto,DataDetailVm>().ReverseMap();

            CreateMap<User,UserCreateDto>().ReverseMap();
            CreateMap<User,LoginVm>().ReverseMap();
            CreateMap<UserCreateDto, CreateVm>().ReverseMap();
        }
    }
}
