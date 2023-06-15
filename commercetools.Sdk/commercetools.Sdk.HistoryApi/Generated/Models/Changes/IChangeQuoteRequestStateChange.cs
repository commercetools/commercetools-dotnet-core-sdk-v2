using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeQuoteRequestStateChange))]
    public partial interface IChangeQuoteRequestStateChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IQuoteRequestState PreviousValue { get; set; }

        IQuoteRequestState NextValue { get; set; }

    }
}
