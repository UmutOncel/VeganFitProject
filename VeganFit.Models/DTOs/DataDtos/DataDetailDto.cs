using VeganFit.Core.Enums;

namespace VeganFit.Models.DTOs.DataDtos
{
    public class DataDetailDto
    {
        public string ProductName { get; set; }

        public Meal Meal { get; set; }
        public int Calori { get; set; }

        public string UserEmail { get; set; }
        public string? Serving { get; set; }
        public byte[] Picture { get; set; }
        public DateTime Datetime { get; set; }
    }
}
