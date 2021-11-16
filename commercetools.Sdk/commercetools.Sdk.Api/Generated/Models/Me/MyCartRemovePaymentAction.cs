using commercetools.Api.Models.Payments;


namespace commercetools.Api.Models.Me
{
    public partial class MyCartRemovePaymentAction : IMyCartRemovePaymentAction
    {
        public string Action { get; set; }

        public IPaymentResourceIdentifier Payment { get; set; }
        public MyCartRemovePaymentAction()
        {
            this.Action = "removePayment";
        }
    }
}
