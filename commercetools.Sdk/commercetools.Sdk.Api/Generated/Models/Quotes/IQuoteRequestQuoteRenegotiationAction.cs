using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Quotes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Quotes.QuoteRequestQuoteRenegotiationAction))]
    public partial interface IQuoteRequestQuoteRenegotiationAction : IQuoteUpdateAction
    {
        string BuyerComment { get; set; }

    }
}
