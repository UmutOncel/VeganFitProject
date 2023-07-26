using VeganFit.Core.Enums;

namespace VeganFit.Models.DTOs.WeigthDtos
{
    public class WeightCreateDto
    {
        public double UserWeight { get; set; }

        public string UserName { get; set; }

        public State State => State.Created;

        public DateTime RecordDate { get; set; }

        public string CreatedBy { get; set; }
       
    }
}
