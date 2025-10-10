using commercetools.Sdk.CheckoutApi.Models.Common;


namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations
{

    public partial class SetDisplayInfoDescriptionUpdateAction : ISetDisplayInfoDescriptionUpdateAction
    {
        public string Action { get; set; }

        public ILocalizedString Description { get; set; }
        public SetDisplayInfoDescriptionUpdateAction()
        {
            this.Action = "setDisplayInfoDescription";
        }
    }
}
