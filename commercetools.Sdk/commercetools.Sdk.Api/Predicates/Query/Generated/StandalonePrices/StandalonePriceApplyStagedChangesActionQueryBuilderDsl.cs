// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.StandalonePrices
{

    public partial class StandalonePriceApplyStagedChangesActionQueryBuilderDsl
    {
        public StandalonePriceApplyStagedChangesActionQueryBuilderDsl()
        {
        }

        public static StandalonePriceApplyStagedChangesActionQueryBuilderDsl Of()
        {
            return new StandalonePriceApplyStagedChangesActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StandalonePriceApplyStagedChangesActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StandalonePriceApplyStagedChangesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StandalonePriceApplyStagedChangesActionQueryBuilderDsl>(p, StandalonePriceApplyStagedChangesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
