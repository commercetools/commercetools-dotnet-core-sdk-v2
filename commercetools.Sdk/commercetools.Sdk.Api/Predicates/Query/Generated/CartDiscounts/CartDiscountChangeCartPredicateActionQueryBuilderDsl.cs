// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CartDiscounts
{

    public partial class CartDiscountChangeCartPredicateActionQueryBuilderDsl
    {
        public CartDiscountChangeCartPredicateActionQueryBuilderDsl()
        {
        }

        public static CartDiscountChangeCartPredicateActionQueryBuilderDsl Of()
        {
            return new CartDiscountChangeCartPredicateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartDiscountChangeCartPredicateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartDiscountChangeCartPredicateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartDiscountChangeCartPredicateActionQueryBuilderDsl>(p, CartDiscountChangeCartPredicateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartDiscountChangeCartPredicateActionQueryBuilderDsl, string> CartPredicate()
        {
            return new ComparisonPredicateBuilder<CartDiscountChangeCartPredicateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("cartPredicate")),
            p => new CombinationQueryPredicate<CartDiscountChangeCartPredicateActionQueryBuilderDsl>(p, CartDiscountChangeCartPredicateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
