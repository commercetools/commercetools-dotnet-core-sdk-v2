using commercetools.Sdk.Api.Models.Customers;


namespace commercetools.Sdk.Api.Models.Quotes
{

    public partial class QuoteChangeCustomerAction : IQuoteChangeCustomerAction
    {
        public string Action { get; set; }

        public ICustomerResourceIdentifier Customer { get; set; }
        public QuoteChangeCustomerAction()
        {
            this.Action = "changeCustomer";
        }
    }
}
