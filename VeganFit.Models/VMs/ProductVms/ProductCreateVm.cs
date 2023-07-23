namespace VeganFit.Models.VMs.ProductVms
{
    public class ProductCreateVm : ProductBaseVm
    {
        public string CreatedBy { get; set; }
        public DateTime RecordDate => DateTime.Now;
    }
}
