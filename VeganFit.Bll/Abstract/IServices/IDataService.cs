using VeganFit.Models.DTOs.DataDtos;
using VeganFit.Shared;

namespace VeganFit.Bll.Abstract.IServices
{
    public interface IDataService
    {
        ResultService<DataDetailDto> GetDetails();
    }
}
