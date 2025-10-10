using commercetools.Sdk.CheckoutApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetDisplayInfoLabelUpdateAction))]
    public partial interface ISetDisplayInfoLabelUpdateAction : IPaymentIntegrationUpdateAction
    {
        ILocalizedString Label { get; set; }

    }
}
