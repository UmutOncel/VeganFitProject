using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeganFit.Core.BaseEntities;
using VeganFit.Core.Enums;

namespace VeganFit.Entities
{
    public class Data : BaseEntity
    {
        public int Calori { get; set; }
        public DateTime Datetime { get; set; }      //baseentity createdtime aynı olur mu?
        public Meal Meal { get; set; }
        public virtual User User { get; set; }
        public int UserId { get; set; }
        public virtual Product Product { get; set; }
        public int ProductId { get; set; }
        public virtual OptionalProduct OptionalProduct { get; set; }
        public int OptionalProductId { get; set; }
    }
}
