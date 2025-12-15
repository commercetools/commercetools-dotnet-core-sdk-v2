using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ShippingMethodAddShippingRateChange))]
    public partial interface IShippingMethodAddShippingRateChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IZoneResourceIdentifier Zone { get; set; }

        IShippingRate NextValue { get; set; }

    }
}
