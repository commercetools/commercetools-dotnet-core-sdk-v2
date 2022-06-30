using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Quotes
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Quotes.QuoteUpdateAction))]
    [SubTypeDiscriminator("changeQuoteState", typeof(commercetools.Sdk.Api.Models.Quotes.QuoteChangeQuoteStateAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Sdk.Api.Models.Quotes.QuoteSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Sdk.Api.Models.Quotes.QuoteSetCustomTypeAction))]
    public partial interface IQuoteUpdateAction
    {
        string Action { get; set; }
    }
}
