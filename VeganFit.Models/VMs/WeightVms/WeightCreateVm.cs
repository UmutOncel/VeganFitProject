namespace VeganFit.Models.VMs.WeightVms
{
    public class WeightCreateVm
    {
        public int Weight { get; set; }

        public DateTime RecordDate => DateTime.Now;
    }
}
