namespace VeganFit.Models.DTOs.OptionalProductDtos
{
    public class OptionalProductBaseDto
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public DateTime RecordDate { get; set; }

        public string Picture { get; set; }

        public string Serving { get; set; }

        public double Calori { get; set; }
    }
}
