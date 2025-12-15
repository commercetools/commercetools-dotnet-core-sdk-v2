

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class DirectDiscount : IDirectDiscount
    {
        public string Id { get; set; }

        public ICartDiscountValue Value { get; set; }

        public ICartDiscountTarget Target { get; set; }
    }
}
