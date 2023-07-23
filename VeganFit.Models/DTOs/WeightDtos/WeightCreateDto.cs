using VeganFit.Core.Enums;

namespace VeganFit.Models.DTOs.WeigthDtos
{
    public class WeightCreateDto
    {
        public int Weight { get; set; }

        public State State => State.Created;

        public string CreatedBy { get; set; }
    }
}
