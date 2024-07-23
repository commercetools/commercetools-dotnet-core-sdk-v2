using commercetools.Sdk.Api.Models.Stores;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.CartDiscounts
{

    public partial class CartDiscountSetStoresAction : ICartDiscountSetStoresAction
    {
        public string Action { get; set; }

        public IList<IStoreResourceIdentifier> Stores { get; set; }
        public IEnumerable<IStoreResourceIdentifier> StoresEnumerable { set => Stores = value.ToList(); }

        public CartDiscountSetStoresAction()
        {
            this.Action = "setStores";
        }
    }
}
