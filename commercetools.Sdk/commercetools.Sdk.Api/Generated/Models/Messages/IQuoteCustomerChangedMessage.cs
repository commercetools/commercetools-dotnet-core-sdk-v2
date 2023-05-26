using commercetools.Sdk.Api.Models.Customers;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.QuoteCustomerChangedMessage))]
    public partial interface IQuoteCustomerChangedMessage : IMessage
    {
        ICustomerReference Customer { get; set; }

        ICustomerReference PreviousCustomer { get; set; }

    }
}
