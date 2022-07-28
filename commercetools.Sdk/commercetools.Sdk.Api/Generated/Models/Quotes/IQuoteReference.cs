using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Quotes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Quotes.QuoteReference))]
    public partial interface IQuoteReference : IReference
    {
        IQuote Obj { get; set; }

    }
}
