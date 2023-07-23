using VeganFit.Core.Enums;

namespace VeganFit.Models.DTOs.DataDtos
{
    public class DataDetailDto
    {
        public string ProductName { get; set; }

        public Meal Meal { get; set; }
        public int Calori { get; set; }
    }
}
