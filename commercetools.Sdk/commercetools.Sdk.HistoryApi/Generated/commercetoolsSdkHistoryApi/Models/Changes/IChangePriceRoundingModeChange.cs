using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangePriceRoundingModeChange))]
    public partial interface IChangePriceRoundingModeChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IRoundingMode PreviousValue { get; set; }

        IRoundingMode NextValue { get; set; }

    }
}
