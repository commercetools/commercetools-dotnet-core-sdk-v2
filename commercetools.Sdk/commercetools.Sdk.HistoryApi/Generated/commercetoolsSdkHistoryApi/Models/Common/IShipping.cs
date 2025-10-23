using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.Shipping))]
    public partial interface IShipping
    {
        string ShippingKey { get; set; }

        IShippingInfo ShippingInfo { get; set; }

        IAddress ShippingAddress { get; set; }

        IShippingRateInput ShippingRateInput { get; set; }

        ICustomFields ShippingCustomFields { get; set; }

    }
}
