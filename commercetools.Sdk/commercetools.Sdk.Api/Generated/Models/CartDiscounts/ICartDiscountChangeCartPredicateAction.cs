using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountChangeCartPredicateAction))]
    public partial interface ICartDiscountChangeCartPredicateAction : ICartDiscountUpdateAction
    {
        string CartPredicate { get; set; }

    }
}
