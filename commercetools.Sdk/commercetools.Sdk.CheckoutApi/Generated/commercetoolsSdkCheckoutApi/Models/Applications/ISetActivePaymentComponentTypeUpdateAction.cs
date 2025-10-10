using commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Applications
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Applications.SetActivePaymentComponentTypeUpdateAction))]
    public partial interface ISetActivePaymentComponentTypeUpdateAction : IApplicationUpdateAction
    {
        new string Action { get; set; }

        IPaymentComponentType ActivePaymentComponentType { get; set; }

    }
}
