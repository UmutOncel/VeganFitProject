using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeganFit.Core.Enums;

namespace VeganFit.Models.VMs.DataVms
{
    public class DataDetailVm
    {
        public string ProductName { get; set; }

        public int Calori { get; set; }

        public Meal Meal { get; set; }

        public string UserEmail { get; set; }

        public string Serving { get; set; }

    }
}
