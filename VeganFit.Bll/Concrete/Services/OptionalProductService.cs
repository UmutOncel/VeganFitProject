using AutoMapper;
using VeganFit.Bll.Abstract.IServices;
using VeganFit.DAL.Abstract;
using VeganFit.Entities;
using VeganFit.Models.DTOs.OptionalProductDtos;
using VeganFit.Models.VMs.OptionalProductVms;
using VeganFit.Shared;

namespace VeganFit.Bll.Concrete.Services
{
    public class OptionalProductService : IOptionalProductService
    {
        private readonly IOptionalProductRepo _opRepo;
        private readonly IMapper _mapper;

        public OptionalProductService(IOptionalProductRepo optionalProduct,IMapper mapper)
        {
            _mapper = mapper;
            _opRepo = optionalProduct;
        }
        public ResultService<OptionalProductCreateDto> Create(OptionalProductCreateVm productCreateVm)
        {
            ResultService<OptionalProductCreateDto> result = new ResultService<OptionalProductCreateDto>();

            OptionalProductCreateDto createDto = _mapper.Map<OptionalProductCreateDto>(productCreateVm);

            OptionalProduct newOp = _mapper.Map<OptionalProduct>(createDto);
            var addedOp = _opRepo.Create(newOp);
            if (addedOp != null)
            {
                result.Data = createDto;
            }
            else
            {
                result.AddError(ErrorType.BadRequest, "Ekleme işlemi başarısız sonuçlandı..");
            }

            return result;
        }

        public bool Delete(int id)
        {
            OptionalProduct op = _opRepo.GetFirstOrDefault(filter: filter => filter.Id == id);


            if (op != null)
            {
                return _opRepo.Delete(op);
            }

            return false;
        }
    }
}
