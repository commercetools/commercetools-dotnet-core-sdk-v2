using System.Collections.Generic;


namespace commercetools.Sdk.HistoryApi.Models.Common
{
    public partial class DiscountedLineItemPrice : IDiscountedLineItemPrice
    {
        public IMoney Value { get; set; }

        public List<IDiscountedLineItemPortion> IncludedDiscounts { get; set; }
    }
}
