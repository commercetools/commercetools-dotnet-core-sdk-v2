using commercetools.Sdk.Api.Models.Customers;


namespace commercetools.Sdk.Api.Models.Payments
{
    public partial class PaymentSetCustomerAction : IPaymentSetCustomerAction
    {
        public string Action { get; set; }

        public ICustomerResourceIdentifier Customer { get; set; }
        public PaymentSetCustomerAction()
        {
            this.Action = "setCustomer";
        }
    }
}
