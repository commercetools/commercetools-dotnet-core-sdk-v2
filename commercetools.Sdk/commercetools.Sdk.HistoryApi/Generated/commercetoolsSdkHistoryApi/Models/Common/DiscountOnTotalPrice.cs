using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class DiscountOnTotalPrice : IDiscountOnTotalPrice
    {
        public ITypedMoney DiscountedAmount { get; set; }

        public IList<IDiscountedTotalPricePortion> IncludedDiscounts { get; set; }

        public IEnumerable<IDiscountedTotalPricePortion> IncludedDiscountsEnumerable { set => IncludedDiscounts = value.ToList(); }

        public ITypedMoney DiscountedNetAmount { get; set; }

        public ITypedMoney DiscountedGrossAmount { get; set; }
    }
}
