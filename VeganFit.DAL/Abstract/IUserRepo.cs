using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeganFit.Core.IBaseRepositories;
using VeganFit.Entities;

namespace VeganFit.DAL.Abstract
{
    public interface IUserRepo : IBaseRepository<User>
    {
    }
}
