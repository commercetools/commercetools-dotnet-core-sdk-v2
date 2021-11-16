using commercetools.Api.Models.Payments;


namespace commercetools.Api.Models.Carts
{
    public partial class CartAddPaymentAction : ICartAddPaymentAction
    {
        public string Action { get; set; }

        public IPaymentResourceIdentifier Payment { get; set; }
        public CartAddPaymentAction()
        {
            this.Action = "addPayment";
        }
    }
}
