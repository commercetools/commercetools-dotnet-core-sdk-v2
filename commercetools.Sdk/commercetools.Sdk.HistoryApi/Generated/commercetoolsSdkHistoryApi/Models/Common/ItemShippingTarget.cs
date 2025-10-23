

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class ItemShippingTarget : IItemShippingTarget
    {
        public string AddressKey { get; set; }

        public long Quantity { get; set; }

        public string ShippingMethodKey { get; set; }
    }
}
