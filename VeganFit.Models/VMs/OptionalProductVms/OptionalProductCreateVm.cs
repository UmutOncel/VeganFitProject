namespace VeganFit.Models.VMs.OptionalProductVms
{
    public class OptionalProductCreateVm
    {
        public string ProductName { get; set; }
        public int Calori { get; set; }
        public string Serving { get; set; }
        public string Picture { get; set; }

        public string CreatedBy { get; set; }
    }
}
