using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderChangeOrderStateActionQueryBuilderDsl
    {
        public StagedOrderChangeOrderStateActionQueryBuilderDsl()
        {
        }

        public static StagedOrderChangeOrderStateActionQueryBuilderDsl Of()
        {
            return new StagedOrderChangeOrderStateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderChangeOrderStateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderChangeOrderStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderChangeOrderStateActionQueryBuilderDsl>(p, StagedOrderChangeOrderStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderChangeOrderStateActionQueryBuilderDsl, string> OrderState()
        {
            return new ComparisonPredicateBuilder<StagedOrderChangeOrderStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("orderState")),
            p => new CombinationQueryPredicate<StagedOrderChangeOrderStateActionQueryBuilderDsl>(p, StagedOrderChangeOrderStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
