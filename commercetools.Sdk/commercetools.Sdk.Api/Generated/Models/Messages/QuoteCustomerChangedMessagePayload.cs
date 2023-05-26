using commercetools.Sdk.Api.Models.Customers;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class QuoteCustomerChangedMessagePayload : IQuoteCustomerChangedMessagePayload
    {
        public string Type { get; set; }

        public ICustomerReference Customer { get; set; }

        public ICustomerReference PreviousCustomer { get; set; }
        public QuoteCustomerChangedMessagePayload()
        {
            this.Type = "QuoteCustomerChanged";
        }
    }
}
