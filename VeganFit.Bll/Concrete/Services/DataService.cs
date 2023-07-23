using VeganFit.Bll.Abstract.IServices;
using VeganFit.Core.Enums;
using VeganFit.DAL.Abstract;
using VeganFit.Models.DTOs.DataDtos;
using VeganFit.Models.VMs.DataVms;
using VeganFit.Shared;

namespace VeganFit.Bll.Concrete.Services
{
    public class DataService : IDataService
    {
        private readonly IDataService _data;
        private readonly IDataRepo _dataRepo;
        public ResultService<DataDetailDto> GetDetails()
        {
            ResultService<List<DataDetailVm>> result = new ResultService<List<DataDetailVm>>();

            //var datas = _dataRepo.GetFilteredList(select: x => new DataDetailVm
            //{
            //    ProductName = x.Product.ProductName,
            //    Calori = x.Calori

            //});

            //if(datas != null )
            //{
            //    result.Data = datas.ToList();
            //}
            //else
            //{
            //    result.AddError(ErrorType.BadRequest, "Beklenmedik bir hata ile karşılaşıldı");
            //}

            return
        }
    }
}
