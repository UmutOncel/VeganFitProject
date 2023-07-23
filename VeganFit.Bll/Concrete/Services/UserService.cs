using VeganFit.Bll.Abstract.IServices;
using VeganFit.Models.VMs.UserVms;
using VeganFit.Shared;

namespace VeganFit.Bll.Concrete.Services
{
    public class UserService : IUserService
    {
        public ResultService<LoginVm> Login(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
