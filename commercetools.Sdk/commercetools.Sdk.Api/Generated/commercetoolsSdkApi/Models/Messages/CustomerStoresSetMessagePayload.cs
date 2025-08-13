using commercetools.Sdk.Api.Models.Stores;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class CustomerStoresSetMessagePayload : ICustomerStoresSetMessagePayload
    {
        public string Type { get; set; }

        public IList<IStoreKeyReference> Stores { get; set; }

        public IEnumerable<IStoreKeyReference> StoresEnumerable { set => Stores = value.ToList(); }

        public IList<IStoreKeyReference> OldStores { get; set; }

        public IEnumerable<IStoreKeyReference> OldStoresEnumerable { set => OldStores = value.ToList(); }
        public CustomerStoresSetMessagePayload()
        {
            this.Type = "CustomerStoresSet";
        }
    }
}
