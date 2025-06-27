// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderChangePriceRoundingModeActionQueryBuilderDsl
    {
        public StagedOrderChangePriceRoundingModeActionQueryBuilderDsl()
        {
        }

        public static StagedOrderChangePriceRoundingModeActionQueryBuilderDsl Of()
        {
            return new StagedOrderChangePriceRoundingModeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderChangePriceRoundingModeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderChangePriceRoundingModeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderChangePriceRoundingModeActionQueryBuilderDsl>(p, StagedOrderChangePriceRoundingModeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderChangePriceRoundingModeActionQueryBuilderDsl, string> PriceRoundingMode()
        {
            return new ComparisonPredicateBuilder<StagedOrderChangePriceRoundingModeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("priceRoundingMode")),
            p => new CombinationQueryPredicate<StagedOrderChangePriceRoundingModeActionQueryBuilderDsl>(p, StagedOrderChangePriceRoundingModeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
