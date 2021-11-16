using commercetools.Api.Models.Customers;


namespace commercetools.Api.Models.Payments
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
