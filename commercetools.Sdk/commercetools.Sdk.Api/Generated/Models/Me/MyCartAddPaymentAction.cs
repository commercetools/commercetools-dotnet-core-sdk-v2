using commercetools.Api.Models.Payments;


namespace commercetools.Api.Models.Me
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
