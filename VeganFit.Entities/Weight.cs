using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeganFit.Core.BaseEntities;

namespace VeganFit.Entities
{
    public class Weight : BaseEntity
    {
        public int UserWeight { get; set; }
        public DateTime DateOfRecord { get; set; }    //baseentity içindeki createddate bu propu karşılar mı?
        public virtual User User { get; set; }
        public int UserId { get; set; }
    }
}
