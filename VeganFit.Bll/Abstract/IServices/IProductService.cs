using VeganFit.Models.DTOs.ProductDtos;
using VeganFit.Models.VMs.ProductVms;
using VeganFit.Shared;

namespace VeganFit.Bll.Abstract.IServices
{
    public interface IProductService
    {
        /// <summary>
        /// Product tablosunda parametre olarak girilen ürünün olup olmadığı bulan ve sonucu boolean olarak döndüren metot.
        /// </summary>
        /// <param name="productName"></param>
        /// <returns></returns>
        bool IsExistProduct(string productName);

        /// <summary>
        /// Product tablosuna yeni veri ekleyen, eklemeye işleminde hata olursa hata ekleyen olmazsa sonucu döndüren metot.
        /// </summary>
        /// <param name="createVm"></param>
        /// <returns></returns>
        ResultService<ProductCreateDto> Create(ProductCreateVm createVm);

        /// <summary>
        /// Product tablosundaki veriyi güncelleyen, güncelleme işleminde hata olursa hata ekleyen olmazsa sonucu döndüren metot.
        /// </summary>
        /// <param name="updateVm"></param>
        /// <returns></returns>
        ResultService<ProductUpdateDto> Update(ProductUpdateVm updateVm);

        /// <summary>
        /// Product tablosundaki veriyi silen ve sonucu boolean olarak döndüren metot.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Delete(int id);
    }
}
