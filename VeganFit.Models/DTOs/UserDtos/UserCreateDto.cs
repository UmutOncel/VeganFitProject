using VeganFit.Core.Enums;

namespace VeganFit.Models.DTOs.UserDtos
{
    public class UserCreateDto
    {
        public string Email{ get; set; }
        public string Password { get; set; }

        public State State => State.Created;

        public Role Role => Role.StandartUser;

        public DateTime CreatedDate => DateTime.Now;
    }
}
