

namespace commercetools.Sdk.Api.Models.Stores
{

    public partial class Storefront : IStorefront
    {
        public string CheckoutUrlTemplate { get; set; }

        public string OrderUrlTemplate { get; set; }

        public string TermsOfServiceUrl { get; set; }

        public string PrivacyPolicyUrl { get; set; }

        public string RefundPolicyUrl { get; set; }

        public string ShippingPolicyUrl { get; set; }

        public string CookiePolicyUrl { get; set; }

        public string ImprintUrl { get; set; }

        public string FaqUrl { get; set; }

        public string ContactUrl { get; set; }
    }
}
