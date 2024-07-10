using commercetools.Sdk.Api.Models.Customers;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.QuoteCustomerChangedMessagePayload))]
    public partial interface IQuoteCustomerChangedMessagePayload : IMessagePayload
    {
        ICustomerReference Customer { get; set; }

        ICustomerReference PreviousCustomer { get; set; }

    }
}
