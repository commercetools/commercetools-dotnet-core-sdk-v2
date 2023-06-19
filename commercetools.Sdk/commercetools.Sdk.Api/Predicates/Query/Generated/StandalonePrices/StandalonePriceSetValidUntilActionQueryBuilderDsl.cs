using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.StandalonePrices
{

    public partial class StandalonePriceSetValidUntilActionQueryBuilderDsl
    {
        public StandalonePriceSetValidUntilActionQueryBuilderDsl()
        {
        }

        public static StandalonePriceSetValidUntilActionQueryBuilderDsl Of()
        {
            return new StandalonePriceSetValidUntilActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StandalonePriceSetValidUntilActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StandalonePriceSetValidUntilActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StandalonePriceSetValidUntilActionQueryBuilderDsl>(p, StandalonePriceSetValidUntilActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandalonePriceSetValidUntilActionQueryBuilderDsl, DateTime> ValidUntil()
        {
            return new ComparisonPredicateBuilder<StandalonePriceSetValidUntilActionQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validUntil")),
            p => new CombinationQueryPredicate<StandalonePriceSetValidUntilActionQueryBuilderDsl>(p, StandalonePriceSetValidUntilActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
