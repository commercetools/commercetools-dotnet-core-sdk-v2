using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Quotes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Quotes.QuoteChangeQuoteStateAction))]
    public partial interface IQuoteChangeQuoteStateAction : IQuoteUpdateAction
    {
        IQuoteState QuoteState { get; set; }
    }
}
