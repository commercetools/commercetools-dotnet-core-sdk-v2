// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartFreezeCartActionQueryBuilderDsl
    {
        public CartFreezeCartActionQueryBuilderDsl()
        {
        }

        public static CartFreezeCartActionQueryBuilderDsl Of()
        {
            return new CartFreezeCartActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartFreezeCartActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartFreezeCartActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartFreezeCartActionQueryBuilderDsl>(p, CartFreezeCartActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartFreezeCartActionQueryBuilderDsl, string> Strategy()
        {
            return new ComparisonPredicateBuilder<CartFreezeCartActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("strategy")),
            p => new CombinationQueryPredicate<CartFreezeCartActionQueryBuilderDsl>(p, CartFreezeCartActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
