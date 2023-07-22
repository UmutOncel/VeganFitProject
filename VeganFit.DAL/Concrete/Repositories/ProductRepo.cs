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
    public class ProductRepo : BaseRepository<Product, VeganFitDbContext>, IProductRepo
    {
        public ProductRepo(VeganFitDbContext context) : base(context)
        {
        }
    }
}
