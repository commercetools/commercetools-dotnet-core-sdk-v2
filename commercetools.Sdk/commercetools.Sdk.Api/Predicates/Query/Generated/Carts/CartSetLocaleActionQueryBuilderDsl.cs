// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartSetLocaleActionQueryBuilderDsl
    {
        public CartSetLocaleActionQueryBuilderDsl()
        {
        }

        public static CartSetLocaleActionQueryBuilderDsl Of()
        {
            return new CartSetLocaleActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartSetLocaleActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartSetLocaleActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartSetLocaleActionQueryBuilderDsl>(p, CartSetLocaleActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartSetLocaleActionQueryBuilderDsl, string> Locale()
        {
            return new ComparisonPredicateBuilder<CartSetLocaleActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("locale")),
            p => new CombinationQueryPredicate<CartSetLocaleActionQueryBuilderDsl>(p, CartSetLocaleActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
