// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartSetAnonymousIdActionQueryBuilderDsl
    {
        public CartSetAnonymousIdActionQueryBuilderDsl()
        {
        }

        public static CartSetAnonymousIdActionQueryBuilderDsl Of()
        {
            return new CartSetAnonymousIdActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartSetAnonymousIdActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartSetAnonymousIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartSetAnonymousIdActionQueryBuilderDsl>(p, CartSetAnonymousIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartSetAnonymousIdActionQueryBuilderDsl, string> AnonymousId()
        {
            return new ComparisonPredicateBuilder<CartSetAnonymousIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("anonymousId")),
            p => new CombinationQueryPredicate<CartSetAnonymousIdActionQueryBuilderDsl>(p, CartSetAnonymousIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
