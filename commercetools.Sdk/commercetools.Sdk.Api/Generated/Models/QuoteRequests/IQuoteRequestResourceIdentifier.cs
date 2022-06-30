using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.QuoteRequests
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.QuoteRequests.QuoteRequestResourceIdentifier))]
    public partial interface IQuoteRequestResourceIdentifier : IResourceIdentifier
    {
    }
}
