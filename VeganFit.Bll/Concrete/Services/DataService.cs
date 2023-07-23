using VeganFit.Bll.Abstract.IServices;
using VeganFit.Models.DTOs.DataDtos;
using VeganFit.Shared;

namespace VeganFit.Bll.Concrete.Services
{
    public class DataService : IDataService
    {
        public ResultService<DataDetailDto> GetDetails(int id)
        {
            throw new NotImplementedException();
        }
    }
}
