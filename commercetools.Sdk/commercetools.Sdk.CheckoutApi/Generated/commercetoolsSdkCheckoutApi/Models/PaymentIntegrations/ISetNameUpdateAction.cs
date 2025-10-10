using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetNameUpdateAction))]
    public partial interface ISetNameUpdateAction : IPaymentIntegrationUpdateAction
    {
        string Name { get; set; }

    }
}
