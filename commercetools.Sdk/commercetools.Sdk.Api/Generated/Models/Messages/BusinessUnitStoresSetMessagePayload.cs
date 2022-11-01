using commercetools.Sdk.Api.Models.Stores;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class BusinessUnitStoresSetMessagePayload : IBusinessUnitStoresSetMessagePayload
    {
        public string Type { get; set; }

        public List<IStoreKeyReference> Stores { get; set; }
        public BusinessUnitStoresSetMessagePayload()
        {
            this.Type = "BusinessUnitStoresSet";
        }
    }
}
