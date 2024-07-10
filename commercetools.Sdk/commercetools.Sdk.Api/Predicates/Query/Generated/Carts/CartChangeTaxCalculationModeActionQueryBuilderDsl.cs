// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartChangeTaxCalculationModeActionQueryBuilderDsl
    {
        public CartChangeTaxCalculationModeActionQueryBuilderDsl()
        {
        }

        public static CartChangeTaxCalculationModeActionQueryBuilderDsl Of()
        {
            return new CartChangeTaxCalculationModeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartChangeTaxCalculationModeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartChangeTaxCalculationModeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartChangeTaxCalculationModeActionQueryBuilderDsl>(p, CartChangeTaxCalculationModeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartChangeTaxCalculationModeActionQueryBuilderDsl, string> TaxCalculationMode()
        {
            return new ComparisonPredicateBuilder<CartChangeTaxCalculationModeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("taxCalculationMode")),
            p => new CombinationQueryPredicate<CartChangeTaxCalculationModeActionQueryBuilderDsl>(p, CartChangeTaxCalculationModeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
