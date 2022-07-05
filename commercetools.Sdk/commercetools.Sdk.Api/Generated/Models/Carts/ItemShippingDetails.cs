using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class ItemShippingDetails : IItemShippingDetails
    {
        public List<IItemShippingTarget> Targets { get; set; }

        public bool Valid { get; set; }
    }
}
