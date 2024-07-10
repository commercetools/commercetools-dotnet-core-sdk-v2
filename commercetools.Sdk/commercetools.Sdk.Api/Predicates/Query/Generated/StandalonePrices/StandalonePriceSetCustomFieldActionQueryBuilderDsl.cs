using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.StandalonePrices
{

    public partial class StandalonePriceSetCustomFieldActionQueryBuilderDsl
    {
        public StandalonePriceSetCustomFieldActionQueryBuilderDsl()
        {
        }

        public static StandalonePriceSetCustomFieldActionQueryBuilderDsl Of()
        {
            return new StandalonePriceSetCustomFieldActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StandalonePriceSetCustomFieldActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StandalonePriceSetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StandalonePriceSetCustomFieldActionQueryBuilderDsl>(p, StandalonePriceSetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandalonePriceSetCustomFieldActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<StandalonePriceSetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<StandalonePriceSetCustomFieldActionQueryBuilderDsl>(p, StandalonePriceSetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandalonePriceSetCustomFieldActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<StandalonePriceSetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<StandalonePriceSetCustomFieldActionQueryBuilderDsl>(p, StandalonePriceSetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
