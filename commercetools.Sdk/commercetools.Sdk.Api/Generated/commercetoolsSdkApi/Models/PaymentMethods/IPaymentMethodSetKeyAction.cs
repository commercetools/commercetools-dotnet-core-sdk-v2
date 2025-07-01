using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.PaymentMethods
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodSetKeyAction))]
    public partial interface IPaymentMethodSetKeyAction : IPaymentMethodUpdateAction
    {
        string Key { get; set; }

    }
}
