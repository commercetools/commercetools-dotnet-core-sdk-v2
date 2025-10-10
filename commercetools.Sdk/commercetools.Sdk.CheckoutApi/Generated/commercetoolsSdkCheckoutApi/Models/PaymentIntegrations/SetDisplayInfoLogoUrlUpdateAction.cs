using commercetools.Sdk.CheckoutApi.Models.Common;


namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations
{

    public partial class SetDisplayInfoLogoUrlUpdateAction : ISetDisplayInfoLogoUrlUpdateAction
    {
        public string Action { get; set; }

        public ILocalizedString LogoUrl { get; set; }
        public SetDisplayInfoLogoUrlUpdateAction()
        {
            this.Action = "setDisplayInfoLogoUrl";
        }
    }
}
