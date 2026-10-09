using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetRecurringPaymentStrategyAction))]
    public partial interface ICartSetRecurringPaymentStrategyAction : ICartUpdateAction
    {
        IPaymentStrategy PaymentStrategy { get; set; }

    }
}
