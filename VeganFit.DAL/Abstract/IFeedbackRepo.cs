using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeganFit.Core.IBaseRepositories;
using VeganFit.Entities;

namespace VeganFit.DAL.Abstract
{
    /// <summary>
    /// Feedback entity'sinin metotlarını oluşturmak için Core katmanında generic olarak oluşturulan IBaseRepository interface'inden kalıtım alındı.
    /// </summary>
    public interface IFeedbackRepo : IBaseRepository<Feedback>
    {
    }
}
