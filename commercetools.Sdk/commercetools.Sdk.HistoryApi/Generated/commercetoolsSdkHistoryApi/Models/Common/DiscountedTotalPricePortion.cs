

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class DiscountedTotalPricePortion : IDiscountedTotalPricePortion
    {
        public IReference Discount { get; set; }

        public ITypedMoney DiscountedAmount { get; set; }
    }
}
