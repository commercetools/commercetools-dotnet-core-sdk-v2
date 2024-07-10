// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartSetKeyActionQueryBuilderDsl
    {
        public CartSetKeyActionQueryBuilderDsl()
        {
        }

        public static CartSetKeyActionQueryBuilderDsl Of()
        {
            return new CartSetKeyActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartSetKeyActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartSetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartSetKeyActionQueryBuilderDsl>(p, CartSetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartSetKeyActionQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<CartSetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<CartSetKeyActionQueryBuilderDsl>(p, CartSetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
