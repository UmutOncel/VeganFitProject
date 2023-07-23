using VeganFit.Core.Enums;

namespace VeganFit.Models.VMs.UserVms
{
    public class LoginVm
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
    }
}
