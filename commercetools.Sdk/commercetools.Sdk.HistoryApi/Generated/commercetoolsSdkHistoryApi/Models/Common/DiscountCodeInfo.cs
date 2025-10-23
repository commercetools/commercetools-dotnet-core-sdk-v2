

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class DiscountCodeInfo : IDiscountCodeInfo
    {
        public IDiscountCodeReference DiscountCode { get; set; }

        public IDiscountCodeState State { get; set; }
    }
}
