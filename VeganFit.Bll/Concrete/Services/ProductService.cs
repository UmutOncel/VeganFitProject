using AutoMapper;
using VeganFit.Bll.Abstract.IServices;
using VeganFit.DAL.Abstract;
using VeganFit.Entities;
using VeganFit.Models.DTOs.ProductDtos;
using VeganFit.Models.VMs.ProductVms;
using VeganFit.Shared;

namespace VeganFit.Bll.Concrete.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepo _productRepo;
        private readonly IMapper _mapper;

        public ProductService(IMapper mapper,IProductRepo productRepo )
        {
            _productRepo = productRepo;
            _mapper = mapper;
        }
        public ResultService<ProductCreateDto> Create(ProductCreateVm createVm)
        {
            ResultService<ProductCreateDto> result = new ResultService<ProductCreateDto>();

            ProductCreateDto createDto = _mapper.Map<ProductCreateDto>( createVm );
            
            Product newProduct = _mapper.Map<Product>( createDto );
            var addedProduct = _productRepo.Create(newProduct );

            if ( addedProduct != null )
            {
                result.Data = createDto;
            }
            else
            {
                result.AddError(ErrorType.BadRequest, "Ekleme işlemi başarısız");
            }
            return result;
        }

        public bool Delete(int id)
        {
            Product product = _productRepo.GetFirstOrDefault(filter:x=>x.Id == id);

            if ( product != null )
            {
                return _productRepo.Delete(product);
            }

            return false;

        }

        public bool IsExistProduct(string productName)
        {
            return _productRepo.Any(x=>x.ProductName.Equals(productName));
        }

        public ResultService<ProductUpdateDto> Update(ProductUpdateVm updateVm)
        {
            ResultService<ProductUpdateDto> result = new ResultService<ProductUpdateDto>();

            var updateDto = _mapper.Map<ProductUpdateDto>( updateVm );
            
            var data = _mapper.Map<Product>( updateDto );

            var updateData = _productRepo.Update(data);

            if ( updateData != null )
            {
                result.Data = updateDto;
            }
            else
            {
                result.AddError(ErrorType.BadRequest, "Güncelleme başarısız !!"); 
            }
            return result;
        }
    }
}
