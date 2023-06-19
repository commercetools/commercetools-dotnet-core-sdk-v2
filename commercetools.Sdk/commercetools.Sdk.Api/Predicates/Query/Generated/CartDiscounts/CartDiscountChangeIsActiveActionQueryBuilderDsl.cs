// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CartDiscounts
{

    public partial class CartDiscountChangeIsActiveActionQueryBuilderDsl
    {
        public CartDiscountChangeIsActiveActionQueryBuilderDsl()
        {
        }

        public static CartDiscountChangeIsActiveActionQueryBuilderDsl Of()
        {
            return new CartDiscountChangeIsActiveActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartDiscountChangeIsActiveActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartDiscountChangeIsActiveActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartDiscountChangeIsActiveActionQueryBuilderDsl>(p, CartDiscountChangeIsActiveActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartDiscountChangeIsActiveActionQueryBuilderDsl, bool> IsActive()
        {
            return new ComparisonPredicateBuilder<CartDiscountChangeIsActiveActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("isActive")),
            p => new CombinationQueryPredicate<CartDiscountChangeIsActiveActionQueryBuilderDsl>(p, CartDiscountChangeIsActiveActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
