using VeganFit.Models.DTOs.FeedbackDtos;
using VeganFit.Models.VMs.FeedbackVms;
using VeganFit.Shared;

namespace VeganFit.Bll.Abstract.IServices
{
    public interface IFeedbackService
    {
        ResultService<FeedbackCreateDto> Create(FeedbackCreateVm createVm);

        bool Delete(int id);
    }
}
