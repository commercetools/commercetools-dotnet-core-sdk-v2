using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeTaxRoundingModeChange))]
    public partial interface IChangeTaxRoundingModeChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IRoundingMode PreviousValue { get; set; }

        IRoundingMode NextValue { get; set; }

    }
}
