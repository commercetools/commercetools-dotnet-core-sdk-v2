using commercetools.Sdk.CheckoutApi.Models.Common;


namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations
{

    public partial class DisplayInfo : IDisplayInfo
    {
        public ILocalizedString Label { get; set; }

        public ILocalizedUrl LogoUrl { get; set; }

        public ILocalizedString Description { get; set; }

        public ILocalizedString PayButtonText { get; set; }
    }
}
