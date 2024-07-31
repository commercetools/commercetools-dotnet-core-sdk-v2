using commercetools.Sdk.ImportApi.Models.Common;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.ImportApi.Models.Orders
{

    public partial class DiscountedLineItemPriceDraft : IDiscountedLineItemPriceDraft
    {
        public IMoney Value { get; set; }

        public IList<IDiscountedLineItemPortion> IncludedDiscounts { get; set; }

        public IEnumerable<IDiscountedLineItemPortion> IncludedDiscountsEnumerable { set => IncludedDiscounts = value.ToList(); }
    }
}
