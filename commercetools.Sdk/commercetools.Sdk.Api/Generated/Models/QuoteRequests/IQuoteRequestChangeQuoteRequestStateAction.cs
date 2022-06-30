using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.QuoteRequests
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.QuoteRequests.QuoteRequestChangeQuoteRequestStateAction))]
    public partial interface IQuoteRequestChangeQuoteRequestStateAction : IQuoteRequestUpdateAction
    {
        IQuoteRequestState QuoteRequestState { get; set; }
    }
}
