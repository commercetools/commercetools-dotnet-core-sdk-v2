using commercetools.Sdk.Api.Models.Stores;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class BusinessUnitStoresSetMessagePayload : IBusinessUnitStoresSetMessagePayload
    {
        public string Type { get; set; }

        public IList<IStoreKeyReference> Stores { get; set; }
        public IEnumerable<IStoreKeyReference> StoresEnumerable { set => Stores = value.ToList(); }

        public BusinessUnitStoresSetMessagePayload()
        {
            this.Type = "BusinessUnitStoresSet";
        }
    }
}
