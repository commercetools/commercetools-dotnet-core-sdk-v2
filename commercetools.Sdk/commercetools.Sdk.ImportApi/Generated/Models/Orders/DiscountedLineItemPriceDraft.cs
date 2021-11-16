using commercetools.ImportApi.Models.Common;
using System.Collections.Generic;


namespace commercetools.ImportApi.Models.Orders
{
    public partial class DiscountedLineItemPriceDraft : IDiscountedLineItemPriceDraft
    {
        public IMoney Value { get; set;}
        
        public List<IDiscountedLineItemPortion> IncludedDiscounts { get; set;}
    }
}
