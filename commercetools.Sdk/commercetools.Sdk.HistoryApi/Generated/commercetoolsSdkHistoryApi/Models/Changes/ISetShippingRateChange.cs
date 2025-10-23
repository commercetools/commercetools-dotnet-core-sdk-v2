using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetShippingRateChange))]
    public partial interface ISetShippingRateChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IShippingRate PreviousValue { get; set; }

        IShippingRate NextValue { get; set; }

    }
}
