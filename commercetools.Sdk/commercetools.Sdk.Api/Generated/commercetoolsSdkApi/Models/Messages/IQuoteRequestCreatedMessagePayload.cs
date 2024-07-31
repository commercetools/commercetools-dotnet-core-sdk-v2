using commercetools.Sdk.Api.Models.QuoteRequests;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.QuoteRequestCreatedMessagePayload))]
    public partial interface IQuoteRequestCreatedMessagePayload : IMessagePayload
    {
        IQuoteRequest QuoteRequest { get; set; }

    }
}
