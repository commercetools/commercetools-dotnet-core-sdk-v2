using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.StandalonePriceChangeValueChange))]
    public partial interface IStandalonePriceChangeValueChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        bool Staged { get; set; }

        IMoney PreviousValue { get; set; }

        IMoney NextValue { get; set; }

    }
}
