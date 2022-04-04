using commercetools.Sdk.Api.Models.Payments;


namespace commercetools.Sdk.Api.Models.Me
{
    public partial class MyCartAddPaymentAction : IMyCartAddPaymentAction
    {
        public string Action { get; set; }

        public IPaymentResourceIdentifier Payment { get; set; }
        public MyCartAddPaymentAction()
        {
            this.Action = "addPayment";
        }
    }
}
