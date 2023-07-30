using VeganFit.Models.DTOs.WeigthDtos;
using VeganFit.Models.VMs.WeightVms;
using VeganFit.Shared;

namespace VeganFit.Bll.Abstract.IServices
{
    public interface IWeightService
    {
        /// <summary>
        /// Weight tablosuna yeni veri ekleyen, eklemeye işleminde hata olursa hata ekleyen olmazsa sonucu döndüren metot.
        /// </summary>
        /// <param name="weightCreate"></param>
        /// <returns></returns>
        ResultService<WeightCreateDto> Create(WeightCreateVm weightCreate);
    }
}
