namespace VeganFit.Models.VMs.OptionalProductVms
{
    public class OptionalProductCreateVm
    {
        public string ProductName { get; set; }
        public double Calori { get; set; }
        public string Serving { get; set; }
        public byte[] Picture { get; set; }

        public string CreatedBy { get; set; }
    }
}
