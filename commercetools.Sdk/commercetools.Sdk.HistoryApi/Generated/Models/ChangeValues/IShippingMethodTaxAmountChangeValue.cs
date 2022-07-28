using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.ChangeValues.ShippingMethodTaxAmountChangeValue))]
    public partial interface IShippingMethodTaxAmountChangeValue
    {
        ITaxedPrice TaxedPrice { get; set; }

        ITaxRate TaxRate { get; set; }

    }
}
