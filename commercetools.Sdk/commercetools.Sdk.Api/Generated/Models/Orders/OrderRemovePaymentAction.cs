using commercetools.Sdk.Api.Models.Payments;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderRemovePaymentAction : IOrderRemovePaymentAction
    {
        public string Action { get; set; }

        public IPaymentResourceIdentifier Payment { get; set; }
        public OrderRemovePaymentAction()
        {
            this.Action = "removePayment";
        }
    }
}
