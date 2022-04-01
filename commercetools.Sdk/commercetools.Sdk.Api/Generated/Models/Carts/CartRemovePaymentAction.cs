using commercetools.Sdk.Api.Models.Payments;


namespace commercetools.Sdk.Api.Models.Carts
{
    public partial class CartRemovePaymentAction : ICartRemovePaymentAction
    {
        public string Action { get; set; }

        public IPaymentResourceIdentifier Payment { get; set; }
        public CartRemovePaymentAction()
        {
            this.Action = "removePayment";
        }
    }
}
