using commercetools.Sdk.Api.Models.Stores;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class CartDiscountStoresSetMessagePayload : ICartDiscountStoresSetMessagePayload
    {
        public string Type { get; set; }

        public IList<IStoreKeyReference> Stores { get; set; }

        public IEnumerable<IStoreKeyReference> StoresEnumerable { set => Stores = value.ToList(); }
        public CartDiscountStoresSetMessagePayload()
        {
            this.Type = "CartDiscountStoresSet";
        }
    }
}
