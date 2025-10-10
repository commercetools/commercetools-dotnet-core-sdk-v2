using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetDisplayInfoUpdateAction))]
    public partial interface ISetDisplayInfoUpdateAction : IPaymentIntegrationUpdateAction
    {
        IDisplayInfo DisplayInfo { get; set; }

    }
}
