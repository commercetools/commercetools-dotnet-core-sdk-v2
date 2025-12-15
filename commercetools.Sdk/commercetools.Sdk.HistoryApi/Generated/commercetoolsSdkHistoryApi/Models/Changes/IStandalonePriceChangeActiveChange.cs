using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.StandalonePriceChangeActiveChange))]
    public partial interface IStandalonePriceChangeActiveChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        bool PreviousValue { get; set; }

        bool NextValue { get; set; }

    }
}
