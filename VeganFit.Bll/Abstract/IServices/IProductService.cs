using VeganFit.Models.DTOs.ProductDtos;
using VeganFit.Models.VMs.ProductVms;
using VeganFit.Shared;

namespace VeganFit.Bll.Abstract.IServices
{
    public interface IProductService
    {
        bool IsExistProduct(string productName);

        ResultService<ProductCreateDto> Create(ProductCreateVm createVm);
        ResultService<ProductUpdateDto> Update(ProductUpdateVm updateVm);

        bool Delete(int id);
    }
}
