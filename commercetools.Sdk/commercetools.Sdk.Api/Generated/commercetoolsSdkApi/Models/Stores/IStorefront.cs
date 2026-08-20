using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Stores.Storefront))]
    public partial interface IStorefront
    {
        string CheckoutUrlTemplate { get; set; }

        string OrderUrlTemplate { get; set; }

        string TermsOfServiceUrl { get; set; }

        string PrivacyPolicyUrl { get; set; }

        string RefundPolicyUrl { get; set; }

        string ShippingPolicyUrl { get; set; }

        string CookiePolicyUrl { get; set; }

        string ImprintUrl { get; set; }

        string FaqUrl { get; set; }

        string ContactUrl { get; set; }

    }
}
