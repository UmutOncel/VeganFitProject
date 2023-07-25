namespace VeganFit.Models.VMs.WeightVms
{
    public class WeightCreateVm
    {
        public int UserWeight { get; set; }

        public string UserName { get; set; }
        public DateTime RecordDate => DateTime.Now;

       
    }
}
