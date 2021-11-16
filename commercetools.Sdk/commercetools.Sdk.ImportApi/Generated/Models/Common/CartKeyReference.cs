namespace commercetools.ImportApi.Models.Common
{
    public partial class CartKeyReference : ICartKeyReference
    {
        public string Key { get; set;}
        
        public IReferenceType TypeId { get; set;}
        public CartKeyReference()
        { 
           this.TypeId = IReferenceType.FindEnum("cart");
        }
    }
}
