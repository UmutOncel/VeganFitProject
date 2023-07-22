﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeganFit.Core.BaseEntities;

namespace VeganFit.Entities
{
    public class OptionalProduct : BaseEntity
    {
        public string ProductName { get; set; }
        public int Calori { get; set; }
        public string? Serving { get; set; }
        public byte[]? Picture { get; set; }
        public virtual ICollection<Data> Datas { get; set; }
        public OptionalProduct()
        {
            Datas = new HashSet<Data>();
        }
    }
}