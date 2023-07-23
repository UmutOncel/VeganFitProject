using VeganFit.Bll.Abstract.IServices;
using VeganFit.Models.DTOs.FeedbackDtos;
using VeganFit.Models.VMs.FeedbackVms;
using VeganFit.Shared;

namespace VeganFit.Bll.Concrete.Services
{
    public class FeedbackService : IFeedbackService
    {
        public ResultService<FeedbackCreateDto> Create(FeedbackCreateVm createVm)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
