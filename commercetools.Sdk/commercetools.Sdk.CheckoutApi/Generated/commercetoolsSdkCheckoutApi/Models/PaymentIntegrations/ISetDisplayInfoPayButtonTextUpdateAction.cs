using commercetools.Sdk.CheckoutApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetDisplayInfoPayButtonTextUpdateAction))]
    public partial interface ISetDisplayInfoPayButtonTextUpdateAction : IPaymentIntegrationUpdateAction
    {
        ILocalizedString PayButtonText { get; set; }

    }
}
