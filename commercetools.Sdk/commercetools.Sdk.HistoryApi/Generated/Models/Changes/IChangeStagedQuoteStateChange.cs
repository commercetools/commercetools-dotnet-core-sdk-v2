using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeStagedQuoteStateChange))]
    public partial interface IChangeStagedQuoteStateChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IStagedQuoteState PreviousValue { get; set; }

        IStagedQuoteState NextValue { get; set; }

    }
}
