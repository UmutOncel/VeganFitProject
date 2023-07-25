using AutoMapper;
using VeganFit.Bll.Abstract.IServices;
using VeganFit.Core.Enums;
using VeganFit.DAL.Abstract;
using VeganFit.Entities;
using VeganFit.Models.DTOs.DataDtos;
using VeganFit.Models.VMs.DataVms;
using VeganFit.Shared;

namespace VeganFit.Bll.Concrete.Services
{
    public class DataService : IDataService
    {
        private readonly IDataService _data;
        private readonly IDataRepo _dataRepo;
        private readonly IMapper _mapper;

        public ResultService<DataDetailDto> Create(DataDetailDto detailDto)
        {
            ResultService<DataDetailDto> result = new ResultService<DataDetailDto>();

            Data newData = _mapper.Map<Data>(detailDto);
            var addData = _dataRepo.Create(newData);
            if(addData != null)
            {
                result.Data = detailDto;
            }
            else
            {
                result.AddError(ErrorType.BadRequest, "Ekleme işlemi başarısız");
            }

            return result;
        }

        public ResultService<List<DataDetailVm>> GetDetails()
        {
            ResultService<List<DataDetailVm>> result = new ResultService<List<DataDetailVm>>();

            var datas = _dataRepo.GetFilteredList(select: x => new DataDetailVm
            {
                ProductName = x.Product.ProductName,
                Calori = x.Calori

            },where:x=>x.State != State.Deleted,includes:x=>x.Product);

            if (datas != null)
            {
                result.Data = datas.ToList();
            }
            else
            {
                result.AddError(ErrorType.BadRequest, "Beklenmedik bir hata ile karşılaşıldı");
            }

            return result;
        }
    }
}
