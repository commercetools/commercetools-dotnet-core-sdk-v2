

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class DiscountedPrice : IDiscountedPrice
    {
        public ITypedMoney Value { get; set; }

        public IProductDiscountReference Discount { get; set; }
    }
}
