using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.StandalonePrices
{

    public partial class StandalonePriceSetKeyActionQueryBuilderDsl
    {
        public StandalonePriceSetKeyActionQueryBuilderDsl()
        {
        }

        public static StandalonePriceSetKeyActionQueryBuilderDsl Of()
        {
            return new StandalonePriceSetKeyActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StandalonePriceSetKeyActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StandalonePriceSetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StandalonePriceSetKeyActionQueryBuilderDsl>(p, StandalonePriceSetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandalonePriceSetKeyActionQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<StandalonePriceSetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<StandalonePriceSetKeyActionQueryBuilderDsl>(p, StandalonePriceSetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
