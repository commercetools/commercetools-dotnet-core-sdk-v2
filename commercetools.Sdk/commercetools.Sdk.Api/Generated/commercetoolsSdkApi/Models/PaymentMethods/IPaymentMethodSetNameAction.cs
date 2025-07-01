using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.PaymentMethods
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodSetNameAction))]
    public partial interface IPaymentMethodSetNameAction : IPaymentMethodUpdateAction
    {
        ILocalizedString Name { get; set; }

    }
}
