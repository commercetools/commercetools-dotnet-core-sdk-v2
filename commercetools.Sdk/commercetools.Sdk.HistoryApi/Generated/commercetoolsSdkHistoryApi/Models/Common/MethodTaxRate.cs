

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class MethodTaxRate : IMethodTaxRate
    {
        public string ShippingMethodKey { get; set; }

        public ITaxRate TaxRate { get; set; }
    }
}
