using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetParcelTrackingDataChange))]
    public partial interface ISetParcelTrackingDataChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        ITrackingData PreviousValue { get; set; }

        ITrackingData NextValue { get; set; }

        IParcelChangeValue Parcel { get; set; }

    }
}
