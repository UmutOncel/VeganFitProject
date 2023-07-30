using AutoMapper;
using VeganFit.Bll.Abstract.IServices;
using VeganFit.DAL.Abstract;
using VeganFit.Entities;
using VeganFit.Models.DTOs.WeigthDtos;
using VeganFit.Models.VMs.WeightVms;
using VeganFit.Shared;

namespace VeganFit.Bll.Concrete.Services
{
    public class WeightService : IWeightService
    {
        private readonly IWeightRepo _weightRepo;
        private readonly IMapper _mapper;

        public WeightService(IMapper mapper , IWeightRepo weightRepo)
        {
            _mapper = mapper;
            _weightRepo = weightRepo;
        }

        /// <summary>
        /// Weight tablosuna yeni veri ekleyen, eklemeye işleminde hata olursa hata ekleyen olmazsa sonucu döndüren metot.
        /// </summary>
        /// <param name="weightCreate"></param>
        /// <returns></returns>
        public ResultService<WeightCreateDto> Create(WeightCreateVm weightCreate)
        {
            ResultService<WeightCreateDto> result = new ResultService<WeightCreateDto>();

            WeightCreateDto createDto = _mapper.Map<WeightCreateDto>(weightCreate);
            
            Weight newWeight = _mapper.Map<Weight>(createDto);
            var addedWeight =_weightRepo.Create(newWeight);
            if (addedWeight != null)
            {
                result.Data = createDto;
            }
            else
            {
                result.AddError(ErrorType.BadRequest, "Ekleme işleminde hata..");
            }
            
            return result;
        }
    }
}
