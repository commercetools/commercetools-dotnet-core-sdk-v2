using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Common.ShippingRatePriceTier))]
    public partial interface IShippingRatePriceTier
    {
        IShippingRateTierType Type { get; set; }
    }
}
