

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class Shipping : IShipping
    {
        public string ShippingKey { get; set; }

        public IShippingInfo ShippingInfo { get; set; }

        public IAddress ShippingAddress { get; set; }

        public IShippingRateInput ShippingRateInput { get; set; }

        public ICustomFields ShippingCustomFields { get; set; }
    }
}
