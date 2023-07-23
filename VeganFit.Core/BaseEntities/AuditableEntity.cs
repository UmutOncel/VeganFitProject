using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeganFit.Core.BaseEntities
{
    /// <summary>
    /// BaseEntity'deki property'lerin yanında tam silmeye olanak tanıyan class açıldı.
    /// </summary>
    public abstract class AuditableEntity : BaseEntity
    {
        public DateTime? DeletedDate { get; set; }
        //Tam silme (Veri database'den kaldırılıyor)
    }
}
