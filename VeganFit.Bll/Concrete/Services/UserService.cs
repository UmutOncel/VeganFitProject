using AutoMapper;
using VeganFit.Bll.Abstract.IServices;
using VeganFit.DAL.Abstract;
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

        //public ResultService<CreateVm> Create(CreateVm createVm)
        //{
        //    ResultService<UserCreateDto> result = new ResultService<UserCreateDto>();
            

        //    //if (user == null)
        //    //{
        //    //    var added = new CreateVm { Email = user.Email, FirstName = user.Firstname, LastName = user.Lastname, BirthDate = user.Birthdate, Password = user.Password };
        //    //    result.Data = added;
        //    //}
        //    //else
        //    //{
        //    //    result.AddError(ErrorType.BadRequest, "Bu kullanıcı kayıtlı..");
        //    //}


        //    //return result;
        //}

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
