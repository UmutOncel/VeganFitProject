using VeganFit.Core.Enums;

namespace VeganFit.Models.DTOs.OptionalProductDtos
{
    public class OptionalProductCreateDto
    {
        public string CreatedBy { get; set; }
        public State State => State.Created;

        public DateTime CreateDate = DateTime.Now;
    }
}
