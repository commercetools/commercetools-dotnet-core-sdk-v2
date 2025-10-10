using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetTypeUpdateAction))]
    public partial interface ISetTypeUpdateAction : IPaymentIntegrationUpdateAction
    {
        string Type { get; set; }

    }
}
