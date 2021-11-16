namespace commercetools.ImportApi.Models.Common
{
    public partial class ProductKeyReference : IProductKeyReference
    {
        public string Key { get; set;}
        
        public IReferenceType TypeId { get; set;}
        public ProductKeyReference()
        { 
           this.TypeId = IReferenceType.FindEnum("product");
        }
    }
}
