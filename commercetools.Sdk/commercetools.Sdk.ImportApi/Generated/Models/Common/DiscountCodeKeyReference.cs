namespace commercetools.ImportApi.Models.Common
{
    public partial class DiscountCodeKeyReference : IDiscountCodeKeyReference
    {
        public string Key { get; set;}
        
        public IReferenceType TypeId { get; set;}
        public DiscountCodeKeyReference()
        { 
           this.TypeId = IReferenceType.FindEnum("discount-code");
        }
    }
}
