using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetGeoLocationChange))]
    public partial interface ISetGeoLocationChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IGeoLocation PreviousValue { get; set; }

        IGeoLocation NextValue { get; set; }

    }
}
