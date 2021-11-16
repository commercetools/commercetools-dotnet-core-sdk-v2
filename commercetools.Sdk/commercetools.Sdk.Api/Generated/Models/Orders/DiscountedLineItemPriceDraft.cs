using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using System.Collections.Generic;


namespace commercetools.Api.Models.Orders
{
    public partial class DiscountedLineItemPriceDraft : IDiscountedLineItemPriceDraft
    {
        public IMoney Value { get; set; }

        public List<IDiscountedLineItemPortion> IncludedDiscounts { get; set; }
    }
}
