using VeganFit.Models.DTOs.WeigthDtos;
using VeganFit.Models.VMs.WeightVms;
using VeganFit.Shared;

namespace VeganFit.Bll.Abstract.IServices
{
    public interface IWeightService
    {
        ResultService<WeightCreateDto> Create(WeightCreateVm weightCreate);
    }
}
