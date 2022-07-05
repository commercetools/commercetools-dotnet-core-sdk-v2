using commercetools.Sdk.ImportApi.Models.Common;
using System.Collections.Generic;


namespace commercetools.Sdk.ImportApi.Models.Orders
{

    public partial class DiscountedLineItemPriceDraft : IDiscountedLineItemPriceDraft
    {
        public IMoney Value { get; set; }

        public List<IDiscountedLineItemPortion> IncludedDiscounts { get; set; }
    }
}
