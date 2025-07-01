// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartChangePriceRoundingModeActionQueryBuilderDsl
    {
        public CartChangePriceRoundingModeActionQueryBuilderDsl()
        {
        }

        public static CartChangePriceRoundingModeActionQueryBuilderDsl Of()
        {
            return new CartChangePriceRoundingModeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartChangePriceRoundingModeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartChangePriceRoundingModeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartChangePriceRoundingModeActionQueryBuilderDsl>(p, CartChangePriceRoundingModeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartChangePriceRoundingModeActionQueryBuilderDsl, string> PriceRoundingMode()
        {
            return new ComparisonPredicateBuilder<CartChangePriceRoundingModeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("priceRoundingMode")),
            p => new CombinationQueryPredicate<CartChangePriceRoundingModeActionQueryBuilderDsl>(p, CartChangePriceRoundingModeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
