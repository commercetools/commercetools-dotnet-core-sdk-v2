

namespace commercetools.Sdk.ImportApi.Models.Common
{

    public partial class StoreKeyReference : IStoreKeyReference
    {
        public string Key { get; set; }

        public IReferenceType TypeId { get; set; }
        public StoreKeyReference()
        {
            this.TypeId = IReferenceType.FindEnum("store");
        }
    }
}
