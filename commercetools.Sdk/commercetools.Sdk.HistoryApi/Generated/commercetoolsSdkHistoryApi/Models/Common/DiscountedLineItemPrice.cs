using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class DiscountedLineItemPrice : IDiscountedLineItemPrice
    {
        public ITypedMoney Value { get; set; }

        public IList<IDiscountedLineItemPortion> IncludedDiscounts { get; set; }

        public IEnumerable<IDiscountedLineItemPortion> IncludedDiscountsEnumerable { set => IncludedDiscounts = value.ToList(); }
    }
}
