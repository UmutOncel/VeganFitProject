using AutoMapper;
using VeganFit.Bll.Abstract.IServices;
using VeganFit.Core.Enums;
using VeganFit.DAL.Abstract;
using VeganFit.DAL.Concrete.Repositories;
using VeganFit.Entities;
using VeganFit.Models.DTOs.DataDtos;
using VeganFit.Models.VMs.DataVms;
using VeganFit.Shared;

namespace VeganFit.Bll.Concrete.Services
{
    public class DataService : IDataService
    {
        private readonly IDataRepo _dataRepo;
        private readonly IMapper _mapper;

        public DataService(IMapper mapper,IDataRepo dataRepo)
        {
            _mapper = mapper;
            _dataRepo = dataRepo;
        }

        public ResultService<DataDetailDto> Create(DataDetailDto dataDetail)
        {
            ResultService<DataDetailDto> result = new ResultService<DataDetailDto>();

            Data newData = _mapper.Map<Data>(dataDetail);
            var addData = _dataRepo.Create(newData);
            if(addData != null)
            {
                result.Data = dataDetail;
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

        public bool Delete(int id)
        {
            Data data = _dataRepo.GetFirstOrDefault(filter: x => x.Id == id);

            if (data != null)
            {
                return _dataRepo.Delete(data);
            }

            return false;
        }
    }
}
