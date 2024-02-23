using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Stores
{

    public partial class StoreKeyReference : IStoreKeyReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Key { get; set; }
        public StoreKeyReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("store");
        }
    }
}
