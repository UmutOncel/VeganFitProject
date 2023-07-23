using VeganFit.Models.DTOs.OptionalProductDtos;
using VeganFit.Models.VMs.OptionalProductVms;
using VeganFit.Shared;

namespace VeganFit.Bll.Abstract.IServices
{
    public interface IOptionalProductService
    {
        ResultService<OptionalProductCreateDto> Create(OptionalProductCreateVm productCreateVm);

        bool Delete(int id);
    }
}
