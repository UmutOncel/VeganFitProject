using AutoMapper;
using VeganFit.Bll.Abstract.IServices;
using VeganFit.DAL.Abstract;
using VeganFit.Entities;
using VeganFit.Models.DTOs.FeedbackDtos;
using VeganFit.Models.VMs.FeedbackVms;
using VeganFit.Shared;

namespace VeganFit.Bll.Concrete.Services
{
    public class FeedbackService : IFeedbackService
    {
        private readonly IFeedbackRepo _feedbackRepo;
        private readonly IMapper _mapper;

        public FeedbackService(IMapper mapper , IFeedbackRepo feedbackRepo)
        {
            _feedbackRepo = feedbackRepo;
            _mapper = mapper;
        }

        /// <summary>
        /// Feedback tablosuna yeni veri ekleyen, eklemeye işleminde hata olursa hata ekleyen olmazsa sonucu döndüren metot. 
        /// </summary>
        /// <param name="createVm"></param>
        /// <returns></returns>
        public ResultService<FeedbackCreateDto> Create(FeedbackCreateVm createVm)
        {
            ResultService<FeedbackCreateDto> result = new ResultService<FeedbackCreateDto>();

            FeedbackCreateDto createDto = _mapper.Map<FeedbackCreateDto>(createVm);

            Feedback newFeedback=_mapper.Map<Feedback>(createDto);
            var addedFeedback = _feedbackRepo.Create(newFeedback);

            if (addedFeedback != null)
            {
                result.Data = createDto;
            }
            else
            {
                result.AddError(ErrorType.BadRequest, "Ekleme işlemi başarısız");
            }

            return result;
        }

        /// <summary>
        /// Feedback tablosundaki veriyi silen ve sonucu boolean olarak döndüren metot.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            Feedback feedback = _feedbackRepo.GetFirstOrDefault(filter:x=>x.Id == id);
            if (feedback != null)
            {
                return _feedbackRepo.Delete(feedback);
            }

            return false;
        }
    }
}
