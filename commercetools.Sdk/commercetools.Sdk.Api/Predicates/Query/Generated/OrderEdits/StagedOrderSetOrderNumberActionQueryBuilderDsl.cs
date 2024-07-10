using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderSetOrderNumberActionQueryBuilderDsl
    {
        public StagedOrderSetOrderNumberActionQueryBuilderDsl()
        {
        }

        public static StagedOrderSetOrderNumberActionQueryBuilderDsl Of()
        {
            return new StagedOrderSetOrderNumberActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderSetOrderNumberActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetOrderNumberActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderSetOrderNumberActionQueryBuilderDsl>(p, StagedOrderSetOrderNumberActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetOrderNumberActionQueryBuilderDsl, string> OrderNumber()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetOrderNumberActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("orderNumber")),
            p => new CombinationQueryPredicate<StagedOrderSetOrderNumberActionQueryBuilderDsl>(p, StagedOrderSetOrderNumberActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
