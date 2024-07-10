using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderRemoveCustomLineItemActionQueryBuilderDsl
    {
        public StagedOrderRemoveCustomLineItemActionQueryBuilderDsl()
        {
        }

        public static StagedOrderRemoveCustomLineItemActionQueryBuilderDsl Of()
        {
            return new StagedOrderRemoveCustomLineItemActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderRemoveCustomLineItemActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderRemoveCustomLineItemActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderRemoveCustomLineItemActionQueryBuilderDsl>(p, StagedOrderRemoveCustomLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderRemoveCustomLineItemActionQueryBuilderDsl, string> CustomLineItemId()
        {
            return new ComparisonPredicateBuilder<StagedOrderRemoveCustomLineItemActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItemId")),
            p => new CombinationQueryPredicate<StagedOrderRemoveCustomLineItemActionQueryBuilderDsl>(p, StagedOrderRemoveCustomLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderRemoveCustomLineItemActionQueryBuilderDsl, string> CustomLineItemKey()
        {
            return new ComparisonPredicateBuilder<StagedOrderRemoveCustomLineItemActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItemKey")),
            p => new CombinationQueryPredicate<StagedOrderRemoveCustomLineItemActionQueryBuilderDsl>(p, StagedOrderRemoveCustomLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
