using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeganFit.Core.BaseEntities;

namespace VeganFit.Entities
{
    public class Feedback : BaseEntity
    {
        public string MessageText { get; set; }
        public virtual User User { get; set; }
        public int UserId { get; set; }
    }
}
