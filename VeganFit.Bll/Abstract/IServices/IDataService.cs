using VeganFit.Models.DTOs.DataDtos;
using VeganFit.Models.VMs.DataVms;
using VeganFit.Shared;

namespace VeganFit.Bll.Abstract.IServices
{
    public interface IDataService
    {
        ResultService<List<DataDetailVm>> GetDetails();

        ResultService<DataDetailDto> Create(DataDetailDto detailDto);
    }
}
