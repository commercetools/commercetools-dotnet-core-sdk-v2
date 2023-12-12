using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.RemoveLocationChange))]
    public partial interface IRemoveLocationChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        ILocation PreviousValue { get; set; }

    }
}
