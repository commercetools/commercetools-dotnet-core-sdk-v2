using commercetools.Sdk.CheckoutApi.Models.Common;


namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations
{

    public partial class SetDisplayInfoPayButtonTextUpdateAction : ISetDisplayInfoPayButtonTextUpdateAction
    {
        public string Action { get; set; }

        public ILocalizedString PayButtonText { get; set; }
        public SetDisplayInfoPayButtonTextUpdateAction()
        {
            this.Action = "setDisplayInfoPayButtonText";
        }
    }
}
