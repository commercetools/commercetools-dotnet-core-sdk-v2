using commercetools.Sdk.Api.Models.Types;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.PaymentMethods
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodSetCustomTypeAction))]
    public partial interface IPaymentMethodSetCustomTypeAction : IPaymentMethodUpdateAction
    {
        ITypeResourceIdentifier Type { get; set; }

        IFieldContainer Fields { get; set; }

    }
}
