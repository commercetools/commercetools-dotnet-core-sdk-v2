using commercetools.Sdk.CheckoutApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.DisplayInfo))]
    public partial interface IDisplayInfo
    {
        ILocalizedString Label { get; set; }

        ILocalizedUrl LogoUrl { get; set; }

        ILocalizedString Description { get; set; }

        ILocalizedString PayButtonText { get; set; }

    }
}
