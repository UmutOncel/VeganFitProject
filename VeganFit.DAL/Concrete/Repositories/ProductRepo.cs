using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeganFit.DAL.Abstract;
using VeganFit.DAL.Base.EntityFramework;
using VeganFit.DAL.Concrete.Context;
using VeganFit.Entities;

namespace VeganFit.DAL.Concrete.Repositories
{
    /// <summary>
    /// ProductRepo'yu oluşturmak için Base klasörü içindeki BaseRepository class'ından ve IProductRepo'dan kalıtım verdik.
    /// </summary>
    /// <param name="context"></param>
    public class ProductRepo : BaseRepository<Product, VeganFitDbContext>, IProductRepo
    {
        public ProductRepo(VeganFitDbContext context) : base(context)
        {
        }
    }
}
