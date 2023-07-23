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
    /// FeedbackRepo'yu oluşturmak için Base klasörü içindeki BaseRepository class'ından ve IFeedbackRepo'dan kalıtım verdik.
    /// </summary>
    public class FeedbackRepo : BaseRepository<Feedback, VeganFitDbContext>, IFeedbackRepo
    {
        public FeedbackRepo(VeganFitDbContext context) : base(context)
        {
        }
    }
}
