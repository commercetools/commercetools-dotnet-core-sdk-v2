using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.StandalonePrices
{

    public partial class StandalonePriceSetValidFromActionQueryBuilderDsl
    {
        public StandalonePriceSetValidFromActionQueryBuilderDsl()
        {
        }

        public static StandalonePriceSetValidFromActionQueryBuilderDsl Of()
        {
            return new StandalonePriceSetValidFromActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StandalonePriceSetValidFromActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StandalonePriceSetValidFromActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StandalonePriceSetValidFromActionQueryBuilderDsl>(p, StandalonePriceSetValidFromActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandalonePriceSetValidFromActionQueryBuilderDsl, DateTime> ValidFrom()
        {
            return new ComparisonPredicateBuilder<StandalonePriceSetValidFromActionQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validFrom")),
            p => new CombinationQueryPredicate<StandalonePriceSetValidFromActionQueryBuilderDsl>(p, StandalonePriceSetValidFromActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
