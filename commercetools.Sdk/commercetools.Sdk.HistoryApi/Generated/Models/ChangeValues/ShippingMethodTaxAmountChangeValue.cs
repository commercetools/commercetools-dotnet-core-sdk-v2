using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{
    public partial class ShippingMethodTaxAmountChangeValue : IShippingMethodTaxAmountChangeValue
    {
        public ITaxedPrice TaxedPrice { get; set; }

        public ITaxRate TaxRate { get; set; }
    }
}
