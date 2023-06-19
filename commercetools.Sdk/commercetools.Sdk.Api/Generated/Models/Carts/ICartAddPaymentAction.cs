using commercetools.Sdk.Api.Models.Payments;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartAddPaymentAction))]
    public partial interface ICartAddPaymentAction : ICartUpdateAction
    {
        IPaymentResourceIdentifier Payment { get; set; }

    }
}
