using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetKeyUpdateAction))]
    public partial interface ISetKeyUpdateAction : IPaymentIntegrationUpdateAction
    {
        string Key { get; set; }

    }
}
