using commercetools.Sdk.CheckoutApi.Models.Common;


namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations
{

    public partial class SetDisplayInfoLabelUpdateAction : ISetDisplayInfoLabelUpdateAction
    {
        public string Action { get; set; }

        public ILocalizedString Label { get; set; }
        public SetDisplayInfoLabelUpdateAction()
        {
            this.Action = "setDisplayInfoLabel";
        }
    }
}
