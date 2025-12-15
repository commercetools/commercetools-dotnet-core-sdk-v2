using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.StandalonePriceSetValidFromAndUntilChange))]
    public partial interface IStandalonePriceSetValidFromAndUntilChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IValidFromAndUntilValue PreviousValue { get; set; }

        IValidFromAndUntilValue NextValue { get; set; }

    }
}
