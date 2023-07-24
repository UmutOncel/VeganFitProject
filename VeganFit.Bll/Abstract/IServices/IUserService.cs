using VeganFit.Models.VMs.UserVms;
using VeganFit.Shared;

namespace VeganFit.Bll.Abstract.IServices
{
    public interface IUserService
    {
        ResultService<LoginVm> Login(string username, string password);

        //ResultService<CreateVm> Create(CreateVm createVm);
    }
}
