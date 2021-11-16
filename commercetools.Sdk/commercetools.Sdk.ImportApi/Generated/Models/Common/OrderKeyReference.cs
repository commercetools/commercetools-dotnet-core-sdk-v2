namespace commercetools.ImportApi.Models.Common
{
    public partial class OrderKeyReference : IOrderKeyReference
    {
        public string Key { get; set;}
        
        public IReferenceType TypeId { get; set;}
        public OrderKeyReference()
        { 
           this.TypeId = IReferenceType.FindEnum("order");
        }
    }
}
