using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ReplaceTaxRateChange))]
    public partial interface IReplaceTaxRateChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        ITaxRate PreviousValue { get; set; }

        ITaxRate NextValue { get; set; }

    }
}
