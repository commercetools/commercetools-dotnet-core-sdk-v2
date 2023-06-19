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

        IMoney PreviousValue { get; set; }

        IMoney NextValue { get; set; }

    }
}
