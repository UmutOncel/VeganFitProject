using VeganFit.Bll.Abstract.IServices;
using VeganFit.Models.DTOs.OptionalProductDtos;
using VeganFit.Models.VMs.OptionalProductVms;
using VeganFit.Shared;

namespace VeganFit.Bll.Concrete.Services
{
    public class OptionalProductService : IOptionalProductService
    {
        public ResultService<OptionalProductCreateDto> Create(OptionalProductCreateVm productCreateVm)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
