// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.StandalonePrices
{

    public partial class StandalonePriceRemovePriceTierActionQueryBuilderDsl
    {
        public StandalonePriceRemovePriceTierActionQueryBuilderDsl()
        {
        }

        public static StandalonePriceRemovePriceTierActionQueryBuilderDsl Of()
        {
            return new StandalonePriceRemovePriceTierActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StandalonePriceRemovePriceTierActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StandalonePriceRemovePriceTierActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StandalonePriceRemovePriceTierActionQueryBuilderDsl>(p, StandalonePriceRemovePriceTierActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandalonePriceRemovePriceTierActionQueryBuilderDsl, long> MinimumQuantity()
        {
            return new ComparisonPredicateBuilder<StandalonePriceRemovePriceTierActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("minimumQuantity")),
            p => new CombinationQueryPredicate<StandalonePriceRemovePriceTierActionQueryBuilderDsl>(p, StandalonePriceRemovePriceTierActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
