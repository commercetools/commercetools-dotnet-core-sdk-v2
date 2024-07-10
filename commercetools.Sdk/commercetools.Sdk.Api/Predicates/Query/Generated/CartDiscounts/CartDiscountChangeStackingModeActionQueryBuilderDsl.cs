// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CartDiscounts
{

    public partial class CartDiscountChangeStackingModeActionQueryBuilderDsl
    {
        public CartDiscountChangeStackingModeActionQueryBuilderDsl()
        {
        }

        public static CartDiscountChangeStackingModeActionQueryBuilderDsl Of()
        {
            return new CartDiscountChangeStackingModeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartDiscountChangeStackingModeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartDiscountChangeStackingModeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartDiscountChangeStackingModeActionQueryBuilderDsl>(p, CartDiscountChangeStackingModeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartDiscountChangeStackingModeActionQueryBuilderDsl, string> StackingMode()
        {
            return new ComparisonPredicateBuilder<CartDiscountChangeStackingModeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("stackingMode")),
            p => new CombinationQueryPredicate<CartDiscountChangeStackingModeActionQueryBuilderDsl>(p, CartDiscountChangeStackingModeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
