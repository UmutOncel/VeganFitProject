using VeganFit.Core.Enums;

namespace VeganFit.Models.DTOs.ProductDtos
{
    public class ProductCreateDto:ProductBaseDto
    {
        public string CreatedBy { get; set; }
        public State State => State.Created;
        public DateTime CreateDate => DateTime.Now;
    }
}
