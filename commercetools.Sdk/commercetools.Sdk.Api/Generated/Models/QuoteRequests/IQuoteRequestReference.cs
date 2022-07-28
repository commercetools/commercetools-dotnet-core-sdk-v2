using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.QuoteRequests
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.QuoteRequests.QuoteRequestReference))]
    public partial interface IQuoteRequestReference : IReference
    {
        IQuoteRequest Obj { get; set; }

    }
}
