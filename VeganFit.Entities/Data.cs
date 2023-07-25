using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeganFit.Core.BaseEntities;
using VeganFit.Core.Enums;

namespace VeganFit.Entities
{
    /// <summary>
    /// Data class'ının property'leri tanımlandı. Ortak property'ler için BaseEntity class'ından kalıtım alındı.
    /// </summary>
    public class Data : BaseEntity
    {
        public string ProductName { get; set; }
        public int Calori { get; set; }
        public DateTime Datetime { get; set; }
        public Meal Meal { get; set; }
        public virtual User User { get; set; }
        public int? UserId { get; set; }
        public string UserEmail { get; set; }
        public virtual Product Product { get; set; }
        public int? ProductId { get; set; }
        public virtual OptionalProduct OptionalProduct { get; set; }
        public int? OptionalProductId { get; set; }
    }
}
