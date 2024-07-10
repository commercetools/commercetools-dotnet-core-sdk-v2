using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Quotes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Quotes.QuoteReference))]
    public partial interface IQuoteReference : IReference
    {
        IQuote Obj { get; set; }

    }
}
