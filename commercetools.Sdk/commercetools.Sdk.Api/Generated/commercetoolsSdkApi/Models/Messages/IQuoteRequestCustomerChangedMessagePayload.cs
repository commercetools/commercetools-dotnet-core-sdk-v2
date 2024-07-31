using commercetools.Sdk.Api.Models.Customers;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.QuoteRequestCustomerChangedMessagePayload))]
    public partial interface IQuoteRequestCustomerChangedMessagePayload : IMessagePayload
    {
        ICustomerReference Customer { get; set; }

        ICustomerReference PreviousCustomer { get; set; }

    }
}
