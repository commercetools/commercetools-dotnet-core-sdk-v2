// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CartDiscounts
{

    public partial class CartDiscountShippingCostTargetQueryBuilderDsl
    {
        public CartDiscountShippingCostTargetQueryBuilderDsl()
        {
        }

        public static CartDiscountShippingCostTargetQueryBuilderDsl Of()
        {
            return new CartDiscountShippingCostTargetQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartDiscountShippingCostTargetQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CartDiscountShippingCostTargetQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CartDiscountShippingCostTargetQueryBuilderDsl>(p, CartDiscountShippingCostTargetQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
