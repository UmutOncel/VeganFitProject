namespace VeganFit.Models.VMs.UserVms
{
    public class CreateVm
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
    }
}
