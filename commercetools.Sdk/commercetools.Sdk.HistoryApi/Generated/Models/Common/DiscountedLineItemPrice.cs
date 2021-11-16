using System.Collections.Generic;


namespace commercetools.HistoryApi.Models.Common
{
    public partial class DiscountedLineItemPrice : IDiscountedLineItemPrice
    {
        public IMoney Value { get; set; }

        public List<IDiscountedLineItemPortion> IncludedDiscounts { get; set; }
    }
}
