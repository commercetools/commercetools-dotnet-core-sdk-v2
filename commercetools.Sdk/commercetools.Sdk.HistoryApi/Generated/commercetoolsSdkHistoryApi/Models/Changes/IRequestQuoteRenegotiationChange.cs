using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.RequestQuoteRenegotiationChange))]
    public partial interface IRequestQuoteRenegotiationChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IQuoteState PreviousValue { get; set; }

        IQuoteState NextValue { get; set; }

        string BuyerComment { get; set; }

    }
}
