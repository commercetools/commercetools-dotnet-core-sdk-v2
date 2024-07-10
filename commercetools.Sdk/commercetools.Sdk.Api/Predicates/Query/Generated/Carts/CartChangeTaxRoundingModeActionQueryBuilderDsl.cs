// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartChangeTaxRoundingModeActionQueryBuilderDsl
    {
        public CartChangeTaxRoundingModeActionQueryBuilderDsl()
        {
        }

        public static CartChangeTaxRoundingModeActionQueryBuilderDsl Of()
        {
            return new CartChangeTaxRoundingModeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartChangeTaxRoundingModeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartChangeTaxRoundingModeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartChangeTaxRoundingModeActionQueryBuilderDsl>(p, CartChangeTaxRoundingModeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartChangeTaxRoundingModeActionQueryBuilderDsl, string> TaxRoundingMode()
        {
            return new ComparisonPredicateBuilder<CartChangeTaxRoundingModeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("taxRoundingMode")),
            p => new CombinationQueryPredicate<CartChangeTaxRoundingModeActionQueryBuilderDsl>(p, CartChangeTaxRoundingModeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
