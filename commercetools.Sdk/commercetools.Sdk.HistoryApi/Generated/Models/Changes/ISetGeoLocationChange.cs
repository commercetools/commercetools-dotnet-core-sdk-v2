using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetGeoLocationChange))]
    public partial interface ISetGeoLocationChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IGeoLocation NextValue { get; set; }

        IGeoLocation PreviousValue { get; set; }

    }
}
