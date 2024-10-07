using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.RemoveTaxRateChange))]
    public partial interface IRemoveTaxRateChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        ITaxRate PreviousValue { get; set; }

    }
}
