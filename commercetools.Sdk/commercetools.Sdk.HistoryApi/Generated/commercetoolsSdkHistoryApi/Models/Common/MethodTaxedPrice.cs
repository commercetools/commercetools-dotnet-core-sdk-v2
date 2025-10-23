

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class MethodTaxedPrice : IMethodTaxedPrice
    {
        public string ShippingMethodKey { get; set; }

        public ITaxedItemPrice TaxedPrice { get; set; }
    }
}
