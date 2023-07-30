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

        /// <summary>
        /// Product tablosuna yeni veri ekleyen, eklemeye işleminde hata olursa hata ekleyen olmazsa sonucu döndüren metot.
        /// </summary>
        /// <param name="createVm"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Product tablosundaki veriyi silen ve sonucu boolean olarak döndüren metot.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            Product product = _productRepo.GetFirstOrDefault(filter:x=>x.Id == id);

            if ( product != null )
            {
                return _productRepo.Delete(product);
            }

            return false;
        }

        /// <summary>
        /// Product tablosunda parametre olarak girilen ürünün olup olmadığı bulan ve sonucu boolean olarak döndüren metot.
        /// </summary>
        /// <param name="productName"></param>
        /// <returns></returns>
        public bool IsExistProduct(string productName)
        {
            return _productRepo.Any(x=>x.ProductName.Equals(productName));
        }

        /// <summary>
        /// Product tablosundaki veriyi güncelleyen, güncelleme işleminde hata olursa hata ekleyen olmazsa sonucu döndüren metot.
        /// </summary>
        /// <param name="updateVm"></param>
        /// <returns></returns>
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
