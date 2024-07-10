using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Stores
{

    public partial class StoreReference : IStoreReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public IStore Obj { get; set; }
        public StoreReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("store");
        }
    }
}
