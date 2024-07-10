using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderSetCountryActionQueryBuilderDsl
    {
        public StagedOrderSetCountryActionQueryBuilderDsl()
        {
        }

        public static StagedOrderSetCountryActionQueryBuilderDsl Of()
        {
            return new StagedOrderSetCountryActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderSetCountryActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetCountryActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderSetCountryActionQueryBuilderDsl>(p, StagedOrderSetCountryActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetCountryActionQueryBuilderDsl, string> Country()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetCountryActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("country")),
            p => new CombinationQueryPredicate<StagedOrderSetCountryActionQueryBuilderDsl>(p, StagedOrderSetCountryActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
