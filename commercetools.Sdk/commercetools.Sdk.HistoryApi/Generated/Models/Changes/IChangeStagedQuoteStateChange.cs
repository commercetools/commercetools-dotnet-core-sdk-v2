using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeStagedQuoteStateChange))]
    public partial interface IChangeStagedQuoteStateChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IStagedQuoteState NextValue { get; set; }

        IStagedQuoteState PreviousValue { get; set; }

    }
}
