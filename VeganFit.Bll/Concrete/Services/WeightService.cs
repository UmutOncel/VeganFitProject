using VeganFit.Bll.Abstract.IServices;
using VeganFit.Models.DTOs.WeigthDtos;
using VeganFit.Models.VMs.WeightVms;
using VeganFit.Shared;

namespace VeganFit.Bll.Concrete.Services
{
    public class WeightService : IWeightService
    {
        public ResultService<WeightCreateDto> Create(WeightCreateVm weightCreate)
        {
            throw new NotImplementedException();
        }
    }
}
