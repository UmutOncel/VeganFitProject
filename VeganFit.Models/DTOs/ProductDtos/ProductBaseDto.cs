namespace VeganFit.Models.DTOs.ProductDtos
{
    public class ProductBaseDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public DateTime RecordDate { get; set; }

        public byte[] Picture { get; set; }

        public string Serving { get; set; }

        public int Calori { get; set; }

    }
}
