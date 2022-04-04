using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.Payments
{
    public partial class PaymentAddInterfaceInteractionAction : IPaymentAddInterfaceInteractionAction
    {
        public string Action { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public PaymentAddInterfaceInteractionAction()
        {
            this.Action = "addInterfaceInteraction";
        }
    }
}
