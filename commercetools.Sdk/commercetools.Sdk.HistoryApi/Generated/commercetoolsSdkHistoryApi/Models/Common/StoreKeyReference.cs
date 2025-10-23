

namespace commercetools.Sdk.HistoryApi.Models.Common
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
