using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Carts
{
    public partial class ItemShippingDetailsDraft : IItemShippingDetailsDraft
    {
        public List<IItemShippingTarget> Targets { get; set; }
    }
}
