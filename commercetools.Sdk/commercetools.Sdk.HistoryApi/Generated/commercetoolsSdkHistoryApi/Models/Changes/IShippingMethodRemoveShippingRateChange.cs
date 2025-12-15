using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ShippingMethodRemoveShippingRateChange))]
    public partial interface IShippingMethodRemoveShippingRateChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IZoneResourceIdentifier Zone { get; set; }

        IShippingRate PreviousValue { get; set; }

    }
}
