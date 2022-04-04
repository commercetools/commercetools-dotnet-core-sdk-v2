using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Stores
{
    public partial class StoreUpdate : IStoreUpdate
    {
        public long Version { get; set; }

        public List<IStoreUpdateAction> Actions { get; set; }
    }
}
