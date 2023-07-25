using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeganFit.Core.BaseEntities;

namespace VeganFit.Entities
{
    /// <summary>
    /// Product class'ının property'leri tanımlandı. Ortak property'ler için BaseEntity class'ından kalıtım alındı.
    /// </summary>
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public double Calori { get; set; }
        public string? Serving { get; set; }
        public byte[] Picture { get; set; }
        public virtual ICollection<Data> Datas { get; set; }
        public Product()
        {
            Datas = new HashSet<Data>();
        }
    }
}
