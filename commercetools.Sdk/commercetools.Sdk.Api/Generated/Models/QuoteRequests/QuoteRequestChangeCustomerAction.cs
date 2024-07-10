using commercetools.Sdk.Api.Models.Customers;


namespace commercetools.Sdk.Api.Models.QuoteRequests
{

    public partial class QuoteRequestChangeCustomerAction : IQuoteRequestChangeCustomerAction
    {
        public string Action { get; set; }

        public ICustomerResourceIdentifier Customer { get; set; }
        public QuoteRequestChangeCustomerAction()
        {
            this.Action = "changeCustomer";
        }
    }
}
