using AutoMapper;
using VeganFit.Bll.Abstract.IServices;
using VeganFit.DAL.Abstract;
using VeganFit.Entities;
using VeganFit.Models.DTOs.UserDtos;
using VeganFit.Models.VMs.UserVms;
using VeganFit.Shared;

namespace VeganFit.Bll.Concrete.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepo _userRepo;
        private readonly IMapper _mapper;

        public UserService(IUserRepo userRepo , IMapper mapper)
        {
            _mapper = mapper;
            _userRepo = userRepo;
        }

        public ResultService<UserCreateDto> Create(CreateVm createVm)
        {
            ResultService<UserCreateDto> result = new ResultService<UserCreateDto>();

            UserCreateDto userCreateDto = _mapper.Map<UserCreateDto>(createVm);

            User newUser = _mapper.Map<User>(userCreateDto);
            
            var addedUser = _userRepo.Create(newUser);

            if (addedUser != null)
            {
                result.Data = userCreateDto;
            }
            else
            {
                result.AddError(ErrorType.BadRequest, "Bir şeyler yolunda gitmedi. Ekleme Başarısız.");
            }

            return result;
            
        }

        public ResultService<LoginVm> Login(string username, string password)
        {
            ResultService<LoginVm> result = new ResultService<LoginVm> ();
            var user = _userRepo.GetFirstOrDefault(filter:x=>x.Email ==  username && x.Password.Equals(password));
            if (user != null)
            {
                var logged = new LoginVm { Email = username, Password = password, Role = user.Role };
                result.Data = logged;
            }
            else
            {
                result.AddError(ErrorType.NotFound, "Kullanıcı Bulunamadı");
            }

            return result;
        }

    }
}
