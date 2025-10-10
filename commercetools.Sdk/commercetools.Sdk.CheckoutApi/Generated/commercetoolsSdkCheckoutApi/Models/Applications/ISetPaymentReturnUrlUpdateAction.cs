using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Applications
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Applications.SetPaymentReturnUrlUpdateAction))]
    public partial interface ISetPaymentReturnUrlUpdateAction : IApplicationUpdateAction
    {
        new string Action { get; set; }

        string PaymentReturnUrl { get; set; }

    }
}
