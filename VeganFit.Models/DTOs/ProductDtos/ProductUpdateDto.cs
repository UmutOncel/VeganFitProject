using VeganFit.Core.Enums;

namespace VeganFit.Models.DTOs.ProductDtos
{
    public class ProductUpdateDto:ProductBaseDto
    {
        public State State => State.Updated;

        public DateTime UpdateDate => DateTime.Now;
        public string UpdatedBy { get; set; }
    }
}
