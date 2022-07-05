using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartUpdate : ICartUpdate
    {
        public long Version { get; set; }

        public List<ICartUpdateAction> Actions { get; set; }
    }
}
