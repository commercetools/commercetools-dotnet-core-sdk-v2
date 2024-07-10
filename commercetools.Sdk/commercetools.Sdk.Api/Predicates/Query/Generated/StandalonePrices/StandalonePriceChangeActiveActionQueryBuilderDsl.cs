using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.StandalonePrices
{

    public partial class StandalonePriceChangeActiveActionQueryBuilderDsl
    {
        public StandalonePriceChangeActiveActionQueryBuilderDsl()
        {
        }

        public static StandalonePriceChangeActiveActionQueryBuilderDsl Of()
        {
            return new StandalonePriceChangeActiveActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StandalonePriceChangeActiveActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StandalonePriceChangeActiveActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StandalonePriceChangeActiveActionQueryBuilderDsl>(p, StandalonePriceChangeActiveActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandalonePriceChangeActiveActionQueryBuilderDsl, bool> Active()
        {
            return new ComparisonPredicateBuilder<StandalonePriceChangeActiveActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("active")),
            p => new CombinationQueryPredicate<StandalonePriceChangeActiveActionQueryBuilderDsl>(p, StandalonePriceChangeActiveActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
