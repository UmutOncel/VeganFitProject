using AutoMapper;
using VeganFit.Bll.Abstract.IServices;
using VeganFit.Entities;
using VeganFit.Models.DTOs.ProductDtos;
using VeganFit.Models.VMs.ProductVms;
using VeganFit.Shared;

namespace VeganFit.Bll.Concrete.Services
{
    public class ProductService : IProductService
    {
        //private readonly IProductRepo _productRepo;
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductService(IMapper mapper )
        {
            _mapper = mapper;
        }
        public ResultService<ProductCreateDto> Create(ProductCreateVm createVm)
        {
            ResultService<ProductCreateDto> result = new ResultService<ProductCreateDto>();

            ProductCreateDto createDto = _mapper.Map<ProductCreateDto>( createVm );
            
            Product newProduct = _mapper.Map<Product>( createDto );
            //var addedProduct = _productRepo.Create(newProduct );

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
            throw new NotImplementedException();
        }

        public bool IsExistProduct(string productName)
        {
            throw new NotImplementedException();
        }

        public ResultService<ProductUpdateDto> Update(ProductUpdateVm updateVm)
        {
            throw new NotImplementedException();
        }
    }
}
