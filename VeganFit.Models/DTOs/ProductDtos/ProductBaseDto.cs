namespace VeganFit.Models.DTOs.ProductDtos
{
    public class ProductBaseDto
    {
        public int Id { get; set; }
        public string ProductName { get; set; }

        public DateTime RecordDate { get; set; }

        public byte[] Picture { get; set; }

        public string Serving { get; set; }

        public double Calori { get; set; }

    }
}
