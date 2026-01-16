// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartUnlockCartActionQueryBuilderDsl
    {
        public CartUnlockCartActionQueryBuilderDsl()
        {
        }

        public static CartUnlockCartActionQueryBuilderDsl Of()
        {
            return new CartUnlockCartActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartUnlockCartActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartUnlockCartActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartUnlockCartActionQueryBuilderDsl>(p, CartUnlockCartActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
