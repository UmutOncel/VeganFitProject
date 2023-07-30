using VeganFit.Models.DTOs.FeedbackDtos;
using VeganFit.Models.VMs.FeedbackVms;
using VeganFit.Shared;

namespace VeganFit.Bll.Abstract.IServices
{
    public interface IFeedbackService
    {
        /// <summary>
        /// Feedback tablosuna yeni veri ekleyen, eklemeye işleminde hata olursa hata ekleyen olmazsa sonucu döndüren metot. 
        /// </summary>
        /// <param name="createVm"></param>
        /// <returns></returns>
        ResultService<FeedbackCreateDto> Create(FeedbackCreateVm createVm);

        /// <summary>
        /// Feedback tablosundaki veriyi silen ve sonucu boolean olarak döndüren metot.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Delete(int id);
    }
}
