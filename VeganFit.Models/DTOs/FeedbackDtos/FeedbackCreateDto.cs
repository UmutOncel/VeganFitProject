namespace VeganFit.Models.DTOs.FeedbackDtos
{
    public class FeedbackCreateDto
    {
        public string Message { get; set; }
        public string UserName { get; set; }
        public DateTime CreatedDate => DateTime.Now;
    }
}
