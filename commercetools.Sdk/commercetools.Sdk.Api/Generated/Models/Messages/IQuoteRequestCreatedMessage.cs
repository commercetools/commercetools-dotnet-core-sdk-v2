using commercetools.Sdk.Api.Models.QuoteRequests;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.QuoteRequestCreatedMessage))]
    public partial interface IQuoteRequestCreatedMessage : IMessage
    {
        IQuoteRequest QuoteRequest { get; set; }

    }
}
