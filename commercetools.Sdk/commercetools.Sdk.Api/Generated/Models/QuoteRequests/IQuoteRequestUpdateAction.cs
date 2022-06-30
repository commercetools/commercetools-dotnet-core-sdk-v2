using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.QuoteRequests
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.QuoteRequests.QuoteRequestUpdateAction))]
    [SubTypeDiscriminator("changeQuoteRequestState", typeof(commercetools.Sdk.Api.Models.QuoteRequests.QuoteRequestChangeQuoteRequestStateAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Sdk.Api.Models.QuoteRequests.QuoteRequestSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Sdk.Api.Models.QuoteRequests.QuoteRequestSetCustomTypeAction))]
    public partial interface IQuoteRequestUpdateAction
    {
        string Action { get; set; }
    }
}
