using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Stores
{
    public partial class StoreResourceIdentifier : IStoreResourceIdentifier
    {
        public IReferenceTypeId TypeId { get; set;}
        
        public string Id { get; set;}
        
        public string Key { get; set;}
        public StoreResourceIdentifier()
        { 
           this.TypeId = IReferenceTypeId.FindEnum("store");
        }
    }
}
