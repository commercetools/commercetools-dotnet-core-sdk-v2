// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartSetDirectDiscountsIgnoreCartDiscountsActionQueryBuilderDsl
    {
        public CartSetDirectDiscountsIgnoreCartDiscountsActionQueryBuilderDsl()
        {
        }

        public static CartSetDirectDiscountsIgnoreCartDiscountsActionQueryBuilderDsl Of()
        {
            return new CartSetDirectDiscountsIgnoreCartDiscountsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartSetDirectDiscountsIgnoreCartDiscountsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartSetDirectDiscountsIgnoreCartDiscountsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartSetDirectDiscountsIgnoreCartDiscountsActionQueryBuilderDsl>(p, CartSetDirectDiscountsIgnoreCartDiscountsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartSetDirectDiscountsIgnoreCartDiscountsActionQueryBuilderDsl, bool> DirectDiscountsIgnoreCartDiscounts()
        {
            return new ComparisonPredicateBuilder<CartSetDirectDiscountsIgnoreCartDiscountsActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("directDiscountsIgnoreCartDiscounts")),
            p => new CombinationQueryPredicate<CartSetDirectDiscountsIgnoreCartDiscountsActionQueryBuilderDsl>(p, CartSetDirectDiscountsIgnoreCartDiscountsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
