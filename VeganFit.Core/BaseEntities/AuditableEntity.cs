using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeganFit.Core.BaseEntities
{
    public abstract class AuditableEntity : BaseEntity
    {
        public DateTime? DeletedDate { get; set; }      //tam silme.
    }
}
