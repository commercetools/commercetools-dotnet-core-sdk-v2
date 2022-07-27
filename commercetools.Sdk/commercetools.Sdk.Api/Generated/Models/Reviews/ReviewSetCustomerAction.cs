using commercetools.Sdk.Api.Models.Customers;


namespace commercetools.Sdk.Api.Models.Reviews
{

    public partial class ReviewSetCustomerAction : IReviewSetCustomerAction
    {
        public string Action { get; set; }

        public ICustomerResourceIdentifier Customer { get; set; }
        public ReviewSetCustomerAction()
        {
            this.Action = "setCustomer";
        }
    }
}
