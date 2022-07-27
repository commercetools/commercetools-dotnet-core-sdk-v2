using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Labels
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Labels.StagedQuoteLabel))]
    public partial interface IStagedQuoteLabel : ILabel
    {
        new string Type { get; set; }

        string Key { get; set; }

        IReference Customer { get; set; }

        IReference QuoteRequest { get; set; }
    }
}
