// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartLockCartActionQueryBuilderDsl
    {
        public CartLockCartActionQueryBuilderDsl()
        {
        }

        public static CartLockCartActionQueryBuilderDsl Of()
        {
            return new CartLockCartActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartLockCartActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartLockCartActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartLockCartActionQueryBuilderDsl>(p, CartLockCartActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
