using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeQuoteStateChange))]
    public partial interface IChangeQuoteStateChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IQuoteState PreviousValue { get; set; }

        IQuoteState NextValue { get; set; }

    }
}
