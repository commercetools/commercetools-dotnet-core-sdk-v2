using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.StandalonePriceSetValidUntilChange))]
    public partial interface IStandalonePriceSetValidUntilChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        string PreviousValue { get; set; }

        string NextValue { get; set; }

    }
}
