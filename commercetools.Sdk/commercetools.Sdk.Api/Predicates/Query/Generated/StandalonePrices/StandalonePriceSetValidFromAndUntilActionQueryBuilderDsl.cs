using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.StandalonePrices
{

    public partial class StandalonePriceSetValidFromAndUntilActionQueryBuilderDsl
    {
        public StandalonePriceSetValidFromAndUntilActionQueryBuilderDsl()
        {
        }

        public static StandalonePriceSetValidFromAndUntilActionQueryBuilderDsl Of()
        {
            return new StandalonePriceSetValidFromAndUntilActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StandalonePriceSetValidFromAndUntilActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StandalonePriceSetValidFromAndUntilActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StandalonePriceSetValidFromAndUntilActionQueryBuilderDsl>(p, StandalonePriceSetValidFromAndUntilActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandalonePriceSetValidFromAndUntilActionQueryBuilderDsl, DateTime> ValidFrom()
        {
            return new ComparisonPredicateBuilder<StandalonePriceSetValidFromAndUntilActionQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validFrom")),
            p => new CombinationQueryPredicate<StandalonePriceSetValidFromAndUntilActionQueryBuilderDsl>(p, StandalonePriceSetValidFromAndUntilActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandalonePriceSetValidFromAndUntilActionQueryBuilderDsl, DateTime> ValidUntil()
        {
            return new ComparisonPredicateBuilder<StandalonePriceSetValidFromAndUntilActionQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validUntil")),
            p => new CombinationQueryPredicate<StandalonePriceSetValidFromAndUntilActionQueryBuilderDsl>(p, StandalonePriceSetValidFromAndUntilActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
