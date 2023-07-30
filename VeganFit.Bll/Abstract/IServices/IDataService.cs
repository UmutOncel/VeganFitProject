using VeganFit.Models.DTOs.DataDtos;
using VeganFit.Models.VMs.DataVms;
using VeganFit.Shared;

namespace VeganFit.Bll.Abstract.IServices
{
    public interface IDataService
    {
        /// <summary>
        /// Data tablosundaki verileri şarta bağlı olarak listeleyen, o şartta veri yok ise hata oluşturan ve sonucu döndüren metot. 
        /// </summary>
        /// <returns></returns>
        ResultService<List<DataDetailVm>> GetDetails();

        /// <summary>
        /// Data tablosuna yeni veri ekleyen, eklemeye işleminde hata olursa hata ekleyen olmazsa sonucu döndüren metot. 
        /// </summary>
        /// <param name="dataDetail"></param>
        /// <returns></returns>
        ResultService<DataDetailDto> Create(DataDetailDto dataDetail);

        /// <summary>
        /// Data tablosundaki veriyi silen ve sonucu boolean olarak döndüren metot.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Delete(int id);
    }
}
