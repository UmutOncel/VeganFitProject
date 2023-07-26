using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeganFit.Core.BaseEntities;

namespace VeganFit.Entities
{
    /// <summary>
    /// Weight class'ının property'leri tanımlandı. Ortak property'ler için BaseEntity class'ından kalıtım alındı.
    /// </summary>
    public class Weight : BaseEntity
    {
        public double UserWeight { get; set; }

        public string UserName { get; set; }
        public DateTime RecordDate { get; set; }
        public virtual User User { get; set; }
        public int? UserId { get; set; }
    }
}
