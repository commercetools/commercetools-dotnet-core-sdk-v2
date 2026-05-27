using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.QuoteRequests
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.QuoteRequests.QuoteRequestReference))]
    public partial interface IQuoteRequestReference : IReference
    {
        new IReferenceTypeId TypeId { get; set; }

        IQuoteRequest Obj { get; set; }

    }
}
