using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.PaymentMethods
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodReference))]
    public partial interface IPaymentMethodReference : IReference
    {
        IPaymentMethod Obj { get; set; }

        new string Id { get; set; }

    }
}
