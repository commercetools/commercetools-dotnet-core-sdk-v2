// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.StandalonePrices
{

    public partial class StandalonePriceRemoveStagedChangesActionQueryBuilderDsl
    {
        public StandalonePriceRemoveStagedChangesActionQueryBuilderDsl()
        {
        }

        public static StandalonePriceRemoveStagedChangesActionQueryBuilderDsl Of()
        {
            return new StandalonePriceRemoveStagedChangesActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StandalonePriceRemoveStagedChangesActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StandalonePriceRemoveStagedChangesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StandalonePriceRemoveStagedChangesActionQueryBuilderDsl>(p, StandalonePriceRemoveStagedChangesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
