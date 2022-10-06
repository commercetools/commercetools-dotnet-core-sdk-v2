using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.Stores;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class BusinessUnitStoreModeChangedMessagePayload : IBusinessUnitStoreModeChangedMessagePayload
    {
        public string Type { get; set; }

        public List<IStoreKeyReference> Stores { get; set; }

        public IBusinessUnitStoreMode StoreMode { get; set; }

        public List<IStoreKeyReference> OldStores { get; set; }

        public IBusinessUnitStoreMode OldStoreMode { get; set; }
        public BusinessUnitStoreModeChangedMessagePayload()
        {
            this.Type = "BusinessUnitStoreModeChanged";
        }
    }
}
