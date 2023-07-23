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
    /// DataRepo'yu oluşturmak için Base klasörü içindeki BaseRepository class'ından ve IDataRepo'dan kalıtım verdik.
    /// </summary>
    public class DataRepo : BaseRepository<Data, VeganFitDbContext>, IDataRepo
    {
        public DataRepo(VeganFitDbContext context) : base(context)
        {
        }
    }
}
