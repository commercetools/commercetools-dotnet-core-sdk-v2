using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.SetGeoLocationChange))]
    public partial interface ISetGeoLocationChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IGeoLocation NextValue { get; set; }

        IGeoLocation PreviousValue { get; set; }
    }
}
