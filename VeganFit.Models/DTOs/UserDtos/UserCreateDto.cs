using VeganFit.Core.Enums;

namespace VeganFit.Models.DTOs.UserDtos
{
    public class UserCreateDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email{ get; set; }
        public string Password { get; set; }
        public DateTime? BirthDate { get; set; }
        public State State => State.Created;
        public Role Role => Role.StandartUser;
        public DateTime CreatedDate => DateTime.Now;
    }
}
