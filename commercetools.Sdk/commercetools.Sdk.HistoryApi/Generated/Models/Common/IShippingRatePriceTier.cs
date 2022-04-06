using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.ShippingRatePriceTier))]
    public partial interface IShippingRatePriceTier
    {
        IShippingRateTierType Type { get; set; }
    }
}
